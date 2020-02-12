using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication0106.DAC;
using WebApplication0106.Models;

namespace WebApplication0106.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index(string returnURl)
        {
            return View(new CartIndexViewModel
            {
                Cart = GetCart(),
                ReturnUrl = returnURl
            });
        }

        public ActionResult AddToCart(string productID, string returnUrl)
        {
            //productID를 조회
            ProductDAC product = new ProductDAC();
            Product item = product.GetProductInfo(productID);

            GetCart().AddItem(item, 1);

            return RedirectToAction("Index", new { returnUrl });
        }

        public ActionResult RemoveFromCart(string productId, string returnUrl)
        {
            ProductDAC product = new ProductDAC();
            Product item = product.GetProductInfo(productId);

            GetCart().RemoveItem(item);
            return RedirectToAction("Index", new { returnUrl });
        }

        public Cart GetCart()
        {
            Cart cart = (Cart)Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }

        //장바구니 요약정보 (상단메뉴 우측)
        public ActionResult Summary()
        {
            return PartialView(GetCart());
        }

        public ActionResult Checkout()
        {
            return View();

        }

    } 
}