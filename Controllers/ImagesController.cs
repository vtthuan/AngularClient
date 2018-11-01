using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularClient.Models;
using AngularClient.ViewModel;
using System.IO;
using System.Net.Http;

namespace AngularClient.Controllers
{    
    [Route("api/images")]
    public class ImagesController : Controller
    {
        [HttpGet]
        public IActionResult Get(int imageId)
        {            
           return PhysicalFile(@"C:\test.jpg", "image/jpeg");
        }
    }
}