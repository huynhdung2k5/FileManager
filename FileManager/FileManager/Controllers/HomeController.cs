using FileManager.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FileManager.Controllers
{
    public class HomeController : Controller
    {

        private IWebHostEnvironment host;

        public HomeController(IWebHostEnvironment _host)
        {
            host = _host;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public string FileUpLoad(IFormFile file)
        {
            if (file != null)
            {
                //chỉ đường dẫn
                string fullPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "MyImages", file.FileName);

                //copy file vô thư mục 
                using (var files = new FileStream(fullPath, FileMode.Create))
                {
					file.CopyTo(files);
                }
            }
            return "/MyImages/" + file.FileName;
        }

        public object GetAllFile(string path="/MyImages")
		{
			string wwwPath = host.WebRootPath;
			var files = Directory.GetFiles(wwwPath + path);
			var dirs = Directory.GetDirectories(wwwPath + path);
			var filePaths = files.Select(f => f.Replace(wwwPath, "").Replace("\\", "/"));
			var dirPaths = dirs.Select(f => f.Replace(wwwPath, "").Replace("\\", "/"));
			return new {
				dirs = dirPaths,
				files = filePaths
			};
		}
    }
}
