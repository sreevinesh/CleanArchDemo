using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchs.Mvc.Controllers
{
    [Authorize]
    public class CrsssController : Controller
    {
        private ICrsssService _crsssService;
        public CrsssController(ICrsssService crsssService)
        {
            _crsssService = crsssService;
        }
        public IActionResult Index()
        {
            CrsssViewModel model = _crsssService.GetCrssses();
            return View(model);
        }
    }
}
