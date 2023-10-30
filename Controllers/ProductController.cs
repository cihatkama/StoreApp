using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

namespace StoreApp.Controllers
{
    public class ProductController : Controller
    {

        private readonly RepositoryContext _context;

        public ProductController(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Index()
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
            return _context.Products;
            
        }
    }
}