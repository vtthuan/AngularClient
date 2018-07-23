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
        [HttpGet]
        public VideoViewModel[] GetAll()
        {
            return new List<VideoViewModel>()
            {
                new VideoViewModel() {Title = "test", CategoryName = "abc", Id=1},
                new VideoViewModel() {Title = "otot", CategoryName = "abc", Id=2}            

            }.ToArray();
        }
        [HttpGet("{id}")]
        public VideoViewModel Get(int id)
        {
            return new VideoViewModel() { Title = "test", CategoryId = 1, Id = 1 };
        }
    }
}