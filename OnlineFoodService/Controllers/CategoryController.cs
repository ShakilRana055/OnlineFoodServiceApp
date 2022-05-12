using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFoodServiceBLL.IBLLRepository;
using OnlineFoodServiceEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodServiceApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IBLLCategoryRepository context;

        public CategoryController(IBLLCategoryRepository context)
        {
            this.context = context;
        }
        [HttpGet]
        public List<Category> Get()
        {
            return context.GetAll();
        }
    }
}
