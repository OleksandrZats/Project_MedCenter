using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MidService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MidService.Controllers
{
    public class ServiceController : Controller
    {
        MidServiceContext midServiceContext = new MidServiceContext();

        [Authorize(Roles = "1, 0")]
        // GET: Service
        public ActionResult Index()
        {
            
            IEnumerable<Service> services = midServiceContext.Services;
            ViewBag.Services = services;

            return View();
        }


        [Authorize(Roles = "1, 0")]
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.CurentUser = midServiceContext.Users.FirstOrDefault(u => u.FIO == User.Identity.Name);
            ViewBag.Id = id;
            IEnumerable<Doctor> doctors = midServiceContext.Doctors;
            ViewBag.Doctors = doctors;

            return View();
        }

        [HttpPost]
        public ActionResult Buy(Order order)
        {
            order.Date = DateTime.Now;

            midServiceContext.Orders.Add(order);

            midServiceContext.SaveChanges();

            return Redirect("~/Service/Index");

        }
    }
}