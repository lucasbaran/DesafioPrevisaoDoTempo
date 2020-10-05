using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DesafioQuay.Api.Models;
using DesafioQuay.Application;

namespace DesafioQuay.Api.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICPTECService cptecService;

        public HomeController(ICPTECService cptecService)
        {
            this.cptecService = cptecService;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public JsonResult BuscarCidade(string cidade) => Json(cptecService.ObterInformacoesCidade(cidade));

        [HttpPost]
        public IActionResult PrevisaoDoTempoCidade(int codigoCidade) => PartialView(cptecService.ObertPrevisaoDoTempoCidade(codigoCidade));

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
