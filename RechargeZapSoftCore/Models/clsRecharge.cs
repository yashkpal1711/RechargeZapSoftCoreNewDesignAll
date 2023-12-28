using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ARA_StringHunt;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Configuration;
using System.Web;
using System.Net;
using System.IO;
using Microsoft.AspNetCore.Http;
using RestSharp;

namespace RechargeZapSoftCore.Models
{
    public class clsRecharge
    {
        Data ObjData = new Data();
        //OpenSSL ssl = new OpenSSL();
        public string UserId { get; set; }
        public string RechargeMobile { get; set; }
        public string CallbackURL { get; set; }
        public string Id { get; set; }

        public string UserMobile { get; set; }
        public string UserPassword { get; set; }
        public String AgentId { get; set; }
        public string APIUserMobile { get; set; }
        public string OperatorCode { get; set; }
        public string OperatorId { get; set; }
        public string RechargeOTP { get; set; }
        public string otprecharge1 { get; set; }
        public string otprecharge2 { get; set; }
        public string otprecharge3 { get; set; }
        public string otprecharge4 { get; set; }
        public string otprecharge5 { get; set; }
        public string OperatorName { get; set; }
        public decimal RechargeAmount { get; set; }
        public DataTable dtData { get; set; }
        public decimal PaymentGatewayAmount { get; set; }
        public decimal ProcessingCharge { get; set; }
        public string APIId { get; set; }
        public string IPAddress { get; set; }
        public string EntryBy { get; set; }
        public string UserType { get; set; }
        public string Promocode { get; set; }
        public string Message { get; set; }
        public string GiftTo { get; set; }
        public string OtherMobile { get; set; }
        public string OtherName { get; set; }
        public string OtherEmail { get; set; }
        public string PaymentGatewayResponse { get; set; }
        public string OperatorType { get; set; }
        public string Rechargebile { get; set; }
        public string Name { get; set; }
        public string ReferenceId { get; set; }
        public string RechargeType { get; set; }
        public string StatusImage { get; set; }
        public string LiveId { get; set; }
        public string RechargeDate { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string Status { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
        public string VoucherData { get; set; }
        public string Option1 { get; set; }
        public string Option2 { get; set; }
        public string Option3 { get; set; }
        public string Option4 { get; set; }
        public string OptionalValue1 { get; set; }
        public string OptionalValue2 { get; set; }
        public string OptionalValue3 { get; set; }
        public string OptionalValue4 { get; set; }
        public string DispalyValue1 { get; set; }
        public string DispalyValue2 { get; set; }
        public string DispalyValue3 { get; set; }
        public string DispalyValue4 { get; set; }
        public string Number { get; set; }
        public string CircleCode { get; set; }
        public string CategoryId { get; set; }
        public string CircleName { get; set; }
        public string SlabName { get; set; }
        public string MentionBy { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string LoginEmail { get; set; }
        public decimal UsedBalance { get; set; }

        public string OTP { get; set; }
        public string OTP1 { get; set; }
        public string OTP2 { get; set; }
        public string OTP3 { get; set; }
        public string OTP4 { get; set; }
        public string OTP5 { get; set; }
        public string Mobile { get; set; }
        public string PaymentGatewayOrderid { get; set; }


        public string SessionNo = DateTime.Parse(DateTime.Now.ToString()).ToString("dddMMMddyyyyHHmmss");
        string keyPath = "";

        public DataTable getRechargeCommission()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT tb1.*
,tb2.[1] AS type1,tb2.[2] AS type2,tb2.[3] AS type3,tb2.[4] AS type4,tb2.[5] AS type5,tb2.[6] AS type6,tb2.[7] AS type7
,tb3.[1] AS changetype1,tb3.[2] AS changetype2,tb3.[3] AS changetype3,tb3.[4] AS changetype4,tb3.[5] AS changetype5,tb3.[6] AS changetype6,tb3.[7] AS changetype7
  FROM

(
select * from (
select LVL,oc.id as OperatorId ,OC.Operator,Commission from COMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(Commission)
for Lvl in ([1],[2],[3],[4],[5],[6],[7])
  )As Pivot1
  ) tb1
  LEFT JOIN 
(
select * from (
select LVL,oc.id as OperatorId ,OC.Operator,cd.type from COMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(type)
for Lvl in ([1],[2],[3],[4],[5],[6],[7])
  )As Pivot1)
  
  tb2 ON tb2.operatorid=tb1.operatorid
LEFT JOIN 
(

select * from (
select LVL,oc.id as OperatorId ,OC.operator,changetype from COMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(changetype)
for Lvl in ([1],[2],[3],[4],[5],[6],[7])
  )As Pivot1
  )
  tb3 ON tb1.operatorid=tb3.operatorid  order by tb1.operatorid";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getRetailerRechargeCommission()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT tb1.*
,tb2.[1] AS type1
,tb3.[1] AS changetype1
  FROM

(
select * from (
select LVL,oc.id as OperatorId ,OC.Operator,Commission from RetailerCOMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(Commission)
for Lvl in ([1])
  )As Pivot1
  ) tb1
  LEFT JOIN 
(
select * from (
select LVL,oc.id as OperatorId ,OC.Operator,cd.type from RetailerCOMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(type)
for Lvl in ([1])
  )As Pivot1)
  
  tb2 ON tb2.operatorid=tb1.operatorid
LEFT JOIN 
(

select * from (
select LVL,oc.id as OperatorId ,OC.operator,changetype from RetailerCOMMISSIOIN_DISTRIBUTION_DETAIL CD  right outer  JOIN OperatorCode OC ON OC.ID=CD.OperatorId 

) as T 
Pivot
(
Max(changetype)
for Lvl in ([1])
  )As Pivot1
  )
  tb3 ON tb1.operatorid=tb3.operatorid  order by tb1.operatorid";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getIReffOperator()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT Operator,ltrim(rtrim(IReffOp)) as IReffOp,id FROM operatorcode WITH (nolock) WHERE IReffOp IS NOT null ORDER BY Operator";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCallbackURLMaster(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * from callbackurlmaster with (nolock) where userid=" + objrecharge.UserId + "";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getOperatorCodeForPlan()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT operator,id from operatorcode with (nolock) order by operator";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCircleCodePlan()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT circlecode,circlename from circlecodedetail with (nolock) order by circlename";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCallbackURLMasterAll()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * from callbackurlmaster with (nolock) ";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable getIPAddressMaster(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * from IPMaster with (nolock) where userid=" + objrecharge.UserId + "";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable getIPAddressReport(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT im.*,ud.mobile from IPMaster im with (nolock) left join userdetail ud with (nolock) on im.userid=ud.id where 1=1";
                if (objrecharge.UserId != "")
                {
                    s2 += " and ud.mobile=" + objrecharge.UserId + "";
                }
                if (objrecharge.IPAddress != "")
                {
                    s2 += " and im.ip=" + objrecharge.IPAddress + "";
                }
                s2 += " order by im.mentiondate desc ";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCircleCodeList()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * from CircleCodeDetail with (nolock) order by circlename";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getIPAddressMasterAll(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * from IPMaster with (nolock) where 1=1  ";
                if (objrecharge.FromDate != DateTime.MinValue && objrecharge.ToDate != DateTime.MinValue)
                {
                    s2 += "  and convert(DATE, mentiondate  )  >= '" + objrecharge.FromDate.ToString("yyyy/MM/dd") + "'   and convert(DATE, mentiondate  )   <= '" + objrecharge.ToDate.ToString("yyyy/MM/dd") + "' ";
                }
                if (objrecharge.UserId != "")
                {
                    s2 += "  and userid = " + objrecharge.UserId + " ";
                }
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getSlab()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * FROM SlabMaster WITH (nolock) ";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getNumberList()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT * FROM numberlist WITH (nolock) ORDER BY Number";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getIReffCircle()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT DISTINCT circle,ltrim(rtrim(IReffCIrcle)) as IReffCIrcle  FROM userkhush.NumberList WITH (nolock) order by circle";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCircle()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"SELECT *  FROM LoopCircleCode WITH (nolock) order by circlecode";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public string Insert_Number(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_add_NumberList";
                SqlParameter[] parameter = {
                new SqlParameter("@Number",objrecharge.Number),
                new SqlParameter("@OperatorName",objrecharge.OperatorName),
                new SqlParameter("@OperatorCode",objrecharge.OperatorCode),
                new SqlParameter("@CircleName",objrecharge.CircleName),
                new SqlParameter("@CircleCode",objrecharge.CircleCode)
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }


        public string Edit_Number(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_edit_NumberList";
                SqlParameter[] parameter = {
                new SqlParameter("@Number",objrecharge.Number),
                new SqlParameter("@OperatorName",objrecharge.OperatorName),
                new SqlParameter("@OperatorCode",objrecharge.OperatorCode),
                new SqlParameter("@CircleName",objrecharge.CircleName),
                new SqlParameter("@CircleCode",objrecharge.CircleCode)
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }

        public string Delete_Number(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_delete_NumberList";
                SqlParameter[] parameter = {
                new SqlParameter("@Number",objrecharge.Number),
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }

        public string ActivateIp(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_activateIpaddress";
                SqlParameter[] parameter = {
                new SqlParameter("@ID",objrecharge.Id),
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }
        public string DeactivateIp(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_deactivateIpaddress";
                SqlParameter[] parameter = {
                new SqlParameter("@ID",objrecharge.Id),
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }

        public int InsertRechargeCommission(string cmd)
        {
            int res = 0;
            ObjData.StartConnection();
            try
            {
                string s2 = "delete from COMMISSIOIN_DISTRIBUTION_DETAIL";
                ObjData.RunInsUpDelQuery(s2);
                ObjData.RunInsUpDelQuery(cmd);
                res = 1;
            }
            catch (Exception ex)
            {
                res = 0;
            }
            ObjData.EndConnection();
            return res;
        }


        public DataTable OperatorOpetion(string @OperatorCodeId)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "OpertorOption";
                SqlParameter[] parameter = { new SqlParameter("@OperatorCodeId", OperatorCodeId),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable GetUserbal(string mobile)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_get_UserBal";
                SqlParameter[] parameter = { new SqlParameter("@mobile", mobile),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable GetCheckValues(string Msg)
        {
            string str = Msg.Trim().Replace(",", " ").Replace(":", " ").Replace("<", " ").Replace(">", " ").Replace("/", " ").Replace("*", " ").Replace("  ", " ").Replace("  ", " ").Replace("|", " ").Replace("=", " ").Replace("\"", " ").Trim();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_CheckTextResponse";
                SqlParameter[] parameter = { new SqlParameter("@Msg", str),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable LastRechargeRecode(string Userid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "LastTransactionIDRecode";
                SqlParameter[] parameter = { new SqlParameter("@Userid", Userid), };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataSet getRechargePlan(clsRecharge objrecharge)
        {
            DataSet ds = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getRechargePlan";
                SqlParameter[] parameter = {
                    new SqlParameter("@OperatorId", objrecharge.OperatorCode),
                    new SqlParameter("@CircleCode", objrecharge.CircleCode),
                };
                ds = ObjData.RunDataSetProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                ds = null;
            }
            ObjData.EndConnection();
            return ds;
        }

        public DataTable getUserBalance(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getuserBalance";
                SqlParameter[] parameter = { new SqlParameter("@email", objrecharge.Email), };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getUserBalance2(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getuserBalance";
                SqlParameter[] parameter = { new SqlParameter("@email", objrecharge.LoginEmail), };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getRechargePlanByCategory(clsRecharge objrecharge)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getRechargePlanByCategory";
                SqlParameter[] parameter = {
                    new SqlParameter("@operatorId", objrecharge.OperatorCode),
                    new SqlParameter("@circlecode", objrecharge.CircleCode),
                    new SqlParameter("@Categoryid", objrecharge.CategoryId),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable fillNumberList()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "select nl.*,lo.Id AS OperatorPlanCode,lc.circlecode AS CirclePlanCode,lc.CircleCode AS   CircleId,lc.CircleCode as CircleCode1   from NumberList nl WITH (nolock)  LEFT JOIN operatorcode lo WITH (nolock) ON nl.operatorid=lo.id LEFT JOIN circlecodedetail lc WITH (nolock) ON nl.CircleCode=lc.CircleCode ";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable fillNumberListNew(string str_numberseries)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "select nl.*,lo.Id AS OperatorPlanCode,lc.circlecode AS CirclePlanCode,lc.CircleCode AS   CircleId,lc.CircleCode as CircleCode1   from NumberList nl WITH (nolock)  LEFT JOIN operatorcode lo WITH (nolock) ON nl.operatorid=lo.id LEFT JOIN circlecodedetail lc WITH (nolock) ON nl.CircleCode=lc.CircleCode  where nl.number='" + str_numberseries + "'";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable GetAllOpertorSelectedByUser(string Userid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = @"select convert(NVARCHAR(max),oc.Id)+'__'+isnull(oo.Option1Name,'0')+'__'+isnull(oo.Option2Name,'0')+'__'+isnull(oo.Option3Name,'0')+'__'+isnull(oo.Option4Name,'0')+'__'+isnull(oo.Displayalue1,'0')+'__'+isnull(oo.Displayalue2,'0')+'__'+isnull(oo.Displayalue3,'0')+'__'+isnull(oo.Displayalue4,'0') AS id
,oc.Operator,oc.OPID,oc.Type,oc.Length,oc.Minimum,oc.Maximum,oc.DisplayName,oc.DisplayNote,oc.EntryBy,oc.EtryDate,oc.AccountDisplay,oc.CustomerDisplay,oc.LocationDisplay,oc.LoctionId,oc.OperatorImage,
oc.StartsWith,oc.DisabledReasion,oc.IsDown,oc.BackupAPI,oc.PartialPay,oc.operatortype from OperatorCode oc 
LEFT JOIN OperatorOption oo ON oc.Id=oo.OperatorCodeId
order by oc.Operator";
                //string s2 = @"select oc.* from operatorcode order by oc.Operator";
                dt = ObjData.RunDataTable(s2);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public string checkvalidation(string TxtAmount, string TxtMobileNo, string DdlOpertor)
        {
            string Error = "Error";
            if (TxtMobileNo == "")
            {
                Error = "Please Enter Mobile No.";
            }
            else if (DdlOpertor == "Select Operator")
            {
                Error = "Please Select Operator.";

            }
            else if (TxtAmount == "")
            {
                Error = "Please Enter Amount";

            }
            else { return "success"; }
            return Error;
        }
        public DataTable GetResponseValues(string Resp, string Type)
        {
            try
            {
                if (Type == "1")
                {
                    Resp = Resp.Replace("{", "[{");
                    Resp = Resp.Replace("}", "}]");
                    DataTable dtValue = (DataTable)JsonConvert.DeserializeObject(Resp, (typeof(DataTable)));
                    return dtValue;
                }
                else if (Type == "2")
                {


                    System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(new System.IO.StringReader(Resp));
                    reader.Read();

                    System.Data.DataSet ds = new System.Data.DataSet();
                    ds.ReadXml(reader, System.Data.XmlReadMode.Auto);
                    DataTable dt = ds.Tables[0];
                    return dt;
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("Status", typeof(string)));
                    dt.Columns.Add(new DataColumn("Our_txn_no", typeof(string)));
                    dt.Columns.Add(new DataColumn("operatorcode", typeof(string)));
                    dt.Columns.Add(new DataColumn("account", typeof(string)));
                    dt.Columns.Add(new DataColumn("amount", typeof(string)));
                    dt.Columns.Add(new DataColumn("operator_ref_no", typeof(string)));
                    dt.Columns.Add(new DataColumn("user_txn_no", typeof(string)));
                    dt.Columns.Add(new DataColumn("closing_balance", typeof(string)));
                    dt.Columns.Add(new DataColumn("message", typeof(string)));
                    dt.Columns.Add(new DataColumn("time", typeof(string)));

                    dt.Rows.Add(Resp.Split(',')[0].ToString(),
                        Resp.Split(',')[1].ToString(),
                        Resp.Split(',')[2].ToString(),
                        Resp.Split(',')[3].ToString(),
                        Resp.Split(',')[4].ToString(),
                        Resp.Split(',')[5].ToString(),
                        Resp.Split(',')[6].ToString(),
                        Resp.Split(',')[7].ToString(),
                        Resp.Split(',')[8].ToString(),
                        Resp.Split(',')[9].ToString()
                        );

                    return dt;
                }
            }
            catch (Exception ex)
            {
                DataTable dtt = new DataTable();
                dtt.Columns.Add("ResultErr");
                dtt.Rows.Add(ex.Message);
                return dtt;
            }
        }


        //public string checkvalidation(System.Web.UI.WebControls.TextBox TxtAmount, System.Web.UI.WebControls.TextBox TxtMobileNo, System.Web.UI.WebControls.DropDownList DdlOpertor)
        //{
        //    string Error = "Error";
        //    if (TxtMobileNo.Text.Trim() == "")
        //    {
        //        Error = "Please Enter Mobile No.";
        //    }
        //    else if (DdlOpertor.SelectedItem.Text == "Select Operator")
        //    {
        //        Error = "Please Select Operator.";

        //    }
        //    else if (TxtAmount.Text.Trim() == "")
        //    {
        //        Error = "Please Enter Amount";

        //    }
        //    else { return "success"; }
        //    return Error;
        //}
        public String InsertTransaction_Api_response(String TransactionId, int APIId, String URL, string Response)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_add_TRANSACTION_API_RESPONSES";
                SqlParameter[] parameter = {
                new SqlParameter("@TransactionID", TransactionId),
                new SqlParameter("@APIId", APIId),
                new SqlParameter("@URL", URL),
                new SqlParameter("@Response", Response),
                };
                DataTable dtresult = new DataTable();
                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
                res = dtresult.Rows[0][0].ToString();
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }


        //private String _strRequest(string SDCode, string APCode, string OPCode, string SessionNo, string txtMobileNo, string account, string authenticator3, string amount)
        //{
        //    ssl.CERTNo = ConfigurationManager.AppSettings["CERTNo"];
        //    StringBuilder _reqStr = new StringBuilder();
        //    #region Create Request
        //    _reqStr.Append("CERT=" + ssl.CERTNo + Environment.NewLine);
        //    _reqStr.Append("SD=" + SDCode + Environment.NewLine);
        //    _reqStr.Append("AP=" + APCode + Environment.NewLine);
        //    _reqStr.Append("OP=" + OPCode + Environment.NewLine);
        //    _reqStr.Append("SESSION=" + SessionNo + Environment.NewLine);
        //    _reqStr.Append("NUMBER=" + txtMobileNo + Environment.NewLine);
        //    _reqStr.Append("ACCOUNT=" + account + Environment.NewLine);
        //    _reqStr.Append("Authenticator3=" + authenticator3 + Environment.NewLine);
        //    _reqStr.Append("AMOUNT=" + amount + Environment.NewLine);
        //    _reqStr.Append("TERM_ID=" + APCode + Environment.NewLine);//Mostly value of TERM_ID=AP Code, but value may be vary.
        //    _reqStr.Append("COMMENT=test");
        //    #endregion
        //    return _reqStr.ToString();
        //}
        public static DataTable convertStringToDataTable(string data)
        {
            DataTable dataTable = new DataTable();

            int StartIndex = data.IndexOf("BEGIN");
            int EndIndex = data.IndexOf("END");
            int length = EndIndex - StartIndex;
            data = data.Substring((StartIndex + 7), length - 7);
            data = data.Replace("\n", String.Empty);
            DataRow dataRow = dataTable.NewRow();
            dataTable.Rows.Add(dataRow);
            foreach (string row in data.Split('\r'))
            {
                if (row != "")
                {
                    string[] keyValue = row.Split('=');
                    //if (!columnsAdded)
                    {
                        DataColumn dataColumn = new DataColumn(keyValue[0]);
                        dataTable.Columns.Add(dataColumn);
                    }
                    dataRow[keyValue[0]] = keyValue[1];
                    //}
                    //columnsAdded = true;
                    //dataTable.Rows.Add(dataRow);
                }
            }
            return dataTable;
        }
        public String InsertError(string ProcedureName, string ErrorRecieved, string BlockName, string ErrorCode = "", string Transaction_ID = "", string RStatus = "", string CStatus = "")
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_Add_Error_Log";
                SqlParameter[] parameter = {
               new SqlParameter("@ProcedureName", ProcedureName),
               new SqlParameter("@ErrorRecieved", ErrorRecieved),
               new SqlParameter("@BlockName", BlockName),
               new SqlParameter("@ErrorCode", ErrorCode),
               new SqlParameter("@Transaction_ID", Transaction_ID),
               new SqlParameter("@RStatus", RStatus),
                };
                DataTable dtresult = new DataTable();
                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
                res = dtresult.Rows[0][0].ToString();
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }
        public DataTable UpdateTransactionStatus(string url, string status, string Resp, string VenderId, string transactionid, string DeductionAmt, string UserId, string MobileNo, string msg, string LiveIdValue, int APIID)
        {

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_UpdateTransactionStatus";
                SqlParameter[] parameter = {
                                               new SqlParameter("@Url", url),
                                               new SqlParameter("@Status", status),
                                               new SqlParameter("@Response", Resp.Trim()),
                                               new SqlParameter("@VenderId", VenderId),
                                               new SqlParameter("@TransactionID", dt.Rows[0][1].ToString()),
                                               new SqlParameter("@DeductionAmt", DeductionAmt),
                                               new SqlParameter("@UserId", UserId),
                                               new SqlParameter("@RechargeNo", MobileNo),
                                               new SqlParameter("@msg", msg),
                                               new SqlParameter("@LiveId", LiveIdValue),
                                                new SqlParameter("@APIID", APIID),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateTransactionStatus1(string url, string status, string Resp, string VenderId, string transactionid, string DeductionAmt, string UserId, string MobileNo, string msg, string LiveIdValue, int APIID)
        {

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_UpdateTransactionStatus";
                SqlParameter[] parameter = {
                                               new SqlParameter("@Url", url),
                                               new SqlParameter("@Status", status),
                                               new SqlParameter("@Response", Resp.Trim()),
                                               new SqlParameter("@VenderId", VenderId),
                                               new SqlParameter("@TransactionID", dt.Rows[0][1].ToString()),
                                               new SqlParameter("@DeductionAmt", DeductionAmt),
                                               new SqlParameter("@UserId", UserId),
                                               new SqlParameter("@RechargeNo", MobileNo),
                                               new SqlParameter("@msg", msg),
                                               new SqlParameter("@LiveId", LiveIdValue),
                                                new SqlParameter("@APIID", APIID),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable GiftCardInitiate(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {

                s2 = "sp_GiftCardOrderInitiate";
                SqlParameter[] parameter = {
               new SqlParameter("@dtdata", objrecharge.dtData) ,
               new SqlParameter("@Mobile", objrecharge.UserMobile) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,
               new SqlParameter("@mentionby", "Online") ,
               new SqlParameter("@Orderid", objrecharge.ReferenceId)    ,
               new SqlParameter("@Email", objrecharge.Email)    ,
               new SqlParameter("@Name", objrecharge.UserName)    ,
               new SqlParameter("@LoginEmail", objrecharge.LoginEmail)    ,
               new SqlParameter("@UsedBalance", objrecharge.UsedBalance)    ,
               new SqlParameter("@GiftTo", objrecharge.GiftTo)    ,
               new SqlParameter("@OtherName", objrecharge.OtherName)    ,
               new SqlParameter("@OtherMobile", objrecharge.OtherMobile)    ,
               new SqlParameter("@OtherEmail", objrecharge.OtherEmail)    ,
               new SqlParameter("@Message", objrecharge.Message)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }
        public DataTable UpdateGiftCardInitiate(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_updateGiftCardOrderInitiate";
                SqlParameter[] parameter = {

               new SqlParameter("@referenceid", objrecharge.ReferenceId)    ,
               new SqlParameter("@Status", objrecharge.Status)    ,
               new SqlParameter("@Message", objrecharge.Message)    ,
               new SqlParameter("@Response", objrecharge.PaymentGatewayResponse)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
                InsertError("ParsingPaymentGateway2", ex.Message.ToString(), "ParsingPaymentGateway", "", "", objrecharge.ReferenceId, "");

            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }


        public DataTable UpdateGiftCardOrderDetail(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_updateGiftCardOrderDetail";
                SqlParameter[] parameter = {

               new SqlParameter("@id", objrecharge.Id)    ,
               new SqlParameter("@request", objrecharge.Request)    ,
               new SqlParameter("@Response", objrecharge.Response)    ,
               new SqlParameter("@VoucherData", objrecharge.VoucherData)    ,
               new SqlParameter("@Status", objrecharge.Status)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }
        public DataTable InsertGiftCardOrderDetailLog(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_add_GiftCardDetailLogDetail";
                SqlParameter[] parameter = {

               new SqlParameter("@OrderId", objrecharge.Id)    ,
               new SqlParameter("@request", objrecharge.Request)    ,
               new SqlParameter("@Response", objrecharge.Response)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }

        public DataTable getOperatorCodeType(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_getOperatorCodeType";
                SqlParameter[] parameter = {

               new SqlParameter("@id", objrecharge.OperatorCode)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }
        public DataTable RechargeInitiate(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                
                s2 = "sp_RechargeIntiate";
                SqlParameter[] parameter = {
               new SqlParameter("@RechargeMobile", objrecharge.RechargeMobile) ,
               new SqlParameter("@RechargeAmount", objrecharge.RechargeAmount) ,
               new SqlParameter("@OperatorId", objrecharge.OperatorCode) ,
               new SqlParameter("@UserMobile", objrecharge.UserMobile) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,
               new SqlParameter("@EntryBy", "Online") ,
               new SqlParameter("@RechargeType", "") ,
               new SqlParameter("@optional1","") ,
               new SqlParameter("@optional2", "") ,
               new SqlParameter("@optional3", "") ,
               new SqlParameter("@optional4", "") ,
               new SqlParameter("@DispalyValue1", "") ,
               new SqlParameter("@DispalyValue2", "") ,
               new SqlParameter("@DispalyValue3", "") ,
               new SqlParameter("@DispalyValue4", "")   ,
               new SqlParameter("@Promocode", "")    ,
               new SqlParameter("@OperatorType", "")    ,
               new SqlParameter("@referenceid", objrecharge.ReferenceId)    ,
               new SqlParameter("@Email", objrecharge.Email)    ,
               new SqlParameter("@UserName", objrecharge.UserName)    ,
               new SqlParameter("@LoginEmail", objrecharge.LoginEmail)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }
        public DataTable UpdateRechargeInitiate(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_UpdateRechargeInitiate";
                SqlParameter[] parameter = {
           
               new SqlParameter("@referenceid", objrecharge.ReferenceId)    ,
               new SqlParameter("@Status", objrecharge.Status)    ,
               new SqlParameter("@Message", objrecharge.Message)    ,
               new SqlParameter("@Response", objrecharge.PaymentGatewayResponse)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresult;
        }
        public DataTable RechargeNew(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            string str_messagesuccess = "";
            string str_img = "";
            string status = "";
            string referenceid = "";
            string LiveIdValue = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            DataTable dtresponse = new DataTable();
            dtresponse.Columns.Add(new DataColumn("Status", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("ReferenceId", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("RechargeMobile", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("Amount", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("Message", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("RechargeDate", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("Image", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("LiveId", typeof(string)));


            ObjData.StartConnection();

            try
            {
                if (objrecharge.RechargeType == "PaymentGateway")
                {

                s2 = "sp_RechargeNew";
                }
                else if (objrecharge.RechargeType == "Wallet")
                {

                    s2 = "sp_RechargeNewWallet";
                }
                SqlParameter[] parameter = {
               new SqlParameter("@RechargeMobile", objrecharge.RechargeMobile) ,
               new SqlParameter("@RechargeAmount", objrecharge.RechargeAmount) ,
               new SqlParameter("@OperatorId", objrecharge.OperatorCode) ,
               new SqlParameter("@IpAddress", "") ,
               new SqlParameter("@EntryBy", "Online") ,
               new SqlParameter("@RechargeType", objrecharge.RechargeType) ,
               new SqlParameter("@optional1", OptionalValue1) ,
               new SqlParameter("@optional2", OptionalValue2) ,
               new SqlParameter("@optional3", OptionalValue3) ,
               new SqlParameter("@optional4", OptionalValue4) ,
               new SqlParameter("@DispalyValue1", "") ,
               new SqlParameter("@DispalyValue2", "") ,
               new SqlParameter("@DispalyValue3", "") ,
               new SqlParameter("@DispalyValue4", "")   ,
               new SqlParameter("@Promocode", "")    ,
               new SqlParameter("@OperatorType", "")    ,
               new SqlParameter("@email", objrecharge.Email)    ,
               new SqlParameter("@mobile", objrecharge.Mobile)    ,
               new SqlParameter("@username", objrecharge.UserName)    ,
               new SqlParameter("@PaymentGatewayOrderid", objrecharge.PaymentGatewayOrderid)    ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);

                if (dtresult.Rows[0][0].ToString() == "1")
                {
                    referenceid = dtresult.Rows[0]["referenceid"].ToString();
                    string Resp = "";
                    string struseremail = dtresult.Rows[0]["email"].ToString();
                    string ErrorMsg = dtresult.Rows[0]["errors"].ToString();
                    string url = dtresult.Rows[0]["url"].ToString(); ;
                    string msg = "";
                    //string status = "";
                    string RechargeStatus = "";
                    string Type = dtresult.Rows[0]["Type"].ToString();
                    string StatusValue = dtresult.Rows[0]["StatusValue"].ToString();
                    string StatusName = dtresult.Rows[0]["StatusName"].ToString();
                    string VenderId = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdColumn = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdValue = "";
                    string LiveId = dtresult.Rows[0]["LiveId"].ToString();
                  
                    string Error1 = "";

                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Resp = url.CallURL();


                    if (ErrorMsg != "")
                    {
                        string[] errmsg = ErrorMsg.Split(new string[] { "||" }, StringSplitOptions.None);
                        //string[] errmsg = ErrorMsg.Split('[]');
                        for (int i = 0; i < errmsg.Length; i++)
                        {
                            if (errmsg[i].ToString().Trim() != "")
                            {
                                if (Resp.Contains(errmsg[i].ToString().Trim()) == true && errmsg[i] != "")
                                {
                                    status = "Failed";
                                    msg = errmsg[i];
                                    if (msg.ToLower().Contains("insufficient") == true)
                                    {

                                        msg = "System error found";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (status != "Failed")
                    {
                        DataTable dtResp = GetResponseValues(Resp, Type);
                        DataColumnCollection columns = dtResp.Columns;
                        if (dtResp.Columns.Contains("ResultErr") == false)
                        {
                            string[] StsCol = StatusName.Split('/');
                            string[] StsVal = StatusValue.Split(',');
                            if (dtResp.Columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[0].Trim().ToUpper())
                                {
                                    status = "Success";
                                }
                                if (matchvalue == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                if (StsVal.Length > 3)
                                {
                                    if (matchvalue == StsVal[3].Trim().ToUpper())
                                    {
                                        status = "Failed";
                                    }
                                    if (StsVal.Length > 4)
                                    {
                                        if (matchvalue == StsVal[4].Trim().ToUpper())
                                        {
                                            if (matchvalue == "suspense")
                                            {
                                                status = "Pending";
                                            }
                                            else
                                            {
                                                status = "Failed";
                                            }
                                        }
                                    }
                                }
                            }
                            if (columns.Contains(VenderIdColumn))
                            {
                                //Vendor ID means RP Id
                                VenderId = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                                VenderIdValue = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                            }
                            else
                            {
                                VenderId = "";
                                VenderIdValue = "";
                            }
                            if (columns.Contains(LiveId))
                            {
                                //Live Id value
                                LiveIdValue = dtResp.Rows[0][LiveId].ToString().ToUpper();
                            }
                            if (columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[2].Trim().ToUpper())
                                {
                                    status = "Pending";
                                }
                            }
                            if (columns.Contains("MSG"))
                            {
                                msg = dtResp.Rows[0]["MSG"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            else
                                if (columns.Contains("message"))
                            {
                                msg = dtResp.Rows[0]["message"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                            {
                                if (dtResp.Rows[0][StsCol[StsCol.Length - 1].Trim()].ToString() == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                else if (StsCol.Length == 2)
                                {
                                    if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                                    {
                                        status = "Failed";

                                    }
                                }
                            }
                        }
                        if (status == "")
                        {
                            status = "";
                            status = "Pending";
                        }
                        if (columns.Contains("txstatus_desc"))
                        {
                            if (dtResp.Rows[0]["txstatus_desc"].ToString().ToLower() == "pending")
                            {
                                status = "Pending";
                            }
                        }
                    }



                    s2 = "sp_update_RechargeRequest";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
               new SqlParameter("@VendorId", VenderIdValue) ,
               new SqlParameter("@Liveid", LiveIdValue) ,
               new SqlParameter("@status", status) ,
               new SqlParameter("@Message", msg) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedure(s2, parameter2);

                   
                    if (status == "Failed")
                    {
                        str_messagesuccess = "Recharge Request Failed. ";
                        str_img = "fail.png";
                    }
                    else if (status == "Success")
                    {
                        str_messagesuccess = "Recharge Request Submitted Successfully. ";
                        str_img = "success.png";
                        
                    }
                    else
                    {
                        str_messagesuccess = "Recharge Request Pending. ";
                        str_img = "pending.png";
                    }
                }
                else
                {
                    status = "Failed";
                    str_img = "fail.png";
                    str_messagesuccess = dtresult.Rows[0]["msg"].ToString();
                }

                dtresponse.Rows.Add(status, referenceid, objrecharge.RechargeMobile, objrecharge.RechargeAmount, str_messagesuccess, System.DateTime.Now.ToString("dd/MM/yyyy"),str_img, LiveIdValue);

                //                string str_body = @" <table style=""border:8px solid gainsboro;width:350px;"">
                //        <tr>
                //            <td><img src=""http://khushimobilejunction.com/images/logo.png"" style=""width:200px;"" /></td>
                //        </tr>
                //        <tr><td><h4 style=""padding:0px;margin:0px;"">" + str_messagesuccess + @"</h4></td></tr>
                //         <tr><td><h3 style=""padding:0px;margin:0px;"">Rs. " + objrecharge.RechargeAmount.ToString() + @"<img src=""http://khushimobilejunction.com/images/" + str_img + @""" style=""height:15px;""  /></h3></td></tr>
                //         <tr><td>Operator</td></tr>
                //         <tr><td><h4 style=""padding:0px;margin:0px;"">" + objrecharge.OperatorName + @"<img src=""http://khushimobilejunction.com/Operatorimage/" + objrecharge.OperatorName + @".png""  /></h4></td></tr>
                //         <tr><td>Mobile No</td></tr>
                //         <tr><td><h4 style=""padding:0px;margin:0px;"">" + objrecharge.RechargeMobile + @"</h4></td></tr>
                //          <tr><td>Date : " + Convert.ToDateTime(dtresult.Rows[0]["Trandate"].ToString()).ToString("dd/MM/yyyy hh:mm tt") + @"</td></tr>
                //          <tr><td>Transaction Id : " + referenceid + @"</td></tr>
                //          <tr><td><h4 style=""padding:0px;margin:0px;"">Your Updated Balance Amount  : " + dtresult.Rows[0]["newbalance"].ToString() + @"</h4></td></tr>
                //    </table>";
                //ObjData.sendmail("Khushi Mobile Junction- Recharge", struseremail, str_body);
            }
            catch (Exception ex)
            {
                InsertError("rechargenew", ex.Message, "FronRechargeNewMethodPage", "", "", "", "");
                res = "Error: ";
                res += ex.Message;
                dtresponse.Rows.Add("error", referenceid, objrecharge.RechargeMobile, objrecharge.RechargeAmount, ex.Message, System.DateTime.Now.ToString("dd/MM/yyyy"), "fail.png","");
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            return dtresponse;
        }

        public DataTable RechargeFromAPINew(clsRecharge objrecharge)
        {

            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);


            string str_balance = "";
            string status = "";
            string referenceid = ""; string LiveIdValue = ""; string msg = "";

            DataTable dtresult = new DataTable();





            try
            {
                s2 = "sp_RechargeFromAPI";
                SqlParameter[] parameter = {
               new SqlParameter("@RechargeMobile", objrecharge.RechargeMobile) ,
               new SqlParameter("@RechargeAmount", objrecharge.RechargeAmount) ,
               new SqlParameter("@OPCode", objrecharge.OperatorCode) ,
               new SqlParameter("@APIUserMobile", objrecharge.APIUserMobile) ,
               new SqlParameter("@APIuserpassword", objrecharge.UserPassword) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,
               new SqlParameter("@AgentId", objrecharge.AgentId) ,
               //new SqlParameter("@optional1", objrecharge.Option1) ,
               //new SqlParameter("@optional2", objrecharge.Option2) ,
               //new SqlParameter("@optional3", objrecharge.Option3) ,
               //new SqlParameter("@optional4", objrecharge.Option4) ,
                new SqlParameter("@DispalyValue1", objrecharge.OptionalValue1) ,
               new SqlParameter("@DispalyValue2", objrecharge.OptionalValue2) ,
               new SqlParameter("@DispalyValue3", objrecharge.OptionalValue3) ,
               new SqlParameter("@DispalyValue4", objrecharge.OptionalValue4)   ,

                };
                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);

                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }

            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {

                //   dtresult = ObjData.RunDataTableProcedure(s2, parameter);
                if (dtresult.Rows[0][0].ToString() == "1")
                {
                    referenceid = dtresult.Rows[0]["referenceid"].ToString();
                    string Resp = "";
                    string struseremail = dtresult.Rows[0]["email"].ToString();
                    string ErrorMsg = dtresult.Rows[0]["errors"].ToString();
                    string url = dtresult.Rows[0]["url"].ToString(); ;
                    msg = "";
                    status = "";
                    string RechargeStatus = "";
                    string Type = dtresult.Rows[0]["Type"].ToString();
                    string StatusValue = dtresult.Rows[0]["StatusValue"].ToString();
                    string StatusName = dtresult.Rows[0]["StatusName"].ToString();
                    string VenderId = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdColumn = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdValue = "";
                    string LiveId = dtresult.Rows[0]["LiveId"].ToString();
                    LiveIdValue = "";
                    string Error1 = "";
                    str_balance = dtresult.Rows[0]["balanceamount"].ToString();
                    //  Resp = url.CallURL();
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    //  request.AddHeader("postman-token", "2e63cbe6-df93-6e99-6d50-dda50d65101a");
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "application/x-www-form-urlencoded");
                    request.AddParameter("application/x-www-form-urlencoded", url.Split('?')[1].ToString(), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    Resp = response.Content;
                    //                   Resp = @"<?xml version=""1.0"" encoding=""utf-8""?>
                    //<Result xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns=""http://tempuri.org/"">
                    //  <reqid>442603747</reqid>
                    //  <status>FAILED</status>
                    //  <remark>Invalid Denomination!</remark>
                    //  <mn>8962272109</mn>
                    //  <field1 />
                    //  <ec>1006</ec>
                    //  <amt>50</amt>
                    //</Result>";

                    if (ErrorMsg != "")
                    {
                        string[] errmsg = ErrorMsg.Split(new string[] { "||" }, StringSplitOptions.None);
                        //string[] errmsg = ErrorMsg.Split('[]');
                        for (int i = 0; i < errmsg.Length; i++)
                        {
                            if (errmsg[i].ToString().Trim() != "")
                            {
                                if (Resp.Contains(errmsg[i].ToString().Trim()) == true && errmsg[i] != "")
                                {
                                    status = "Failed";
                                    msg = errmsg[i];
                                    if (msg.ToLower().Contains("insufficient") == true)
                                    {

                                        msg = "System error found";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (status != "Failed")
                    {
                        DataTable dtResp = GetResponseValues(Resp, Type);
                        DataColumnCollection columns = dtResp.Columns;
                        if (dtResp.Columns.Contains("ResultErr") == false)
                        {
                            string[] StsCol = StatusName.Split('/');
                            string[] StsVal = StatusValue.Split(',');
                            if (dtResp.Columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[0].Trim().ToUpper())
                                {
                                    status = "Success";
                                }
                                if (matchvalue == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                if (StsVal.Length > 3)
                                {
                                    if (matchvalue == StsVal[3].Trim().ToUpper())
                                    {
                                        status = "Failed";
                                    }
                                    if (matchvalue == StsVal[4].Trim().ToUpper())
                                    {
                                        if (matchvalue == "suspense")
                                        {
                                            status = "Pending";
                                        }
                                        else
                                        {
                                            status = "Failed";
                                        }
                                    }
                                }
                            }
                            if (columns.Contains(VenderIdColumn))
                            {
                                //Vendor ID means RP Id
                                VenderId = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                                VenderIdValue = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                            }
                            else
                            {
                                VenderId = "";
                                VenderIdValue = "";
                            }
                            if (columns.Contains(LiveId))
                            {
                                //Live Id value
                                LiveIdValue = dtResp.Rows[0][LiveId].ToString().ToUpper();
                            }
                            if (columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[2].Trim().ToUpper())
                                {
                                    status = "Pending";
                                }
                            }
                            if (columns.Contains("MSG"))
                            {
                                msg = dtResp.Rows[0]["MSG"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            else
                                if (columns.Contains("message"))
                            {
                                msg = dtResp.Rows[0]["message"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                            {
                                if (dtResp.Rows[0][StsCol[StsCol.Length - 1].Trim()].ToString() == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                else if (StsCol.Length == 2)
                                {
                                    if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                                    {
                                        status = "Failed";

                                    }
                                }
                            }
                        }
                        if (status == "")
                        {
                            status = "";
                            status = "Pending";
                        }
                        if (columns.Contains("txstatus_desc"))
                        {
                            if (dtResp.Rows[0]["txstatus_desc"].ToString().ToLower() == "pending")
                            {
                                status = "Pending";
                            }
                        }
                    }



                    s2 = "sp_update_RechargeRequest";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
               new SqlParameter("@VendorId", VenderIdValue) ,
               new SqlParameter("@Liveid", LiveIdValue) ,
               new SqlParameter("@status", status) ,
               new SqlParameter("@Message", msg) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedureTRans(s2, tr, parameter2);

                    string str_messagesuccess = "";
                    string str_img = "";
                    if (status == "Failed")
                    {
                        str_messagesuccess = "Recharge Request Failed. ";
                        str_img = "fail.png";
                    }
                    else
                    {
                        str_messagesuccess = "Recharge Request Submitted Successfully. ";
                        str_img = "success.png";
                    }
                }
                else
                {
                    status = "Failed";
                    msg = dtresult.Rows[0]["msg"].ToString();
                }

               
                tr.Commit();

            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }

            DataTable dtresponse = new DataTable { TableName = "RechargeResponse" };
            dtresponse.Columns.Add(new DataColumn("STATUS", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MOBILE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("AMOUNT", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("TXNID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("AGENTID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("OPID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("BALANCE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MSG", typeof(string)));

            dtresponse.Rows.Add(status, objrecharge.RechargeMobile, objrecharge.RechargeAmount.ToString(), referenceid, objrecharge.AgentId, LiveIdValue, str_balance, msg);

            return dtresponse;
        }
        public DataTable RechargeFromAPI(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            string str_balance = "";
            string status = "";
            string referenceid = ""; string LiveIdValue = ""; string msg = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_RechargeFromAPI";
                SqlParameter[] parameter = {
               new SqlParameter("@RechargeMobile", objrecharge.RechargeMobile) ,
               new SqlParameter("@RechargeAmount", objrecharge.RechargeAmount) ,
               new SqlParameter("@OPCode", objrecharge.OperatorCode) ,
               new SqlParameter("@APIUserMobile", objrecharge.APIUserMobile) ,
               new SqlParameter("@APIuserpassword", objrecharge.UserPassword) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,
               new SqlParameter("@AgentId", objrecharge.AgentId) ,
               //new SqlParameter("@optional1", objrecharge.Option1) ,
               //new SqlParameter("@optional2", objrecharge.Option2) ,
               //new SqlParameter("@optional3", objrecharge.Option3) ,
               //new SqlParameter("@optional4", objrecharge.Option4) ,
                new SqlParameter("@DispalyValue1", objrecharge.OptionalValue1) ,
               new SqlParameter("@DispalyValue2", objrecharge.OptionalValue2) ,
               new SqlParameter("@DispalyValue3", objrecharge.OptionalValue3) ,
               new SqlParameter("@DispalyValue4", objrecharge.OptionalValue4)   ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
                if (dtresult.Rows[0][0].ToString() == "1")
                {
                    referenceid = dtresult.Rows[0]["referenceid"].ToString();
                    string Resp = "";
                    string struseremail = dtresult.Rows[0]["email"].ToString();
                    string ErrorMsg = dtresult.Rows[0]["errors"].ToString();
                    string url = dtresult.Rows[0]["url"].ToString(); ;
                    msg = "";
                    status = "";
                    string RechargeStatus = "";
                    string Type = dtresult.Rows[0]["Type"].ToString();
                    string StatusValue = dtresult.Rows[0]["StatusValue"].ToString();
                    string StatusName = dtresult.Rows[0]["StatusName"].ToString();
                    string VenderId = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdColumn = dtresult.Rows[0]["VenderId"].ToString();
                    string VenderIdValue = "";
                    string LiveId = dtresult.Rows[0]["LiveId"].ToString();
                    LiveIdValue = "";
                    string Error1 = "";
                    str_balance = dtresult.Rows[0]["balanceamount"].ToString();
                    //  Resp = url.CallURL();
                    var client = new RestClient(url);
                    var request = new RestRequest(Method.POST);
                    //  request.AddHeader("postman-token", "2e63cbe6-df93-6e99-6d50-dda50d65101a");
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("content-type", "application/x-www-form-urlencoded");
                    request.AddParameter("application/x-www-form-urlencoded", url.Split('?')[1].ToString(), ParameterType.RequestBody);
                    IRestResponse response = client.Execute(request);
                    Resp = response.Content;
                    //                   Resp = @"<?xml version=""1.0"" encoding=""utf-8""?>
                    //<Result xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns=""http://tempuri.org/"">
                    //  <reqid>442603747</reqid>
                    //  <status>FAILED</status>
                    //  <remark>Invalid Denomination!</remark>
                    //  <mn>8962272109</mn>
                    //  <field1 />
                    //  <ec>1006</ec>
                    //  <amt>50</amt>
                    //</Result>";

                    if (ErrorMsg != "")
                    {
                        string[] errmsg = ErrorMsg.Split(new string[] { "||" }, StringSplitOptions.None);
                        //string[] errmsg = ErrorMsg.Split('[]');
                        for (int i = 0; i < errmsg.Length; i++)
                        {
                            if (errmsg[i].ToString().Trim() != "")
                            {
                                if (Resp.Contains(errmsg[i].ToString().Trim()) == true && errmsg[i] != "")
                                {
                                    status = "Failed";
                                    msg = errmsg[i];
                                    if (msg.ToLower().Contains("insufficient") == true)
                                    {

                                        msg = "System error found";
                                    }
                                    break;
                                }
                            }
                        }
                    }
                    if (status != "Failed")
                    {
                        DataTable dtResp = GetResponseValues(Resp, Type);
                        DataColumnCollection columns = dtResp.Columns;
                        if (dtResp.Columns.Contains("ResultErr") == false)
                        {
                            string[] StsCol = StatusName.Split('/');
                            string[] StsVal = StatusValue.Split(',');
                            if (dtResp.Columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[0].Trim().ToUpper())
                                {
                                    status = "Success";
                                }
                                if (matchvalue == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                if (StsVal.Length > 3)
                                {
                                    if (matchvalue == StsVal[3].Trim().ToUpper())
                                    {
                                        status = "Failed";
                                    }
                                    if (matchvalue == StsVal[4].Trim().ToUpper())
                                    {
                                        if (matchvalue == "suspense")
                                        {
                                            status = "Pending";
                                        }
                                        else
                                        {
                                            status = "Failed";
                                        }
                                    }
                                }
                            }
                            if (columns.Contains(VenderIdColumn))
                            {
                                //Vendor ID means RP Id
                                VenderId = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                                VenderIdValue = dtResp.Rows[0][VenderIdColumn].ToString().ToUpper();
                            }
                            else
                            {
                                VenderId = "";
                                VenderIdValue = "";
                            }
                            if (columns.Contains(LiveId))
                            {
                                //Live Id value
                                LiveIdValue = dtResp.Rows[0][LiveId].ToString().ToUpper();
                            }
                            if (columns.Contains(StsCol[0].Trim()))
                            {
                                string matchvalue = dtResp.Rows[0][StsCol[0].Trim()].ToString().ToUpper();
                                if (matchvalue == StsVal[2].Trim().ToUpper())
                                {
                                    status = "Pending";
                                }
                            }
                            if (columns.Contains("MSG"))
                            {
                                msg = dtResp.Rows[0]["MSG"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            else
                                if (columns.Contains("message"))
                            {
                                msg = dtResp.Rows[0]["message"].ToString().ToUpper();
                                if (msg.ToLower().Contains("insufficient") == true)
                                {
                                    Error1 = "System error found";
                                }
                                else
                                {
                                    Error1 = msg;
                                }
                            }
                            if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                            {
                                if (dtResp.Rows[0][StsCol[StsCol.Length - 1].Trim()].ToString() == StsVal[1].Trim().ToUpper())
                                {
                                    status = "Failed";
                                }
                                else if (StsCol.Length == 2)
                                {
                                    if (dtResp.Columns.Contains(StsCol[StsCol.Length - 1]))
                                    {
                                        status = "Failed";

                                    }
                                }
                            }
                        }
                        if (status == "")
                        {
                            status = "";
                            status = "Pending";
                        }
                        if (columns.Contains("txstatus_desc"))
                        {
                            if (dtResp.Rows[0]["txstatus_desc"].ToString().ToLower() == "pending")
                            {
                                status = "Pending";
                            }
                        }
                    }



                    s2 = "sp_update_RechargeRequest";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
               new SqlParameter("@VendorId", VenderIdValue) ,
               new SqlParameter("@Liveid", LiveIdValue) ,
               new SqlParameter("@status", status) ,
               new SqlParameter("@Message", msg) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedure(s2, parameter2);

                    string str_messagesuccess = "";
                    string str_img = "";
                    if (status == "Failed")
                    {
                        str_messagesuccess = "Recharge Request Failed. ";
                        str_img = "fail.png";
                    }
                    else
                    {
                        str_messagesuccess = "Recharge Request Submitted Successfully. ";
                        str_img = "success.png";
                    }
                }
                else
                {
                    status = "Failed";
                    msg = dtresult.Rows[0]["msg"].ToString();
                }

            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            DataTable dtresponse = new DataTable { TableName = "RechargeResponse" };
            dtresponse.Columns.Add(new DataColumn("STATUS", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MOBILE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("AMOUNT", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("TXNID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("AGENTID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("OPID", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("BALANCE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MSG", typeof(string)));

            dtresponse.Rows.Add(status, objrecharge.RechargeMobile, objrecharge.RechargeAmount.ToString(), referenceid, objrecharge.AgentId, LiveIdValue, str_balance, msg);

            return dtresponse;
        }
        public DataTable GetUserBalanceAPI(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            string str_balance = "";
            string str_message = "";
            string status = "";
            string referenceid = ""; string LiveIdValue = ""; string msg = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_UserBalanceAPI";
                SqlParameter[] parameter = {
               new SqlParameter("@APIUserMobile", objrecharge.APIUserMobile) ,
               new SqlParameter("@APIuserpassword", objrecharge.UserPassword) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
                status = dtresult.Rows[0][0].ToString();
                if (dtresult.Rows[0][0].ToString() == "1")
                {
                    str_balance = dtresult.Rows[0]["balanceamount"].ToString();
                }
                else
                {
                    str_balance = dtresult.Rows[0]["balanceamount"].ToString();
                }
                str_message = dtresult.Rows[0]["msg"].ToString();

            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            DataTable dtresponse = new DataTable { TableName = "UserBalance" };
            dtresponse.Columns.Add(new DataColumn("STATUS", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MESSAGE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("BALANCE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("APIUSERMOBILE", typeof(string)));

            dtresponse.Rows.Add(status, str_message, str_balance, objrecharge.APIUserMobile);

            return dtresponse;
        }
        public DataTable InsertDisputeRequestAPI(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            string str_message = "";
            string status = "";
            string referenceid = ""; string LiveIdValue = ""; string msg = "";
            SqlConnection cn;
            DataTable dtresult = new DataTable();
            ObjData.StartConnection();

            try
            {
                s2 = "sp_add_DisputeRequestAPI";
                SqlParameter[] parameter = {
               new SqlParameter("@APIUserMobile", objrecharge.APIUserMobile) ,
               new SqlParameter("@APIuserpassword", objrecharge.UserPassword) ,
               new SqlParameter("@IpAddress", objrecharge.IPAddress) ,
               new SqlParameter("@agentid", objrecharge.ReferenceId) ,

                };

                dtresult = ObjData.RunDataTableProcedure(s2, parameter);
                status = dtresult.Rows[0][0].ToString();

                str_message = dtresult.Rows[0]["msg"].ToString();

            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                //tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
            }
            DataTable dtresponse = new DataTable { TableName = "DisputeRequest" };
            dtresponse.Columns.Add(new DataColumn("STATUS", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("MESSAGE", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("APIUSERMOBILE", typeof(string)));

            dtresponse.Rows.Add(status, str_message, objrecharge.APIUserMobile);

            return dtresponse;
        }

        public DataTable InsertCallBackURL(string url)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_InsertCallbackUrl";
                SqlParameter[] parameter = { new SqlParameter("@Url", url),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable InsertSaveURLHitting(string url, string IPAddress)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_Add_URLHitting";
                SqlParameter[] parameter = { new SqlParameter("@RequestURL", url),
                    new SqlParameter("@IPAddress", IPAddress),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public string Insert_Slab(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_add_SlabMaster";
                SqlParameter[] parameter = {
                new SqlParameter("@SlabName",objrecharge.SlabName),
                new SqlParameter("@MentionBy",objrecharge.MentionBy)
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "0";
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }

        public DataTable GetRechargeUserType(string refId)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_RechargeUserType";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateCallBackResponse(string refId, string LiveId, string status, string Message)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_update_Callback";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@Liveid", LiveId),
                                               new SqlParameter("@status", status),
                                               new SqlParameter("@Message", Message),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public string InsertCallBackURLHitting(string userid, string callbackurl, string agentid)
        {
            DataTable dt = null;
            string res = "";
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_add_callbackurlhitting";
                SqlParameter[] parameter = {
                                               new SqlParameter("@userid", userid),
                                               new SqlParameter("@callbackurl", callbackurl),
                                               new SqlParameter("@agentid", agentid),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
                res = dt.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                dt = null;
                res = "0";
            }
            ObjData.EndConnection();
            return res;
        }
        public DataTable UpdateCallBackResponseRetailer(string refId, string LiveId, string status, string Message)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_update_CallbackRetailer";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@Liveid", LiveId),
                                               new SqlParameter("@status", status),
                                               new SqlParameter("@Message", Message),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateRechargeStatusManual(string refId, string status, string entryby)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_UpdateStatusManual";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@status", status),
                                               new SqlParameter("@EntryBy", entryby),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateLiveId(string refId, string liveid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_EditRechargeLiveId";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@Liveid", liveid),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable InsertPayuWebhooklog(string str_Response, string str_MentionBy)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_add_PayuWebhookLog";
                SqlParameter[] parameter = {
                                               new SqlParameter("@response", str_Response),
                                               new SqlParameter("@MentionBy", str_MentionBy),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateRechargeMobileNo(string refId, string NewMobileNo, string mentionby)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_editRechargeMobile";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@NewMobileNo", NewMobileNo),
                                               new SqlParameter("@mentionby", mentionby),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateRechargeStatusManualRetailer(string refId, string status, string entryby)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_UpdateStatusManualRetailer";
                SqlParameter[] parameter = {
                                               new SqlParameter("@ReferenceId", refId),
                                               new SqlParameter("@status", status),
                                               new SqlParameter("@EntryBy", entryby),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable UpdateDisputeStatus(string disputeid, string liveid, string remark, string status, string entryby)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_UpdateDisputeStatus";
                SqlParameter[] parameter = {
                                               new SqlParameter("@DIsputeid", disputeid),
                                               new SqlParameter("@LiveId", liveid),
                                               new SqlParameter("@Remark", remark),
                                               new SqlParameter("@status", status),
                                               new SqlParameter("@EntryBy", entryby),
                                           };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }


        public DataTable getRechargeReport(clsRecharge objrecharge)
        {
            //            string str_query = @"SELECT ud.Mobile,oc.Operator,  rq.UserMobile,ud.name,rq.RechargeMobile,rq.RechargeAmount,rq.liveid,
            //(SELECT isnull(sum(cramount),0)-isnull(sum(dramount),0) FROM  TransactionDetail td WITH (nolock) WHERE id<=(SELECT isnull( max(id),0) FROM TransactionDetail td2 WHERE td2.TransactionId=rq.ReferenceId AND td2.userid=rq.UserMobile) AND td.userid=rq.UserMobile) AS balanceamount
            //,rq.ReferenceId,rq.Status,rq.Message,rq.Entrydate,rq.apiname,rq.rechargeresponse,rq.rechargerequest FROM rechargerequest rq with (nolock) LEFT JOIN userdetail ud with (nolock) ON rq.UserMobile=ud.id LEFT JOIN operatorcode oc WITH (nolock) ON oc.Id=rq.OperatorId where 1=1  ";

            string str_query = @"SELECT ud.Mobile,oc.Operator,  rq.UserMobile,ud.name,rq.RechargeMobile,rq.RechargeAmount,rq.liveid,
0 AS balanceamount
,rq.ReferenceId,rq.Status,rq.Message,rq.Entrydate,rq.apiname FROM rechargerequest rq with (nolock) LEFT JOIN userdetail ud with (nolock) ON rq.UserMobile=ud.id LEFT JOIN operatorcode oc WITH (nolock) ON oc.Id=rq.OperatorId where 1=1  ";


            if (objrecharge.FromDate != DateTime.MinValue && objrecharge.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(DATE, rq.entrydate  )  >= '" + objrecharge.FromDate.ToString("yyyy/MM/dd") + "'   and convert(DATE, rq.entrydate  )   <= '" + objrecharge.ToDate.ToString("yyyy/MM/dd") + "' ";
            }
            if (objrecharge.Name != "")
            {
                str_query += "  and ud.name like '%" + objrecharge.Name + "%' ";
            }
            if (objrecharge.UserMobile != "")
            {
                str_query += "  and ud.mobile = '" + objrecharge.UserMobile + "' ";
            }
            if (objrecharge.RechargeMobile != "")
            {
                str_query += "  and rq.rechargemobile = '" + objrecharge.RechargeMobile + "' ";
            }
            if (objrecharge.ReferenceId != "")
            {
                str_query += "  and rq.ReferenceId = '" + objrecharge.ReferenceId + "' ";
            }
            //if (objrecharge.UserId != "")
            //{
            //    str_query += "  and rq.userid = '" + objrecharge.UserId + "' ";
            //}
            if (objrecharge.Status != "0")
            {
                if (objrecharge.Status == "Pending")
                {
                    str_query += "  and  rq.Status in  ('Pending','Request Sent') ";
                }
                else
                {
                    str_query += "  and  rq.Status = '" + objrecharge.Status + "' ";
                }


            }
            if (objrecharge.OperatorCode != "0" && objrecharge.OperatorCode != null)
            {
                str_query += "  and  rq.operatorid = '" + objrecharge.OperatorCode + "' ";
            }
            if (objrecharge.APIId != "0" && objrecharge.APIId != null)
            {
                str_query += "  and  rq.apiid = '" + objrecharge.APIId + "' ";
            }

            str_query += " order by rq.entrydate  desc";

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                dt = ObjData.RunDataTable(str_query);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable getRequestResponse(clsRecharge objrecharge)
        {


            string str_query = @"SELECT * from rechargerequest with (nolock) where ReferenceId = '" + objrecharge.ReferenceId + "'  ";

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                dt = ObjData.RunDataTable(str_query);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getDIsputeReport(clsRecharge objRecharge)
        {
            string str_query = "SELECT dd.*,rq.UserMobile,rq.RechargeMobile,rq.RechargeAmount,rq.entrydate as rechargedate FROM DisputeDetail dd LEFT JOIN rechargerequest rq ON dd.ReferenceId=rq.ReferenceId where 1=1 ";


            if (objRecharge.FromDate != DateTime.MinValue && objRecharge.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(DATE, dd.entrydate  )  >= '" + objRecharge.FromDate.ToString("yyyy/MM/dd") + "'   and convert(DATE, dd.entrydate  )   <= '" + objRecharge.ToDate.ToString("yyyy/MM/dd") + "' ";
            }

            if (objRecharge.RechargeMobile != "")
            {
                str_query += "  and rq.RechargeMobile = '" + objRecharge.RechargeMobile + "' ";
            }
            if (objRecharge.UserMobile != "")
            {
                str_query += "  and rq.UserMobile = '" + objRecharge.UserMobile + "' ";
            }

            if (objRecharge.Status != "0")
            {
                str_query += "  and dd.status = '" + objRecharge.Status + "' ";
            }


            str_query += " order by dd.entrydate  desc";

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                dt = ObjData.RunDataTable(str_query);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getCallbackURLReport(clsRecharge objRecharge)
        {
            string str_query = "SELECT * from callbackurl with (nolock) where 1=1 ";


            if (objRecharge.FromDate != DateTime.MinValue && objRecharge.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(DATE, [Datetime]  )  >= '" + objRecharge.FromDate.ToString("yyyy/MM/dd") + "'   and convert(DATE,  [Datetime]  )   <= '" + objRecharge.ToDate.ToString("yyyy/MM/dd") + "' ";
            }

            if (objRecharge.ReferenceId != "")
            {
                str_query += "  and url like  '%" + objRecharge.ReferenceId + "%' ";
            }


            str_query += " order by [Datetime]  desc";

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                dt = ObjData.RunDataTable(str_query);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public String InsertCallbackURL(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_add_CallbackURLMaster";
                SqlParameter[] parameter = {
               new SqlParameter("@userid", objrecharge.UserId),
               new SqlParameter("@CallbackURL", objrecharge.CallbackURL),
               new SqlParameter("@mentionby", objrecharge.MentionBy),
                };
                DataTable dtresult = new DataTable();
                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
                res = dtresult.Rows[0][0].ToString();
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }
        public String InsertIPAddress(clsRecharge objrecharge)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataSet ds = new DataSet();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);

            try
            {
                s2 = "sp_add_IPMaster";
                SqlParameter[] parameter = {
               new SqlParameter("@userid", objrecharge.UserId),
               new SqlParameter("@ip", objrecharge.IPAddress),
               new SqlParameter("@mentionby", objrecharge.MentionBy),
                };
                DataTable dtresult = new DataTable();
                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
                res = dtresult.Rows[0][0].ToString();
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = "Error: ";
                res += ex.Message;
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }
        public string ReturnMessage(string Status, string Msg, string Format)
        {
            string RespInFormat = "";
            try
            {
                if (Format.ToUpper() == "XML")
                {
                    RespInFormat = "<NODES>";
                    RespInFormat += "<STATUS>" + Status + "</STATUS>";
                    RespInFormat += "<MSG>" + Msg + "</MSG>";
                    RespInFormat += "</NODES>";
                }
                else if (Format.ToUpper() == "JSON")
                {
                    JSONResponse Json = new JSONResponse();
                    Json.STATUS = Status;
                    Json.MSG = Msg;
                    RespInFormat = JsonConvert.SerializeObject(Json);
                }
            }
            catch { }
            return RespInFormat;
        }
    }

    public class JSONResponse
    {
        public string STATUS { get; set; }
        public string MSG { get; set; }
    }
}
