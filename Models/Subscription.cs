namespace Instagram_Clone.Models
{
    public class Subscription
    {

        public int Id { get; set; }

        public string PlanType { get; set; }

        public double PlanPrice { get; set; }

        public DateTime BuyDate { get; set; }

        public DateTime ExpireDate  { get; set; }

    }
}
