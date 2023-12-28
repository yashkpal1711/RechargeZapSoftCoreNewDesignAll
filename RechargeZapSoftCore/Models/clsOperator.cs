using ARA_StringHunt;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RechargeZapSoftCore.Models
{
    public class clsOperator
    {
        Data ObjData = new Data();
        public string OperatorId { get; set; }
        public string VehicleNumber { get; set; }
        public string Optional1 { get; set; }
        public string CircleId { get; set; }
        public string Number { get; set; }


        //============ live
        string giftcardusername = "TWVJWYLFKFAUQYZHNBNIZYAGSIDHYZCW";
        string giftcardpassword = "k51FI}>gX1nby)&m{}pP&3WLmsu6[$5x";
        //===local
        //string giftcardusername = "ZVBPNPCHVMBUAQTZYOWPLTXVWXWYERDS";
        //string giftcardpassword = "]soLj$si!x6IL![KP~rkQ^sXG^hT3yJS";


        public DataTable GetAllOperator()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc with (nolock) left join OperatorCodeType oct   with (nolock)  on oc.Type=oct.typeid order by oc.Type,Operator";

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
        public DataTable GetAllOperatorFastag()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc   with (nolock)   left join OperatorCodeType oct   with (nolock)   on oc.Type=oct.typeid where oc.type=12 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorElectricity()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc   with (nolock)   left join OperatorCodeType oct   with (nolock)   on oc.Type=oct.typeid where oc.type=5 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorWater()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc   with (nolock)   left join OperatorCodeType oct   with (nolock)   on oc.Type=oct.typeid where oc.type=15 order by oc.Type,Operator";

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

        public DataTable GetAllOperatorInsurance()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=16 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorElectricityByCircle(clsOperator objoperator)
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=5 and oc.circlecode='" + objoperator.CircleId + "' order by oc.Type,Operator";

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
        public DataTable GetAllOperatorPrepaid()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc   with (nolock)   left join OperatorCodeType oct   with (nolock)   on oc.Type=oct.typeid where oc.type=1 order by oc.Type,Operator";

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
        public DataTable GetOperatorDetail(string str_operatorid)
        {
            string str_query = "select oct.Type as TypeName,oc.*,oo.Option1Name,oo.Displayalue1,oo.Option2Name,oo.Displayalue2,oo.Option3Name,oo.Displayalue3,oo.Option4Name,oo.Displayalue4,oo.Optional1Type,oo.Optional1Values,oo.Optional2Type,oo.Optional2Values,oo.Optional3Type,oo.Optional3Values,oo.Optional4Type,oo.Optional4Values from OperatorCode oc   with (nolock)  left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid LEFT JOIN operatoroption oo WITH (nolock) ON oo.OperatorCodeId=oc.Id where oc.id='" + str_operatorid + "' ";

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
        public DataTable GetAllOperatorPostpaid()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=6 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorDTH()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=2 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorGas()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=9 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorCylinder()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=13 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorBroadband()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct   with (nolock)  on oc.Type=oct.typeid where oc.type=14 order by oc.Type,Operator";

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
        public DataTable GetAllOperatorLandline()
        {
            string str_query = "select oct.Type as TypeName,oc.* from OperatorCode oc  with (nolock)   left join OperatorCodeType oct  with (nolock)   on oc.Type=oct.typeid where oc.type=3 order by oc.Type,Operator";

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
        public DataTable getROfferOpratorCodeWithAPI(string operatorid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_get_ROfferOPeratorWithAPI";
                SqlParameter[] parameter = { new SqlParameter("@operatorid", operatorid), };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }

        public DataTable getFastagBillFetch(string operatorid, string vehiclenumber)
        {
            DataTable dtresponse = new DataTable();
            dtresponse.Columns.Add(new DataColumn("status", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("message", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("minvalue", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("maxvalue", typeof(string)));

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string referenceid = "";
                string Resp = "";
                string s2 = "sp_get_FastagBillFetch";
                SqlParameter[] parameter = {
                    new SqlParameter("@operatorid", operatorid),
                    new SqlParameter("@vehiclenumber", vehiclenumber),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string url = dt.Rows[0]["url"].ToString();
                    referenceid = dt.Rows[0]["referenceid"].ToString();
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Resp = url.CallURL();


                    DataTable dt2 = GetResponseValues(Resp, "1");
                    if (dt2.Rows.Count > 0)
                    {
                        dtresponse.Rows.Add(dt2.Rows[0]["status"].ToString(), dt2.Rows[0]["msg"].ToString(), dt.Rows[0]["minvalue"].ToString(), dt.Rows[0]["maxvalue"].ToString());
                    }

                    s2 = "sp_update_FastagBillFetchLog";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedure(s2, parameter2);


                }
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dtresponse;
        }

        public DataTable InsertOperatorCheckResponse(string str_request, string str_response)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {

                string s2 = "sp_add_OperatorCheckResponse";
                SqlParameter[] parameter = {
                    new SqlParameter("@request", str_request),
                    new SqlParameter("@response", str_response),
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

        public DataTable getFastagBillElectricity(string operatorid, string vehiclenumber, string Optional1)
        {
            DataTable dtresponse = new DataTable();
            dtresponse.Columns.Add(new DataColumn("status", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("message", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("dueamount", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("customername", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("billdate", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("duedate", typeof(string)));

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string referenceid = "";
                string Resp = "";
                string s2 = "sp_get_FastagBillFetch";
                SqlParameter[] parameter = {
                    new SqlParameter("@operatorid", operatorid),
                    new SqlParameter("@vehiclenumber", vehiclenumber),
                    new SqlParameter("@optional1", Optional1),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string url = dt.Rows[0]["url"].ToString();
                    referenceid = dt.Rows[0]["referenceid"].ToString();
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Resp = url.CallURL();
                    //Resp = @"{""account"":""102244633"",""amount"":0.0,""rpid"":"" "",""agentid"":""2023041009152901578153011"",""opid"":"" "",""dueamount"":0.0,""customername"":"" "",""duedate"":"" "",""billdate"":"" "",""billnumber"":"" "",""bilperiod"":"" "",""fetchBillID"":0,""isRefundStatusShow"":false,""status"":3,""msg"":""Payment Received for the Billing Period - No Bill Due"",""bal"":0.0,""errorcode"":""416""}";

                    DataTable dt2 = GetResponseValues(Resp, "1");
                    if (dt2.Rows.Count > 0)
                    {
                        dtresponse.Rows.Add(dt2.Rows[0]["status"].ToString(), dt2.Rows[0]["msg"].ToString(), dt2.Rows[0]["dueamount"].ToString(), dt2.Rows[0]["customername"].ToString(), dt2.Rows[0]["billdate"].ToString(), dt2.Rows[0]["duedate"].ToString());
                    }

                    s2 = "sp_update_FastagBillFetchLog";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedure(s2, parameter2);


                }
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dtresponse;
        }
        public DataTable getFastagBillCylinder(string operatorid, string vehiclenumber, string Optional1)
        {
            DataTable dtresponse = new DataTable();
            dtresponse.Columns.Add(new DataColumn("status", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("message", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("dueamount", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("customername", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("billdate", typeof(string)));
            dtresponse.Columns.Add(new DataColumn("duedate", typeof(string)));

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string referenceid = "";
                string Resp = "";
                string s2 = "sp_get_FastagBillFetch";
                SqlParameter[] parameter = {
                    new SqlParameter("@operatorid", operatorid),
                    new SqlParameter("@vehiclenumber", vehiclenumber),
                    new SqlParameter("@optional1", Optional1),
                };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    string url = dt.Rows[0]["url"].ToString();
                    referenceid = dt.Rows[0]["referenceid"].ToString();
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    Resp = url.CallURL();
                    //Resp = @"{""account"":""102244633"",""amount"":0.0,""rpid"":"" "",""agentid"":""2023041009152901578153011"",""opid"":"" "",""dueamount"":0.0,""customername"":"" "",""duedate"":"" "",""billdate"":"" "",""billnumber"":"" "",""bilperiod"":"" "",""fetchBillID"":0,""isRefundStatusShow"":false,""status"":3,""msg"":""Payment Received for the Billing Period - No Bill Due"",""bal"":0.0,""errorcode"":""416""}";

                    DataTable dt2 = GetResponseValues(Resp, "1");
                    if (dt2.Rows.Count > 0)
                    {
                        dtresponse.Rows.Add(dt2.Rows[0]["status"].ToString(), dt2.Rows[0]["msg"].ToString(), dt2.Rows[0]["dueamount"].ToString(), dt2.Rows[0]["customername"].ToString(), dt2.Rows[0]["billdate"].ToString(), dt2.Rows[0]["duedate"].ToString());
                    }

                    s2 = "sp_update_FastagBillFetchLog";
                    SqlParameter[] parameter2 = {
               new SqlParameter("@ReferenceId", referenceid) ,
               new SqlParameter("@response", Resp) ,
                };

                    DataTable dtUpdateresponse = ObjData.RunDataTableProcedure(s2, parameter2);


                }
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dtresponse;
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
        public DataTable getOperatorCheckOperator(string operatorname, string circlename)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getOperatorCheckOperatorId";
                SqlParameter[] parameter = {
                    new SqlParameter("@operator", operatorname),
                    new SqlParameter("@circle", circlename),
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

        public DataTable getROfferAPICiecleCode(string apiid, string circleid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_getROfferAPICircelCode";
                SqlParameter[] parameter = {
                    new SqlParameter("@APIId", apiid),
                    new SqlParameter("@CircleId", circleid),
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

        public DataTable getTopGiftCardbrand()
        {
            string str_query = "SELECT top 4 gc.*,isnull(bd.discount,0) AS discount FROM GiftCardBrandDetail gc WITH (nolock) LEFT JOIN BrandDiscountDetail bd WITH (nolock) ON bd.brandproductcode=gc.BrandProductCode  WHERE isnull(gc.brandimage,'')!='' AND gc.denominationList !='0'  AND gc.BrandProductCode IN (SELECT bm.brandproductcode FROM BrandCategoryMappingDetail bm WITH (nolock) WHERE bm.categoryid=25 )";

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
        public DataTable getGiftCardbrandCarousel1()
        {
            string str_query = "SELECT  gc.*,isnull(bd.discount,0) AS discount FROM GiftCardBrandDetail gc WITH (nolock) LEFT JOIN BrandDiscountDetail bd WITH (nolock) ON bd.brandproductcode=gc.BrandProductCode  WHERE isnull(gc.brandimage,'')!='' AND gc.denominationList !='0'  AND gc.BrandProductCode IN (SELECT bm.brandproductcode FROM BrandCategoryMappingDetail bm WITH (nolock) WHERE bm.categoryid=21 )";

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
        public DataTable getGiftCardbrandCarousel2()
        {
            string str_query = "SELECT  gc.*,isnull(bd.discount,0) AS discount FROM GiftCardBrandDetail gc WITH (nolock) LEFT JOIN BrandDiscountDetail bd WITH (nolock) ON bd.brandproductcode=gc.BrandProductCode  WHERE isnull(gc.brandimage,'')!='' AND gc.denominationList !='0'  AND gc.BrandProductCode IN (SELECT bm.brandproductcode FROM BrandCategoryMappingDetail bm WITH (nolock) WHERE bm.categoryid=22 )";

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
        public DataTable getGiftCardbrandCarousel3()
        {
            string str_query = "SELECT  gc.*,isnull(bd.discount,0) AS discount FROM GiftCardBrandDetail gc WITH (nolock) LEFT JOIN BrandDiscountDetail bd WITH (nolock) ON bd.brandproductcode=gc.BrandProductCode  WHERE isnull(gc.brandimage,'')!='' AND gc.denominationList !='0'  AND gc.BrandProductCode IN (SELECT bm.brandproductcode FROM BrandCategoryMappingDetail bm WITH (nolock) WHERE bm.categoryid=23 )";

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
        public DataTable getGiftCardbrandCarousel4()
        {
            string str_query = "SELECT  gc.*,isnull(bd.discount,0) AS discount FROM GiftCardBrandDetail gc WITH (nolock) LEFT JOIN BrandDiscountDetail bd WITH (nolock) ON bd.brandproductcode=gc.BrandProductCode  WHERE isnull(gc.brandimage,'')!='' AND gc.denominationList !='0'  AND gc.BrandProductCode IN (SELECT bm.brandproductcode FROM BrandCategoryMappingDetail bm WITH (nolock) WHERE bm.categoryid=24 )";

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
        public DataTable getTopGiftCardbrandByCategoryId(string str_Categoryid)
        {
            string str_query = "SELECT  * FROM GiftCardBrandDetail WITH (nolock) WHERE isnull(brandimage,'')!='' AND denominationList !='0' AND BrandProductCode IN (SELECT BrandProductCode FROM BrandCategoryMappingDetail WITH (nolock) WHERE Categoryid='"+ str_Categoryid + "') ";

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
        public DataTable getGiftcardDiscount(string brandproductcode)
        {
            string str_query = "SELECT * FROM BrandDiscountDetail WITH (nolock) WHERE BrandProductCode='"+ brandproductcode + "'";

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


        public DataSet getgiftCardDetail(string brandcode, string token)
        {

            DataSet ds = null;
            DataSet dsdetail = null;

            try
            {
                //================== test======================
                //var client = new RestClient("https://send.bulkgv.net/API/v1/getbrands");
                //================== Live======================
                var client = new RestClient("https://send.bulkgv.com/API/v1/getbrands");

                
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("token", token);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                @"    ""BrandProductCode"":""" + brandcode + @"""
" + "\n" +
                @"}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                IRestResponse response = client.Execute(request);
                //Console.WriteLine(response.Content);

                ds = ConvertJSONToDataSet(response.Content.ToString());

                if (ds.Tables[0].Rows[0]["status"].ToString() == "success")
                {
                    string str_data = ds.Tables[0].Rows[0]["data"].ToString();

                    string str_decryptdata = DecryptString("6d66fb7debfd15bf716bb14752b9603b", str_data);
                    dsdetail = ConvertJSONToDataSet(@"{
  ""root"": {
    ""data"":"+str_decryptdata+"}}");
                }
            }
            catch (Exception ex)
            {
                ds = null;
            }

            return dsdetail;
        }

        public DataTable getgiftCardDetailFromDataBase(string brandcode)
        {

            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_get_GiftCardBrandDetail";
                SqlParameter[] parameter = { new SqlParameter("@BrandProductCode", brandcode), };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }


        public DataTable getGiftCardToken()
        {
            string str_query = "SELECT giftcardtoken,giftcardtokentime,datediff(minute,giftcardtokentime, dbo.getIndianDate()) AS difference from systemsetting with (nolock)";

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



        public DataTable getTopGiftCardCategory()
        {
            string str_query = "SELECT  * FROM GiftCardCategoryMaster WITH (nolock) WHERE CategoryId NOT IN (21,22,23,24,25) and isnull(status,'1')='1' Order By CategoryName";

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

        public DataTable getCircle()
        {
            string str_query = "select * from CircleCodeDetail with (nolock) order by circlename";

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
        public DataTable getElectricityCircle()
        {
            string str_query = "select * from ElectricityCircleCodeDetail with (nolock) order by circlename";

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
        public DataTable GetAllOperatorEntryBy(string EntryBy)
        {
            string str_query = "select * from OperatorCode order by Operator desc where EntryBy=" + EntryBy + "";

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
        public DataTable GetOperatorCodeType()
        {
            string str_query = "select * from OperatorCodeType order by Type desc";

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
        public DataTable GetSelectedOperator(string Id)
        {
            string str_query = "select * from OperatorCode where ID=" + Id + "";

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
        public DataTable GetRechargeApi()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_Select_Recharge_api";
                SqlParameter[] parameter = { };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable Get_Operator()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_get_Operator";
                SqlParameter[] parameter = { };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable selectOpertorWithOption()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "SelectOpertorOption";
                SqlParameter[] parameter = { };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable GetROfferApi()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_Select_ROffer_api";
                SqlParameter[] parameter = { };
                dt = ObjData.RunDataTableProcedure(s2, parameter);
            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
        public DataTable Get_CIrcle_API_Code_ByCIrcleidForGetCircle(string circleid, Int32 Apid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_Get_Circle_API_Code_byCIrcleidFOrGetCircle";
                SqlParameter[] parameter = {
                    new SqlParameter("@circleid",circleid),
                    new SqlParameter("@Apid",Apid),
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
        public string Insert_CircleApiCodeFOrGetCircle(DataTable dtsave)
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
                s2 = "sp_Insert_CircleApiCodeFOrGetCircleCode";
                SqlParameter[] parameter = {
                    new SqlParameter("@dtsave", dtsave)
                };
                ObjData.RunInsUpDelQueryTransProc(s2, tr, parameter);
                res = "1";
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = ex.Message.ToString();
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }

        public DataTable Get_Operator_API_Code_ByOpid(Int32 OperatorId, Int32 Apid)
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {
                string s2 = "sp_Get_Operator_API_Code_byOpid";
                SqlParameter[] parameter = {
                    new SqlParameter("@OperatorId",OperatorId),
                    new SqlParameter("@Apid",Apid),
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

        public DataTable GetenerateGiftCardToken()
        {
            DataTable dt = null;
            ObjData.StartConnection();
            try
            {

                //================== test======================
                //var client = new RestClient("https://send.bulkgv.net/API/v1/gettoken");
                //================== Live======================
                var client = new RestClient("https://send.bulkgv.com/API/v1/gettoken");
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                request.AddHeader("username", giftcardusername);
                request.AddHeader("password", giftcardpassword);
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                IRestResponse response = client.Execute(request);




               //string str_response = response.Content.ToString();

                string str_reponse =  @"{""status"":""success"",""data"":""BN0VPrpW3zzixY5qdKoXrgueV+n4HN+OhhQF+9s3CLhEKk3AvdncnSsIUeNGYU3mgK+35rpmijsMT0LE+s+i/YY8ym4kMCPC0Ac3TFCOhffoo9POIPIUucSlmDBbUZyCf8ydbNNbedTvuioL0lIdVzJVqInTTBv/aTshQ/Uh8M4Wo8hBYjWDSrc/0HG/QaY5hh3/J2IdfbC7BZuEavqXW87mGIb0kHpR0l9+CrJwEz7z3vEVZ5MAMPbT2VaM4jrej3dcIRafPJWuAq0qu34VA2gc40WsdufzT23epAX2kGZm4aB2kq1qjq12b1etHTS/Ed/YrI8Taa5B1l9rcRMW2eC/JLawd1UvqQ1fs2O5ez8="",""desc"":""Process successfully completed"",""code"":""0000""}";


                DataSet ds = ConvertJSONToDataSet(str_reponse);

                if (ds.Tables[0].Rows[0]["status"].ToString() == "success")
                {

                    string str_data = ds.Tables[0].Rows[0]["data"].ToString();

                    //================ test==========================
                    //string str_key = "6d66fb7debfd15bf716bb14752b9603b";
                    //================ live ============================
                    string str_key = "vn3wrtSbd6sB9inNCCl79GG3S5V60JH0";

                    string strtoken = "";
                    strtoken = DecryptString(str_key, str_data);
                    strtoken = strtoken.Substring(0, strtoken.Length - 5);
                    string s2 = "sp_updategetGiftCardToken";
                    SqlParameter[] parameter = {
                    new SqlParameter("@GiftCardToken",strtoken.Replace(@"""","")),
                    new SqlParameter("@GiftCardTokenResponse",response.Content.ToString()),
                };
                    dt = ObjData.RunDataTableProcedure(s2, parameter);
                }



            }
            catch (Exception ex)
            {
                dt = null;
            }
            ObjData.EndConnection();
            return dt;
        }
       public DataSet ConvertJSONToDataSet(string Resp)
        {
            DataSet jsonDataSet = new DataSet();
            try
            {
                //Resp = Resp.Replace("{", "[{");
                //Resp = Resp.Replace("}", "}]");
                //DataSet myDataSet = JsonConvert.DeserializeObject<DataSet>(Resp);
                //return myDataSet;
                XmlDocument xd1 = new XmlDocument();
                xd1 = (XmlDocument)JsonConvert.DeserializeXmlNode(Resp, "root");

                jsonDataSet.ReadXml(new XmlNodeReader(xd1));
            }
            catch (Exception ep)
            {
                throw ep;
            }
            return jsonDataSet;
        }


        public  string EncryptString(string key, string plainText)
        {

            //==================== test ==============================
            //string str_iv = "716bb14752b9603b";
            //==================== live======================
            string str_iv = "xi5Mx1CmqtA9eXqp";

            byte[] iv = Encoding.ASCII.GetBytes(str_iv);
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public  string DecryptString(string key, string cipherText)
        {
            //==================== test ==============================
            //string str_iv = "716bb14752b9603b";
            //==================== live======================
            string str_iv = "xi5Mx1CmqtA9eXqp";

            byte[] iv = Encoding.ASCII.GetBytes(str_iv);
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                aes.Padding = PaddingMode.None;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }


        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new AesManaged.
            using (AesManaged aes = new AesManaged())
            {
                // Create encryptor
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                // Create MemoryStream
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream
                    // to encrypt
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data
            return encrypted;
        }
        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create AesManaged
            using (AesManaged aes = new AesManaged())
            {
                // Create a decryptor
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        public string GetFromDatatable(DataTable datatable, string column)
        {
            return datatable.Rows[0][column].ToString();
        }
        public String InsertOrEditOperator(String Id, String Operator, String OPID, String Type, String Length, String Minimum, String Maximum, String DisplayName, String DisplayNote, string AccountDisplay, string LocationDisplay, string By, string StartsWith, string DisabledReasion)
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
                string str_paramname = "";
                s2 = "";
                if (Id == "-1")
                {
                    s2 = "AddOperator";
                    str_paramname = "@EntryBy";
                }
                else
                {
                    s2 = "EditOperator";
                    str_paramname = "@ModifyBy";
                }


                SqlParameter[] parameter = {
                new SqlParameter("@Id", Id),
                new SqlParameter("@Operator", Operator),
                new SqlParameter("@OPID", OPID),
                new SqlParameter("@Type", Type),
                new SqlParameter("@Length", Length),
                new SqlParameter("@Minimum", Minimum),
                new SqlParameter("@Maximum", Maximum),
                new SqlParameter("@DisplayName", DisplayName),
                new SqlParameter("@DisplayNote", DisplayNote),
                new SqlParameter("@AccountDisplay", AccountDisplay),
                new SqlParameter("@LocationDisplay", LocationDisplay),
                new SqlParameter(str_paramname, By),
                new SqlParameter("@StartsWith", StartsWith),
                new SqlParameter("@DisabledReasion", DisabledReasion),
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
        public string Insert_OperatorApiCode(DataTable dtsave)
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
                s2 = "sp_Insert_OperatorApiCode";
                SqlParameter[] parameter = {
                    new SqlParameter("@dtsave", dtsave)
                };
                ObjData.RunInsUpDelQueryTransProc(s2, tr, parameter);
                res = "1";
                tr.Commit();
            }
            catch (Exception ex)
            {
                res = ex.Message.ToString();
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return res;
        }
        public DataTable OpertorOption(string OperatorCodeId, string replace1, string replace2, string replace3, string replace4, string Note1, string Note2, string Note3, string Note4)
        {
            string res = "";
            string s2 = "";
            SqlConnection cn;
            SqlTransaction tr = null;
            DataTable dtresult = new DataTable();
            cn = ObjData.StartConnectionInTransaction();
            tr = cn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                s2 = "insertOperator";
                SqlParameter[] parameter = {
                new SqlParameter("@OperatorCodeId", OperatorCodeId),
                new SqlParameter("@replace1", replace1),
                new SqlParameter("@replace2", replace2),
                new SqlParameter("@replace3", replace3),
                new SqlParameter("@replace4", replace4),
                new SqlParameter("@Note1", Note1),
                new SqlParameter("@Note2", Note2),
                new SqlParameter("@Note3", Note3),
                new SqlParameter("@Note4", Note4),
                };

                dtresult = ObjData.RunDataTableProcedureTRans(s2, tr, parameter);

                tr.Commit();
            }
            catch (Exception ex)
            {
                dtresult = null;
                res = ex.Message.ToString();
                tr.Rollback();
            }
            finally
            {
                ObjData.EndConnection();
                tr.Dispose();
            }
            return dtresult;
        }
    }
}
