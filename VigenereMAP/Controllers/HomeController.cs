using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VigenereMAP.Models;
using VigenereMAP.Services;

namespace VigenereMAP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CypherRequest(IndexModel data)
        {
            String result = null;
            if (data.type == IndexModel.ENCRYPT)
            {
                result = Cypher.encryptText(data);
                if (result != null)
                {
                    result = $"Resultado encriptado: {result}";
                }
            }
            else if(data.type == IndexModel.DECRYPT) {
                result = Cypher.decryptText(data);
                if (result != null)
                {
                    result = $"Resultado decriptado: {result}";
                }
            }

            if (result == null)
                result = "Cifragem não efetuada!";

            ViewData["result"] = result;

            return View("Index");
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
