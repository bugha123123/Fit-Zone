﻿using Instagram_Clone.Models;

namespace Instagram_Clone.Interface
{
    public interface IExerciseService
    {

        Task<List<Exercise>> GetExerciseListAsync();
    }
}