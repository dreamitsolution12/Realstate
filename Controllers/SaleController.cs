using RealEstate.DataBase;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class SaleController : Controller
    {
        BusinessLayer bl = new BusinessLayer();
        // GET: Sale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PlotTransfer()
        {
            return View();
        }

        public ActionResult PlotCancel()
        {
            return View();
        }

        public ActionResult CustomersList()
        {
            return View();
        }

        public ActionResult SalePlot()
        {
            SalePlot obj = new SalePlot();

            obj.AgentLst = CommonBase.BindDDl(bl.GetMasterData("1"));
            obj.SiteLst = CommonBase.BindDDl(bl.GetMasterData("2"));


            return View(obj);
        }

        public ActionResult PlotRegistry()
        {
            return View();
        }

        public ActionResult PlotAgreement()
        {
            return View();
        }

    }
}