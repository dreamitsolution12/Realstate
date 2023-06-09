using RealEstate.DataBase;
using RealEstate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Controllers
{
    public class MasterController : Controller
    {
        BusinessLayer bl = new BusinessLayer();

        public string GetMasterData(string Action, string P1, string P2, string P3,string P4,string P5)
        {
            return CommonBase.ConvertTableToList(bl.GetMasterData(Action,P1,P2,P3,P4,P5));
        }
        // GET: Master
        public ActionResult Index()
        {
            return View();
        }

        #region Site Master by _qe

        public ActionResult AddSite(SiteMaster obj)
        {
            try
            {
                obj.Action = 2;
                obj.dt = bl.SiteMaster(obj);
                if (obj.Id != null && obj.dt != null & obj.dt.Rows.Count > 0)
                {
                    obj.Id = obj.Id;
                    obj.SiteName = obj.dt.Rows[0]["SiteName"].ToString();
                    obj.FormarName = obj.dt.Rows[0]["FormarName"].ToString();
                    obj.SiteAddress = obj.dt.Rows[0]["SiteAddress"].ToString();
                    obj.MapLink = obj.dt.Rows[0]["MapLink"].ToString();
                    obj.Size = obj.dt.Rows[0]["Size"].ToString();
                    obj.NoofPlot = obj.dt.Rows[0]["NoofPlot"].ToString();
                    obj.PlotAmt = obj.dt.Rows[0]["PlotAmt"].ToString();
                    obj.PaidAmt = obj.dt.Rows[0]["PaidAmt"].ToString();
                    obj.DueAmt = obj.dt.Rows[0]["DueAmt"].ToString();
                }
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('" + exc.Message + "');</script>");
            }
            
            return View(obj);
        }

        public void _addSite(SiteMaster obj)
        {
            try
            {
                obj.Action = obj.Id == null ? 1 : 3;
                obj.ProjectImagesUrl = obj.SaveFile(obj._projectImagesUrl, "~/Media/SiteImage/");
                obj.dt = bl.SiteMaster(obj);

                if (obj.dt != null & obj.dt.Rows.Count > 0)
                    Response.Write("<script>alert('" + obj.dt.Rows[0]["msg"].ToString() + "');Javascript:history.back();</script>");
                else
                    Response.Write("<script>alert('Server error occured!');Javascript:history.back();</script>");
            }
            catch (Exception exc)
            {
                Response.Write("<script>alert('" + exc.Message + "');Javascript:history.back();</script>");
            }
            
        }

        public string deleteSite(int Id)
        {
            string data = "0";
            SiteMaster obj = new SiteMaster();
            try
            {
                obj.Id = Id;
                obj.Action = 4;
                obj.dt = bl.SiteMaster(obj);

                if (obj.dt != null & obj.dt.Rows.Count > 0)
                    data = obj.dt.Rows[0]["msg"].ToString();
            }
            catch (Exception exc)
            {
                data = exc.Message;
            }
            return data;
        }

        #endregion Site Master _qe

        public ActionResult AddPlot()
        {
            return View();
        }

        public ActionResult AddPlotType()
        {
            return View();
        }

        public ActionResult AddBlock()
        {
            return View();
        }


    }
};