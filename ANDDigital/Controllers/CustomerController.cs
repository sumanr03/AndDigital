namespace ANDDigital.Controllers
{   
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Mapper;

    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        [HttpGet]        
        public List<string> GetPhoneNumbers()
        {            
            return CustomerDetails.GetAllPhoneNumbers();
        }

        [HttpGet("{customerId}")]        
        public string GetAllPhoneNumbers(int customerId)
        {
            return CustomerDetails.GetPhoneNumbersByCustomerId(customerId);
        }

        [HttpPut("{customerId}")]
        public bool ActivatePhoneNumber(int customerId)
        {
            return CustomerDetails.ActivatePhoneNumber(customerId);
        }
    }
}