using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DomainBriza;
using DomainBriza.Services;
using BrizaInfra.Repositories;
using Briza_.Models;
using BrizaInfra.Datasource;

namespace Briza__.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceDadosBriza serviceDados;

        public HomeController(IServiceDadosBriza serviceDadosBriza)
        {
            serviceDados = serviceDadosBriza;
        }
        public ActionResult FormBriza()
        {
            return View();
        }


        [HttpPost]
        public ActionResult CadastroBrizaOld(ModelBrizaEnvio modelBrizaEnvio)
        {
            DadosBriza db = new DadosBriza();
            db.DataCadastro = DateTime.Now;
            db.Email = modelBrizaEnvio.Email;
            db.Nome = modelBrizaEnvio.Nome;
            serviceDados.Insert(db);
            ModelState.Clear();
            ViewBag.Mensagem = "Você , " + db.Nome + ", foi cadastrado com sucesso.";
            return View("FormBriza");
        }
        public ActionResult CadastroBriza()
        {
            return View();
        }



    }
}
