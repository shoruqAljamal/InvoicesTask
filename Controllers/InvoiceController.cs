using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoicesTask.Models;
using InvoicesTask.Supervisors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InvoicesTask.Controllers
{
    [Route("api/Invoice")]
    public class InvoiceController : Controller
    {
        private ISupervisor _ISupervisor;
        public InvoiceController(ISupervisor ISupervisor)
        {
          _ISupervisor = ISupervisor;
        }

        [HttpGet("GetInvoiceByID/{id}")]
        public async Task<IActionResult> GetInvoiceByID(int id)
        {
            var result = await _ISupervisor.GetInvoiceByID(id);
            return Ok(result);
        }

        [HttpPost("GetReport")]
        public async Task<IActionResult> GetReport([FromBody]FilterDateModel model)
        {

            try {   
                var result = await _ISupervisor.GetReport(model);
            return Ok(result)
                    ; }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Db is down");
            }
        
        }
        [HttpGet("GetAllStores")]
        public async Task<IActionResult> GetAllStores()
        {
            var result = await _ISupervisor.GetAllStores();
            return Ok(result);
        }
        [HttpGet("GetAllCustomers")]
        public async Task<IActionResult> GetAllCustomers()
        {
            var result = await _ISupervisor.GetAllCustomers();
            return Ok(result);
        }
        [HttpGet("GetAllItems")]
        public async Task<IActionResult> GetAllItems()
        {
            var result = await _ISupervisor.GetAllItems();
            return Ok(result);
        }
        [HttpPost("AddInvoice")]
        public async Task<IActionResult> AddInvoice([FromBody]InvoiceModel invoice)
        {
            try
            {
                var result = await _ISupervisor.AddInvoice(invoice);
                return Ok(result);
            }
            catch(Exception ex)
            {
                return Ok(ex);
            }
          
        }
        [HttpPut("UpdateInvoice")]
        public async Task<IActionResult> UpdateInvoice([FromBody]InvoiceModel invoice)
        {
            
            try
            {
                var result = await _ISupervisor.UpdateInvoice(invoice);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Ok(ex);
            }

        }

    }
}