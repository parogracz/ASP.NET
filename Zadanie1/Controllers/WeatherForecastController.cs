using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Zadanie1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public bool czySamo(char x)
        {
            string array = "aąeęiouy";
            foreach(char comp in array)
            {
                if (x == comp) return true;
            }
            return false;
        }

        [HttpGet("vowelCount/{word}")]
        public ActionResult<int> Get2([FromRoute][StringLength(200)] string word)
        {
            
            int count = 0;

            if(word!=null)
            foreach(char i in word)
            {
                if (czySamo(i)) count++;
            }

            if (count < 1) return StatusCode(204);
            return count;
        }
    }
}
