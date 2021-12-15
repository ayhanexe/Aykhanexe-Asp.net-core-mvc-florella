using asp.net_core_empty_task.DAL;
using asp.net_core_empty_task.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_core_empty_task.Controllers
{
    public class BasketController : Controller
    {
        private AppDbContext _context;

        public BasketController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> CheckBasket()
        {
            List<BasketItem> newBasket = new List<BasketItem>();

            if (!string.IsNullOrEmpty(Request.Cookies["basket"]))
            {
                List<BasketItem> basket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);

                foreach (var item in basket)
                {
                    if (await _context.Products.FindAsync(item.Product.id) != null)
                    {
                        newBasket.Add(item);
                        Response.Cookies.Append("basket", JsonConvert.SerializeObject(newBasket));
                    }
                }
            }
            return Ok();
        }

        public async Task<IActionResult> AddToBasket(int id)
        {
            Product product = await _context.Products.FindAsync(id);
            List<BasketItem> basket = new List<BasketItem>();
            List<BasketItem> newBasket = new List<BasketItem>();

            if (!string.IsNullOrEmpty(Request.Cookies["basket"]))
            {
                List<BasketItem> parsedBasket = JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]);
                basket = parsedBasket.Concat(basket).ToList();
            }

            if (basket.Find(p => p.Product.id == product.id) != null)
            {
                basket.Find(p => p.Product.id == product.id).Count++;
            }
            else
            {
                basket.Add(new BasketItem { Count = 1, Product = product });
            }

            Response.Cookies.Append("basket", JsonConvert.SerializeObject(newBasket));


            return Ok(product);
        }
        public IActionResult GetBasket()
        {
            return Content(Request.Cookies["basket"]);
        }

        public IActionResult BasketItemCount()
        {
            int count = 0;

            if (!string.IsNullOrEmpty(Request.Cookies["basket"]))
            {
                foreach (var item in JsonConvert.DeserializeObject<List<BasketItem>>(Request.Cookies["basket"]))
                {
                    count += item.Count;
                }
                return Ok(count);
            }
            else
            {
                return Ok(count);
            }
        }
    }
}
