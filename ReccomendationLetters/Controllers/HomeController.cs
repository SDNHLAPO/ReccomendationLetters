using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ReccomendationLetters.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ReccomendationLetters.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

       

        public IActionResult Course()
        {
            return View();
        }

        public IActionResult FileUpload()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult>FileUpload(IFormFile file)
        {
            await UploadFile(file);
            TempData["msg"] = "File Uploades Successfully.";
            return View();
        }
        //Upload File on Server
        public async Task<bool> UploadFile(IFormFile file) {
            string path = " ";

            bool iscopied = false;
            try
            {
                if(file.Length > 0)
                {
                    string filename = Guid.NewGuid() + Path.GetExtension(file.FileName);
                 
                    path = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "Upload"));

                    using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                    {

                        await file.CopyToAsync(filestream); 

                    }
                    iscopied = true;
                }
                else
                {

                    iscopied = false;
                }

            }

            catch (Exception)
            {
                throw;
            }
        return iscopied;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
