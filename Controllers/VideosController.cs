using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AngularClient.Models;
using AngularClient.ViewModel;

namespace AngularClient.Controllers
{    
    [Route("api/videos")]
    public class VideosController : Controller
    {
        public VideoViewModel[] Get()
        {
            return new List<VideoViewModel>()
            {
                new VideoViewModel() {Title = "test", CategoryId = 1},
                new VideoViewModel() {Title = "otot", CategoryId = 2}
            
            }.ToArray();
        }
    }
}