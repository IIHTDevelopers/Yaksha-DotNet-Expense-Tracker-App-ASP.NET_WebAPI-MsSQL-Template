using ExpenseTrackerApp.DAL.Interrfaces;
using ExpenseTrackerApp.DAL.Services.Repository;
using ExpenseTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExpenseTrackerApp.DAL.Services
{
    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository _repository;

        public ExpenseService(IExpenseRepository repository)
        {
            _repository = repository;
        }

        public Task<Expense> CreateExpense(Expense expense)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteExpenseById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public List<Expense> GetAllExpenses()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<Expense> GetExpenseById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<Expense> UpdateExpense(Expense model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}