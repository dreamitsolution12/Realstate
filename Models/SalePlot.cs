using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEstate.Models
{
    public class SalePlot
    {
        public List<SelectListItem> AgentLst =new List<SelectListItem>();
        public List<SelectListItem> SiteLst = new List<SelectListItem>();
        public string AgentId { get; set; }
        public string SiteId { get; set; }


    }
}