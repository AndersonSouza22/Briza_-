using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainBriza;
using DomainBriza.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_Briza.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IServiceDadosBriza serviceDados;
        public ValuesController(IServiceDadosBriza serviceDadosBriza)
        {
            serviceDados = serviceDadosBriza;

        }

        [HttpGet]
        public IEnumerable<DadosBriza> Getall()
        {
            return serviceDados.List();
        }

        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "v22225525" }
        //}

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
