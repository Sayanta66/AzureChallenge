﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AzureChallenge.Models.Questions;

namespace AzureChallenge.Interfaces.Providers.Questions
{
    public interface IAssignedQuestionProvider<T, Q>
    {
        public Task<(T, Q)> GetItemAsync(string id);

        public Task<(T, IList<Q>)> GetAllItemsAsync();

        public Task<T> AddItemAsync(Q item);
    }
}