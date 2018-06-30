using RestAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace RestAPI.Controllers
{
    public class HomeController : Controller
    {
        private static HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            return View();
        }

        public async System.Threading.Tasks.Task<PartialViewResult> DetalharModal(int? id)
        {
            VooDTO voo = null;
            HttpResponseMessage response = await client.GetAsync("http://localhost:59692/api/voos/" + id);
            if (response.IsSuccessStatusCode)
            {
                voo = await response.Content.ReadAsAsync<VooDTO>();
            }
            return PartialView("DetalharModal", voo);
        }
    }
}
