﻿using ExpenseTrackerApp.DAL.Interrfaces;
using ExpenseTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ExpenseTrackerApp.Controllers
{
    public class ExpenseController : ApiController
    {
        private readonly IExpenseService _service;
        public ExpenseController(IExpenseService service)
        {
            _service = service;
        }
        public ExpenseController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Expense/CreateExpense")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateExpense([FromBody] Expense model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Expense/UpdateExpense")]
        public async Task<IHttpActionResult> UpdateExpense([FromBody] Expense model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Expense/DeleteExpense")]
        public async Task<IHttpActionResult> DeleteExpense(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Expense/GetExpenseById")]
        public async Task<IHttpActionResult> GetExpenseById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Expense/GetAllExpenses")]
        public async Task<IEnumerable<Expense>> GetAllExpenses()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
