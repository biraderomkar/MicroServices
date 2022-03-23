using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ProductContext _productContext;
        private readonly ILogger<ProductController> _logger;
        public ProductController( ProductContext context, ILogger<ProductController> logger)
        {
            _productContext = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentException(nameof(logger));
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productContext.Products.Find(p => true).ToListAsync();

        }
    }
}
