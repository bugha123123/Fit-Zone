using Instagram_Clone.DTO;
using Instagram_Clone.Interface;
using Instagram_Clone.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using static System.Net.WebRequestMethods;
using Instagram_Clone.ApplicationDBContext;
using System.Security.Cryptography;

namespace Instagram_Clone.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly AppDbContext _appDbContext;

        public AccountController(IAccountService accountService, AppDbContext appDbContext)
        {
            _accountService = accountService;
            _appDbContext = appDbContext;
        }

        public IActionResult LogInPage()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home"); // Redirect to homepage
            }
            return View();
        }

        public IActionResult RegisterPage()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home"); // Redirect to homepage
            }
            return View();
        }
        public async  Task<IActionResult> OTPPage()
        {
            var user = await _accountService.GetLoggedInUserAsync();

            return View(user);
        }

        [HttpPost("verifyotp")]
        [ValidateAntiForgeryToken] // Include this if using anti-forgery tokens
        public async Task<IActionResult> VerifyOTP(string otp)
        {
          

            // Get the logged-in user
            var user = await _accountService.GetLoggedInUserAsync();

            // Check if the OTP provided by the user matches the verification code
            if (otp == user.VerificationCode)
            {
                user.VerificationCode = null;
                return RedirectToAction("Index", "Home");
            }
                return RedirectToAction("OTPPage", "Account");

        }



        [HttpPost("registeruser")]
        public async Task<IActionResult> RegisterUser(CreateUserDTO createUserDTO)
        {
            try
            {
                // Register the user
                await _accountService.RegisterUser(createUserDTO);

                // Generate OTP code
                string otp = await GenerateOTP();

                // Get the logged-in user
                var user = await _accountService.GetLoggedInUserAsync();

                // Set the OTP code for the user
                user.VerificationCode = otp;

                // Save changes to the database
                await _appDbContext.SaveChangesAsync();

                // Set localStorage item after registering user
                HttpContext.Response.Cookies.Append("loggedIn", "true");

                // Send registration confirmation email to Ethereal Email
                string recipientEmail = "vincent50@ethereal.email";
                string subject = "Registration Confirmation";
                string body = $"Dear {createUserDTO.Username},<br/><br/>Thank you for registering with us. Your account has been successfully created. This is your verification code: {otp}, use it on our website to verify your account";

                await SendEmail(recipientEmail, subject, body);

                return RedirectToAction("OTPPage", "Account");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Failed to register user: {ex.Message}");
            }
        }


        private async Task SendEmail(string recipientEmail, string subject, string body)
        {
            try
            {
                // Generate OTP code
               

                // Append OTP code to the email body

                // Create and configure the SMTP client for Ethereal Email
                using (var smtpClient = new SmtpClient("smtp.ethereal.email", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.EnableSsl = true;
                    smtpClient.Credentials = new NetworkCredential("vincent50@ethereal.email", "s27xnBe3puJEwZ84qH");

                    // Create the email message
                    using (var message = new MailMessage())
                    {
                        message.From = new MailAddress("FitZone@gmail.com");
                        message.To.Add(new MailAddress(recipientEmail));
                        message.Subject = subject;
                        message.Body = body;
                        message.IsBodyHtml = true;
                        ViewData["GmailSentMessage"] = "An email has been sent to vincent50@ethereal.email on ethereal. Get your code there and proceed.";
                        // Send the email
                        await smtpClient.SendMailAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to send email: {ex.Message}");
            }
        }
        private async Task<string> GenerateOTP()
        {
            // Use a cryptographically secure random number generator (CSPRNG)
            using (var rng = RandomNumberGenerator.Create())
            {
                // Generate a byte array of appropriate size for the desired OTP length (4 digits)
                byte[] randomNumberBytes = new byte[4];
                rng.GetBytes(randomNumberBytes);

                // Convert the byte array to a base-10 integer within the desired OTP range (1000-9999)
                int randomNumber = Math.Abs(BitConverter.ToInt32(randomNumberBytes, 0)) % 10000;

                // Ensure the random number falls within the desired range (1000-9999)
                if (randomNumber < 1000)
                {
                    randomNumber += 10000;
                }

                // Extract the last 4 digits as the OTP
                return randomNumber.ToString().Substring(randomNumber.ToString().Length - 4);
            }
        }
   

        [HttpPost("signin")]
        public async Task<IActionResult> SignInUser(LogInUserDTO logInUserDTO)
        {
            await _accountService.LogInUser(logInUserDTO);
            string otp = await GenerateOTP();

            HttpContext.Response.Cookies.Append("loggedIn", "true");
            // Send registration confirmation email to Ethereal Email
            string recipientEmail = "vincent50@ethereal.email";
            string subject = "Registration Confirmation";
            string body = $"Dear {logInUserDTO.UserName},<br/><br/>This is your verification code {otp}, use it on  our website to verify your account";
            var user = await _accountService.GetLoggedInUserAsync();

            // Set the OTP code for the user
            user.VerificationCode = otp;

            // Save changes to the database
            await _appDbContext.SaveChangesAsync();
            await SendEmail(recipientEmail, subject, body);
      
            return RedirectToAction("OTPPage", "Account");
        }

        [HttpPost("LogOutUser")]
        public async Task<IActionResult> LogOutUser()
        {
            await _accountService.LogOutUser();

            HttpContext.Response.Cookies.Delete("loggedIn");
            return RedirectToAction("LogInPage", "Account");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateUserProfile(User user, IFormFile profileImage)
        {
            if (ModelState.IsValid)
            {
                await _accountService.UploadUserProfileImage(user, profileImage);
                return RedirectToAction("ProfilePage", "Profile"); 
            }

            return RedirectToAction("ProfilePage", "Profile");

        }

   
    }
}
