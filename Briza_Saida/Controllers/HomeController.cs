using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Briza_Saida.Models;
using DomainBriza;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Briza_Saida.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult RetornoDadosBrizaNew()
        //{
        //    return View();
        //}

        public async Task<ActionResult> RetornoDadosBriza()
        {
            string urlApi = "https://localhost:44302/api/values";
            List<ModelRetornoBriza> dadosBrizaConvert = new List<ModelRetornoBriza>();
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(urlApi))
                {
                   if(response.IsSuccessStatusCode)
                    {
                        var dadosBrizaJson = await response.Content.ReadAsStringAsync();
                        dadosBrizaConvert = JsonConvert.DeserializeObject<List<ModelRetornoBriza>>(dadosBrizaJson.ToString());
                    }
                }
            }

            return View(dadosBrizaConvert.ToList());
        }


    }  
}
