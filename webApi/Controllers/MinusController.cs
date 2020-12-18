using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCalc;
using Microsoft.AspNetCore.Cors;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MinusController : ControllerBase
    {
        SimpleCalc.SimpleCalc simpleCalc = new SimpleCalc.SimpleCalc();

        [HttpGet]
        public string Get([FromQuery(Name = "num1")] decimal num1, [FromQuery(Name = "num2")] decimal num2)
        {

            return simpleCalc.OperatorSwitch(num1, num2, "-");
        }
        [HttpPost]
        public string Post([FromForm(Name = "num1")] decimal num1, [FromForm(Name = "num2")] decimal num2)
        {

            return simpleCalc.OperatorSwitch(num1, num2, "-");
        }
        
        [HttpOptions]
        public string Get()
        {
            return "this api calculates minus operation of two numbers \n"
                + "Get method -> api/minus?num1=left&num2=right   e.g. api/minus?num1=3&num2=5   response is -2";
        }
    }
}
