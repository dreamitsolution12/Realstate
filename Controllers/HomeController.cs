using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RealEstate.DataBase;
using System.Data;

namespace RealEstate.Controllers
{
    public class HomeController : Controller
    {
        BusinessLayer bl = new BusinessLayer();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(Contact obj)
        {
            try
            {
                obj.Action = 1;
                DataTable dt = bl.Contact(obj);
                if (dt.Rows.Count>0)
                {
                    Response.Write("<script>alert('"+dt.Rows[0]["msg"].ToString()+"')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Server error occured!')();</script>");
                }



            }
            catch(Exception exc) 
            {
                throw; 
            }

            ModelState.Clear();
            return View(obj);
        }

        public ActionResult Properties()
        {
            PlotMaster obj = new PlotMaster();
            obj.Action = 2;
            obj.dt = bl.PlotMaster(obj);
            return View(obj);
        }

        public ActionResult PropertyDetails()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }

        public ActionResult PlotAvailability()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login( Login obj)
        {
            string url = "/home/login";
            try
            {
                obj.Action = 1;
                obj.dt = bl.GetLogins(obj);
                if (obj.dt != null && obj.dt.Rows.Count > 0)
                {
                    Session["UserName"] = obj.UserName;
                    Session["Password"] = obj.Password;
                    Session["Role"] = obj.dt.Rows[0]["RoleId"].ToString();
                    Session["URL"] = obj.dt.Rows[0]["URL"].ToString();
                    url = Session["URL"].ToString();
                }
                else
                    Response.Write("<script>alert('Please enter a valid Username and Password!');</script>");
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('" + exc.Message + "');</script>");
            }
            
            return Redirect(url);
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            Session.RemoveAll();
            Session.Clear();
            return Redirect("/home/login");
        }

    }
} 