﻿using FirstProj.Abstractions;
using FirstProj.Models;
using FirstProj.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;

namespace FirstProj.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            Info infoViewModel = new Info();
            infoViewModel.Description = "Jija";
            return View(infoViewModel);
        }
    }
}
