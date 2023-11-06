using ExpenseTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ExpenseTrackerApp.DAL.Services.Repository
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly DatabaseContext _dbContext;
        public ExpenseRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Expense> CreateExpense(Expense expense)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteExpenseById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public List<Expense> GetAllExpenses()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Expense> GetExpenseById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

      
        

        public async Task<Expense> UpdateExpense(Expense model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}