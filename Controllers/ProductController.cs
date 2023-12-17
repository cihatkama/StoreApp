using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Entities.Models;
using Repositories;
using Repositories.Contracts;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly IRepositoryManager _manager;

        public ProductController(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public IActionResult Index()
        {
            // elle list gönderildi.
            // return new List<Product>()
            // {
            //     new Product() {ProductId = 1, ProductName = "Computer", ProductPrice = 5_000}
            // };

            // db den okuyarak gönderildi.
            // var context = new RepositoryContext
            // (
            //     new DbContextOptionsBuilder<RepositoryContext>()
            //     .UseSqlite("Data Source = D:\\workspace\\vscode\\Store\\ProductDb.md")
            //     .Options
            // );

            // Dependency Injection 
            var model = _manager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            // Product product = _context.Products.FirstOrDefault(x => x.ProductId.Equals(id));
            throw new NotImplementedException();
        }
    }
}