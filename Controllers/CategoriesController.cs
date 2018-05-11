using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AngularClient.ViewModel;
using RTF.Core.ViewModel;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularClient.Controllers
{
    [Route("api/categories")]
    public class CategoriesController : Controller
    {
        // GET: /<controller>/
        public CategoryViewModel[] Get()
        {
            return new List<CategoryViewModel>()
            {
                new CategoryViewModel() {Name = "1", Id = 1},
                new CategoryViewModel() {Name = "2", Id = 2}

            }.ToArray();
        }
    }
}
