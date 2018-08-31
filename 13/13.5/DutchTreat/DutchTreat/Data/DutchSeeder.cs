using DutchTreat.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<StoreUser> _userManager;

        public DutchSeeder(DutchContext ctx,
                           IHostingEnvironment hosting,
                           UserManager<StoreUser> userManager)
        {
            this._ctx = ctx;
            this._hosting = hosting;
            this._userManager = userManager;
        }

        public async Task Seed()
        {
            this._ctx.Database.EnsureCreated();

            var user = await _userManager.FindByEmailAsync("dean@dutchtreat.com");

            if (user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Dean",
                    LastName = "Webb",
                    UserName = "dean@dutchtreat.com",
                    Email = "dean@dutchtreat.com"
                };

                var result = await _userManager.CreateAsync(user, "P@ssw0rd!");
                if (result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Failed to create default user");
                }
            }

            if (!this._ctx.Products.Any())
            {
                //Need to create sample data
                var filepath = Path.Combine(this._hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                var order = new Order()
                {
                    OrderDate = DateTime.Now,
                    OrderNumber = "12345",
                    User = user,
                    Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        }
                    }
                };

                this._ctx.Orders.Add(order);

                this._ctx.SaveChanges();

            }
        }
    }
}
