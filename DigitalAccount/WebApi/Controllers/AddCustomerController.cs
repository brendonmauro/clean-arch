﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models.AddCustomer;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddCustomerController : ControllerBase
    {
        [HttpPost]
        public IActionResult AddCustomer(AddCustomerInput input)
        {
            // Call use case to add customer
            return Created("", input);
        }
    }
}
