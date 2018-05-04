using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mortgage_calculator.Models;

namespace mortgage_calculator.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {        
        // POST api/values
        [HttpPost]
        public JsonResult Post([FromBody] CalculationRequest req)
        {
            var err = req.isValid();

            if (err != null) {
                return Json(err);
            }
        
            return Json(
                new MortgageCalculation(
                    req.amount.Value, 
                    req.period.Value, 
                    req.interest.Value
                )
            );
        }
    }
}
