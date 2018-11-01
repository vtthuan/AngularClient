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
                new VideoViewModel() {Title = "test", CategoryName = "1", CategoryId = 1, Id=1, ThumbnailUrl = @"api\images?1"},
                new VideoViewModel() {Title = "otot", CategoryName = "2", CategoryId = 2, Id=2, ThumbnailUrl = @"api\images?2"}            

            }.ToArray();
        }
        [HttpGet("{id}")]
        public VideoViewModel Get(int id)
        {
            return new VideoViewModel() { Title = "test", Description ="abc xyz", CategoryId = 1, Id = 1, ThumbnailUrl = @"api\images?1" };
        }
    }
}