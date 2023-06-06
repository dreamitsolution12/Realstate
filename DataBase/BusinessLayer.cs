using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using RealEstate.DataBase;
using RealEstate.Models;

namespace RealEstate.DataBase
{
    public class BusinessLayer
    {
        DbLayer dbl = new DbLayer();

        #region _qe

        public DataTable GetLogins(Login obj)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@UserName", obj.UserName),
                    new SqlParameter("@Password", obj.Password),
                    new SqlParameter("@Action", obj.Action)
                };
                dt = dbl.ExecProcPara_dt("Proc_GetLoginDetails", sp);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        public DataTable AgentMaster(AgentMaster obj)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@Id", obj.Id),
                    new SqlParameter("@MID", obj.MID),
                    new SqlParameter("@SID", obj.SID),
                    new SqlParameter("@Member_Id", obj.Member_Id),
                    new SqlParameter("@Psw", obj.Password),
                    new SqlParameter("@Name", obj.Name),
                    new SqlParameter("@FatherName", obj.FatherName),
                    new SqlParameter("@Gender", obj.Gender),
                    new SqlParameter("@Mobile", obj.Mobile),
                    new SqlParameter("@Email", obj.Email),
                    new SqlParameter("@AdharNo", obj.AdharNo),
                    new SqlParameter("@PanNo", obj.PanNo),
                    new SqlParameter("@DOB", obj.DOB),
                    new SqlParameter("@BankName", obj.BankName),
                    new SqlParameter("@Branch", obj.Branch),
                    new SqlParameter("@IFSCCode", obj.IFSCCode),
                    new SqlParameter("@AccountNo", obj.AccountNo),
                    new SqlParameter("@ProfilePic", obj.ProfilePic),
                    new SqlParameter("@BankCopy", obj.BankCopy),
                    new SqlParameter("@AdharFrontCopy", obj.AdharFrontCopy),
                    new SqlParameter("@AdharBackCopy", obj.AdharBackCopy),
                    new SqlParameter("@PanCopy", obj.PanCopy),
                    new SqlParameter("@KYC_Status", obj.KYC_Status),
                    new SqlParameter("@createdby", obj.EntryBy),
                    new SqlParameter("@Address", obj.Address),
                    new SqlParameter("@Rank_Id", obj.Rank_Id),
                    new SqlParameter("@Action", obj.Action)
                };
                dt = dbl.ExecProcPara_dt("Proc_AgentMaster", sp);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        public DataTable SiteMaster(SiteMaster obj)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("@Id", obj.Id),
                    new SqlParameter("@SiteName", obj.SiteName),
                    new SqlParameter("@FormarName", obj.FormarName),
                    new SqlParameter("@SiteAddress", obj.SiteAddress),
                    new SqlParameter("@MapLink", obj.MapLink),
                    new SqlParameter("@Size", obj.Size),
                    new SqlParameter("@NoofPlot", obj.NoofPlot),
                    new SqlParameter("@PlotAmt", obj.PlotAmt),
                    new SqlParameter("@PaidAmt", obj.PaidAmt),
                    new SqlParameter("@DueAmt", obj.DueAmt),
                    new SqlParameter("@ProjectImagesUrl", obj.ProjectImagesUrl),
                    new SqlParameter("@Action", obj.Action)
                };
                dt = dbl.ExecProcPara_dt("Proc_SiteMaster", sp);
            }
            catch (Exception exc)
            {
                throw exc;
            }
            return dt;
        }

        #endregion

    }
}