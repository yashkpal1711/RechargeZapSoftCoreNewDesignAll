using ARA_StringHunt;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace RechargeZapSoftCore.Models
{
    public class clsUser
    {
        Data ObjData = new Data();
        public string UserId { get; set; }
        public string SponserId { get; set; }
        public string NewSponserId { get; set; }
        public string UserName { get; set; }
        public string OutletName { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TransactionId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string JuniorUserId { get; set; }
        public string TransactionPassword { get; set; }
        public string PaytmMobileNo { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string Password { get; set; }
        public string BusinessModel { get; set; }
        public string SlabId { get; set; }
        public string RoleId { get; set; }
        public string MentionBy { get; set; }
        public string CountryId { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public string CityName { get; set; }
        public string DepartmentId { get; set; }
        public string Designationid { get; set; }
        public string StateName { get; set; }
        public string Type { get; set; }
        public string EpinNo { get; set; }
        public int PoolNo { get; set; }
        public string StandingPosition { get; set; }
        public string AreaName { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string TransferUserId { get; set; }
        public int NoOfEpin { get; set; }
        public string ParentUserId { get; set; }
        public string NomineeName { get; set; }
        public string NomineeRelation { get; set; }
        public string AccHolderName { get; set; }
        public string AccNo { get; set; }
        public string BankName { get; set; }
        public string BranchName { get; set; }
        public string IFSCCode { get; set; }
        public string PanCardNo { get; set; }
        public string Regtype { get; set; }
        public string Remark { get; set; }
        public decimal Amount { get; set; }
        public decimal AdminCharge { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal CommissionPercent { get; set; }
        public decimal TotalAmount { get; set; }
        public string Id { get; set; }
        public string BankAccountId { get; set; }
        public string PaymentMode { get; set; }
        public string OnlineTransactionId { get; set; }
        public string ChequeNo { get; set; }
        public string Status { get; set; }
        public string PackageId { get; set; }
        public DataTable dtData { get; set; }
        public string WalletType { get; set; }
        public string Message { get; set; }
        public string ImageName { get; set; }
        public decimal TransferAmount { get; set; }
        public DataTable getUserReport(clsUser objUser)
        {
            string str_query = "SELECT isnull( ud.cappingamount,0) as cappingamount, sm.SlabName, isnull(ud.cappingamount,0) as Cappingamount, ud.id, ud.name,ud.mobile,ud.email,ld.Status,ld.RoleId,rm.ROleName,ud.OutletName,ud2.Mobile AS sponsermobile,isnull(ud.balanceamount,0) as balanceamount FROM userdetail ud WITH (nolock) LEFT JOIN logindetail ld WITH (nolock) ON ud.Mobile=ld.UserName LEFT JOIN rolemaster rm WITH (nolock) ON ld.RoleId=rm.RoleId LEFT JOIN userdetail ud2 WITH (nolock) ON ud.SponserId=ud2.id LEFT JOIN slabmaster sm WITH (nolock) ON sm.SlabId=ud.SlabId where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, ud.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,ud.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }
            if (objUser.UserName != "")
            {
                str_query += "  and ud.name like '%" + objUser.UserName + "%' ";
            }

            if (objUser.Mobile != "")
            {
                str_query += "  and ud.mobile = '" + objUser.Mobile + "' ";
            }

            str_query += " order by ud.MentionDate  desc";

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
        public DataSet get_DashboardAdmin()
        {
            string s2 = "";
            DataSet ds = new DataSet();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_GetDashboardAdmin";
                SqlParameter[] parameter = {

                };
                ds = ObjData.RunDataSetProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return ds;
        }
        public DataSet get_DashboardUser(clsUser objuser)
        {
            string s2 = "";
            DataSet ds = new DataSet();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_GetDashboardUser";
                SqlParameter[] parameter = {
                          new SqlParameter("@email",objuser.Email),
                };
                ds = ObjData.RunDataSetProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return ds;
        }
        public DataTable get_RechargeHistory(clsUser objuser)
        {
            string s2 = "";
            DataTable dt = new DataTable();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_GetRechargeHistory";
                SqlParameter[] parameter = {
                          new SqlParameter("@email",objuser.Email),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return dt;
        }
        public DataTable get_TransactionHistory(clsUser objuser)
        {
            string s2 = "";
            DataTable dt = new DataTable();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_GetTransactionHistory";
                SqlParameter[] parameter = {
                          new SqlParameter("@email",objuser.Email),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return dt;
        }
        public DataSet get_AdminLedger(clsUser objuser)
        {
            string s2 = "";
            DataSet ds = new DataSet();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_getAdminLEdger";
                SqlParameter[] parameter = {
                          new SqlParameter("@ledgerdate",objuser.FromDate),
                };
                ds = ObjData.RunDataSetProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return ds;
        }
        public DataSet get_UserLedgerNew(clsUser objuser)
        {
            string s2 = "";
            DataSet ds = new DataSet();
            ObjData.StartConnection();
            try
            {
                s2 = "sp_getUserLEdger";
                SqlParameter[] parameter = {
                          new SqlParameter("@ledgerdate",objuser.FromDate),
                          new SqlParameter("@usermobile",objuser.UserId),
                };
                ds = ObjData.RunDataSetProcedure(s2, parameter);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                ObjData.EndConnection();

            }
            return ds;
        }
        public DataTable getUserReportOfSponser(clsUser objUser)
        {
            string str_query = "SELECT ud.id, ud.name,ud.mobile,ud.email,ld.Status,ld.RoleId,rm.ROleName,ud.OutletName,ud2.Mobile AS sponsermobile FROM userdetail ud WITH (nolock) LEFT JOIN logindetail ld WITH (nolock) ON ud.Mobile=ld.UserName LEFT JOIN rolemaster rm WITH (nolock) ON ld.RoleId=rm.RoleId LEFT JOIN userdetail ud2 WITH (nolock) ON ud.SponserId=ud2.id where 1=1";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, ud.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,ud.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }
            if (objUser.UserName != "")
            {
                str_query += "  and ud.name like '%" + objUser.UserName + "%' ";
            }

            if (objUser.Mobile != "")
            {
                str_query += "  and ud.mobile = '" + objUser.Mobile + "' ";
            }
            if (objUser.SponserId != "")
            {
                str_query += "  and ud.id in (  SELECT id FROM usersunrech.fn_getChild(" + objUser.SponserId + "))  ";
            }

            str_query += " order by ud.MentionDate  desc  OPTION (MAXRECURSION 0) ";

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
        public DataTable getDaybookApiWise(clsUser objUser)
        {
            //            string str_query = @"SELECT apiname,isnull(sum(rechargeamount),0) AS rechargeamount
            //,isnull(sum(CASE WHEN rechargerequest.Status='Success' THEN rechargerequest.RechargeAmount ELSE 0 END),0) AS successrecharge  
            //,isnull(sum(CASE WHEN rechargerequest.Status='Failed' THEN rechargerequest.RechargeAmount ELSE 0 END),0) AS failedrecharge  
            //,isnull(sum(CASE WHEN rechargerequest.Status='Pending' THEN rechargerequest.RechargeAmount ELSE 0 END),0) AS pendingrecharge  
            //,convert(DATE,entrydate) AS entrydate FROM RechargeRequest WITH (nolock)  where 1=1 ";
            //            if (objUser.FromDate != DateTime.MinValue)
            //            {
            //                str_query += "  and convert(date, entrydate)  = convert(date,'" + objUser.FromDate + "')    ";
            //            }

            //            str_query += " GROUP BY APIName,convert(DATE,entrydate)";
            string str_query = @"SELECT rq.apiname,sum(rq.RechargeAmount) totalamount,count(rq.id) totalhit,sum(CASE WHEN rq.Status='Success' THEN 1 ELSE 0 end)successhit, 
sum(CASE WHEN rq.Status='Success' THEN rq.RechargeAmount ELSE 0 end) AS successamount,sum(CASE WHEN rq.Status='Failed' THEN 1 ELSE 0 end)failedhit, 
sum(CASE WHEN rq.Status='Failed' THEN rq.RechargeAmount ELSE 0 end) AS failedamount,sum(CASE WHEN rq.Status='Pending' THEN 1 ELSE 0 end)pendinghit, 
sum(CASE WHEN rq.Status='Pending' THEN rq.RechargeAmount ELSE 0 end) AS pendingamount,
(SELECT isnull(sum(td.cramount),0)-isnull(sum(td.dramount),0) FROM transactiondetail td WITH (nolock) WHERE td.TransactionType='Recharge Commission' AND convert(DATE,td.MentionDate)=convert(DATE,'" + objUser.FromDate + @"')) AS comissionamount
FROM rechargerequest rq WITH (nolock) WHERE  convert (DATE,rq.EntryDate)=convert(DATE,'" + objUser.FromDate + @"')
";


            str_query += " GROUP BY  rq.apiname";

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
        public DataTable getAddMoneyReport(clsUser objUser)
        {
            string str_query = "SELECT ud.Name,ud.Mobile, am.*,isnull(am.CommissionAmount,0) AS CommissionAmount2,isnull(am.FinalAMount,0) AS FinalAMount2  FROM addmoneydetail am WITH (nolock) LEFT JOIN userdetail ud WITH (nolock) ON am.UserId=ud.id where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, am.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,am.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }

            if (objUser.UserId != "")
            {
                str_query += "  and am.UserId = '" + objUser.UserId + "' ";
            }
            if (objUser.Status != "0")
            {
                str_query += "  and am.Status = '" + objUser.Status + "' ";
            }
            if (objUser.TransactionId != "")
            {
                str_query += "  and am.orderid = '" + objUser.TransactionId + "' ";
            }

            str_query += " order by am.MentionDate  desc";

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
        public DataTable getAddMoneyReportofSponser(clsUser objUser)
        {
            string str_query = "SELECT ud.Name,ud.Mobile, am.*,isnull(am.CommissionAmount,0) AS CommissionAmount2,isnull(am.FinalAMount,0) AS FinalAMount2  FROM addmoneydetail am WITH (nolock) LEFT JOIN userdetail ud WITH (nolock) ON am.UserId=ud.id where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, am.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,am.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }

            if (objUser.UserId != "")
            {
                str_query += "  and am.UserId = '" + objUser.UserId + "' ";
            }
            if (objUser.Status != "0")
            {
                str_query += "  and am.Status = '" + objUser.Status + "' ";
            }
            if (objUser.TransactionId != "")
            {
                str_query += "  and am.orderid = '" + objUser.TransactionId + "' ";
            }
            if (objUser.SponserId != "")
            {
                str_query += "  and ud.id in (  SELECT id FROM userdshidf.fn_getChild(" + objUser.SponserId + "))  ";
            }
            str_query += " order by am.MentionDate  desc";

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
        public DataTable getDaybookOperatorWise(clsUser objUser)
        {
            //            string str_query = @"SELECT oc.Operator ,isnull(sum(rq.rechargeamount),0) AS rechargeamount
            //, isnull(sum(CASE WHEN rq.Status = 'Success' THEN rq.RechargeAmount ELSE 0 END), 0) AS successrecharge
            //    , isnull(sum(CASE WHEN rq.Status = 'Failed' THEN rq.RechargeAmount ELSE 0 END), 0) AS failedrecharge
            //        , isnull(sum(CASE WHEN rq.Status = 'Pending' THEN rq.RechargeAmount ELSE 0 END), 0) AS pendingrecharge, convert(DATE,rq.entrydate) AS entrydate FROM RechargeRequest rq WITH (nolock) LEFT JOIN operatorcode oc WITH(nolock) ON rq.OperatorId=oc.Id  WHERE 1=1  ";
            //            if (objUser.FromDate != DateTime.MinValue)
            //            {
            //                str_query += "  and convert(date, rq.entrydate)  = convert(date,'" + objUser.FromDate + "')    ";
            //            }

            //            str_query += " GROUP BY oc.operator,convert(DATE,rq.entrydate)";
            string str_query = @"SELECT rq.OperatorId,oc.Operator,sum(rq.RechargeAmount) totalamount,count(rq.id) totalhit,sum(CASE WHEN rq.Status='Success' THEN 1 ELSE 0 end)successhit, 
sum(CASE WHEN rq.Status='Success' THEN rq.RechargeAmount ELSE 0 end) AS successamount,sum(CASE WHEN rq.Status='Failed' THEN 1 ELSE 0 end)failedhit, 
sum(CASE WHEN rq.Status='Failed' THEN rq.RechargeAmount ELSE 0 end) AS failedamount,sum(CASE WHEN rq.Status='Pending' THEN 1 ELSE 0 end)pendinghit, 
sum(CASE WHEN rq.Status='Pending' THEN rq.RechargeAmount ELSE 0 end) AS pendingamount,
(SELECT isnull(sum(td.cramount),0)-isnull(sum(td.dramount),0) FROM transactiondetail td WITH (nolock) WHERE td.TransactionType='Recharge Commission' AND  convert(DATE,td.MentionDate)=convert(DATE,'" + objUser.FromDate + @"')) AS comissionamount
FROM rechargerequest rq WITH (nolock) LEFT JOIN operatorcode oc WITH (nolock) ON oc.Id=rq.OperatorId WHERE convert (DATE,rq.EntryDate)=convert(DATE,'" + objUser.FromDate + @"')
";


            str_query += " GROUP BY  rq.OperatorId,oc.Operator";

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

        public DataTable getDaybookOperatorWiseUser(clsUser objUser)
        {
            string str_query = @"SELECT rq.OperatorId,oc.Operator,sum(rq.RechargeAmount) totalamount,count(rq.id) totalhit,sum(CASE WHEN rq.Status='Success' THEN 1 ELSE 0 end)successhit, 
sum(CASE WHEN rq.Status='Success' THEN rq.RechargeAmount ELSE 0 end) AS successamount,sum(CASE WHEN rq.Status='Failed' THEN 1 ELSE 0 end)failedhit, 
sum(CASE WHEN rq.Status='Failed' THEN rq.RechargeAmount ELSE 0 end) AS failedamount,sum(CASE WHEN rq.Status='Pending' THEN 1 ELSE 0 end)pendinghit, 
sum(CASE WHEN rq.Status='Pending' THEN rq.RechargeAmount ELSE 0 end) AS pendingamount,
(SELECT isnull(sum(td.cramount),0)-isnull(sum(td.dramount),0) FROM transactiondetail td WITH (nolock) WHERE td.TransactionType='Recharge Commission' AND td.UserID=rq.UserMobile AND convert(DATE,td.MentionDate)=convert(DATE,'" + objUser.FromDate + @"')) AS comissionamount
FROM rechargerequest rq WITH (nolock) LEFT JOIN operatorcode oc WITH (nolock) ON oc.Id=rq.OperatorId LEFT JOIN userdetail ud WITH (nolock) ON ud.id=rq.UserMobile WHERE ud.mobile='" + objUser.UserId + @"' AND convert (DATE,rq.EntryDate)=convert(DATE,'" + objUser.FromDate + @"')
";


            str_query += " GROUP BY  rq.OperatorId,oc.Operator,rq.UserMobile";

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
        public DataTable getDaybookAPIWiseUser(clsUser objUser)
        {
            string str_query = @"SELECT rq.apiname,sum(rq.RechargeAmount) totalamount,count(rq.id) totalhit,sum(CASE WHEN rq.Status='Success' THEN 1 ELSE 0 end)successhit, 
sum(CASE WHEN rq.Status='Success' THEN rq.RechargeAmount ELSE 0 end) AS successamount,sum(CASE WHEN rq.Status='Failed' THEN 1 ELSE 0 end)failedhit, 
sum(CASE WHEN rq.Status='Failed' THEN rq.RechargeAmount ELSE 0 end) AS failedamount,sum(CASE WHEN rq.Status='Pending' THEN 1 ELSE 0 end)pendinghit, 
sum(CASE WHEN rq.Status='Pending' THEN rq.RechargeAmount ELSE 0 end) AS pendingamount,
(SELECT isnull(sum(td.cramount),0)-isnull(sum(td.dramount),0) FROM transactiondetail td WITH (nolock) WHERE td.TransactionType='Recharge Commission' AND td.UserID=rq.UserMobile AND convert(DATE,td.MentionDate)=convert(DATE,'" + objUser.FromDate + @"')) AS comissionamount
FROM rechargerequest rq WITH (nolock) LEFT JOIN userdetail ud WITH (nolock) ON ud.id=rq.UserMobile WHERE ud.mobile='" + objUser.UserId + @"' AND convert (DATE,rq.EntryDate)=convert(DATE,'" + objUser.FromDate + @"')
";


            str_query += " GROUP BY  rq.apiname,rq.UserMobile";

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

        public DataTable getUserLEdger(clsUser objUser)
        {
            string str_query = @"SELECT td.id,td.TransactionId,td.CrAmount,td.DrAmount,td.Remark,td.MentionDate,td.UserID,ud.Name,ud.Mobile,isnull((SELECT (sum(td2.cramount))-sum(td2.dramount) FROM transactiondetail td2 WITH (nolock) WHERE td2.id<td.id),0) AS opening,isnull((SELECT (sum(td2.cramount))-sum(td2.dramount) FROM transactiondetail td2 WITH (nolock) WHERE td2.id<=td.id),0) AS closing FROM transactiondetail td WITH (nolock) LEFT JOIN userdetail ud WITH (nolock) ON td.UserID=ud.id where ud.mobile='" + objUser.UserId + "' and convert(date,td.mentiondate)>= convert(date, '" + objUser.FromDate + "') and   convert(date,td.mentiondate)<= convert(date, '" + objUser.ToDate + "')  ORDER BY td.id ";


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
        public DataTable getCommissionReport(clsUser objUser)
        {
            string str_query = "SELECT fd.*,ud.Name,ud.mobile FROM transactiondetail fd LEFT JOIN userdetail ud ON fd.UserId=ud.id where 1=1 and fd.TransactionType='Recharge Commission' ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, fd.MentionDate)  >= convert(date,'" + objUser.FromDate + "' )  and convert(date,fd.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }

            if (objUser.UserId != "")
            {
                str_query += "  and ud.mobile = '" + objUser.UserId + "' ";
            }
            str_query += " order by fd.MentionDate  desc";

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
        public DataTable getSendSMSReport(clsUser objUser)
        {
            string str_query = "SELECT * from SendSms with (nolock) where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and  convert(date, createdate)  >= convert(date, '" + objUser.FromDate + "')   and convert(date, createdate)  <= convert(date, '" + objUser.ToDate + "') ";
            }

            if (objUser.Mobile != "")
            {
                str_query += "  and mobile = '" + objUser.UserId + "' ";
            }
            str_query += " order by createdate  desc";

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

        public DataTable getRole()
        {
            string str_query = "select * from rolemaster with (nolock) order  by roleno ";
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
        public DataTable getUserName(clsUser objUser)
        {
            string str_query = "SELECT ud.SponserId,ud2.UserName AS sponsername, ud.userid, ud.username,ud.mobile,isnull(ud.imagename,'default.png') as imagename FROM userdetail ud with (nolock) LEFT JOIN userdetail ud2 WITH(nolock) ON ud.SponserId=ud2.UserId   where ud.UserId = '" + objUser.UserId + "' ";
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
        public DataSet getSponserNameWithRole(clsUser objUser)
        {
            string str_query = @"SELECT id,name,mobile,email,slabid FROM UserDetail WITH (nolock) WHERE mobile=(SELECT mobile FROM UserDetail  WITH (nolock)  WHERE Mobile='" + objUser.Mobile + @"');
SELECT * FROM rolemaster with (nolock) WHERE   roleno>(SELECT roleno FROM rolemaster with (nolock) WHERE roleid=(SELECT roleid FROM logindetail with (nolock) WHERE username='" + objUser.Mobile + "'))";
            DataSet dt = null;
            ObjData.StartConnection();
            try
            {
                dt = ObjData.RunSelectQuery(str_query);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable getFundRequestReport(clsUser objUser)
        {
            string str_query = "SELECT fd.*,ud.Name,cs.AccountNo+'('+cs.bankname+')' as accno2 FROM FundRequestDetail fd LEFT JOIN userdetail ud ON fd.UserId=ud.id left join CompanyAccountDetail cs on fd.bankaccountid=cs.id where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and fd.MentionDate  >= '" + objUser.FromDate + "'   and fd.MentionDate   <= '" + objUser.ToDate + "' ";
            }

            if (objUser.UserId != "")
            {
                str_query += "  and fd.UserId = '" + objUser.UserId + "' ";
            }

            str_query += " order by fd.MentionDate  desc";

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
        public DataTable getTransactionReport(clsUser objUser)
        {
            string str_query = "SELECT fd.*,ud.Name,ud.mobile FROM transactiondetail fd LEFT JOIN userdetail ud ON fd.UserId=ud.id where 1=1 ";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, fd.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,fd.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }

            if (objUser.UserId != "")
            {
                str_query += "  and fd.UserId = '" + objUser.UserId + "' ";
            }
            if (objUser.TransactionId != "")
            {
                str_query += "  and fd.transactionid = '" + objUser.TransactionId + "' ";
            }

            str_query += " order by fd.MentionDate  desc";

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
        public DataTable getLoginReport(clsUser objUser)
        {
            string str_query = "SELECT ud.userid, ud.username,ud.Mobile,ud.Email,ud.Gender,ud.Address,ud.CityName,ud.MentionDate,ld.password,ld.status, case when ld.status='1' then 'Active' else 'Deactive' end as loginstatus FROM userdetail ud with (nolock)  left join Logindetail ld  with (nolock)  on ud.userid=ld.username where 1=1 ";


            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, ud.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,ud.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }
            if (objUser.UserName != "")
            {
                str_query += "  and ud.username = '" + objUser.UserName + "' ";
            }
            if (objUser.UserId != "")
            {
                str_query += "  and ud.UserId = '" + objUser.UserId + "' ";
            }
            if (objUser.Mobile != "")
            {
                str_query += "  and ud.mobile = '" + objUser.Mobile + "' ";
            }
            str_query += " order by ud.MentionDate  desc";
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

        public DataTable getUserDetail(clsUser objUser)
        {
            string str_query = "SELECT ud.* FROM userdetail ud with (nolock)  where ud.id = '" + objUser.UserId + "' ";
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
        public DataTable getUserDetailByEmail(clsUser objUser)
        {
            string str_query = "SELECT ud.* FROM userdetail ud with (nolock)  where ud.email = '" + objUser.Email + "' ";
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
        public DataTable getFundTRansferRecieveReportAdmin(clsUser objUser)
        {
            string str_query = @"select td.transactionid,td.cramount ,td.dramount,td.userid,td.touserid,td.transactiontype,td.remark,td.mentiondate,ud.name,ud2.name as toname,ud.mobile,ud2.mobile as tomobile,
(SELECT isnull(sum(td3.cramount),0)-isnull(sum(td3.dramount),0) FROM  TransactionDetail td3 WITH (nolock) WHERE td3.id<=td.id AND td3.userid=td.userid) AS balanceamount 
from transactiondetail td with (nolock) left join userdetail ud with (nolock)  on td.userid=ud.id left join userdetail ud2 with (nolock) on td.touserid=ud2.id where 1=1 and td.transactiontype in ('Fund Credit','Fund Debit')";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, td.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,td.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }
            if (objUser.UserId != "")
            {
                str_query += "  and ud.mobile='" + objUser.UserId + "' ";
            }

            str_query += " order by td.MentionDate  desc   ";

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
        public DataTable getFundTRansferRecieveReport(clsUser objUser)
        {
            string str_query = @"select td.transactionid,td.cramount ,td.dramount,td.userid,td.touserid,td.transactiontype,td.remark,td.mentiondate,ud.name,ud2.name as toname,
(SELECT isnull(sum(td3.cramount),0)-isnull(sum(td3.dramount),0) FROM  TransactionDetail td3 WITH (nolock) WHERE td3.id<=td.id AND td3.userid=td.userid) AS balanceamount 
from transactiondetail td with (nolock) left join userdetail ud with (nolock)  on td.userid=ud.id left join userdetail ud2 with (nolock) on td.touserid=ud2.id where 1=1 and td.transactiontype in ('Fund Credit','Fund Debit')";
            if (objUser.FromDate != DateTime.MinValue && objUser.ToDate != DateTime.MinValue)
            {
                str_query += "  and convert(date, td.MentionDate)  >= convert(date,'" + objUser.FromDate + "')   and convert(date,td.MentionDate)   <= convert(date,'" + objUser.ToDate + "') ";
            }
            if (objUser.UserId != "")
            {
                str_query += "  and td.userid=" + objUser.UserId + " ";
            }

            str_query += " order by td.MentionDate  desc   ";

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
        public string Insert_User(clsUser objUser)
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

                s2 = "sp_add_UserDetail";
                SqlParameter[] parameter = {
                    new SqlParameter("@Name",objUser.UserName),
                    new SqlParameter("@OutletName",objUser.OutletName),
                    new SqlParameter("@SponserMobile",objUser.SponserId),
                    new SqlParameter("@Gender",objUser.Gender),
                    new SqlParameter("@Email",objUser.Email),
                    new SqlParameter("@Mobile",objUser.Mobile),
                    new SqlParameter("@Address",objUser.Address),
                    new SqlParameter("@Cityid",objUser.CityName),
                    new SqlParameter("@stateid",objUser.StateId),
                    new SqlParameter("@Pincode",objUser.Pincode),
                    new SqlParameter("@slabid",objUser.SlabId),
                    new SqlParameter("@BusinessModel",objUser.BusinessModel),
                    new SqlParameter("@Roleid",objUser.RoleId),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                };
                res = ObjData.RunInsUpDelQueryTransProcScalar(s2, tr, parameter);
                //try
                //{
                //string url = "http://www.apihub.online/api/Services/transact?token=ce4f9f4c676718405d7033ddb36dee00&skey=SST&to=" + objUser.Mobile + "&sender=ETOPUP&smstext=" + "Dear Sir/Madam you are successfully registered on  FutureLifeSecure.in. Your login details are-username:" + res + ", password:" + objUser.Password + "&smsformat=TEXT&format=json";
                //string Result = url.CallURL();
                //Insert_SendSMS(objUser.Mobile, Result, url);
                //}
                //catch { }
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


        public string SendPassword(clsUser objUser)
        {

            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "SELECT ud.userid,ud.mobile,ld.Password FROM UserDetail ud WITH  (nolock)  LEFT JOIN logindetail ld WITH (nolock) ON ud.UserId=ld.Username where ud.userid='" + objUser.UserId + "' ";
                dt = ObjData.RunSelectQueryTTrans(s2, tr);
                if (dt.Rows.Count > 0)
                {
                    objUser.Mobile = dt.Rows[0]["mobile"].ToString();
                    string password = dt.Rows[0]["password"].ToString();
                    string url = "http://www.apihub.online/api/Services/transact?token=ce4f9f4c676718405d7033ddb36dee00&skey=SST&to=" + objUser.Mobile + "&sender=ETOPUP&smstext=" + "Dear User your password is " + password + "&smsformat=TEXT&format=json";

                    string Result = url.CallURL();
                    Insert_SendSMS(objUser.Mobile, Result, url);

                    res = objUser.Mobile;
                }
                else
                {
                    res = "f";
                }
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
        public string senddms()
        {
            string url = "http://www.apihub.online/api/Services/transact?token=ce4f9f4c676718405d7033ddb36dee00&skey=SST&to=8888888888&sender=ETOPUP&smstext=ttt&smsformat=TEXT&format=json";
            //ObjData.SendMsg("8888888888", "hello");
            string Result = url.CallURL();
            return Result;
        }
        public DataTable getUserTeamReport(clsUser objUser)
        {
            string str_query = "SELECT ud.id, ud.name,ud.mobile,ud.email,ld.Status,ld.RoleId,rm.ROleName,ud.OutletName,ud2.Mobile AS sponsermobile,ud.balanceamount FROM userdetail ud WITH (nolock) LEFT JOIN logindetail ld WITH (nolock) ON ud.Mobile=ld.UserName LEFT JOIN rolemaster rm WITH (nolock) ON ld.RoleId=rm.RoleId LEFT JOIN userdetail ud2 WITH (nolock) ON ud.SponserId=ud2.id where 1=1";

            if (objUser.SponserId != "")
            {
                str_query += "  and ud.id in (  SELECT id FROM usersunrech.fn_getChild(" + objUser.SponserId + "))  ";
            }

            str_query += " order by ud.MentionDate  desc  OPTION (MAXRECURSION 0) ";

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
        public string ResetPassword(clsUser objUser)
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
                s2 = "sp_ResetPassword";
                SqlParameter[] parameter = {
                    new SqlParameter("@Mobile",objUser.Mobile),
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
        public string User_Activate(clsUser objUser)
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
                s2 = "sp_ActivateUser";
                SqlParameter[] parameter = {
                    new SqlParameter("@UserMobile",objUser.Mobile),
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
        public string InsertFundRequest(clsUser objUser)
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
                s2 = "sp_add_FundRequestDetail";
                SqlParameter[] parameter = {
                    new SqlParameter("@BankAccountId",objUser.BankAccountId),
                    new SqlParameter("@UserId",objUser.UserId),
                    new SqlParameter("@Amount",objUser.Amount),
                    new SqlParameter("@Remark",objUser.Remark),
                    new SqlParameter("@PaymentMode",objUser.PaymentMode),
                    new SqlParameter("@OnlineTransactionId",objUser.OnlineTransactionId),
                    new SqlParameter("@MobileNoInBank",objUser.Mobile),
                    new SqlParameter("@ChequeNo",objUser.ChequeNo),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
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
        public string User_Deactivate(clsUser objUser)
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
                s2 = "sp_DeactivateUser";
                SqlParameter[] parameter = {
                    new SqlParameter("@UserMobile",objUser.Mobile),
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
        public string UpdateFundRequest(clsUser objUser)
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
                s2 = "sp_update_FundRequest";
                SqlParameter[] parameter = {
                    new SqlParameter("@id",objUser.Id),
                    new SqlParameter("@Status",objUser.Status),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
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
        public DataTable Update_Userdetail(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_edit_UserDetail";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@name",objUser.UserName),
                    new SqlParameter("@outletname",objUser.OutletName),
                    new SqlParameter("@email",objUser.Email),
                    new SqlParameter("@gender",objUser.Gender),
                    new SqlParameter("@Address",objUser.Address),
                    new SqlParameter("@CityiD",objUser.CityId),
                    new SqlParameter("@StateId",objUser.StateId),
                    new SqlParameter("@Pincode",objUser.Pincode),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ChangeRole(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_changeRole";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@NewROleId",objUser.RoleId),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ShowPassword(clsUser objUser)
        {

            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_showPassword";
                SqlParameter[] parameter = {
                    new SqlParameter("@userid",objUser.UserId),
                    new SqlParameter("@TranPassword",objUser.TransactionPassword),
                    new SqlParameter("@JuniorUserId",objUser.JuniorUserId),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
                tr.Commit();

            }
            catch (Exception ex)
            {
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return dt;
        }
        public DataTable FundTransfer(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_FundTrasnfer";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@Type",objUser.Type),
                    new SqlParameter("@Amount",objUser.Amount),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                    new SqlParameter("@CommPercent",objUser.CommissionPercent),
                    new SqlParameter("@ActualAmount",objUser.ActualAmount),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ChangeMobile(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_ChangeMobile";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@newmobile",objUser.Mobile),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ChangeIntroducer(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_ChangeIntroducer";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@NewSponserId",objUser.SponserId),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ChangeSlab(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_changeSlab";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@NewSlabId",objUser.SlabId),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public DataTable ChangeCappingAmount(clsUser objUser)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dt = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "sp_Change_CappingAmount";
                SqlParameter[] parameter = {
                    new SqlParameter("@Userid",objUser.UserId),
                    new SqlParameter("@Cappingamount",objUser.Amount),
                };
                dt = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);
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
            return dt;
        }
        public string Update_UserProfile(clsUser objUser)
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
                s2 = "update UserDetail  set username='" + objUser.UserName + "', email='" + objUser.Email + "',dateofbirth='" + objUser.DateOfBirth.ToString("yyyy/MM/dd") + "',gender='" + objUser.Gender + "' ,mobile='" + objUser.Mobile + "', address='" + objUser.Address + "', CityName='" + objUser.CityName + "',areaName='" + objUser.AreaName + "' ,pincode='" + objUser.Pincode + "',imagename='" + objUser.ImageName + "',stateid='" + objUser.StateId + "'  where UserId='" + objUser.UserId + "'   ";
                ObjData.RunInsUpDelQueryTrans(s2, tr);
                res = "t";
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
        public string Update_UserProfile2(clsUser objUser)
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
                s2 = "update UserDetail  set username='" + objUser.UserName + "', email='" + objUser.Email + "',dateofbirth='" + objUser.DateOfBirth.ToString("yyyy/MM/dd") + "',gender='" + objUser.Gender + "' ,mobile='" + objUser.Mobile + "', address='" + objUser.Address + "',stateid='" + objUser.StateId + "', CityName='" + objUser.CityName + "',areaName='" + objUser.AreaName + "' ,pincode='" + objUser.Pincode + "',AccountHolderName='" + objUser.AccHolderName + "',AccountNo='" + objUser.AccNo + "',IFSCCode='" + objUser.IFSCCode + "',BankName='" + objUser.BankName + "',BranchName='" + objUser.BranchName + "',PanNumber='" + objUser.PanCardNo + "',NomineeName='" + objUser.NomineeName + "',NomineeRelation='" + objUser.NomineeRelation + "',imagename='" + objUser.ImageName + "',paytmmobileno ='" + objUser.PaytmMobileNo + "'  where UserId='" + objUser.UserId + "'   ";
                ObjData.RunInsUpDelQueryTrans(s2, tr);
                res = "t";
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


        public string Insert_SendSMS(string str_Mobile, string str_Result, string str_Message)
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
                s2 = "insert into SendSms(CreateDate,Mobile,Result,Message)  values (getdate(),'" + str_Mobile + "','" + str_Result + "','" + str_Message + "') ";
                ObjData.RunInsUpDelQueryTrans(s2, tr);
                res = "t";
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
        public string InsertCallbackRequest(clsUser objUser)
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
                s2 = "sp_add_CallbackRequestDetail";
                SqlParameter[] parameter = {
                    new SqlParameter("@UserId",objUser.UserId),
                    new SqlParameter("@MobileNo",objUser.Mobile),
                    new SqlParameter("@MentionBy",objUser.MentionBy),
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
        public string Update_UserProfileByEmail(clsUser objUser)
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
                s2 = "sp_edit_userdetailByEmail";
                SqlParameter[] parameter = {
                    new SqlParameter("@Email",objUser.Email),
                    new SqlParameter("@Username",objUser.UserName),
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

    }
}
