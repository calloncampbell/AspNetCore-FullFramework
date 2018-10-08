using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClassLibrary.Complete;
using Microsoft.AspNetCore.Mvc;
using Plato.Core.Miscellaneous;

namespace WebApplication.Complete.Controllers.v1.api
{
    [Route("v1/api/[controller]")]
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        private readonly IClass1 _class1;

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeController"/> class.
        /// </summary>
        /// <param name="class1">The class1.</param>
        public WelcomeController(
            IClass1 class1)
        {
            Guard.AgainstNull(() => class1);
            _class1 = class1;
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Welcome to the WebApplication.Complete Sample API!");
        }
    }
}
