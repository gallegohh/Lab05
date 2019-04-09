using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Lab05.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab05.Web.App.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Index()
        {
            string[] paises = new string[] { "Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain", "Sweden", "Switzerland", "UK", "USA", "Venezuela" };
            ViewBag.Paises = new SelectList(paises);

            return View(new List<Orders>());
        }
    }
}