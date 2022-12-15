using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rail_Reserv.Models;

namespace Rail_Reserv.Controllers
{
    public class HomeController : Controller
    {
        OurDbContext Db1=new OurDbContext();
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Index1(string searching)
        {
            return View(Db1.TrainDetails.Where(x=>x.DestinationStation.Contains(searching)||searching==null).ToList());
        }
        
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Passenger p)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    Db1.Passengers.Add(p);
                    Db1.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.message = p.FirstName + " " + p.LastName + " " + "Successfully registered";
            }
            return View();
        }
        public ActionResult afterlogin()
        {
            return View();
        }
        public ActionResult CancelTicket() {
            return View();
        }
        public ActionResult Reservation() {
            return View();
        }
        [HttpPost]
        public ActionResult Reservation(Reservation r)
        {
            if (ModelState.IsValid)
            {
                using (OurDbContext db = new OurDbContext())
                {
                    Db1.Reservations.Add(r);
                    Db1.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.message = r.Res_Id + " " + r.Res_Name + " " + "Successfully Reserved";
            }
            return View();
        }
    }
}