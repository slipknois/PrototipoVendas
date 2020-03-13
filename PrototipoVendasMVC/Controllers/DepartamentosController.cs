using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrototipoVendasMVC.Models;

namespace PrototipoVendasMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {

            List<Departamento> list = new List<Departamento>();
            list.Add(new Departamento { Id = 1, Name = "Eletronicos" });
            list.Add(new Departamento { Id = 2, Name = "Alimentos" });
            list.Add(new Departamento { Id = 3, Name = "Padaria" });

            return View(list);
        }
    }
}