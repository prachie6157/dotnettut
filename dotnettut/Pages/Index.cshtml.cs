using dotnettut.Models;
using dotnettut.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnettut.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductService productServices)
        {
            _logger = logger;
            ProductService = productServices;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
