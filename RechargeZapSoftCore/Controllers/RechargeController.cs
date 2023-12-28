using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Xml;
using ARA_StringHunt;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RechargeZapSoftCore.Models;
using RestSharp;
//using System.Data.DataSetExtensions;

namespace RechargeZapSoftCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RechargeController : ControllerBase
    {
        // GET: api/Recharge
        [HttpGet]
        [Route("getOperator")]
        public DataTable Get()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperator();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorPrepaid")]
        public DataTable GetOperatorPrepaid()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorPrepaid();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorPostpaid")]
        public DataTable GetOperatorPostpaid()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorPostpaid();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorFastag")]
        public DataTable GetOperatorFastag()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorFastag();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorElectricity")]
        public DataTable getOperatorElectricity()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorElectricity();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorWater")]
        public DataTable getOperatorWater()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorWater();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorInsurance")]
        public DataTable getOperatorInsurance()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorInsurance();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorDTH")]
        public DataTable GetOperatorDTH()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorDTH();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorGas")]
        public DataTable GetOperatorGas()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorGas();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorCylinder")]
        public DataTable GetOperatorCylinder()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorCylinder();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorBroadband")]
        public DataTable GetOperatorBroadband()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorBroadband();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getOperatorLandline")]
        public DataTable GetOperatorLandline()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorLandline();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getCircle")]
        public DataTable getCircle()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getCircle();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardBrand")]
        public DataTable getGiftCardBrand()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getTopGiftCardbrand();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardCarousel1")]
        public DataTable getGiftCardCarousel1()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getGiftCardbrandCarousel1();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardCarousel2")]
        public DataTable getGiftCardCarousel2()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getGiftCardbrandCarousel2();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardCarousel3")]
        public DataTable getGiftCardCarousel3()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getGiftCardbrandCarousel3();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardCarousel4")]
        public DataTable getGiftCardCarousel4()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getGiftCardbrandCarousel4();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getGiftCardCategory")]
        public DataTable getGiftCardCategory()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getTopGiftCardCategory();
            //return new string[] { "value1", "value2" };
            return dt;
        }
        [HttpGet]
        [Route("getElectricityCircle")]
        public DataTable getElectricityCircle()
        {
            clsOperator objoperator = new clsOperator();
            DataTable dt = new DataTable();
            dt = objoperator.getElectricityCircle();
            //return new string[] { "value1", "value2" };
            return dt;
        }

        [HttpPost]
        [Route("getPlan")]
        public List<string> getPlan(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_tabheader = "";
            string str_tabcontent = "";
            string strurl = "";
            string resp = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getROfferOpratorCodeWithAPI(objoperator.OperatorId);
            if (dt.Rows.Count > 0)
            {
                strurl = dt.Rows[0]["mobileplanurl"].ToString();
                // url = url.Replace("{mobile}", TxtCardNo.Text);
                strurl = strurl.Replace("{operator}", dt.Rows[0]["operatorcode"].ToString());

                string str_APICircleCode = "0";

                DataTable dtcircle = new DataTable();
                dtcircle = objoperator2.getROfferAPICiecleCode(dt.Rows[0]["id"].ToString(), objoperator.CircleId);

                if (dtcircle.Rows.Count > 0)
                {
                    str_APICircleCode = dtcircle.Rows[0]["circlecode"].ToString();
                }

                strurl = strurl.Replace("{circle}", str_APICircleCode);

                if (strurl != "")
                {
                    try
                    {
                        resp = strurl.CallURL();
                        resp = resp.Replace("RATE CUTTER", "RATE_CUTTER");
                        resp = resp.Replace(@"3G\/ 4G", "_3GOr4G");
                        resp = resp.Replace(@"3G\/4G", "_3GOr4G");
                        resp = resp.Replace(@"""1", @"""_1");
                        resp = resp.Replace(@"""2", @"""_2");
                        resp = resp.Replace(@"""3", @"""_3");
                        resp = resp.Replace(@"""4", @"""_4");
                        resp = resp.Replace(@"""5", @"""_5");
                        resp = resp.Replace(@"""6", @"""_6");
                        resp = resp.Replace(@"""7", @"""_7");
                        resp = resp.Replace(@"""8", @"""_8");
                        resp = resp.Replace(@"""9", @"""_9");
                        // Response.Write(resp);
                        //string resp = @"{""records"":{""FULLTT"":[{""rs"":""75"",""desc"":""For Jio Phone Customers Only - Data: 0.01GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""99"",""desc"":""Applicable Only on Jiophone WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""109"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.99 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""125"",""desc"":""For Jio Phone Customers Only - Data: 0.5GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""129"",""desc"":""Pack validity(days)28 ,Total data(GB)2 Data at high speed(Post which unlimited @ 64 Kbps) 2GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 500 minutes SMS300"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""153"",""desc"":""Applicable Only on Jiophone activated SIMs: (WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""155"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 1 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""163"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.153 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""185"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 2 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""199"",""desc"":""Pack validity(days)28 Total data(GB)42 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""249"",""desc"":""Pack validity(days)28 Total data(GB)56 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""307"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.297 + Rs.10 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""317"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.297 + Rs.20 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""329"",""desc"":""Pack validity(days)84 Total data(GB)6 Data at high speed(Post which unlimited @ 64 Kbps) 6GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3000 minutes SMS1000"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""349"",""desc"":""MRP`349 Pack validity(days)28 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 3 GB\/ Day VoiceJio to Jio Unlimited, Jio to Non-Jio FUP of 1000 minutes SMS100"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""399"",""desc"":""Pack validity(days)56 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""444"",""desc"":""Pack validity(days)56 Total data(GB)112 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""555"",""desc"":""Pack validity(days)84 Total data(GB)126 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""599"",""desc"":""Pack validity(days)84 Total data(GB)168 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""604"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.10 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""614"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.20 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""1299"",""desc"":""Pack validity(days)365 Total data(GB)24 Data at high speed(Post which unlimited @ 64 Kbps) 24GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMS3600"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2121"",""desc"":""MRP`2121 Pack validity(days)336 Total data(GB)504 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMSUnlimited(100 \/ day) Jio AppsComplimentary subscription"",""validity"":""336 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2199"",""desc"":""Pack validity(days)365 Total data(GB)547.5 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""}],""TOPUP"":[{""rs"":""10"",""desc"":""Talktime7.47 IUC Minutes124 Complementary data(GB)1"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""20"",""desc"":""Talktime14.95 IUC Minutes249 Complementary data(GB)2"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""50"",""desc"":""Talktime39.37 IUC Minutes656 Complementary data(GB)5"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""100"",""desc"":""Talktime81.75 IUC Minutes1,362 Complementary data(GB)10"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""500"",""desc"":""Talktime420.73 IUC Minutes7,012 Complementary data(GB)50"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""1000"",""desc"":""Talktime844.46 IUC Minutes14,074 Complementary data(GB)100"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""}],""3G\/ 4G"":[{""rs"":""11"",""desc"":""Unlimited 400 MB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""21"",""desc"":""Unlimited 1 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""51"",""desc"":""Unlimited 3 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""101"",""desc"":""Unlimited 6 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""}],""Romaing"":[{""rs"":""501"",""desc"":"" Rs 551 ISD Talktime"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""575"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 100 minutes | Roaming International SMS: 100 SMS | International Roaming Data: 250 MB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf "",""validity"":""1 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""1101"",""desc"":""International Roaming: Rs.1211.0 | ISD SMS: 5 SMS | (The Monetary value can be used for voice calls, SMS and Data usage while on International Roaming only) For IR rates visit http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - Tariff.pdf(For All Customers)"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""2875"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India(100 Min\/ Day): 700 minutes | Roaming International SMS: 100 SMS \/ Day | International Roaming Data: 250 MB \/ Day | high speed - thereafter at 64 Kbps | The Unlimited pack benefits... "",""validity"":""7 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""5751"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 1500 minutes | Roaming International SMS: 1500 SMS | International Roaming Data: 5 GB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf"",""validity"":""30 days"",""last_update"":""17 - 10 - 2019""}]},""status"":1,""time"":null}";
                        DataSet ds = ReadDataFromJson(resp);


                        //    DataSet ds=ReadDataFromJson(@"{""records"":{""TOPUP"":[{""rs"":""10"",""desc"":""Get Talktime of Rs. 7.47"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""20"",""desc"":""Get Talktime of Rs. 14.95"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""30"",""desc"":""Get Talktime of Rs. 22.42"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""50"",""desc"":""Get Talktime of Rs.39.37"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""500"",""desc"":""Get Talktime of Rs. 423.73"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""1000"",""desc"":""Get Talktime of Rs. 847.46"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""5000"",""desc"":""Get Talktime of Rs. 4237.29"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""}],""RATE CUTTER"":[{""rs"":""18"",""desc"":""60 minutes US & cananda calling free Validity 1 Hour.Dial * 444 * 18# to activate and start calling now. _x001C_*T&Cs apply. Refer https:\/\/shop.vodafone.in\/shop\/prepaid\/Prepaid_SuperHour_t&c.pdf for applicable ISD codes"",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""19"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+200MB Data. Validity 2 Days"",""validity"":""2 days"",""last_update"":""22-02-2020""},{""rs"":""24"",""desc"":""Plan Voucher - Call rate of 2.5p\/sec, 100 on-net night minutes for 14 days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""39"",""desc"":""30 Limited validity talktime, Local\/National Calls @ 2.5p\/sec and 100 MB Data Pack Validity for 14 Days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""49"",""desc"":""Get Rs38 Talktime+Local\/National Calls@2.5p\/sec+100MB for 28 Days Talktime Rs 38 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""79"",""desc"":""Get Rs64 Talktime+Local\/National Calls@1p\/sec+200MB for 28 Days Talktime Rs 64 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""}],""SMS"":[{""rs"":""12"",""desc"":""Get 120 local\/national SMS for 10 days"",""validity"":""10 days"",""last_update"":""22-02-2020""},{""rs"":""26"",""desc"":""Get 250 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""36"",""desc"":""Get 350 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""99"",""desc"":""Unlimited Local+STD+Roamings Calls to all Network + 1GB + 100 SMS.Validity 18 Days"",""validity"":""18 days"",""last_update"":""22-02-2020""},{""rs"":""129"",""desc"":""Truly Unlimited Local+STD+Roamings Calls to all Network + 2GB + 300 Local and National SMS.Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""199"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""219"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""269"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks + 4GB Data + 600 Local and National SMS. Pack Validity for 56 Days."",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""398"",""desc"":""3GB Daily(84GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""499"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 70 Days"",""validity"":""70 days"",""last_update"":""22-02-2020""},{""rs"":""555"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 77 Days"",""validity"":""77 days"",""last_update"":""22-02-2020""},{""rs"":""558"",""desc"":""3GB Daily(168GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""}],""Romaing"":[{""rs"":""295"",""desc"":""40 mins of international roaming calls which include Outgoing local calls, calls back to India and Incoming Calls only. Applicable in USA, UAE, Singapore, Thailand, UK, Sri Lanka, China, Saudi Arabia, Qatar, Oman, Bahrain, Kuwait, Nepal, Bangladesh, Indonesia, Malaysia, Australia, NZ, Canada & many more! Validity: 28 days. T&C Apply"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 1GB (Rs.1\/MB after 1GB) FREE SMS & FREE incoming calls. Plus 120mins FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, Enjoy 300MB data (Re.1\/MB after 300MB) & 10 Free SMS (Re.1\/SMS after 10SMS). Also enjoy FREE incoming calls with 50mins FREE outgoing calls(local & to India), after 50 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries ."",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""995"",""desc"":""Get FREE 150 min outgoing & incoming calls & 500 MB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Bangladesh, Sri Lanka, China, Kenya, Germany, Belgium, Turkey, Netherlands & more! Also, get FREE 100 min & 100 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 7 days. T&C Apply"",""validity"":""7 days"",""last_update"":""22-02-2020""},{""rs"":""1495"",""desc"":""Get FREE 300 min outgoing & incoming calls & 1GB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Europe (Germany, Belgium, France, Netherlands, Italy, Spain, Greece), Australia, NZ, Bangladesh, China, Turkey & more! Also, get FREE 150 min & 250 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 14 days. T&C Apply"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""2695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 4GB (Rs.1\/MB after 4GB) FREE SMS & FREE incoming calls. Plus 120mins\/day FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, enjoy 1.2GB data (Re.1\/MB after 1.2GB) & 40 Free SMS (Re.1\/SMS after 40SMS). Also enjoy FREE incoming calls with 200mins FREE outgoing calls(local & to India), after 200 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries."",""validity"":""4 days"",""last_update"":""22-02-2020""}],""COMBO"":[{""rs"":""149"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB Data+300SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""299"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""379"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+6GB Data+1000SMS. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+1.5GB\/Day+100SMS\/Day. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""449"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB\/Day+100SMS\/Day. Validity:56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""599"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""699"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""1499"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +24GB Data+3600SMS. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""},{""rs"":""2399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""}]},""status"":1,""time"":null}");
                        //if (ds.Tables[0].Columns.Contains("records"))
                        //{
                        //DataView view = new DataView(ds.Tables[0]);
                        //DataTable dtrechargetype = view.ToTable(true, "records");
                        for (int i = 2; i < ds.Tables.Count; i++)
                        {



                            if (i == 2)
                            {
                                //str_tabheader += @"<li class=""nav-item""><a class=""nav-link active show"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("RATE_CUTTER", "RATE CUTTER").Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + "</a></li>";

                                str_tabheader += @"<li ><a href=""#tab" + ds.Tables[i].TableName + @""" class=""active"" data-toggle=""tab"">" + ds.Tables[i].TableName.Replace("RATE_CUTTER", "RATE CUTTER").Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + "</a></li>";
                                //DataView dvdata = new DataView(ds.Tables[i]);
                                //dvdata.RowFilter = "RechargeType= '" + dtrechargetype.Rows[i]["rechargetype"].ToString() + "'"; // query example = "id = 10"
                                //str_tabcontent += @"    <div class=""tab-pane active"" id=""tab" + ds.Tables[i].TableName + @""">
                                //        <table class=""table table-bordered table-striped table-hovered"">
                                //        <tr>
                                //        <th>
                                //        Amount
                                //        </th>
                                //        <th>
                                //        Validity
                                //        </th>
                                //        <th>
                                //        Description
                                //        </th>
                                //        <th>
                                //        Select Plan
                                //        </th>
                                //        </tr>";
                                str_tabcontent += @"    <div class=""tab-pane active"" id=""tab" + ds.Tables[i].TableName + @""">";

                                foreach (DataRow r in ds.Tables[i].Rows)
                                {
                                    //str_tabcontent += @" <tr>
                                    //    <td>
                                    // " + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //   " + r["validity"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //     " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //        <a style=""color:white;"" onclick=""selectplanmobile('" + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn btn-primary btn-round"">Select</a>
                                    //    </td>
                                    //    </tr>";
                                    str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                     " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  <br/>
 Validity : " + r["validity"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                        </div>
                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                  <i class=""fa fa-inr""></i>   " + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                                }

                                //str_tabcontent += @"</table>
                                //        </div>";
                                str_tabcontent += @"
                                        </div>";
                            }
                            else
                            {
                                //str_tabheader += @" <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"""_2", @"""2").Replace(@"""_3", @"""3").Replace(@"""_4", @"""4").Replace(@"""_5", @"""5").Replace(@"""_6", @"""6").Replace(@"""_7", @"""7").Replace(@"""_8", @"""8").Replace(@"""_9", @"""9") + "</a></li>";
                                str_tabheader += @"<li ><a href=""#tab" + ds.Tables[i].TableName + @"""  data-toggle=""tab"">" + ds.Tables[i].TableName.Replace("RATE_CUTTER", "RATE CUTTER").Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + "</a></li>";

                                str_tabcontent += @"  <div class=""tab-pane"" id=""tab" + ds.Tables[i].TableName + @""">";
                                foreach (DataRow r in ds.Tables[i].Rows)
                                {
                                    //str_tabcontent += @" <tr>
                                    //    <td>
                                    // " + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //   " + r["validity"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //     " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  
                                    //    </td>
                                    //    <td>
                                    //        <a style=""color:white;"" onclick=""selectplanmobile('" + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn btn-primary btn-round"">Select</a>
                                    //    </td>
                                    //    </tr>";
                                    str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                     " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  <br/>
 Validity : " + r["validity"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                        </div>
                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                  <i class=""fa fa-inr""></i>   " + r["rs"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                                }

                                str_tabcontent += @"</table>
                                        </div>";

                            }
                        }
                    }
                    catch (Exception ep)
                    {

                    }
                }

            }
            else
            {
                //lblrechargeplanresponse.Text = "No API Found";
            }

            //DataTable dt = new DataTable();
            //dt = objoperator.getCircle();
            //return new string[] { "value1", "value2" };
            //return dt;

            //ViewBag.tab = outputHtml;

            List<string> li = new List<string>();
            li.Add(str_tabheader);
            li.Add(str_tabcontent);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }

        [HttpPost]
        [Route("getPlan2")]
        public List<string> getPlan2(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_tabheader = "";
            string str_tabcontent = "";
            string strurl = "";
            string resp = "";


            try
            {
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.OperatorCode = objoperator.OperatorId;
                objrecharge.CircleCode = objoperator.CircleId;
                //string resp = @"{""records"":{""FULLTT"":[{""rs"":""75"",""desc"":""For Jio Phone Customers Only - Data: 0.01GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""99"",""desc"":""Applicable Only on Jiophone WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""109"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.99 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""125"",""desc"":""For Jio Phone Customers Only - Data: 0.5GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""129"",""desc"":""Pack validity(days)28 ,Total data(GB)2 Data at high speed(Post which unlimited @ 64 Kbps) 2GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 500 minutes SMS300"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""153"",""desc"":""Applicable Only on Jiophone activated SIMs: (WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""155"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 1 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""163"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.153 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""185"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 2 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""199"",""desc"":""Pack validity(days)28 Total data(GB)42 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""249"",""desc"":""Pack validity(days)28 Total data(GB)56 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""307"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.297 + Rs.10 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""317"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.297 + Rs.20 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""329"",""desc"":""Pack validity(days)84 Total data(GB)6 Data at high speed(Post which unlimited @ 64 Kbps) 6GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3000 minutes SMS1000"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""349"",""desc"":""MRP`349 Pack validity(days)28 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 3 GB\/ Day VoiceJio to Jio Unlimited, Jio to Non-Jio FUP of 1000 minutes SMS100"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""399"",""desc"":""Pack validity(days)56 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""444"",""desc"":""Pack validity(days)56 Total data(GB)112 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""555"",""desc"":""Pack validity(days)84 Total data(GB)126 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""599"",""desc"":""Pack validity(days)84 Total data(GB)168 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""604"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.10 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""614"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.20 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""1299"",""desc"":""Pack validity(days)365 Total data(GB)24 Data at high speed(Post which unlimited @ 64 Kbps) 24GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMS3600"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2121"",""desc"":""MRP`2121 Pack validity(days)336 Total data(GB)504 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMSUnlimited(100 \/ day) Jio AppsComplimentary subscription"",""validity"":""336 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2199"",""desc"":""Pack validity(days)365 Total data(GB)547.5 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""}],""TOPUP"":[{""rs"":""10"",""desc"":""Talktime7.47 IUC Minutes124 Complementary data(GB)1"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""20"",""desc"":""Talktime14.95 IUC Minutes249 Complementary data(GB)2"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""50"",""desc"":""Talktime39.37 IUC Minutes656 Complementary data(GB)5"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""100"",""desc"":""Talktime81.75 IUC Minutes1,362 Complementary data(GB)10"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""500"",""desc"":""Talktime420.73 IUC Minutes7,012 Complementary data(GB)50"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""1000"",""desc"":""Talktime844.46 IUC Minutes14,074 Complementary data(GB)100"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""}],""3G\/ 4G"":[{""rs"":""11"",""desc"":""Unlimited 400 MB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""21"",""desc"":""Unlimited 1 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""51"",""desc"":""Unlimited 3 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""101"",""desc"":""Unlimited 6 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""}],""Romaing"":[{""rs"":""501"",""desc"":"" Rs 551 ISD Talktime"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""575"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 100 minutes | Roaming International SMS: 100 SMS | International Roaming Data: 250 MB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf "",""validity"":""1 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""1101"",""desc"":""International Roaming: Rs.1211.0 | ISD SMS: 5 SMS | (The Monetary value can be used for voice calls, SMS and Data usage while on International Roaming only) For IR rates visit http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - Tariff.pdf(For All Customers)"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""2875"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India(100 Min\/ Day): 700 minutes | Roaming International SMS: 100 SMS \/ Day | International Roaming Data: 250 MB \/ Day | high speed - thereafter at 64 Kbps | The Unlimited pack benefits... "",""validity"":""7 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""5751"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 1500 minutes | Roaming International SMS: 1500 SMS | International Roaming Data: 5 GB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf"",""validity"":""30 days"",""last_update"":""17 - 10 - 2019""}]},""status"":1,""time"":null}";
                DataSet ds = objrecharge.getRechargePlan(objrecharge);


                //    DataSet ds=ReadDataFromJson(@"{""records"":{""TOPUP"":[{""rs"":""10"",""desc"":""Get Talktime of Rs. 7.47"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""20"",""desc"":""Get Talktime of Rs. 14.95"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""30"",""desc"":""Get Talktime of Rs. 22.42"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""50"",""desc"":""Get Talktime of Rs.39.37"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""500"",""desc"":""Get Talktime of Rs. 423.73"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""1000"",""desc"":""Get Talktime of Rs. 847.46"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""5000"",""desc"":""Get Talktime of Rs. 4237.29"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""}],""RATE CUTTER"":[{""rs"":""18"",""desc"":""60 minutes US & cananda calling free Validity 1 Hour.Dial * 444 * 18# to activate and start calling now. _x001C_*T&Cs apply. Refer https:\/\/shop.vodafone.in\/shop\/prepaid\/Prepaid_SuperHour_t&c.pdf for applicable ISD codes"",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""19"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+200MB Data. Validity 2 Days"",""validity"":""2 days"",""last_update"":""22-02-2020""},{""rs"":""24"",""desc"":""Plan Voucher - Call rate of 2.5p\/sec, 100 on-net night minutes for 14 days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""39"",""desc"":""30 Limited validity talktime, Local\/National Calls @ 2.5p\/sec and 100 MB Data Pack Validity for 14 Days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""49"",""desc"":""Get Rs38 Talktime+Local\/National Calls@2.5p\/sec+100MB for 28 Days Talktime Rs 38 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""79"",""desc"":""Get Rs64 Talktime+Local\/National Calls@1p\/sec+200MB for 28 Days Talktime Rs 64 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""}],""SMS"":[{""rs"":""12"",""desc"":""Get 120 local\/national SMS for 10 days"",""validity"":""10 days"",""last_update"":""22-02-2020""},{""rs"":""26"",""desc"":""Get 250 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""36"",""desc"":""Get 350 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""99"",""desc"":""Unlimited Local+STD+Roamings Calls to all Network + 1GB + 100 SMS.Validity 18 Days"",""validity"":""18 days"",""last_update"":""22-02-2020""},{""rs"":""129"",""desc"":""Truly Unlimited Local+STD+Roamings Calls to all Network + 2GB + 300 Local and National SMS.Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""199"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""219"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""269"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks + 4GB Data + 600 Local and National SMS. Pack Validity for 56 Days."",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""398"",""desc"":""3GB Daily(84GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""499"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 70 Days"",""validity"":""70 days"",""last_update"":""22-02-2020""},{""rs"":""555"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 77 Days"",""validity"":""77 days"",""last_update"":""22-02-2020""},{""rs"":""558"",""desc"":""3GB Daily(168GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""}],""Romaing"":[{""rs"":""295"",""desc"":""40 mins of international roaming calls which include Outgoing local calls, calls back to India and Incoming Calls only. Applicable in USA, UAE, Singapore, Thailand, UK, Sri Lanka, China, Saudi Arabia, Qatar, Oman, Bahrain, Kuwait, Nepal, Bangladesh, Indonesia, Malaysia, Australia, NZ, Canada & many more! Validity: 28 days. T&C Apply"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 1GB (Rs.1\/MB after 1GB) FREE SMS & FREE incoming calls. Plus 120mins FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, Enjoy 300MB data (Re.1\/MB after 300MB) & 10 Free SMS (Re.1\/SMS after 10SMS). Also enjoy FREE incoming calls with 50mins FREE outgoing calls(local & to India), after 50 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries ."",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""995"",""desc"":""Get FREE 150 min outgoing & incoming calls & 500 MB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Bangladesh, Sri Lanka, China, Kenya, Germany, Belgium, Turkey, Netherlands & more! Also, get FREE 100 min & 100 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 7 days. T&C Apply"",""validity"":""7 days"",""last_update"":""22-02-2020""},{""rs"":""1495"",""desc"":""Get FREE 300 min outgoing & incoming calls & 1GB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Europe (Germany, Belgium, France, Netherlands, Italy, Spain, Greece), Australia, NZ, Bangladesh, China, Turkey & more! Also, get FREE 150 min & 250 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 14 days. T&C Apply"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""2695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 4GB (Rs.1\/MB after 4GB) FREE SMS & FREE incoming calls. Plus 120mins\/day FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, enjoy 1.2GB data (Re.1\/MB after 1.2GB) & 40 Free SMS (Re.1\/SMS after 40SMS). Also enjoy FREE incoming calls with 200mins FREE outgoing calls(local & to India), after 200 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries."",""validity"":""4 days"",""last_update"":""22-02-2020""}],""COMBO"":[{""rs"":""149"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB Data+300SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""299"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""379"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+6GB Data+1000SMS. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+1.5GB\/Day+100SMS\/Day. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""449"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB\/Day+100SMS\/Day. Validity:56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""599"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""699"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""1499"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +24GB Data+3600SMS. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""},{""rs"":""2399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""}]},""status"":1,""time"":null}");
                //if (ds.Tables[0].Columns.Contains("records"))
                //{
                //DataView view = new DataView(ds.Tables[0]);
                //DataTable dtrechargetype = view.ToTable(true, "records");


                int i = 0;

                foreach (DataRow drcategory in ds.Tables[0].Rows)
                {
                  

                    if (i == 0)
                    {
                        str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" class=""active"" data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";

                        str_tabcontent += @"    <div class=""tab-pane active"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";


                        //DataTable dt = new DataTable();
                        //objrecharge.OperatorCode = objoperator.OperatorId;
                        //objrecharge.CircleCode = objoperator.CircleId;
                        //objrecharge.CategoryId = drcategory["categoryid"].ToString();
                        //dt = objrecharge.getRechargePlanByCategory(objrecharge);
                        //DataView dv = dt.DefaultView;

                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"

                        if (dv.ToTable().Rows.Count > 0)
                        {

                          

                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime =r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<i class=""fa fa-wifi"" aria-hidden=""true""></i> " + str_data + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @"<i class=""fa fa-envelope"" aria-hidden=""true""></i> " + str_sms + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<i class=""fa fa-phone"" aria-hidden=""true""></i> " + str_talktime + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }

                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                     " + r["description"].ToString() + @"  <br/>
 <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
<b>"+str_talktime+ @"" + str_data + @"" + str_sms + @"</b>
                                        </div>
                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                            }
                        }
                        //str_tabcontent += @"</table>
                        //        </div>";
                        str_tabcontent += @"
                                        </div>";
                    }
                    else
                    {
                       

                        //str_tabheader += @" <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"""_2", @"""2").Replace(@"""_3", @"""3").Replace(@"""_4", @"""4").Replace(@"""_5", @"""5").Replace(@"""_6", @"""6").Replace(@"""_7", @"""7").Replace(@"""_8", @"""8").Replace(@"""_9", @"""9") + "</a></li>";
                        str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @"""  data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";

                        str_tabcontent += @"  <div class=""tab-pane"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";
                        //DataTable dt = new DataTable();
                        //objrecharge.OperatorCode = objoperator.OperatorId;
                        //objrecharge.CircleCode = objoperator.CircleId;
                        //objrecharge.CategoryId = drcategory["categoryid"].ToString();
                        //dt = objrecharge.getRechargePlanByCategory(objrecharge);
                        //DataView dv = dt.DefaultView;

                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"
                        if (dv.ToTable().Rows.Count > 0)
                        {
                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime = r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<i class=""fa fa-wifi"" aria-hidden=""true""></i> " + str_data + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @"<i class=""fa fa-envelope"" aria-hidden=""true""></i> " + str_sms + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<i class=""fa fa-phone"" aria-hidden=""true""></i> " + str_talktime + "&nbsp;&nbsp;&nbsp;&nbsp; ";
                                }
                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                     " + r["description"].ToString() + @"  <br/>
 <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
<b>" + str_talktime + @"" + str_data + @"" + str_sms + @"</b>
                                        </div>
                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                        }
                    }

                        str_tabcontent += @"</table>
                                        </div>";

                    }

                    i++;
                }

            }
            catch (Exception ep)
            {

            }


            List<string> li = new List<string>();
            li.Add(str_tabheader);
            li.Add(str_tabcontent);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }

        [HttpPost]
        [Route("getPlanNewDesign")]
        public List<string> getPlanNewDesign(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_tabheader = "";
            string str_tabcontent = "";
            string strurl = "";
            string resp = "";


            try
            {
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.OperatorCode = objoperator.OperatorId;
                objrecharge.CircleCode = objoperator.CircleId;
                //string resp = @"{""records"":{""FULLTT"":[{""rs"":""75"",""desc"":""For Jio Phone Customers Only - Data: 0.01GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""99"",""desc"":""Applicable Only on Jiophone WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""109"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.99 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""125"",""desc"":""For Jio Phone Customers Only - Data: 0.5GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""129"",""desc"":""Pack validity(days)28 ,Total data(GB)2 Data at high speed(Post which unlimited @ 64 Kbps) 2GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 500 minutes SMS300"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""153"",""desc"":""Applicable Only on Jiophone activated SIMs: (WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""155"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 1 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""163"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.153 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""185"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 2 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""199"",""desc"":""Pack validity(days)28 Total data(GB)42 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""249"",""desc"":""Pack validity(days)28 Total data(GB)56 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""307"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.297 + Rs.10 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""317"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.297 + Rs.20 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""329"",""desc"":""Pack validity(days)84 Total data(GB)6 Data at high speed(Post which unlimited @ 64 Kbps) 6GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3000 minutes SMS1000"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""349"",""desc"":""MRP`349 Pack validity(days)28 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 3 GB\/ Day VoiceJio to Jio Unlimited, Jio to Non-Jio FUP of 1000 minutes SMS100"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""399"",""desc"":""Pack validity(days)56 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""444"",""desc"":""Pack validity(days)56 Total data(GB)112 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""555"",""desc"":""Pack validity(days)84 Total data(GB)126 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""599"",""desc"":""Pack validity(days)84 Total data(GB)168 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""604"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.10 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""614"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.20 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""1299"",""desc"":""Pack validity(days)365 Total data(GB)24 Data at high speed(Post which unlimited @ 64 Kbps) 24GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMS3600"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2121"",""desc"":""MRP`2121 Pack validity(days)336 Total data(GB)504 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMSUnlimited(100 \/ day) Jio AppsComplimentary subscription"",""validity"":""336 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2199"",""desc"":""Pack validity(days)365 Total data(GB)547.5 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""}],""TOPUP"":[{""rs"":""10"",""desc"":""Talktime7.47 IUC Minutes124 Complementary data(GB)1"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""20"",""desc"":""Talktime14.95 IUC Minutes249 Complementary data(GB)2"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""50"",""desc"":""Talktime39.37 IUC Minutes656 Complementary data(GB)5"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""100"",""desc"":""Talktime81.75 IUC Minutes1,362 Complementary data(GB)10"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""500"",""desc"":""Talktime420.73 IUC Minutes7,012 Complementary data(GB)50"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""1000"",""desc"":""Talktime844.46 IUC Minutes14,074 Complementary data(GB)100"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""}],""3G\/ 4G"":[{""rs"":""11"",""desc"":""Unlimited 400 MB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""21"",""desc"":""Unlimited 1 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""51"",""desc"":""Unlimited 3 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""101"",""desc"":""Unlimited 6 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""}],""Romaing"":[{""rs"":""501"",""desc"":"" Rs 551 ISD Talktime"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""575"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 100 minutes | Roaming International SMS: 100 SMS | International Roaming Data: 250 MB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf "",""validity"":""1 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""1101"",""desc"":""International Roaming: Rs.1211.0 | ISD SMS: 5 SMS | (The Monetary value can be used for voice calls, SMS and Data usage while on International Roaming only) For IR rates visit http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - Tariff.pdf(For All Customers)"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""2875"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India(100 Min\/ Day): 700 minutes | Roaming International SMS: 100 SMS \/ Day | International Roaming Data: 250 MB \/ Day | high speed - thereafter at 64 Kbps | The Unlimited pack benefits... "",""validity"":""7 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""5751"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 1500 minutes | Roaming International SMS: 1500 SMS | International Roaming Data: 5 GB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf"",""validity"":""30 days"",""last_update"":""17 - 10 - 2019""}]},""status"":1,""time"":null}";
                DataSet ds = objrecharge.getRechargePlan(objrecharge);


                //    DataSet ds=ReadDataFromJson(@"{""records"":{""TOPUP"":[{""rs"":""10"",""desc"":""Get Talktime of Rs. 7.47"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""20"",""desc"":""Get Talktime of Rs. 14.95"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""30"",""desc"":""Get Talktime of Rs. 22.42"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""50"",""desc"":""Get Talktime of Rs.39.37"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""500"",""desc"":""Get Talktime of Rs. 423.73"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""1000"",""desc"":""Get Talktime of Rs. 847.46"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""5000"",""desc"":""Get Talktime of Rs. 4237.29"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""}],""RATE CUTTER"":[{""rs"":""18"",""desc"":""60 minutes US & cananda calling free Validity 1 Hour.Dial * 444 * 18# to activate and start calling now. _x001C_*T&Cs apply. Refer https:\/\/shop.vodafone.in\/shop\/prepaid\/Prepaid_SuperHour_t&c.pdf for applicable ISD codes"",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""19"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+200MB Data. Validity 2 Days"",""validity"":""2 days"",""last_update"":""22-02-2020""},{""rs"":""24"",""desc"":""Plan Voucher - Call rate of 2.5p\/sec, 100 on-net night minutes for 14 days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""39"",""desc"":""30 Limited validity talktime, Local\/National Calls @ 2.5p\/sec and 100 MB Data Pack Validity for 14 Days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""49"",""desc"":""Get Rs38 Talktime+Local\/National Calls@2.5p\/sec+100MB for 28 Days Talktime Rs 38 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""79"",""desc"":""Get Rs64 Talktime+Local\/National Calls@1p\/sec+200MB for 28 Days Talktime Rs 64 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""}],""SMS"":[{""rs"":""12"",""desc"":""Get 120 local\/national SMS for 10 days"",""validity"":""10 days"",""last_update"":""22-02-2020""},{""rs"":""26"",""desc"":""Get 250 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""36"",""desc"":""Get 350 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""99"",""desc"":""Unlimited Local+STD+Roamings Calls to all Network + 1GB + 100 SMS.Validity 18 Days"",""validity"":""18 days"",""last_update"":""22-02-2020""},{""rs"":""129"",""desc"":""Truly Unlimited Local+STD+Roamings Calls to all Network + 2GB + 300 Local and National SMS.Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""199"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""219"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""269"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks + 4GB Data + 600 Local and National SMS. Pack Validity for 56 Days."",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""398"",""desc"":""3GB Daily(84GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""499"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 70 Days"",""validity"":""70 days"",""last_update"":""22-02-2020""},{""rs"":""555"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 77 Days"",""validity"":""77 days"",""last_update"":""22-02-2020""},{""rs"":""558"",""desc"":""3GB Daily(168GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""}],""Romaing"":[{""rs"":""295"",""desc"":""40 mins of international roaming calls which include Outgoing local calls, calls back to India and Incoming Calls only. Applicable in USA, UAE, Singapore, Thailand, UK, Sri Lanka, China, Saudi Arabia, Qatar, Oman, Bahrain, Kuwait, Nepal, Bangladesh, Indonesia, Malaysia, Australia, NZ, Canada & many more! Validity: 28 days. T&C Apply"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 1GB (Rs.1\/MB after 1GB) FREE SMS & FREE incoming calls. Plus 120mins FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, Enjoy 300MB data (Re.1\/MB after 300MB) & 10 Free SMS (Re.1\/SMS after 10SMS). Also enjoy FREE incoming calls with 50mins FREE outgoing calls(local & to India), after 50 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries ."",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""995"",""desc"":""Get FREE 150 min outgoing & incoming calls & 500 MB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Bangladesh, Sri Lanka, China, Kenya, Germany, Belgium, Turkey, Netherlands & more! Also, get FREE 100 min & 100 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 7 days. T&C Apply"",""validity"":""7 days"",""last_update"":""22-02-2020""},{""rs"":""1495"",""desc"":""Get FREE 300 min outgoing & incoming calls & 1GB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Europe (Germany, Belgium, France, Netherlands, Italy, Spain, Greece), Australia, NZ, Bangladesh, China, Turkey & more! Also, get FREE 150 min & 250 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 14 days. T&C Apply"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""2695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 4GB (Rs.1\/MB after 4GB) FREE SMS & FREE incoming calls. Plus 120mins\/day FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, enjoy 1.2GB data (Re.1\/MB after 1.2GB) & 40 Free SMS (Re.1\/SMS after 40SMS). Also enjoy FREE incoming calls with 200mins FREE outgoing calls(local & to India), after 200 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries."",""validity"":""4 days"",""last_update"":""22-02-2020""}],""COMBO"":[{""rs"":""149"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB Data+300SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""299"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""379"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+6GB Data+1000SMS. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+1.5GB\/Day+100SMS\/Day. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""449"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB\/Day+100SMS\/Day. Validity:56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""599"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""699"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""1499"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +24GB Data+3600SMS. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""},{""rs"":""2399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""}]},""status"":1,""time"":null}");
                //if (ds.Tables[0].Columns.Contains("records"))
                //{
                //DataView view = new DataView(ds.Tables[0]);
                //DataTable dtrechargetype = view.ToTable(true, "records");


                int i = 0;

                foreach (DataRow drcategory in ds.Tables[0].Rows)
                {


                    if (i == 0)
                    {
                        //str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" class=""active"" data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";
                        str_tabheader += @"<li class=""nav-item"">
                                                            <a class=""nav-link active"" id=""#tabid" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" data-toggle=""tab"" href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tab"" aria-controls=""unlimited"" aria-selected=""true"">" + drcategory["categoryname"].ToString() + @"</a>
                                                        </li>";
                        //str_tabcontent += @"    <div class=""tab-pane active"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";
                        str_tabcontent += @"<div class=""tab-pane fade show active"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tabpanel"" aria-labelledby=""unlimited"">
                                                            <div class=""inner-plan-bx"">";

                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"

                        if (dv.ToTable().Rows.Count > 0)
                        {



                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime = r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<li><i class=""fa-solid fa-wifi""></i><span>"+str_data+"</span></li>";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @" <li><i class=""fa-solid fa-message""></i><span>"+str_sms+"</span></li>";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<li><i class=""fa-solid fa-phone""></i><span>"+str_talktime+"</span></li> ";
                                }

//                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
//                                     " + r["description"].ToString() + @"  <br/>
// <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
//<b>" + str_talktime + @"" + str_data + @"" + str_sms + @"</b>
//                                        </div>
//                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
//                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
//                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";

                            str_tabcontent+= @"<div class=""h-plan-list"">
                                                                    <div class=""h-plan-top"">
                                                                        <div class=""hplan-left"">
                                                                            <div class=""h-inner-left"">
                                                                                <p class=""h-price""><i class=""fa-solid fa-indian-rupee-sign""></i>" + r["amount"].ToString() + @"</p>
                                                                                <p class=""h-validity""><i class=""fa-solid fa-clock""></i><span>Validity: " + r["validity"].ToString() + @"</span></p>
                                                                            </div>
                                                                            <div class=""h-inner-right"">
                                                                                <ul>
                                                                                </ul>
                                                                            </div>
                                                                        </div>
                                                                        <div class=""hplan-right"">
                                                                            <a onclick=""selectplanmobile('" + r["amount"].ToString() + @"')"" class=""submitpanbtn"">Select</a>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""h-plan-bottom"">
                                                                        <div class=""h-plan-content"">
                                                                            <p>" + r["description"].ToString() + @"</p>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""mobile-hplan"">
                                                                        <div class=""mobile-hplan-row"">
                                                                            <div class=""mobile-h-left"">
                                                                                <p class=""h-validity""><i class=""fa-solid fa-clock""></i><span>Validity: "+r["validity"].ToString()+ @"</span></p>
                                                                            </div>
                                                                            <div class=""mobile-h-right"">
                                                                                <a onclick=""selectplanmobile('" + r["amount"].ToString() + @"')"" class=""submitpanbtn"">Select</a>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>";

                            }
                        }
                        //str_tabcontent += @"</table>
                        //        </div>";
                        str_tabcontent += @" </div>
                                        </div>";
                    }
                    else
                    {


                        //str_tabheader += @" <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"""_2", @"""2").Replace(@"""_3", @"""3").Replace(@"""_4", @"""4").Replace(@"""_5", @"""5").Replace(@"""_6", @"""6").Replace(@"""_7", @"""7").Replace(@"""_8", @"""8").Replace(@"""_9", @"""9") + "</a></li>";
                        //str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @"""  data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";
                        str_tabheader += @"<li class=""nav-item"">
                                                            <a class=""nav-link"" id=""#tabid" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" data-toggle=""tab"" href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tab"" aria-controls=""unlimited"" aria-selected=""false"">" + drcategory["categoryname"].ToString() + @"</a>
                                                        </li>";
                        //str_tabcontent += @"  <div class=""tab-pane"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";
                        //DataTable dt = new DataTable();
                        //objrecharge.OperatorCode = objoperator.OperatorId;
                        //objrecharge.CircleCode = objoperator.CircleId;
                        //objrecharge.CategoryId = drcategory["categoryid"].ToString();
                        //dt = objrecharge.getRechargePlanByCategory(objrecharge);
                        //DataView dv = dt.DefaultView;

                        str_tabcontent += @"<div class=""tab-pane fade"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tabpanel"" aria-labelledby=""unlimited"">
                                                            <div class=""inner-plan-bx"">";

                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"

                        if (dv.ToTable().Rows.Count > 0)
                        {



                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime = r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<li><i class=""fa-solid fa-wifi""></i><span>" + str_data + "</span></li>";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @" <li><i class=""fa-solid fa-message""></i><span>" + str_sms + "</span></li>";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<li><i class=""fa-solid fa-phone""></i><span>" + str_talktime + "</span></li> ";
                                }

                                //                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                //                                     " + r["description"].ToString() + @"  <br/>
                                // <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
                                //<b>" + str_talktime + @"" + str_data + @"" + str_sms + @"</b>
                                //                                        </div>
                                //                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                //                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
                                //                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";

                                str_tabcontent += @"<div class=""h-plan-list"">
                                                                    <div class=""h-plan-top"">
                                                                        <div class=""hplan-left"">
                                                                            <div class=""h-inner-left"">
                                                                                <p class=""h-price""><i class=""fa-solid fa-indian-rupee-sign""></i>" + r["amount"].ToString() + @"</p>
                                                                                <p class=""h-validity""><i class=""fa-solid fa-clock""></i><span>Validity: " + r["validity"].ToString() + @"</span></p>
                                                                            </div>
                                                                            <div class=""h-inner-right"">
                                                                                <ul>
                                                                                </ul>
                                                                            </div>
                                                                        </div>
                                                                        <div class=""hplan-right"">
                                                                            <a onclick=""selectplanmobile('" + r["amount"].ToString() + @"')"" class=""submitpanbtn"">Select</a>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""h-plan-bottom"">
                                                                        <div class=""h-plan-content"">
                                                                            <p>" + r["description"].ToString() + @"</p>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""mobile-hplan"">
                                                                        <div class=""mobile-hplan-row"">
                                                                            <div class=""mobile-h-left"">
                                                                                <p class=""h-validity""><i class=""fa-solid fa-clock""></i><span>Validity: " + r["validity"].ToString() + @"</span></p>
                                                                            </div>
                                                                            <div class=""mobile-h-right"">
                                                                                <a onclick=""selectplanmobile('" + r["amount"].ToString() + @"')"" class=""submitpanbtn"">Select</a>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </div>";

                            }
                        }
                        //str_tabcontent += @"</table>
                        //        </div>";
                        str_tabcontent += @" </div>
                                        </div>";

                    }

                    i++;
                }

            }
            catch (Exception ep)
            {

            }


            List<string> li = new List<string>();
            li.Add(str_tabheader);
            li.Add(str_tabcontent);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }


        [HttpPost]
        [Route("getPlanLanding")]
        public List<string> getPlanLanding(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_tabheader = "";
            string str_tabcontent = "";
            string strurl = "";
            string resp = "";


            try
            {
                clsRecharge objrecharge = new clsRecharge();
                objrecharge.OperatorCode = objoperator.OperatorId;
                objrecharge.CircleCode = objoperator.CircleId;
                //string resp = @"{""records"":{""FULLTT"":[{""rs"":""75"",""desc"":""For Jio Phone Customers Only - Data: 0.01GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""99"",""desc"":""Applicable Only on Jiophone WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""109"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.99 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.99 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""125"",""desc"":""For Jio Phone Customers Only - Data: 0.5GB\/ day + Voice: Jio to Jio Unlimited &Jio to Non-Jio FUP"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""129"",""desc"":""Pack validity(days)28 ,Total data(GB)2 Data at high speed(Post which unlimited @ 64 Kbps) 2GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 500 minutes SMS300"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""153"",""desc"":""Applicable Only on Jiophone activated SIMs: (WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""155"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 1 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""163"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.153 + Rs.10 IUC Pack) WITH VALIDITY 28 days Rs.153 Benefit: 1.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""185"",""desc"":""Applicable Only on Jiophone activated SIMs: Data: 2 GB\/ day Voice: Unlimited Calls(Jio to non-Jio FUP)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""199"",""desc"":""Pack validity(days)28 Total data(GB)42 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""249"",""desc"":""Pack validity(days)28 Total data(GB)56 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 1,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""307"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.297 + Rs.10 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""317"",""desc"":""Applicable Only on Jiophone activated SIMs: (Rs.297 + Rs.20 IUC Pack) WITH VALIDITY 84 days Rs.297 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""329"",""desc"":""Pack validity(days)84 Total data(GB)6 Data at high speed(Post which unlimited @ 64 Kbps) 6GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3000 minutes SMS1000"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""349"",""desc"":""MRP`349 Pack validity(days)28 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 3 GB\/ Day VoiceJio to Jio Unlimited, Jio to Non-Jio FUP of 1000 minutes SMS100"",""validity"":""28 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""399"",""desc"":""Pack validity(days)56 Total data(GB)84 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""444"",""desc"":""Pack validity(days)56 Total data(GB)112 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 2,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""56 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""555"",""desc"":""Pack validity(days)84 Total data(GB)126 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""599"",""desc"":""Pack validity(days)84 Total data(GB)168 Data at high speed(Post which unlimited @ 64 Kbps) 2GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 3,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""84 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""604"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.10 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.10 IUC PACK Benefit: Rs 7.47 talktime(124 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""614"",""desc"":""Applicable Only on Jiophone activated SIMs:(Rs.594 + Rs.20 IUC Pack) WITH VALIDITY 168 days Rs.594 Benefit: 0.5 GB\/ day, Jio to Jio calls free, Jio to NON - Jio calls @ 6p\/ min, SMS & Jio Apps Rs.20 IUC PACK Benefit: Rs 14.95 talktime(249 NON - Jio minutes)"",""validity"":""168 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""1299"",""desc"":""Pack validity(days)365 Total data(GB)24 Data at high speed(Post which unlimited @ 64 Kbps) 24GB VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMS3600"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2121"",""desc"":""MRP`2121 Pack validity(days)336 Total data(GB)504 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12000 minutes SMSUnlimited(100 \/ day) Jio AppsComplimentary subscription"",""validity"":""336 days"",""last_update"":""01 - 01 - 1970""},{""rs"":""2199"",""desc"":""Pack validity(days)365 Total data(GB)547.5 Data at high speed(Post which unlimited @ 64 Kbps) 1.5GB per day VoiceJio to Jio Unlimited, Jio to Non - Jio FUP of 12,000 minutes SMSUnlimited(100 \/ day)"",""validity"":""365 days"",""last_update"":""01 - 01 - 1970""}],""TOPUP"":[{""rs"":""10"",""desc"":""Talktime7.47 IUC Minutes124 Complementary data(GB)1"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""20"",""desc"":""Talktime14.95 IUC Minutes249 Complementary data(GB)2"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""50"",""desc"":""Talktime39.37 IUC Minutes656 Complementary data(GB)5"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""100"",""desc"":""Talktime81.75 IUC Minutes1,362 Complementary data(GB)10"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""500"",""desc"":""Talktime420.73 IUC Minutes7,012 Complementary data(GB)50"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""},{""rs"":""1000"",""desc"":""Talktime844.46 IUC Minutes14,074 Complementary data(GB)100"",""validity"":""N\/ A"",""last_update"":""01 - 01 - 1970""}],""3G\/ 4G"":[{""rs"":""11"",""desc"":""Unlimited 400 MB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""21"",""desc"":""Unlimited 1 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""51"",""desc"":""Unlimited 3 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""},{""rs"":""101"",""desc"":""Unlimited 6 GB"",""validity"":""N\/ A"",""last_update"":""17 - 10 - 2019""}],""Romaing"":[{""rs"":""501"",""desc"":"" Rs 551 ISD Talktime"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""575"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 100 minutes | Roaming International SMS: 100 SMS | International Roaming Data: 250 MB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf "",""validity"":""1 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""1101"",""desc"":""International Roaming: Rs.1211.0 | ISD SMS: 5 SMS | (The Monetary value can be used for voice calls, SMS and Data usage while on International Roaming only) For IR rates visit http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - Tariff.pdf(For All Customers)"",""validity"":""28 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""2875"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India(100 Min\/ Day): 700 minutes | Roaming International SMS: 100 SMS \/ Day | International Roaming Data: 250 MB \/ Day | high speed - thereafter at 64 Kbps | The Unlimited pack benefits... "",""validity"":""7 days"",""last_update"":""17 - 10 - 2019""},{""rs"":""5751"",""desc"":""International Roaming Incoming: Unlimited | Intl Local \/ Calls to India: 1500 minutes | Roaming International SMS: 1500 SMS | International Roaming Data: 5 GB | high speed - thereafter at 64 Kbps | The Unlimited pack benefits are applicable while travelling to the country covered in pack benefit and on pack partner network only | To check the country details please visit : http:\/\/ jep - asset.jio.com\/ jio\/ plan\/ IR - packs.pdf"",""validity"":""30 days"",""last_update"":""17 - 10 - 2019""}]},""status"":1,""time"":null}";
                DataSet ds = objrecharge.getRechargePlan(objrecharge);


                //    DataSet ds=ReadDataFromJson(@"{""records"":{""TOPUP"":[{""rs"":""10"",""desc"":""Get Talktime of Rs. 7.47"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""20"",""desc"":""Get Talktime of Rs. 14.95"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""30"",""desc"":""Get Talktime of Rs. 22.42"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""50"",""desc"":""Get Talktime of Rs.39.37"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""500"",""desc"":""Get Talktime of Rs. 423.73"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""1000"",""desc"":""Get Talktime of Rs. 847.46"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""5000"",""desc"":""Get Talktime of Rs. 4237.29"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""}],""RATE CUTTER"":[{""rs"":""18"",""desc"":""60 minutes US & cananda calling free Validity 1 Hour.Dial * 444 * 18# to activate and start calling now. _x001C_*T&Cs apply. Refer https:\/\/shop.vodafone.in\/shop\/prepaid\/Prepaid_SuperHour_t&c.pdf for applicable ISD codes"",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""19"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+200MB Data. Validity 2 Days"",""validity"":""2 days"",""last_update"":""22-02-2020""},{""rs"":""24"",""desc"":""Plan Voucher - Call rate of 2.5p\/sec, 100 on-net night minutes for 14 days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""39"",""desc"":""30 Limited validity talktime, Local\/National Calls @ 2.5p\/sec and 100 MB Data Pack Validity for 14 Days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""49"",""desc"":""Get Rs38 Talktime+Local\/National Calls@2.5p\/sec+100MB for 28 Days Talktime Rs 38 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""79"",""desc"":""Get Rs64 Talktime+Local\/National Calls@1p\/sec+200MB for 28 Days Talktime Rs 64 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""}],""SMS"":[{""rs"":""12"",""desc"":""Get 120 local\/national SMS for 10 days"",""validity"":""10 days"",""last_update"":""22-02-2020""},{""rs"":""26"",""desc"":""Get 250 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""36"",""desc"":""Get 350 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""99"",""desc"":""Unlimited Local+STD+Roamings Calls to all Network + 1GB + 100 SMS.Validity 18 Days"",""validity"":""18 days"",""last_update"":""22-02-2020""},{""rs"":""129"",""desc"":""Truly Unlimited Local+STD+Roamings Calls to all Network + 2GB + 300 Local and National SMS.Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""199"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""219"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""269"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks + 4GB Data + 600 Local and National SMS. Pack Validity for 56 Days."",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""398"",""desc"":""3GB Daily(84GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""499"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 70 Days"",""validity"":""70 days"",""last_update"":""22-02-2020""},{""rs"":""555"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 77 Days"",""validity"":""77 days"",""last_update"":""22-02-2020""},{""rs"":""558"",""desc"":""3GB Daily(168GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""}],""Romaing"":[{""rs"":""295"",""desc"":""40 mins of international roaming calls which include Outgoing local calls, calls back to India and Incoming Calls only. Applicable in USA, UAE, Singapore, Thailand, UK, Sri Lanka, China, Saudi Arabia, Qatar, Oman, Bahrain, Kuwait, Nepal, Bangladesh, Indonesia, Malaysia, Australia, NZ, Canada & many more! Validity: 28 days. T&C Apply"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 1GB (Rs.1\/MB after 1GB) FREE SMS & FREE incoming calls. Plus 120mins FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, Enjoy 300MB data (Re.1\/MB after 300MB) & 10 Free SMS (Re.1\/SMS after 10SMS). Also enjoy FREE incoming calls with 50mins FREE outgoing calls(local & to India), after 50 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries ."",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""995"",""desc"":""Get FREE 150 min outgoing & incoming calls & 500 MB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Bangladesh, Sri Lanka, China, Kenya, Germany, Belgium, Turkey, Netherlands & more! Also, get FREE 100 min & 100 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 7 days. T&C Apply"",""validity"":""7 days"",""last_update"":""22-02-2020""},{""rs"":""1495"",""desc"":""Get FREE 300 min outgoing & incoming calls & 1GB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Europe (Germany, Belgium, France, Netherlands, Italy, Spain, Greece), Australia, NZ, Bangladesh, China, Turkey & more! Also, get FREE 150 min & 250 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 14 days. T&C Apply"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""2695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 4GB (Rs.1\/MB after 4GB) FREE SMS & FREE incoming calls. Plus 120mins\/day FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, enjoy 1.2GB data (Re.1\/MB after 1.2GB) & 40 Free SMS (Re.1\/SMS after 40SMS). Also enjoy FREE incoming calls with 200mins FREE outgoing calls(local & to India), after 200 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries."",""validity"":""4 days"",""last_update"":""22-02-2020""}],""COMBO"":[{""rs"":""149"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB Data+300SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""299"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""379"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+6GB Data+1000SMS. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+1.5GB\/Day+100SMS\/Day. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""449"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB\/Day+100SMS\/Day. Validity:56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""599"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""699"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""1499"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +24GB Data+3600SMS. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""},{""rs"":""2399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""}]},""status"":1,""time"":null}");
                //if (ds.Tables[0].Columns.Contains("records"))
                //{
                //DataView view = new DataView(ds.Tables[0]);
                //DataTable dtrechargetype = view.ToTable(true, "records");


                int i = 0;

                foreach (DataRow drcategory in ds.Tables[0].Rows)
                {


                    if (i == 0)
                    {
                        //str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" class=""active"" data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";
                        str_tabheader += @"<li class=""nav-item"" role=""presentation"">
                                <a class=""nav-link active"" id=""tabhead" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" data-toggle=""tab"" href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @"""
                                   role=""tab"" aria-controls=""unlimited"" aria-selected=""true"">" + drcategory["categoryname"].ToString() + @"</a>
                            </li>";
                        //str_tabcontent += @"    <div class=""tab-pane active"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";

                        str_tabcontent += @"  <div class=""tab-pane fade show active"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tabpanel""
                                 aria-labelledby=""home-tab"">
                                <div class=""check-plan-main"">";


                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"

                        if (dv.ToTable().Rows.Count > 0)
                        {



                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime = r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<li><p><i class=""fa-solid fa-wifi""></i><span>"+str_data+"</span></p></li> ";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @"<li><p><i class=""fa-solid fa-message""></i><span>" + str_sms + "<span></p></li> ";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<li><p><i class=""fa-solid fa-phone""></i><span>" + str_talktime + "</span></p></li> ";
                                }

                                //                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                //                                     " + r["description"].ToString() + @"  <br/>
                                // <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
                                //<b>" + str_talktime + @"" + str_data + @"" + str_sms + @"</b>
                                //                                        </div>
                                //                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                //                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
                                //                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                                str_tabcontent += @"<div class=""row"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12"">
                                            <div class=""plan-inner-bx"">
                                                <div class=""plan-inner-top"">
                                                    <div class=""plan-inner-left"">
                                                        <div class=""main-plans"">
                                                            <p class=""pricing"">
                                                                <i class=""fa-solid fa-indian-rupee-sign""></i>
                                                                <span>" + Math.Round(Convert.ToDecimal(r["amount"].ToString())).ToString() + @"</span>
                                                            </p>
                                                            <p class=""plan-validity"">
                                                                <i class=""fa-solid fa-clock""></i>
                                                                <span>Validity: " + r["validity"].ToString() + @"</span>
                                                            </p>
                                                        </div>
                                                        <div class=""main-bottom"">
                                                            <ul>
                                                                
                                                                        "+str_talktime+@"
                                                                 
                                                                
                                                                        "+str_data+@"
                                                                  
                                                              
                                                                        "+str_sms+@"
                                                                   
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class=""plan-inner-right"">
                                                        <button onclick=""selectplanmobile('" + Math.Round( Convert.ToDecimal( r["amount"].ToString())).ToString() + @"  ')"" style=""color:white"">Select</button>
                                                    </div>
                                                </div>
                                                <div class=""plan-inner-bottom"">
                                                    <p>
                                                       " + r["description"].ToString() + @"
                                                    </p>

                                                    <div class=""mobile-plan-row"">
                                                        <div class=""mobile-plan-col"">
                                                            <p class=""plan-validity"">
                                                                <i class=""fa-solid fa-clock""></i>
                                                                <span>Validity: " + r["validity"].ToString() + @"</span>
                                                            </p>
                                                        </div>
                                                        <div class=""plan-inner-right"">
                                                            <button onclick=""selectplanmobile('" + Math.Round(Convert.ToDecimal(r["amount"].ToString())).ToString() + @"  ')"" style=""color:white"">Select</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>


                                    </div>";
                            }
                        }
                        //str_tabcontent += @"</table>
                        //        </div>";
                        str_tabcontent += @"
                                        </div>
                                        </div>";
                    }
                    else
                    {


                        //str_tabheader += @" <li class=""nav-item""><a class=""nav-link"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"""_2", @"""2").Replace(@"""_3", @"""3").Replace(@"""_4", @"""4").Replace(@"""_5", @"""5").Replace(@"""_6", @"""6").Replace(@"""_7", @"""7").Replace(@"""_8", @"""8").Replace(@"""_9", @"""9") + "</a></li>";
                        //str_tabheader += @"<li ><a href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @"""  data-toggle=""tab"">" + drcategory["categoryname"].ToString() + "</a></li>";
                        str_tabheader += @"<li class=""nav-item"" role=""presentation"">
                                <a class=""nav-link"" id=""tabhead" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" data-toggle=""tab"" href=""#tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @"""
                                   role=""tab"" aria-controls=""unlimited"" aria-selected=""false"">" + drcategory["categoryname"].ToString() + @"</a>
                            </li>";

                        //str_tabcontent += @"  <div class=""tab-pane"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""">";

                        str_tabcontent += @"  <div class=""tab-pane fade show"" id=""tab" + drcategory["categoryname"].ToString().Replace(" ", "") + @""" role=""tabpanel""
                                 aria-labelledby=""home-tab"">
                                <div class=""check-plan-main"">";
                        //DataTable dt = new DataTable();
                        //objrecharge.OperatorCode = objoperator.OperatorId;
                        //objrecharge.CircleCode = objoperator.CircleId;
                        //objrecharge.CategoryId = drcategory["categoryid"].ToString();
                        //dt = objrecharge.getRechargePlanByCategory(objrecharge);
                        //DataView dv = dt.DefaultView;

                        DataView dv = new DataView(ds.Tables[1]);
                        dv.RowFilter = "categoryid=" + drcategory["categoryid"].ToString() + ""; // query example = "id = 10"
                        if (dv.ToTable().Rows.Count > 0)
                        {
                            foreach (DataRow r in dv.ToTable().Rows)
                            {
                                string str_data = r["data"].ToString();
                                string str_sms = r["sms"].ToString();
                                string str_talktime = r["talktime"].ToString();

                                if (str_data != "")
                                {
                                    str_data = @"<li><p><i class=""fa-solid fa-wifi""></i><span>" + str_data + "</span></p></li> ";
                                }

                                if (str_sms != "")
                                {
                                    str_sms = @"<li><p><i class=""fa-solid fa-message""></i><span>" + str_sms + "<span></p></li> ";
                                }
                                if (str_talktime != "")
                                {
                                    str_talktime = @"<li><p><i class=""fa-solid fa-phone""></i><span>" + str_talktime + "</span></p></li> ";
                                }

                                //                                str_tabcontent += @"<div class=""row bg-white p-4"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10 col-sm-10"" style=""padding: 2px"">
                                //                                     " + r["description"].ToString() + @"  <br/>
                                // <b>Validity : " + r["validity"].ToString() + @"</b> <br/>
                                //<b>" + str_talktime + @"" + str_data + @"" + str_sms + @"</b>
                                //                                        </div>
                                //                                        <div class=""col-md-2 col-sm-2""><a onclick=""selectplanmobile('" + r["amount"].ToString() + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                //                                  <i class=""fa fa-inr""></i>   " + r["amount"].ToString() + @"  
                                //                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                                str_tabcontent += @"<div class=""row"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12"">
                                            <div class=""plan-inner-bx"">
                                                <div class=""plan-inner-top"">
                                                    <div class=""plan-inner-left"">
                                                        <div class=""main-plans"">
                                                            <p class=""pricing"">
                                                                <i class=""fa-solid fa-indian-rupee-sign""></i>
                                                                <span>" + Math.Round(Convert.ToDecimal(r["amount"].ToString())).ToString() + @"</span>
                                                            </p>
                                                            <p class=""plan-validity"">
                                                                <i class=""fa-solid fa-clock""></i>
                                                                <span>Validity: " + r["validity"].ToString() + @"</span>
                                                            </p>
                                                        </div>
                                                        <div class=""main-bottom"">
                                                            <ul>
                                                              
                                                                        " + str_talktime + @"
                                                                  
                                                                        " + str_data + @"
                                                                    
                                                                        " + str_sms + @"
                                                                   
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class=""plan-inner-right"">
                                                        <button onclick=""selectplanmobile('" + Math.Round(Convert.ToDecimal(r["amount"].ToString())).ToString() + @"  ')"" style=""color:white"">Select</button>
                                                    </div>
                                                </div>
                                                <div class=""plan-inner-bottom"">
                                                    <p>
                                                       " + r["description"].ToString() + @"
                                                    </p>

                                                    <div class=""mobile-plan-row"">
                                                        <div class=""mobile-plan-col"">
                                                            <p class=""plan-validity"">
                                                                <i class=""fa-solid fa-clock""></i>
                                                                <span>Validity: " + r["validity"].ToString() + @"</span>
                                                            </p>
                                                        </div>
                                                        <div class=""plan-inner-right"">
                                                            <button onclick=""selectplanmobile('" + Math.Round(Convert.ToDecimal(r["amount"].ToString())).ToString() + @"  ')"" style=""color:white"">Select</button>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>


                                    </div>";
                            }
                        }

                        str_tabcontent += @"
                                        </div>
                                        </div>";

                    }

                    i++;
                }

            }
            catch (Exception ep)
            {

            }


            List<string> li = new List<string>();
            li.Add(str_tabheader);
            li.Add(str_tabcontent);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }

        [HttpPost]
        [Route("getDTHCustmerInfo")]
        public List<string> getDTHCustmerInfo(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_name = "";
            string str_plan = "";
            string str_balance = "";
            string str_lastrechargedate = "";
            string strurl = "";
            string resp = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getROfferOpratorCodeWithAPI(objoperator.OperatorId);
            if (dt.Rows.Count > 0)
            {
                strurl = dt.Rows[0]["dthinfourl"].ToString();
                //strurl = "http://admin.rechargezap.com/webservices/secureservice.asmx/getDTHCustomerInfo?Mobile={mobile}&Operator={operator}";
                // url = url.Replace("{mobile}", TxtCardNo.Text);
                strurl = strurl.Replace("{mobile}", objoperator.Number);
                strurl = strurl.Replace("{operator}", dt.Rows[0]["operatorcodeinfo"].ToString());


                if (strurl != "")
                {
                    try
                    {
                        resp = strurl.CallURL();
                        //resp = @"{""tel"":""02511792745"",""operator"":""Dishtv"",""records"":[{""MonthlyRecharge"":578,""Balance"":""422.73"",""customerName"":""AKAR SHARMA"",""status"":""Active"",""NextRechargeDate"":""21-02-2022"",""lastrechargeamount"":""500"",""lastrechargedate"":""2022-01-27T11:12:40.433"",""planname"":""BST BASE PACKAGE NORTH""}],""status"":1}";
                        DataSet ds = ReadDataFromJson(resp);
                        if (ds.Tables.Count == 2)
                        {
                            if (ds.Tables[1].Rows.Count > 0)
                            {
                                if (ds.Tables[1].Columns.Contains("customerName"))
                                {
                                    str_name = ds.Tables[1].Rows[0]["customerName"].ToString();
                                }
                                if (ds.Tables[1].Columns.Contains("MonthlyRecharge"))
                                {
                                    str_plan = ds.Tables[1].Rows[0]["MonthlyRecharge"].ToString();
                                }
                                if (ds.Tables[1].Columns.Contains("Balance"))
                                {
                                    str_balance = ds.Tables[1].Rows[0]["Balance"].ToString();
                                }
                                if (ds.Tables[1].Columns.Contains("lastrechargedate"))
                                {
                                    str_lastrechargedate = ds.Tables[1].Rows[0]["lastrechargedate"].ToString();
                                    if (str_lastrechargedate.Contains("T"))
                                    {
                                        str_lastrechargedate = str_lastrechargedate.Split('T')[0].ToString();
                                    }
                                }
                            }
                        }

                    }
                    catch (Exception ep)
                    {

                    }
                }

            }
            else
            {
                //lblrechargeplanresponse.Text = "No API Found";
            }

            //DataTable dt = new DataTable();
            //dt = objoperator.getCircle();
            //return new string[] { "value1", "value2" };
            //return dt;

            //ViewBag.tab = outputHtml;

            List<string> li = new List<string>();
            li.Add(str_name);
            li.Add(str_plan);
            li.Add(str_balance);
            li.Add(str_lastrechargedate);
            li.Add(resp);
            return li;

        }

        [HttpPost]
        [Route("getOperatorDetail")]
        public List<string> getOperatorDetail(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_accountdisplay = "";
            string str_displaynote = "";
            string str_displayvalue1 = "";
            string str_displayvalue2 = "";
            string str_displayvalue3 = "";
            string str_displayvalue4 = "";
            string str_optional1type = "";
            string str_optional1values = "";

            string str_optional2type = "";
            string str_optional2values = "";
            string str_optional3type = "";
            string str_optional3values = "";
            string str_optional4type = "";
            string str_optional4values = "";

            DataTable dt = new DataTable();
            dt = objoperator2.GetOperatorDetail(objoperator.OperatorId);
            if (dt.Rows.Count > 0)
            {


                str_accountdisplay = dt.Rows[0]["accountdisplay"].ToString();
                str_displaynote = dt.Rows[0]["displaynote"].ToString();
                str_displayvalue1 = dt.Rows[0]["Displayalue1"].ToString();
                str_displayvalue2 = dt.Rows[0]["Displayalue2"].ToString();
                str_displayvalue3 = dt.Rows[0]["Displayalue3"].ToString();
                str_displayvalue4 = dt.Rows[0]["Displayalue4"].ToString();
                str_optional1type = dt.Rows[0]["Optional1Type"].ToString();
                str_optional1values = dt.Rows[0]["Optional1Values"].ToString();

                str_optional2type = dt.Rows[0]["Optional2Type"].ToString();
                str_optional2values = dt.Rows[0]["Optional2Values"].ToString();

                str_optional3type = dt.Rows[0]["Optional3Type"].ToString();
                str_optional3values = dt.Rows[0]["Optional3Values"].ToString();

                str_optional4type = dt.Rows[0]["Optional4Type"].ToString();
                str_optional4values = dt.Rows[0]["Optional4Values"].ToString();
            }
            else
            {
                //lblrechargeplanresponse.Text = "No API Found";
            }

            //DataTable dt = new DataTable();
            //dt = objoperator.getCircle();
            //return new string[] { "value1", "value2" };
            //return dt;

            //ViewBag.tab = outputHtml;

            List<string> li = new List<string>();
            li.Add(str_accountdisplay);
            li.Add(str_displaynote);
            li.Add(str_displayvalue1);
            li.Add(str_displayvalue2);
            li.Add(str_displayvalue3);
            li.Add(str_displayvalue4);
            li.Add(str_optional1type);
            li.Add(str_optional1values);

            li.Add(str_optional2type);
            li.Add(str_optional2values);

            li.Add(str_optional3type);
            li.Add(str_optional3values);

            li.Add(str_optional4type);
            li.Add(str_optional4values);
            return li;

        }

        [HttpPost]
        [Route("fetchDetailsFastag")]
        public List<string> fetchDetailsFastag(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
          
            string resp = "";
            string msg = "";
            string minlimit = "";
            string maxlimit = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getFastagBillFetch(objoperator.OperatorId,objoperator.VehicleNumber);
            if (dt.Rows.Count > 0)
            {
                resp = dt.Rows[0]["status"].ToString();
                msg = dt.Rows[0]["message"].ToString();
                minlimit = dt.Rows[0]["minvalue"].ToString();
                maxlimit = dt.Rows[0]["maxvalue"].ToString();

            }
            else
            {
                resp = "0";
                msg = "No API Found";
                minlimit = "0";
                maxlimit = "0";
            }


            List<string> li = new List<string>();
           
            li.Add(resp);
            li.Add(msg);
            li.Add(minlimit);
            li.Add(maxlimit);
            return li;

        }

        [HttpPost]
        [Route("fetchDetailsElectricity")]
        public List<string> fetchDetailsElectricity(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();

            string resp = "";
            string msg = "";
            
            string customername = "";
            string dueamount = "";
            string billdate = "";
            string duedate = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getFastagBillElectricity(objoperator.OperatorId, objoperator.VehicleNumber,objoperator.Optional1);
            if (dt.Rows.Count > 0)
            {
                resp = dt.Rows[0]["status"].ToString();
                msg = dt.Rows[0]["message"].ToString();
                customername = dt.Rows[0]["customername"].ToString();
                dueamount = dt.Rows[0]["dueamount"].ToString();
                billdate = dt.Rows[0]["billdate"].ToString();
                duedate = dt.Rows[0]["duedate"].ToString();

            }
            else
            {
                resp = "0";
                msg = "No API Found";
                customername = "0";
                dueamount = "0";
                billdate = "0";
                duedate = "0";
            }


            List<string> li = new List<string>();

            li.Add(resp);
            li.Add(msg);
            li.Add(customername);
            li.Add(dueamount);
            li.Add(billdate);
            li.Add(duedate);
            return li;

        }

        [HttpPost]
        [Route("fetchDetailsCylinder")]
        public List<string> fetchDetailsCylinder(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();

            string resp = "";
            string msg = "";

            string customername = "";
            string dueamount = "";
            string billdate = "";
            string duedate = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getFastagBillCylinder(objoperator.OperatorId, objoperator.VehicleNumber, objoperator.Optional1);
            if (dt.Rows.Count > 0)
            {
                resp = dt.Rows[0]["status"].ToString();
                msg = dt.Rows[0]["message"].ToString();
                customername = dt.Rows[0]["customername"].ToString();
                dueamount = dt.Rows[0]["dueamount"].ToString();
                billdate = dt.Rows[0]["billdate"].ToString();
                duedate = dt.Rows[0]["duedate"].ToString();

            }
            else
            {
                resp = "0";
                msg = "No API Found";
                customername = "0";
                dueamount = "0";
                billdate = "0";
                duedate = "0";
            }


            List<string> li = new List<string>();

            li.Add(resp);
            li.Add(msg);
            li.Add(customername);
            li.Add(dueamount);
            li.Add(billdate);
            li.Add(duedate);
            return li;

        }
        [HttpPost]
        [Route("PayuWebhook")]
        public IActionResult PayuWebhook()
        {
            string str_orderid = "";
            string str_response = "";
            string str_status = "";
            const string hashSeq = "key|txnid|amount|productinfo|firstname|email|udf1|udf2|udf3|udf4|udf5|udf6|udf7|udf8|udf9|udf10";

            str_status = Request.Form["status"].ToString().Trim();
            str_orderid = Request.Form["txnid"].ToString().Trim();
            foreach (string key in Request.Form.Keys)
            {

                str_response += key.Trim() + "=" + Request.Form[key].ToString().Trim() + ",";
            }
            clsRecharge objrecharge = new clsRecharge();
            objrecharge.InsertPayuWebhooklog(str_response, "Online");
            return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("getDTHPlan")]
        public List<string> getDTHPlan(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_tabheader = "";
            string str_tabcontent = "";
            string strurl = "";
            string resp = "";

            DataTable dt = new DataTable();
            dt = objoperator2.getROfferOpratorCodeWithAPI(objoperator.OperatorId);
            if (dt.Rows.Count > 0)
            {
                strurl = dt.Rows[0]["dthplanurl"].ToString();
                // url = url.Replace("{mobile}", TxtCardNo.Text);
                strurl = strurl.Replace("{operator}", dt.Rows[0]["operatorcode"].ToString());

                string str_APICircleCode = "0";


                if (strurl != "")
                {
                    try
                    {
                        //resp = @"{""records"":{""Plan"":[{""rs"":{""_1___YEAR"":""_1349"",""_6___MONTHS"":""_799""},""desc"":""Channels___:___71___\/___RS___799___:___180___DAYS___\/___RS___1349___:___360___DAYS___"",""plan_name"":""UDP___Pack"",""last_update"":""01-01-1970""},{""rs"":{""_6___MONTHS"":""_1497""},""desc"":""Channels___:___90"",""plan_name"":""FREEDOM___WB___Dabang"",""last_update"":""01-01-1970""},{""rs"":{""_6___MONTHS"":""_1498""},""desc"":""Channels___:___94"",""plan_name"":""FREEDOM___Gujarat___Dabang"",""last_update"":""01-01-1970""},{""rs"":{""_6___MONTHS"":""_1499""},""desc"":""Channels___:___96"",""plan_name"":""FREEDOM___Hindi___Dabang"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_153""},""desc"":""Channels___:___102___"",""plan_name"":""BST___ROI___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_153""},""desc"":""Channels___:___102"",""plan_name"":""BST___South___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_153.4""},""desc"":""NCF___=___Rs.___130___(w\/o___tax)___+___Rs.___23.4___(GST)___=___Rs.153.4___(Total___Price___with___tax)___for___first___100___channels___and___Rs.20___(w\/o___tax)___+___Rs.___3.60___(GST)___=___Rs.___23.60___(Total___price___with___tax)___for___every___25___additional___channels___thereof."",""plan_name"":""Welcome___North"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_153.4""},""desc"":""NCF___=___Rs.___130___(w\/o___tax)___+___Rs.___23.4___(GST)___=___Rs.153.4___(Total___Price___with___tax)___for___first___100___channels___and___Rs.20___(w\/o___tax)___+___Rs.___3.60___(GST)___=___Rs.___23.60___(Total___price___with___tax)___for___every___25___additional___channels___thereof."",""plan_name"":""Welcome___South"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_200"",""_3___MONTHS"":""_601""},""desc"":""Channels___:___43___\/___RS___601___ME___97___DAY"",""plan_name"":""New___Orissa___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_206"",""_3___MONTHS"":""_618"",""_6___MONTHS"":""_1236"",""_1___YEAR"":""_2266""},""desc"":""Channels___:___43___\/___RS___618___ME___97___DAYS___\/___RS1236___ME___195DAYS___\/___RS2266___ME___360DAYS"",""plan_name"":""New___MAH___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_220"",""_3___MONTHS"":""_657""},""desc"":""Channels___:___53___\/___RS___657___ME___97___DAYS___"",""plan_name"":""New___Kerala___SD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_220"",""_3___MONTHS"":""_658""},""desc"":""Channels___:___47___\/___RS___658___ME___97___DAYS___"",""plan_name"":""New___WB___SD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_240"",""_3___MONTHS"":""_718"",""_6___MONTHS"":""_1441"",""_1___YEAR"":""_2641""},""desc"":""Channels___:___73___\/___RS___718___ME___97___DAYS___\/___RS___1441___ME___195___DAYS___\/___RS___2641___ME___360___DAYS"",""plan_name"":""Hindi___Value___Lite___SD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_240"",""_3___MONTHS"":""_719"",""_6___MONTHS"":""_1439"",""_1___YEAR"":""_2643""},""desc"":""Channels___:___65___\/___RS___719___ME___97DAYS___\/___RS___1439___ME___195___DAYS___\/___RS___2642___ME___360___DAYS"",""plan_name"":""Gujarat___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_241"",""_3___MONTHS"":""_723"",""_6___MONTHS"":""_1446"",""_1___YEAR"":""_2651""},""desc"":""Channels___:___43___\/___RS___723___:___97___DAYS___\/___RS___1446___:___195___DAYS___\/___RS___2651___:___360___DAYS"",""plan_name"":""New___MAH___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_244"",""_3___MONTHS"":""_732""},""desc"":""Channels___:___47___\/___RS___732___:___97___DAYS"",""plan_name"":""New___WB___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_254"",""_3___MONTHS"":""_761"",""_6___MONTHS"":""_1523"",""_1___YEAR"":""_2793""},""desc"":""Channels___:___84___\/___RS___761___:___97___DAYS___\/___RS___1523___:___195___DAYS___\/___RS___2793___:___360___DAYS"",""plan_name"":""Gujarat___Value___Lite___SD___Pack___(ZEE-TV18)_New"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_254"",""_3___MONTHS"":""_762"",""_6___MONTHS"":""_1524"",""_1___YEAR"":""_2794""},""desc"":""Channels___:___84___\/___RS___762___:___97___DAYS___\/___RS___1524___:___195___DAYS___\/___RS___2794___:___360___DAYS"",""plan_name"":""Hindi___Value___Lite___SD___Pack___(ZEE-TV18)_New"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_254"",""_3___MONTHS"":""_819""},""desc"":""Channels___:___84___\/___RS___819___:___97___DAYS___\/___RS"",""plan_name"":""New___Karnataka___SD___plus"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_272"",""_3___MONTHS"":""_816"",""_6___MONTHS"":""_1632"",""_1___YEAR"":""_2992""},""desc"":""Channels___:___74___\/___RS___816___:___97___DAYS___\/___RS___1632___:___195___DAYS___\/___RS___2992___:___360___DAYS"",""plan_name"":""WB___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_275"",""_3___MONTHS"":""_821"",""_6___MONTHS"":""_1646"",""_1___YEAR"":""_3024""},""desc"":""Channels___:___68___\/___RS___821___:___97___DAYS___\/___RS___1646___:___195___DAYS___\/___RS___3024___:___360___DAYS"",""plan_name"":""Kerala___Value___Lite___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_275"",""_3___MONTHS"":""_822"",""_6___MONTHS"":""_1651"",""_1___YEAR"":""_3026""},""desc"":""Channels___:___83___\/___RS___822___:___97___DAYS___\/___RS___1651___:___195___DAYS___\/___RS___3026___:___360___DAYS"",""plan_name"":""TN___Value___Lite___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_275"",""_3___MONTHS"":""_823"",""_6___MONTHS"":""_1644"",""_1___YEAR"":""_3023""},""desc"":""Channels___:___76___\/___RS___823___:___97___DAYS___\/___RS___1644___:___195___DAYS___\/___RS___3023___:___360___DAYS"",""plan_name"":""Orissa___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_277"",""_3___MONTHS"":""_831""},""desc"":""Channels___:___53___\/___RS___831___:___97___DAYS"",""plan_name"":""New___Kerala___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_279"",""_3___MONTHS"":""_837""},""desc"":""Channels___:___72___\/___RS___837___:___97___DAYS___"",""plan_name"":""New___AP___SD___plus"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_280""},""desc"":""Channels___:___95"",""plan_name"":""Dabang___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_285"",""_3___MONTHS"":""_854"",""_6___MONTHS"":""_1711"",""_1___YEAR"":""_3136""},""desc"":""Channels___:___82___\/___RS___854___:___97___DAYS___\/___RS___1711___:___195___DAYS___\/___RS___3136___:___360___DAYS"",""plan_name"":""Karnataka___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_286"",""_3___MONTHS"":""_858"",""_6___MONTHS"":""_1716"",""_1___YEAR"":""_3146""},""desc"":""Channels___:___69___\/___RS___858___:___97___DAYS___\/___RS___1716___:___195___DAYS___\/___RS___3146___:___360___DAYS"",""plan_name"":""Gujarat___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_286"",""_3___MONTHS"":""_859"",""_6___MONTHS"":""_1717"",""_1___YEAR"":""_3147""},""desc"":""Channels___:___84___\/___RS___859___:___97___DAYS___\/___RS___1717___:___195___DAYS___\/___RS___3147___:___360___DAYS"",""plan_name"":""Marathi___Dabang___Sports___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_289"",""_3___MONTHS"":""_867""},""desc"":""Channels___:___64___\/RS___867___:___97___DAYS"",""plan_name"":""New___Karnataka___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_290"",""_3___MONTHS"":""_871"",""_6___MONTHS"":""_1741"",""_1___YEAR"":""_3196""},""desc"":""Channels___:___97___\/___RS___871___:___97___DAYS___\/___RS___1741___:___195___DAYS___\/___RS___3196___:___360___DAYS"",""plan_name"":""Dabang___Sports"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_290"",""_3___MONTHS"":""_872___"",""_6___MONTHS"":""_1742"",""_1___YEAR"":""_3192""},""desc"":""Channels___:___85___\/___RS___872___:___97___DAYS___\/___RS___1742___:___195___DAYS___\/___RS___3192___:___360___DAYS"",""plan_name"":""WB___Dabang___Sports"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_290"",""_3___MONTHS"":""_873"",""_6___MONTHS"":""_1743"",""_1___YEAR"":""_3193""},""desc"":""Channels___:___87___\/___RS___873___:___97___DAYS___\/___RS___1743___:___195___DAYS___\/___RS___3193___:___360___DAYS"",""plan_name"":""Guj___Dabang___Sports"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_291"",""_3___MONTHS"":""_868"",""_6___MONTHS"":""_1746"",""_1___YEAR"":""_3201""},""desc"":""Channels___:___85___\/___RS___868___:___97___DAYS___\/___RS___1746___:___195___DAYS___\/___RS___3201___:___360___DAYS"",""plan_name"":""Hindi___Value___Lite___HD___Pack___(ZEE-TV18)_New"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_291"",""_3___MONTHS"":""_869"",""_6___MONTHS"":""_1733"",""_1___YEAR"":""_3202""},""desc"":""Channels___:___85___\/___RS___869___:___97___DAYS___\/___RS___1733___:___195___DAYS___\/___RS___3202___:___360___DAYS"",""plan_name"":""Gujarat___Value___Lite___HD___Pack___(ZEE-TV18)"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_292"",""_3___MONTHS"":""_876"",""_6___MONTHS"":""_1752"",""_1___YEAR"":""_3212""},""desc"":""Channels___:___78___\/___RS___876___:___97___DAYS___\/___RS___1752___:___195___DAYS___\/___RS___3212___:___360___DAYS"",""plan_name"":""Hindi___Value___Lite___HD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_293"",""_3___MONTHS"":""_879"",""_6___MONTHS"":""_1758"",""_1___YEAR"":""_3223""},""desc"":""Channels___:___75___\/___RS___879___:___97___DAYS___\/___RS___1758___:___195___DAYS___\/___RS___3223___:___360___DAYS"",""plan_name"":""AP___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_295""},""desc"":""Channels___:___66"",""plan_name"":""New___TN___HD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_295"",""_3___MONTHS"":""_884"",""_6___MONTHS"":""_1769"",""_1___YEAR"":""_3246""},""desc"":""Channels___:___92___\/___RS___884___:___97___DAYS___\/___RS___1769___:___195___DAYS___\/___RS___3246___:___360___DAYS"",""plan_name"":""MAH___Value___Lite___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_295"",""_3___MONTHS"":""_886"",""_6___MONTHS"":""_1771"",""_1___YEAR"":""_3196""},""desc"":""Channels___:___85___\/___RS___886___:___97___DAYS___\/___RS___1771___:___195___DAYS___\/___RS___3196___:___360___DAYS"",""plan_name"":""Oriya___Dabang___Sports"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_324"",""_3___MONTHS"":""_972"",""_6___MONTHS"":""_1944"",""_1___YEAR"":""_3564""},""desc"":""Channels___:___65___\/___RS___972___:___97___DAYS___\/___RS___1944___:___195___DAYS___\/___RS___3564______360___DAYS"",""plan_name"":""Kerala___Value___Lite___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_332"",""_6___MONTHS"":""_1973"",""_1___YEAR"":""_3653""},""desc"":""Channels___:___107___\/___RS___1973___:___195___DAYS___\/___RS___3653___:___360___DAYS___"",""plan_name"":""WB___Value___Sports___lite___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_332"",""_6___MONTHS"":""_1994"",""_1___YEAR"":""_3654""},""desc"":""Channels___:___110___\/___RS___1994___:___195___DAYS___\/___RS___3654___:___360___DAYS"",""plan_name"":""Hindi___Value___Sports___lite___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_333"",""_3___MONTHS"":""_1001"",""_6___MONTHS"":""_1998"",""_1___YEAR"":""_3663""},""desc"":""Channels___:___107___\/___RS___1001___:___97___DAYS___\/___RS___1998___:___195___\/___RS___3663___:___360___DAYS"",""plan_name"":""Orissa___Value___Sports___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_333"",""_3___MONTHS"":""_1002"",""_6___MONTHS"":""_2001"",""_1___YEAR"":""_3664""},""desc"":""Channels___:___90___\/___RS___1002___:___97___DAYS___\/___RS___2001___:___195___DAYS___\/___RS___3664___:___360___DAYS"",""plan_name"":""Kerala___Value___Plus___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_333"",""_3___MONTHS"":""_999"",""_6___MONTHS"":""_1997"",""_1___YEAR"":""_3662""},""desc"":""Channels___:___75___\/___RS___999___:___97___DAYS___\/___RS___1997___:___195___DAYS___\/___RS___3662___:___360___DAYS"",""plan_name"":""AP___Value___Lite___HD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_335"",""_6___MONTHS"":""_2011"",""_1___YEAR"":""_3686""},""desc"":""Channels___:___106___\/___RS___2011___:___195___DAYS___\/___RS___3686___:___360___DAYS___"",""plan_name"":""MAH___Value___Sports___lite"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_336"",""_3___MONTHS"":""_1008"",""_6___MONTHS"":""_2016"",""_1___YEAR"":""_3696""},""desc"":""Channels___:___110___\/___RS___1008___:___97___DAYS___\/___RS___2016___:___195___DAYS___\/___RS___3696___:___360___DAYS"",""plan_name"":""Gujarat___Value___Sports___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_337"",""_3___MONTHS"":""_1021"",""_6___MONTHS"":""_2041"",""_1___YEAR"":""_3741""},""desc"":""Channels___:___98___\/___RS___1021___:___97___DAYS___\/___RS___2041___:___195___DAYS___\/___RS___3741___:___360___DAYS"",""plan_name"":""TN___Value___Sports___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_343""},""desc"":""Channels___:___110___"",""plan_name"":""Karnataka___Value___Plus___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_350""},""desc"":""Channels___:___105"",""plan_name"":""AP___Value___Plus___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_350"",""_3___MONTHS"":""_1048"",""_6___MONTHS"":""_2094"",""_1___YEAR"":""_3849""},""desc"":""Channels___:___77___\/___RS___1048___:___97___DAYS___\/___RS___2094___:___195___DAYS___\/___RS___3849___:___360___DAYS"",""plan_name"":""WB___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_351"",""_3___MONTHS"":""_1053"",""_6___MONTHS"":""_2096"",""_1___YEAR"":""_3861""},""desc"":""Channels___:___78___\/___RS___1053___:___97___DAYS___\/___RS___2096___:___195___DAY___\/___RS___3861___:___360___DAY"",""plan_name"":""Orissa___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_352""},""desc"":""Channels___:___117"",""plan_name"":""Hindi___Value___Sports___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_352""},""desc"":""Channels___:___112"",""plan_name"":""MAH___Value___Sports___SD___plus"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_352""},""desc"":""Channels___:___113"",""plan_name"":""WB___Value___Sports___SD___plus"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1007"",""_6___MONTHS"":""_1949"",""_1___YEAR"":""_3952""},""desc"":""Channels___:___107___\/___RS___1007___:___97___\/___RS___1949___:___195___DAYS___\/___RS___3952___:___360___DAYS"",""plan_name"":""Freedom___Entertainment___HD___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1071"",""_6___MONTHS"":""_2151"",""_1___YEAR"":""_3953""},""desc"":""Channels___:___90___\/___RS___1071___:___97___DAYS___\/___RS___2151___:___195___DAYS___\/___RS___3953___:___360___DAYS"",""plan_name"":""MAH___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1073"",""_6___MONTHS"":""_2153"",""_1___YEAR"":""_3954""},""desc"":""Channels___:___93___\/___RS___1073___:___97___DAYS___\/___RS___2153___:___195___DAYS___\/___RS___3954___:___360___DAYS"",""plan_name"":""Dabang___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1074"",""_6___MONTHS"":""_2156"",""_1___YEAR"":""_3956""},""desc"":""Channels___:___86___\/___RS___1074___:___97___DAYS___\/___RS___2156___:___195___DAYS___\/___RS___3956___:___360___DAYS"",""plan_name"":""WB___Dabang___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1076"",""_6___MONTHS"":""_2157"",""_1___YEAR"":""_3957""},""desc"":""Channels___:___91___\/___RS___1076___:___97___DAYS___\/___RS___2157___:___197___DAYS___\/___RS___3957___:___360___DAYS"",""plan_name"":""Guj___Dabang___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1078"",""_6___MONTHS"":""_2158"",""_1___YEAR"":""_3958""},""desc"":""Channels___:___86___\/___RS___1078___:___97___DAYS___\/___RS___2158___:___195___DAYS___\/___RS___3958___:___360___DAYS"",""plan_name"":""Marathi___Dabang___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_360"",""_3___MONTHS"":""_1079"",""_6___MONTHS"":""_2159"",""_1___YEAR"":""_3959""},""desc"":""Channels___:___87___\/___RS___1079___:___97___DAYS___\/___RS___2159___:___195___DAYS___\/___RS___3959___:___360___DAYS"",""plan_name"":""Oriya___Dabang___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_361"",""_3___MONTHS"":""_1072"",""_6___MONTHS"":""_2152"",""_1___YEAR"":""_3971""},""desc"":""Channels___:___82___\/___RS___1072___:___97___DAYS___\/___RS___2152___:___195___DAYS___\/___RS___3971___:___360___DAYS"",""plan_name"":""Karnataka___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_366"",""_6___MONTHS"":""_2101"",""_1___YEAR"":""_3851""},""desc"":""Channels___:___102___\/___RS___2101___:___195___DAYS___\/___RS___3851___:___360___DAYS"",""plan_name"":""Dabang___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_382"",""_3___MONTHS"":""_1134"",""_6___MONTHS"":""_2268"",""_1___YEAR"":""_4158""},""desc"":""Channels___:___114___\/___RS___1134___:___97___DAYS___\/___RS___2268___:___195___DAY___\/___RS___4158___:___360___DAY"",""plan_name"":""Karnataka___Value___Sports___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_385"",""_3___MONTHS"":""_1155"",""_6___MONTHS"":""_2311"",""_1___YEAR"":""_4234""},""desc"":""Channels___:___83___\/___RS___1155___:___97___DAYS___\/___RS___2311___:___195___DAY___\/___RS___4234___:___360___DAY"",""plan_name"":""TN___Value___Lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_6___MONTHS"":""_3895""},""desc"":""Channels___:___159___\/______RS___3896___ME___195___DAYS___\/"",""plan_name"":""MAH___Mega___6M___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_390"",""_3___MONTHS"":""_1171"",""_6___MONTHS"":""_2341"",""_1___YEAR"":""_4291""},""desc"":""Channels___:___109___\/___RS___1171___:___97___DAYS___\/___RS___2341___:___95___DAYS___\/___RS___4291___:___360___DAY"",""plan_name"":""AP___Value___Sports___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_399"",""_3___MONTHS"":""_1185"",""_6___MONTHS"":""_2327"",""_1___YEAR"":""_4653""},""desc"":""Channels___:___107___\/___RS___1185___:___97___DAYS___\/___RS___2327___:___195___DAYS___\/___RS___4653___:___60___DAY"",""plan_name"":""Freedom___Sports___&___Kids___HD___Pack_Oriya"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_411"",""_3___MONTHS"":""_1151"",""_6___MONTHS"":""_2261"",""_1___YEAR"":""_4521""},""desc"":""Channels___:___114___\/___RS___4521___:___360___DAY___"",""plan_name"":""Freedom___Sports___&___Kids___HD___Pack_Guj"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_412""},""desc"":""Channels___:___89"",""plan_name"":""Kerala___Value___Plus___HD___Pack"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_422""},""desc"":""Channels___:___93"",""plan_name"":""Karnataka___Value___Plus___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_425""},""desc"":""Channels___:___120"",""plan_name"":""TN___My___Family___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_426"",""_3___MONTHS"":""_1193"",""_1___YEAR"":""_4686""},""desc"":""Channels___:___119___\/___RS___4686___:___360___DAYS___"",""plan_name"":""Freedom___Sports___&___Kids___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_429"",""_3___MONTHS"":""_1199"",""_6___MONTHS"":""_2358"",""_1___YEAR"":""_4714""},""desc"":""Channels___:___116___\/___RS___4714___:___360___DAY"",""plan_name"":""Freedom___Sports___&___Kids___HD___Pack_WB"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_432"",""_3___MONTHS"":""_1209"",""_6___MONTHS"":""_2378"",""_1___YEAR"":""_4752""},""desc"":""Channels___:___114___\/___RS___4752___:___360___DAYS"",""plan_name"":""Freedom___Sports___&___Kids___HD___Pack_Mah"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_433""},""desc"":""Channels___:___115"",""plan_name"":""Kerala___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_437""},""desc"":""Channels___:___136"",""plan_name"":""MAH___My___Family___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_437""},""desc"":""Channels___:___132"",""plan_name"":""WB___My___Family___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_447""},""desc"":""Channels___:___120"",""plan_name"":""Karnataka___My___Family___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_449""},""desc"":""Channels___:___141"",""plan_name"":""Hindi___My___Family___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_455""},""desc"":""Channels___:___117"",""plan_name"":""Gujarat___Value___Sports___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_465""},""desc"":""Channels___:___137"",""plan_name"":""TN___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_4676""},""desc"":""Channels___:___120\/___RS___4676___ME___Day___:___360___\/"",""plan_name"":""TN___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_472""},""desc"":""Channels___:___136"",""plan_name"":""Karnataka___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_4763""},""desc"":""Channels___:___115\/Day___:___360"",""plan_name"":""Kerala___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_4803""},""desc"":""Channels___:___132\/Day___:___360"",""plan_name"":""WB___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_4807""},""desc"":""Channels___:___136\/___RS___4807___ME___Day___:___360"",""plan_name"":""MAH___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_4809""},""desc"":""Channels___:___139\/Day___:___360"",""plan_name"":""Gujarat___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_485""},""desc"":""Channels___:___149"",""plan_name"":""Hindi___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_485""},""desc"":""Channels___:___151"",""plan_name"":""MAH___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_485""},""desc"":""Channels___:___145"",""plan_name"":""WB___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_485""},""desc"":""Channels___:___154"",""plan_name"":""Gujarat___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_4917""},""desc"":""Channels___:___120\/Day___:___360"",""plan_name"":""Karnataka___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_4939""},""desc"":""Channels___:___141___and___Day___360"",""plan_name"":""Hindi___My___Family"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_4948""},""desc"":""Channels___:___137\/___RS___4948___ME___Day___:___360"",""plan_name"":""Orissa___My___Family___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_495""},""desc"":""Channels___:___139"",""plan_name"":""AP___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_5006""},""desc"":""Channels___:___117___and___Day___360"",""plan_name"":""Gujarat___Value___Sports___12M___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_503""},""desc"":""Channels___:___152"",""plan_name"":""Orissa___Mega___SD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_5116"",""_1MONTHS"":""_465"",""_3___MONTHS"":""_1396"",""_6___MONTHS"":""_2791""},""desc"":""Channels___:___112___\/___RS___1396___:___97___DAYS___\/___RS___2791___:___195___DAYS___\/___RS___5116___:___360___DAY"",""plan_name"":""Orissa___Value___Sports___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5117""},""desc"":""Channels___:___137___and___Day___360"",""plan_name"":""TN___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5171"",""_1MONTHS"":""_470"",""_3___MONTHS"":""_1412"",""_6___MONTHS"":""_2821""},""desc"":""Channels___:___95___\/___RS___1412___:___97___DAYS___\/___RS___2821___:___195___DAY___\/___RS___5171___:___360"",""plan_name"":""TN___Value___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_518""},""desc"":""Channels___:___137"",""plan_name"":""Hindi___My___Family___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_519""},""desc"":""Channels___:___120"",""plan_name"":""Kerala___Mega___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_5192""},""desc"":""Channels___:___136___and___Day___360"",""plan_name"":""Karnataka___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5224"",""_1MONTHS"":""_475"",""_3___MONTHS"":""_1424"",""_6___MONTHS"":""_2849""},""desc"":""Channels___:___134___\/___RS___1424___:___97___DAYS___\/___RS___2849___:___195___DAYS___\/___RS___5224___:___360___DAY"",""plan_name"":""AP___My___Family___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5226"",""_1MONTHS"":""_475"",""_3___MONTHS"":""_1426"",""_6___MONTHS"":""_2851""},""desc"":""Channels___:___107___\/___RS___1426___:___97___DAYS___\/___RS___2851___:___195___DAY___\/___RS___5226___:___360___DAY"",""plan_name"":""AP___Value___Plus___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5258"",""_1MONTHS"":""_478"",""_3___MONTHS"":""_1434"",""_6___MONTHS"":""_2868""},""desc"":""Channels___:___120___\/___RS___1434___:___97___DAYS___\/___RS___2868___:___195___DAYS___\/___RS___5258___:___360___DAYS"",""plan_name"":""WB___Value___Sports___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5283"",""_1MONTHS"":""_483"",""_6___MONTHS"":""_2883""},""desc"":""Channels___:___118___\/___RS___2883___:___195___DAYS___\/___RS___5283___:___360___DAYS"",""plan_name"":""Hindi___Value___Sports___lite___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5334""},""desc"":""Channels___:___145___and___Day___360"",""plan_name"":""WB___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5336""},""desc"":""Channels___:___149___and___Day___360"",""plan_name"":""Hindi___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5337""},""desc"":""Channels___:___154___and___Day___360"",""plan_name"":""Gujarat___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5338""},""desc"":""Channels___:___151___and___Day___360"",""plan_name"":""MAH___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_544""},""desc"":""Channels___:___118"",""plan_name"":""Karnataka___My___Family___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_5446""},""desc"":""Channels___:___139___and___Day___360"",""plan_name"":""AP___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5447"",""_1MONTHS"":""_496"",""_3___MONTHS"":""_1487"",""_6___MONTHS"":""_2974""},""desc"":""Channels___:___124___\/___RS___1487___:___97___DAYS___\/___RS___2974___:___195___DAY___\/___RS___5447___:___360___DAYS"",""plan_name"":""Hindi___Value___Sports___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5501""},""desc"":""Channels___:___113___and___Day___360"",""plan_name"":""TN___My___Family___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5533"",""_6___MONTHS"":""_3894""},""desc"":""Channels___:___152___\/___RS___5533___ME___Day___360___\/___RS___3894___ME___195___DAYS___Channels___:___160___\/"",""plan_name"":""Orissa___Mega"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_562""},""desc"":""Channels___:___138"",""plan_name"":""WB___My___Family___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_5698""},""desc"":""Channels___:___137___and___Day___360"",""plan_name"":""Hindi___My___Family___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5709""},""desc"":""Channels___:___120___and___Day___360"",""plan_name"":""Kerala___Mega___12M___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_5984""},""desc"":""Channels___:___118___and___Day___360"",""plan_name"":""Karnataka___My___Family___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6052""},""desc"":""Channels___:___146___and___Day___360"",""plan_name"":""Gujarat___My___Family___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6272""},""desc"":""Channels___:___135___and___Day___360"",""plan_name"":""MAH___My___Family___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6316""},""desc"":""Channels___:___144___and___Day___360"",""plan_name"":""Orissa___My___Family___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6424""},""desc"":""Channels___:___132___and___Day___360"",""plan_name"":""AP___My___Family___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_649""},""desc"":""Channels___:___160"",""plan_name"":""Orissa___Mega___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1___YEAR"":""_6711""},""desc"":""Channels___:___140___and___Day___360"",""plan_name"":""TN___Mega___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6787""},""desc"":""Channels___:___142___and___Day___360"",""plan_name"":""Karnataka___Mega___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6876""},""desc"":""Channels___:___157\/Day___:___360"",""plan_name"":""Hindi___Mega___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_6877""},""desc"":""Channels___:___162\/Day___:___360"",""plan_name"":""Gujarat___Mega___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_7007""},""desc"":""Channels___:___152\/Day___:___360"",""plan_name"":""WB___Mega___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_7106""},""desc"":""Channels___:___145\/Day___:___360"",""plan_name"":""AP___Mega___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_7139""},""desc"":""Channels___:___160\/Day___:___360"",""plan_name"":""Orissa___Mega___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1___YEAR"":""_7141""},""desc"":""Channels___:___159\/Day___:___360"",""plan_name"":""MAH___Mega___12M___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_88.50""},""desc"":""_15___channels___"",""plan_name"":""Star___All___South___Value"",""last_update"":""06-07-2020""}],""Add-On___Pack"":[{""rs"":{"""":""""},""desc"":""Channels___:___10"",""plan_name"":""Sony___Bouquet___6___-___Happy___India___Bangla"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""0.59""},""desc"":""Channels___:___2"",""plan_name"":""TV___Today___Hindi___News___Bouquet___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_1.18""},""desc"":""Channels___:___3"",""plan_name"":""TV___Today___TVTN___News___Bouquet___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_1.18""},""desc"":""Channels___:___2"",""plan_name"":""TV___today___Hindi___News___HD___Bouquet___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_1.77""},""desc"":""Channels___:___3"",""plan_name"":""TV___today___News___HD___Bouquet___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_10.62""},""desc"":""Channels___:___4"",""plan_name"":""SVP___Lite___Hindi___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_10.62""},""desc"":""Channels___:___5"",""plan_name"":""Discovery___HD___Bouquet___3___-___INFOTAINMENT___+___SPORTS___HD___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_10.62""},""desc"":""Channels___:___6"",""plan_name"":""Discovery___HD___Bouquet___4___-___INFOTAINMENT___HIGH___DEFINITION___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___25"",""plan_name"":""Zee___All-in-1___Pack___All___South___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___16"",""plan_name"":""SVP___HD___Hindi"",""last_update"":""01-01-1970""},{""rs"":{"""":""_100.3""},""desc"":""Channels___:___17"",""plan_name"":""SVP___HD___Marathi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___29"",""plan_name"":""Zee___All-in-1___Pack___Hindi___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___18"",""plan_name"":""SVP___HD___Bengali"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___13"",""plan_name"":""SPP___HD___English___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___10"",""plan_name"":""SVP___HD___Kannada-Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___12"",""plan_name"":""SVP___HD___Telugu-___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___12"",""plan_name"":""SVP___HD___Tamil-Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___11"",""plan_name"":""SVP___HD___Tamil-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_100.3""},""desc"":""Channels___:___11"",""plan_name"":""SVP___HD___Kannada-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_101.24""},""desc"":""Channels___:___13"",""plan_name"":""Sony___Bouquet___26___-___Happy___India___Platinum___HD___(A)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_101.36""},""desc"":""Channels___:___14"",""plan_name"":""Sony___Bouquet___24___-___Happy___India___Platinum___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_101.36""},""desc"":""Channels___:___14"",""plan_name"":""Sony___Bouquet___25___-___Happy___India___Bangla___Platinum___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_104.9""},""desc"":""Channels___:___15"",""plan_name"":""Sony___Bouquet___27-Happy___India___Platinum___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_105.02""},""desc"":""Channels___:___24"",""plan_name"":""SPP___Bengali-Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_105.02""},""desc"":""Channels___:___17"",""plan_name"":""SPP___Tamil-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_105.02""},""desc"":""Channels___:___17"",""plan_name"":""SPP___Kannada-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_106.2""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All-in-1___Pack___Odia___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_106.2""},""desc"":""Channels___:___21"",""plan_name"":""Zee___Family___Pack___All___South___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_106.2""},""desc"":""Channels___:___24"",""plan_name"":""Zee___Family___Marathi___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___5"",""plan_name"":""Turner___Family___Pack___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___9"",""plan_name"":""Zee___Prime___Pack___Tamil___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___4"",""plan_name"":""Disney___Kids___Pack___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___8"",""plan_name"":""Discovery___HD___Bouquet___2___-___BASIC___INFOTAINMENT___HD___pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___9"",""plan_name"":""Discovery___HD___Bouquet___1___-___BASIC___INFOTAINMENT___(Tamil)___HD___pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_11.8""},""desc"":""Channels___:___4"",""plan_name"":""Disney___Kids___Bouquet"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___25"",""plan_name"":""Zee___All-in-1___Pack___Bangla___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All-in-1___Pack___Tamil___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___17"",""plan_name"":""SVP___HD___All___South___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___25"",""plan_name"":""SPP___Hindi-Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___19"",""plan_name"":""SVP___HD___Hindi-Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___19"",""plan_name"":""SVP___HD___Marathi-___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___24"",""plan_name"":""SPP___Hindi-___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___25"",""plan_name"":""SPP___Marathi-___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___18"",""plan_name"":""SVP___HD___Hindi-___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___18"",""plan_name"":""SVP___HD___Hindi-___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___24"",""plan_name"":""SPP___Hindi-___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___26"",""plan_name"":""SPP___Hindi-___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___20"",""plan_name"":""SVP___HD___Hindi-___Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_112.1""},""desc"":""Channels___:___26"",""plan_name"":""SPP___Hindi-___Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_113""},""desc"":""Channels___:___21"",""plan_name"":""Airtel___Tamil___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_114""},""desc"":""Channels___:___13"",""plan_name"":""Airtel___Kannada___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_114""},""desc"":""Channels___:___15"",""plan_name"":""Airtel___Hindi___Movies___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_118""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All-in-1___Pack___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_118""},""desc"":""Channels___:___25"",""plan_name"":""Zee___All-in-1___Pack___Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_123.9""},""desc"":""Channels___:___26"",""plan_name"":""Zee___All-in-1___Pack___Marathi___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___23"",""plan_name"":""Sun___HD___bouquet___13___Sun___Ultimate___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___16"",""plan_name"":""SPP___HD___Tamil"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___16"",""plan_name"":""SPP___HD___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___23"",""plan_name"":""SPP___All___South___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___"",""plan_name"":""SPP___HD___Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___25"",""plan_name"":""Zee___All___in___1___Tamil___Kannada___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___18"",""plan_name"":""SPP___HD___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___26"",""plan_name"":""Zee___All___in___1___Tamil___Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___26"",""plan_name"":""Zee___All___in___1___Odia___Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_129.8""},""desc"":""Channels___:___26"",""plan_name"":""Zee___All___in___1___Telugu___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_134""},""desc"":""Channels___"",""plan_name"":""Airtel___Kannada___regional___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_135""},""desc"":""Channels___:___20"",""plan_name"":""Airtel___Telugu___Regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_14.16""},""desc"":""Channels___:___2"",""plan_name"":""Sony___Bouquet___17___-___Happy___India___English"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_14.75""},""desc"":""Channels___:___5"",""plan_name"":""Turner___Family___HD___Pack___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___25"",""plan_name"":""SPP___HD___Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___26"",""plan_name"":""SPP___HD___Marathi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___19"",""plan_name"":""SPP___HD___Bengali"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___18"",""plan_name"":""SPP___HD___Kannada-Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___27"",""plan_name"":""Zee___All-in-1___Pack___All___South___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___27"",""plan_name"":""Zee___All___in___1___Marathi___KannadaHD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""hannels___:___20"",""plan_name"":""SPP___HD___Telugu-___Kannada___C"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___20"",""plan_name"":""SPP___HD___Tamil-Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___19"",""plan_name"":""SPP___HD___Tamil-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_141.6""},""desc"":""Channels___:___19"",""plan_name"":""SPP___HD___Kannada-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_145""},""desc"":""Channels___:___15"",""plan_name"":""Airtel___Main___Hindi___Entertainment___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_15.34""},""desc"":""Channels___:___7"",""plan_name"":""Times___Bouquet___2___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_153.4""},""desc"":""Channels___:___28"",""plan_name"":""SPP___HD___Marathi-___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_153.4""},""desc"":""Channels___:___27"",""plan_name"":""SPP___HD___Hindi-___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_153.4""},""desc"":""Channels___:___27"",""plan_name"":""SPP___HD___Hindi-___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_159""},""desc"":""Channels___:___11"",""plan_name"":""Airtel___English___Movies___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_159""},""desc"":""Channels___:___21"",""plan_name"":""Airtel___Tamil___regional___HD___topup___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_159.3""},""desc"":""Channels___:___25"",""plan_name"":""Star___Hindi___Telugu___HD___Premium"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_159.3""},""desc"":""Channels___:___23"",""plan_name"":""Star___Hindi___Malayalam___HD___Premium"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_159.3""},""desc"":""Channels___:___27"",""plan_name"":""SPP___HD___Bengali-Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_159.3""},""desc"":""Channels___:___28"",""plan_name"":""SPP___HD___Hindi-Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_159.3""},""desc"":""Channels___:___29"",""plan_name"":""SPP___HD___Hindi-___Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_166""},""desc"":""Channels___:___15"",""plan_name"":""Airtel___Hindi___Entertainment___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___13"",""plan_name"":""Colors___wala___Telugu___Value___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___13"",""plan_name"":""Colors___wala___Tamil___Value___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___3"",""plan_name"":""Star___English___Mini"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___4"",""plan_name"":""Zee___Prime___Pack___English___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___3"",""plan_name"":""SVP___Lite___English___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___9"",""plan_name"":""Colors-___North___East___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___12"",""plan_name"":""Colors-___North___East___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_17.7""},""desc"":""Channels___:___14"",""plan_name"":""Colors___wala___Kerala___Value___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_171.1""},""desc"":""Channels___:___25"",""plan_name"":""SPP___HD___All___South___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_18.05""},""desc"":""Channels___:___4"",""plan_name"":""Tarang___Bouquet___1___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_18.88""},""desc"":""Channels___:___12"",""plan_name"":""Colors-___Telugu___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_18.88""},""desc"":""Channels___:___12"",""plan_name"":""Colors-___Tamil___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_18.88""},""desc"":""Channels___:___13"",""plan_name"":""Colors-___Kerala___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_189""},""desc"":""Channels___:___20"",""plan_name"":""Airtel___Telugu___Regional___HD___topup___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_19""},""desc"":""Channels___:___16"",""plan_name"":""All___English___News___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_2.95""},""desc"":""Channels___:___2"",""plan_name"":""NDTV___South___Info"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_20""},""desc"":""Channels___:___17"",""plan_name"":""All___English___News___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_20.05""},""desc"":""Channels___:___4"",""plan_name"":""Sony___Bouquet___12___-___Happy___India___Football"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_20.06""},""desc"":""Channels___:___9"",""plan_name"":""Zee___Prime___Pack___Kannada___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_22.42""},""desc"":""Channels___:___4"",""plan_name"":""Sony___Bouquet___11___-___Happy___India___South"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_23.1""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Prime___Pack___Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_23.6""},""desc"":""Channels___:___2"",""plan_name"":""Sony___Bouquet___22___-___Happy___India___English___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_23.6""},""desc"":""Channels___:___9"",""plan_name"":""Times___bouquet___3___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_23.6""},""desc"":""Channels___:___5"",""plan_name"":""Sun___SD___bouquet___10___Kerala___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_23.60""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Super___Pack___Tamil___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_25.96""},""desc"":""Channels___:___19"",""plan_name"":""Colors___wala___Hindi___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_25.96""},""desc"":""Channels___:___17"",""plan_name"":""Colors___wala___Gujrat___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_25.96""},""desc"":""___Channels___:___18"",""plan_name"":""Colors___wala___Bengal___Budget___Plus"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_25.96""},""desc"":""Channels___:___15"",""plan_name"":""Colors-___Marathi___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_25.96""},""desc"":""Channels___:___15"",""plan_name"":""Colors___wala___Odia___Budget___Plus"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_28.32""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Super___Pack___Kannada___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_28.32""},""desc"":""Channels___:___7"",""plan_name"":""ETV___Bouquet___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29""},""desc"":""Channels___:___2"",""plan_name"":""English___Entertainment___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___5"",""plan_name"":""Sony___Bouquet___28___-___Happy___India___South"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___13"",""plan_name"":""Zee___Prime___Pack___Odia-Bangla___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""___Channels___:___12"",""plan_name"":""Zee___Prime___Pack___Odia-Telugu___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___5"",""plan_name"":""Star___English___Mini___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""___Channels___:___10"",""plan_name"":""Zee___Prime___Pack___Tamil___Kannada"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Prime___Pack___Tamil-Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___8"",""plan_name"":""SVP___Tamil"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___9"",""plan_name"":""Zee___Prime___Pack___Tamil___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___9"",""plan_name"":""Zee___Prime___Pack___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___5"",""plan_name"":""SVP___HD___Lite___English___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___5"",""plan_name"":""Zee___Prime___Pack___English___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___22"",""plan_name"":""Colors___wala___Hindi___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___13"",""plan_name"":""Colors-___Karnataka___Budget___Plus"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___20"",""plan_name"":""Colors___wala___Gujarat___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___21"",""plan_name"":""Colors___wala___Bengal___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___18"",""plan_name"":""Colors-___Maharashtra___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_29.5""},""desc"":""Channels___:___18"",""plan_name"":""Colors___wala___Odia___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_3.24""},""desc"":""Channels___:___2"",""plan_name"":""NDTV___South___Life"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_3.54""},""desc"":""Channels___:___3"",""plan_name"":""NDTV___North___Info"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_3.83""},""desc"":""Channels___:___3"",""plan_name"":""NDTV___South"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_3.83""},""desc"":""Channels___:___3"",""plan_name"":""NDTV___North___Life"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_30.68""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Super___Pack___Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_31.86""},""desc"":""Channels___:___14"",""plan_name"":""Colors-___Telugu___Value___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_31.86""},""desc"":""Channels___:___14"",""plan_name"":""Colors___wala___Tamil___Value___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_31.86""},""desc"":""Channels___:___9"",""plan_name"":""Colors-NorthEast___Budget___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_31.86""},""desc"":""Channels___:___13"",""plan_name"":""Colors-North___East___Value___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_31.86""},""desc"":""Channels___:___15"",""plan_name"":""Colors___wala___Kerala___Value___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_33.04""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Prime___Pack___Telugu___Kannada___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_33.15""},""desc"":""Channels___:___3"",""plan_name"":""Sony___Bouquet___15___-___Happy___India___Sports"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35""},""desc"":""Channels___:___11"",""plan_name"":""Airtel___all___Kids___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___6"",""plan_name"":""Sun___SD___bouquet___4___Telugu___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___5"",""plan_name"":""Sun___SD___bouquet___7___Kannada___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___11"",""plan_name"":""Star___Kannada___Tamil___Value"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___5"",""plan_name"":""Sun___HD___bouquet___10___Kerala___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___8"",""plan_name"":""SVP___Kannada___(A)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___8"",""plan_name"":""SVP___Kannada___(B)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___9"",""plan_name"":""SVP___Kannada___(C)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___10"",""plan_name"":""SVP___Kannada-Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___13"",""plan_name"":""Zee___Prime___Pack___Odia-Bangla___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""___Channels___:___24"",""plan_name"":""Colors___wala___Hindi___Family"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___21"",""plan_name"":""Colors-___Karnataka___Value___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___29"",""plan_name"":""Colors___wala___Gujarat___Family___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___28"",""plan_name"":""Colors___wala___Bengal___Family___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___27"",""plan_name"":""Colors___wala___Maharashtra___Family___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.4""},""desc"":""Channels___:___27"",""plan_name"":""Colors___wala___Odia___Family___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.99""},""desc"":""Channels___:___7"",""plan_name"":""Sony___Bouquet___2___-___Happy___India___(A)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.99""},""desc"":""Channels___:___6"",""plan_name"":""Bouquet___3___-___Happy___India___(B)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.99""},""desc"":""Channels___:___8"",""plan_name"":""Sony___Bouquet___1___-___Happy___India"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_35.99""},""desc"":""Channels___:___8"",""plan_name"":""Sony___Bouquet___4___-___Happy___India___Bangla"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_37.76""},""desc"":""Channels___:___19"",""plan_name"":""Colors-___Hindi___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_37.76""},""desc"":""Channels___:___18"",""plan_name"":""Colors-___Bengal___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_37.76""},""desc"":""Channels___:___15"",""plan_name"":""Colors-___Marathi___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_37.76""},""desc"":""Channels___:___15"",""plan_name"":""Colors___wala___Odia___Budget___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_37.96""},""desc"":""Channels___:___17"",""plan_name"":""Colors-___Gujarat___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_38""},""desc"":""Channels___:___3"",""plan_name"":""English___Movies___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_38""},""desc"":""Channels___:___2"",""plan_name"":""Bengali___GEC___+___Movies___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_38.35""},""desc"":""Channels___:___8"",""plan_name"":""Sony___Bouquet___14___-___Happy___India___South___Football"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_4.13""},""desc"":""Channels___:___4"",""plan_name"":""NDTV___Ultra"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_40""},""desc"":""Channels___:___2"",""plan_name"":""English___Movies___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_40.12""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Prime___Pack___All___South___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_40.71""},""desc"":""Channels___:___8"",""plan_name"":""Sony___Bouquet___13___-___Happy___India___South___Platinum"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41""},""desc"":""Channels___:___6"",""plan_name"":""Airtel___Mini___Bengali___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41""},""desc"":""Channels___:___2"",""plan_name"":""Telugu___Movies___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41""},""desc"":""Channels___:___2"",""plan_name"":""Telugu___GEC___+___Movies___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___8"",""plan_name"":""Sun___SD___bouquet___11___Kerala___Prime"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""___Channels___:___11"",""plan_name"":""Zee___Super___Pack___Tamil___Kannada"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Super___Pack___Tamil-Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Super___Pack___Telugu___Kannada___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___8"",""plan_name"":""SVP___HD___Lite___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Super___Pack___Tamil___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Super___Pack___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Prime___Pack___Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Prime___Pack___Odia-Telugu___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___23"",""plan_name"":""Colors___wala___Hindi___Value___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___21"",""plan_name"":""Colors-___Hindi___Value___Plus___HD(A)___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___32"",""plan_name"":""Colors___wala___Karnataka___Family___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___21"",""plan_name"":""Colors-___Gujarat___Value___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___22"",""plan_name"":""Colors-___Bengal___Value___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___20"",""plan_name"":""Colors-___Bengal___Value___Plus___HD___A___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_41.3""},""desc"":""Channels___:___19"",""plan_name"":""Colors___wala___Odia___Value___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_42""},""desc"":""Channels___:___2"",""plan_name"":""Star___Sports___1___Hindi___and___Ten___3___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_42""},""desc"":""Channels___:___2"",""plan_name"":""Airtel___Sports___HD___Hindi___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_42""},""desc"":""Channels___:___2"",""plan_name"":""Hindi___Movies___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_42""},""desc"":""Channels___:___5"",""plan_name"":""Infotainment___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_42""},""desc"":""Channels___:___2"",""plan_name"":""Hindi___Sports___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_42.83""},""desc"":""Channels___:___4"",""plan_name"":""Sony___Bouquet___16___-___Happy___India___Sports"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_43""},""desc"":""Channels___:___3"",""plan_name"":""Hindi___Movies___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_43.66""},""desc"":""Channels___:___16"",""plan_name"":""Zee___Family___Pack___Tamil___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Marathi___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Star___Sports___1___and___Ten___1___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Hindi___Entertainment___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Hindi___Entertainment___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Tamil___GEC___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Tamil___GEC___+___Movies___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Tamil___GEC___+___Movies___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Telugu___GEC___Mini___HD___Topup___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Telugu___GEC___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Telugu___GEC___+___Movies___Mini___HD___Topup___2"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Kannada___GEC___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Malayalam___GEC___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""English___Sports___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_44""},""desc"":""Channels___:___2"",""plan_name"":""Bengali___GEC___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_45.43""},""desc"":""Channels___:___9"",""plan_name"":""Bouquet___7___-___Happy___India___(A)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_45.43""},""desc"":""Channels___:___10"",""plan_name"":""Sony___Bouquet___5___-___Happy___India"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Oriya___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___24"",""plan_name"":""Zee___Family___Pack___Hindi___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___21"",""plan_name"":""Zee___Family___Pack___Marathi___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___20"",""plan_name"":""Zee___Family___Pack___Bangla___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___19"",""plan_name"":""Zee___Family___Pack___Odia___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___13"",""plan_name"":""Star___Telugu___Kannada___Value"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___9"",""plan_name"":""SVP___Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___10"",""plan_name"":""SVP___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___14"",""plan_name"":""Colors-___Kannada___Budget___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___19"",""plan_name"":""Colors-___Marathi___Value___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.02""},""desc"":""Channels___:___12"",""plan_name"":""Colors-___Marathi___Value___PlusHD___A___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_46.2""},""desc"":""___Channels___:___12"",""plan_name"":""SVP___Telugu-___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47""},""desc"":""Channels___:___12"",""plan_name"":""Airtel___Kids___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_47""},""desc"":""Channels___:___3"",""plan_name"":""English___Movies___+___Entertainment___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_47""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Oriya___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___7"",""plan_name"":""Sun___SD___bouquet___1___Tamil___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___8"",""plan_name"":""Sun___SD___bouquet___5___Telugu___Prime___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___12"",""plan_name"":""Star___Kannada___Malayalam___Value"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___8"",""plan_name"":""SVP___HD___Lite___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___10"",""plan_name"":""Zee___Prime___Pack___Tamil___KannadaHD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Prime___Pack___Tamil-Telugu___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___11"",""plan_name"":""SVP___Kannada-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_47.2""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Prime___Telugu___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_49""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___English___Entertainment___SD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_5.02""},""desc"":""Channels___:___2"",""plan_name"":""Turner___Kids___pack___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_5.77""},""desc"":""Channels___:___4"",""plan_name"":""Raj___Bouquet___1"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_5.9""},""desc"":""Channels___:___4"",""plan_name"":""Times___Bouquet___1___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_50.26""},""desc"":""Channels___:___3"",""plan_name"":""Sony___Bouquet___20___-___Happy___India___Sports___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_52""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Marathi___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_52.39""},""desc"":""Channels___:___6"",""plan_name"":""Sony___Bouquet___18___-___Happy___India___Sports___+___English"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""___Channels___:___16"",""plan_name"":""Zee___Family___Pack___Kannada___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""___Channels___:___9"",""plan_name"":""Sun___SD___bouquet___2___Tamil___Prime"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""Channels___:___17"",""plan_name"":""Zee___Family___Pack___Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""Channels___:___13"",""plan_name"":""Zee___Super___Pack___All___South___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""Channels___:___8"",""plan_name"":""Sun___SD___bouquet___8___Kannada___Prime___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""___Channels___:___11"",""plan_name"":""Sun___SD___bouquet___12___Kerala___Super"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Super___Pack___Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_53.1""},""desc"":""Channels___:___12"",""plan_name"":""SVP___Tamil-Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_54""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Malayalam___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_54""},""desc"":""Channels___:___9"",""plan_name"":""Airtel___Hindi___Movies___1M___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_54""},""desc"":""Channels___:___3"",""plan_name"":""Hindi___Movies___+___Entertainment___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_54.75""},""desc"":""Channels___:___6"",""plan_name"":""Sony___Bouquet___23___-___Happy___India___Sports___+___English___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_55""},""desc"":""Channels___:___5"",""plan_name"":""English___Movies___+___Infotainment___Mini___HD___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___15"",""plan_name"":""Star___Hindi___Kannada___Value"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___16"",""plan_name"":""Star___Marathi___Kannada___Value"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___15"",""plan_name"":""SVP___Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___16"",""plan_name"":""SVP___Marathi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___18"",""plan_name"":""SVP___Marathi-___Kannada___A___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___15"",""plan_name"":""SVP___Bengali"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___17"",""plan_name"":""SVP___Hindi-___Kannada___A___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___10"",""plan_name"":""SVP___HD___Lite___Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___9"",""plan_name"":""SVP___HD___Lite___Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___11"",""plan_name"":""SPP___English___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""Channels___:___11"",""plan_name"":""SVP___Tamil-Malayalam___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_57.82""},""desc"":""hannels___:___18"",""plan_name"":""SVP___Marathi-___Kannada___C"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Super___Channels___:___11"",""plan_name"":""Sun___SD___bouquet___3___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""___Channels___:___11"",""plan_name"":""Sun___SD___bouquet___6___Telugu___Super"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___10"",""plan_name"":""Sun___SD___bouquet___9___Kannada___Super___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""___Channels___:___5"",""plan_name"":""Sun___HD___bouquet___7___Kannada___Basic"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Prime___Pack___All___South___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___11"",""plan_name"":""Zee___Super___Pack___Tamil___KannadaHD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Super___Pack___Tamil-Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___12"",""plan_name"":""Zee___Super___Telugu___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___25"",""plan_name"":""Colors-___Hindi___Family___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___22"",""plan_name"":""Colors-___Kannada___Value___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___30"",""plan_name"":""Colors-___Gujarat___Family___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___29"",""plan_name"":""Colors-___Bengal___Family___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___28"",""plan_name"":""Colors-___Marathi___Family___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_59""},""desc"":""Channels___:___28"",""plan_name"":""Colors___wala___Odia___Family___PlusHD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_6.52""},""desc"":""Channels___:___6"",""plan_name"":""Raj___Bouquet___2"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_60""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Marathi___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_60.18""},""desc"":""Channels___:___17"",""plan_name"":""SVP___Bengali-Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_63""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Malayalam___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_63.48""},""desc"":""Channels___:___4"",""plan_name"":""Sony___Bouquet___21___-___Happy___India___SPORTS___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_64.9""},""desc"":""Channels___:___17"",""plan_name"":""Zee___Family___Pack___Tamil___Kannada___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_64.9""},""desc"":""Channels___:___18"",""plan_name"":""Zee___Family___Pack___Tamil___Telugu___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_64.9""},""desc"":""___Channels___:___18"",""plan_name"":""Zee___Family___Pack___Telugu___Kannada"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_64.9""},""desc"":""Channels___:___19"",""plan_name"":""SVP___Hindi-___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_64.9""},""desc"":""Channels___:___17"",""plan_name"":""SVP___Hindi-___Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_66""},""desc"":""Channels___:___6"",""plan_name"":""Airtel___Mini___Bengali___regional___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_67""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Bengali___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_68.79""},""desc"":""Channels___:___10"",""plan_name"":""Sony___Bouquet___19___-___Happy___India___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___27"",""plan_name"":""Zee___All-in-1___Pack___Hindi___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All-in-1___Pack___Marathi___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___23"",""plan_name"":""Zee___All-in-1___Pack___Bangla___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___22"",""plan_name"":""Zee___All-in-1___Pack___Odia___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___23"",""plan_name"":""Zee___Family___Marathi___Kannada___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___22"",""plan_name"":""Zee___Family___Pack___Odia-Telugu___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___15"",""plan_name"":""SVP___HD___Lite___Bengali___Sports___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___15"",""plan_name"":""SVP___HD___Lite___Bengali___GEC___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___16"",""plan_name"":""SVP___HD___Lite___Marathi___Sports___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___16"",""plan_name"":""SVP___HD___Lite___Marathi___GEC___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___15"",""plan_name"":""SVP___HD___Lite___Hindi___Sports"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___15"",""plan_name"":""SVP___HD___Lite___Hindi___GEC"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_69.62""},""desc"":""Channels___:___18"",""plan_name"":""SVP___Hindi-Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_7""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___Gujarati___Regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_7""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___Gujarati___Regional___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_7.08""},""desc"":""Channels___:___5"",""plan_name"":""Times___bouquet___4___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_7.08""},""desc"":""Channels___:___4"",""plan_name"":""Discovery___Bouquet___4___Kids___Infotainment___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_7.08""},""desc"":""Channels___:___5"",""plan_name"":""Discovery___SD___Bouquet___8___-___KIDS___INFOTAINMENT___(TAMIL)___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_7.08""},""desc"":""Channels___:___4"",""plan_name"":""Jaya___Bouquet___1"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_70""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___mini___Tamil___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_70""},""desc"":""Channels___:___9"",""plan_name"":""Airtel___Malayalam___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_70.8""},""desc"":""Channels___:___6"",""plan_name"":""Sun___HD___bouquet___4___Telugu___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_70.8""},""desc"":""Channels___:___25"",""plan_name"":""Zee___Family___Pack___Hindi___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_70.8""},""desc"":""Channels___:___13"",""plan_name"":""Zee___Super___Pack___All___South___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_70.8""},""desc"":""Channels___:___33"",""plan_name"":""Colors-___Kannada___Family___Plus___HD___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_76""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___English___Movies___Mini___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_76.7""},""desc"":""Channels___:___19"",""plan_name"":""Zee___Family___Pack___All___South___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_76.7""},""desc"":""Channels___:___23"",""plan_name"":""Sun___SD___bouquet___13___Sun___Ultimate___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_76.7""},""desc"":""Channels___:___20"",""plan_name"":""Zee___Family___Pack___Odia___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_76.7""},""desc"":""Channels___:___18"",""plan_name"":""Zee___Family___Pack___Tamil___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_77.88""},""desc"":""Channels___:___22"",""plan_name"":""Zee___All-in-1___Pack___Tamil___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_77.88""},""desc"":""Channels___:___22"",""plan_name"":""Zee___All-in-1___Pack___Kannada___SD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_77.88""},""desc"":""Channels___:___23"",""plan_name"":""Zee___All-in-1___Pack___Telugu___SD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_78.11""},""desc"":""Channels___:___13"",""plan_name"":""Sony___Bouquet___10___-___Happy___India___Platinum___(A)"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_78.23""},""desc"":""Channels___:___14"",""plan_name"":""Sony___Bouquet___9___-___Happy___India___BANGLA___Platinum"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_78.23""},""desc"":""Channels___:___14"",""plan_name"":""Sony___Bouquet___8___-___Happy___India___Platinum"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_8.26""},""desc"":""Channels___:___5"",""plan_name"":""Discovery___Bouquet___2___Infotainment___+___Sports___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_8.26""},""desc"":""Channels___:___6"",""plan_name"":""Discovery___Bouquet___6___Basik___Infotainment___Sports___(Tamil)___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_8.26""},""desc"":""Channels___:___6"",""plan_name"":""Discovery___SD___Bouquet___3___-___INFOTAINMENT___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_8.26""},""desc"":""Channels___:___7"",""plan_name"":""Discovery___SD___Bouquet___7___-___INFOTAINMENT___(TAMIL)___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_81""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___mini___Tamil___regional___HD___topup___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_81.42""},""desc"":""Channels___:___14"",""plan_name"":""SPP___Tamil"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_81.42""},""desc"":""Channels___:___14"",""plan_name"":""SPP___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_81.42""},""desc"":""Channels___:___14"",""plan_name"":""SPP___Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_81.42""},""desc"":""Channels___:___16"",""plan_name"":""SPP___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_81.77""},""desc"":""Channels___:___11"",""plan_name"":""Sony___bouquet___29___Happy___India___HD"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_82""},""desc"":""Channels___:___10"",""plan_name"":""Airtel___Malayalam___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___7"",""plan_name"":""Sun___HD___bouquet___1___Tamil___Basic___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___8"",""plan_name"":""Sun___HD___bouquet___8___Kannada___Prime___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___8"",""plan_name"":""Sun___HD___bouquet___11___Kerala___Prime___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___21"",""plan_name"":""Zee___Family___Pack___Bangla___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___18"",""plan_name"":""Zee___Family___Pack___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_82.6""},""desc"":""Channels___:___19"",""plan_name"":""Zee___Family___Pack___Telugu___HD"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_84""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___English___Movies___SD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_86""},""desc"":""Channels___:___7"",""plan_name"":""Airtel___Mini___Kannada___regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_87""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Telugu___Regional___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_87""},""desc"":""Channels___:___6"",""plan_name"":""Airtel___English___Entertainment___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_88""},""desc"":""Channels___:___5"",""plan_name"":""Airtel___Mini___Telugu___Regional___HD___topup___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___9"",""plan_name"":""Sun___HD___bouquet___2___Tamil___Prime___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___8"",""plan_name"":""Sun___HD___bouquet___5___Telugu___Prime"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___8"",""plan_name"":""SVP___HD___Tamil"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___8"",""plan_name"":""SVP___HD___Kannada"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___17"",""plan_name"":""SVP___All___South___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___9"",""plan_name"":""SVP___HD___Malayalam"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_88.5""},""desc"":""Channels___:___10"",""plan_name"":""SVP___HD___Telugu"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_89""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___Mini___Hindi___Entertainment___Topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_89""},""desc"":""Channels___:___4"",""plan_name"":""Airtel___Hindi___Entertainment___Mini___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_89""},""desc"":""Channels___:___7"",""plan_name"":""Airtel___Mini___Kannada___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_89""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Marathi___regional___HD___topup"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_89.68""},""desc"":""Channels___:___23"",""plan_name"":""Zee___All___in___1___Pack___Tamil___Kannad___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_89.68""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All___in___1___Pack___Tamil___Telugu___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_89.68""},""desc"":""Channels___:___24"",""plan_name"":""Zee___All___in___1___Telugu___Kannada"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""Channels___:___11"",""plan_name"":""Colors___wala___Telugu___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""___Channels___:___11"",""plan_name"":""Colors___wala___Tamil___Budget___Plus"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""Channels___:___8"",""plan_name"":""Discovery___Bouquet___1___Basic___Infortainment___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""Channels___:___9"",""plan_name"":""Discovery___Bouquet___5___Basic___Infotainment___(Tamil)___Pack"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""Channels___:___4"",""plan_name"":""HD___Bouquet___5___-___KIDS___INFOTAINMENT___HIGH___DEFINITION___PACK"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_9.44""},""desc"":""Channels___:___12"",""plan_name"":""Colors___wala___Kerala___Budget___Plus___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_91""},""desc"":""Channels___:___8"",""plan_name"":""Airtel___Bengali___regional___HD___topup"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_93""},""desc"":""Channels___:___9"",""plan_name"":""Airtel___Hindi___Movies___Mini___HD___topup___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___25"",""plan_name"":""Zee___All___in___1___Marathi___Kannada___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""___Channels___:___24"",""plan_name"":""Zee___All___in___1___Pack___Odia___Telugu"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___22"",""plan_name"":""SPP___Hindi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___23"",""plan_name"":""SPP___Marathi"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___17"",""plan_name"":""SPP___Bengali"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___16"",""plan_name"":""SPP___Kannada-Tamil___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___18"",""plan_name"":""SPP___Telugu-___Kannada___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_93.22""},""desc"":""Channels___:___18"",""plan_name"":""SPP___Tamil-Telugu___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___11"",""plan_name"":""Sun___HD___bouquet___3___Tamil___Super___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___11"",""plan_name"":""Sun___HD___bouquet___6___Telugu___Super___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___10"",""plan_name"":""Sun___HD___bouquet___9___Kannada___Super___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___11"",""plan_name"":""Sun___HD___bouquet___12___Kerala___Super___"",""last_update"":""01-01-1970""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___22"",""plan_name"":""Zee___Family___Pack___Marathi___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___19"",""plan_name"":""Zee___Family___Tamil___Kannada___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___20"",""plan_name"":""Zee___Family___Pack___Tamil___TeluguHD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___23"",""plan_name"":""Zee___Family___Pack___Odia-Telugu___HD___"",""last_update"":""06-07-2020""},{""rs"":{""_1MONTHS"":""_94.4""},""desc"":""Channels___:___20"",""plan_name"":""Zee___Family___Telugu___Kannada___HD___"",""last_update"":""06-07-2020""}]},""status"":1}";
                        resp = strurl.CallURL();
                        resp = resp.Replace(@"""""", @"""___0""");
                        resp = resp.Replace("RATE CUTTER", "RATE_CUTTER");
                        resp = resp.Replace(@"3G\/ 4G", "_3GOr4G");
                        resp = resp.Replace(@"3G\/4G", "_3GOr4G");
                        resp = resp.Replace(@"""1 M", @"""_1M");
                        resp = resp.Replace(@"""1", @"""_1");
                        resp = resp.Replace(@"""2", @"""_2");
                        resp = resp.Replace(@"""3", @"""_3");
                        resp = resp.Replace(@"""4", @"""_4");
                        resp = resp.Replace(@"""5", @"""_5");
                        resp = resp.Replace(@"""6", @"""_6");
                        resp = resp.Replace(@"""7", @"""_7");
                        resp = resp.Replace(@"""8", @"""_8");
                        resp = resp.Replace(@"""9", @"""_9");
                        resp = resp.Replace(@" ", @"___");
                        // Response.Write(resp);
                        DataSet ds = ReadDataFromJson(resp);

                        DataTable dtResult = new DataTable();
                        dtResult.Columns.Add("Amount", typeof(string));
                        dtResult.Columns.Add("desc", typeof(string));
                        dtResult.Columns.Add("plan_name", typeof(string));

                        DataTable dtplan = ds.Tables["plan"];
                        DataTable dtrs = ds.Tables["rs"];


                        DataView dvdataPlan = new DataView(dtplan);
                        dvdataPlan.RowFilter = "Isnull(Plan_Id,-1) <> -1"; // query example = "id = 10"

                        DataView dvdataRs = new DataView(dtrs);
                        dvdataRs.RowFilter = "Isnull(Plan_Id,-1) <> -1"; // query example = "id = 10"


                        var JoinResult = (from p in dvdataRs.ToTable().AsEnumerable()
                                          join t in dvdataPlan.ToTable().AsEnumerable()
                                          on (p.Field<int>("Plan_Id") == null ? -1 : p.Field<int>("Plan_Id")) equals (t.Field<int>("Plan_Id") == null ? -1 : t.Field<int>("Plan_Id"))

                                          select new
                                          {
                                              _1MONTHS = p.Field<string>("_1MONTHS"),
                                              desc = t.Field<string>("desc"),
                                              plan_name = t.Field<string>("plan_name")
                                          }).ToList();
                        DataTable dtjoin = LINQResultToDataTable(JoinResult);


                        //    DataSet ds=ReadDataFromJson(@"{""records"":{""TOPUP"":[{""rs"":""10"",""desc"":""Get Talktime of Rs. 7.47"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""20"",""desc"":""Get Talktime of Rs. 14.95"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""30"",""desc"":""Get Talktime of Rs. 22.42"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""50"",""desc"":""Get Talktime of Rs.39.37"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""500"",""desc"":""Get Talktime of Rs. 423.73"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""1000"",""desc"":""Get Talktime of Rs. 847.46"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""},{""rs"":""5000"",""desc"":""Get Talktime of Rs. 4237.29"",""validity"":""N\/ A"",""last_update"":""22 - 02 - 2020""}],""RATE CUTTER"":[{""rs"":""18"",""desc"":""60 minutes US & cananda calling free Validity 1 Hour.Dial * 444 * 18# to activate and start calling now. _x001C_*T&Cs apply. Refer https:\/\/shop.vodafone.in\/shop\/prepaid\/Prepaid_SuperHour_t&c.pdf for applicable ISD codes"",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""19"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+200MB Data. Validity 2 Days"",""validity"":""2 days"",""last_update"":""22-02-2020""},{""rs"":""24"",""desc"":""Plan Voucher - Call rate of 2.5p\/sec, 100 on-net night minutes for 14 days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""39"",""desc"":""30 Limited validity talktime, Local\/National Calls @ 2.5p\/sec and 100 MB Data Pack Validity for 14 Days"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""49"",""desc"":""Get Rs38 Talktime+Local\/National Calls@2.5p\/sec+100MB for 28 Days Talktime Rs 38 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""79"",""desc"":""Get Rs64 Talktime+Local\/National Calls@1p\/sec+200MB for 28 Days Talktime Rs 64 valid for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""}],""SMS"":[{""rs"":""12"",""desc"":""Get 120 local\/national SMS for 10 days"",""validity"":""10 days"",""last_update"":""22-02-2020""},{""rs"":""26"",""desc"":""Get 250 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""36"",""desc"":""Get 350 local\/national SMS for 28 days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""99"",""desc"":""Unlimited Local+STD+Roamings Calls to all Network + 1GB + 100 SMS.Validity 18 Days"",""validity"":""18 days"",""last_update"":""22-02-2020""},{""rs"":""129"",""desc"":""Truly Unlimited Local+STD+Roamings Calls to all Network + 2GB + 300 Local and National SMS.Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""199"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 24 Days"",""validity"":""24 days"",""last_update"":""22-02-2020""},{""rs"":""219"",""desc"":""1GB Daily (28GB) & Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""269"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks + 4GB Data + 600 Local and National SMS. Pack Validity for 56 Days."",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""398"",""desc"":""3GB Daily(84GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""499"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 70 Days"",""validity"":""70 days"",""last_update"":""22-02-2020""},{""rs"":""555"",""desc"":""1.5GB Daily(105GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 77 Days"",""validity"":""77 days"",""last_update"":""22-02-2020""},{""rs"":""558"",""desc"":""3GB Daily(168GB) & Truly Unlimited Local+STD+Roamings Calls to all Network + Daily 100 SMS. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""}],""Romaing"":[{""rs"":""295"",""desc"":""40 mins of international roaming calls which include Outgoing local calls, calls back to India and Incoming Calls only. Applicable in USA, UAE, Singapore, Thailand, UK, Sri Lanka, China, Saudi Arabia, Qatar, Oman, Bahrain, Kuwait, Nepal, Bangladesh, Indonesia, Malaysia, Australia, NZ, Canada & many more! Validity: 28 days. T&C Apply"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 1GB (Rs.1\/MB after 1GB) FREE SMS & FREE incoming calls. Plus 120mins FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, Enjoy 300MB data (Re.1\/MB after 300MB) & 10 Free SMS (Re.1\/SMS after 10SMS). Also enjoy FREE incoming calls with 50mins FREE outgoing calls(local & to India), after 50 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries ."",""validity"":""1 days"",""last_update"":""22-02-2020""},{""rs"":""995"",""desc"":""Get FREE 150 min outgoing & incoming calls & 500 MB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Bangladesh, Sri Lanka, China, Kenya, Germany, Belgium, Turkey, Netherlands & more! Also, get FREE 100 min & 100 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 7 days. T&C Apply"",""validity"":""7 days"",""last_update"":""22-02-2020""},{""rs"":""1495"",""desc"":""Get FREE 300 min outgoing & incoming calls & 1GB when roaming abroad in US, UK, Singapore, Thailand, Malaysia, Europe (Germany, Belgium, France, Netherlands, Italy, Spain, Greece), Australia, NZ, Bangladesh, China, Turkey & more! Also, get FREE 150 min & 250 MB when roaming in UAE, Saudi Arabia, Qatar, Oman, Kuwait, Bahrain, Afghanistan, Nepal, Indonesia, Russia, Egypt. Validity: 14 days. T&C Apply"",""validity"":""14 days"",""last_update"":""22-02-2020""},{""rs"":""2695"",""desc"":""In 23 countries including the US, UAE, Singapore, Thailand, Malaysia, UK, New Zealand & more destinations enjoy FREE data up to 4GB (Rs.1\/MB after 4GB) FREE SMS & FREE incoming calls. Plus 120mins\/day FREE outgoing calls(local & to India), after 120 mins Re.1\/min. In 45 other countries, enjoy 1.2GB data (Re.1\/MB after 1.2GB) & 40 Free SMS (Re.1\/SMS after 40SMS). Also enjoy FREE incoming calls with 200mins FREE outgoing calls(local & to India), after 200 mins Re.1\/min. Standard roaming rates apply for Outgoing calls to other countries."",""validity"":""4 days"",""last_update"":""22-02-2020""}],""COMBO"":[{""rs"":""149"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB Data+300SMS. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""299"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 28 Days"",""validity"":""28 days"",""last_update"":""22-02-2020""},{""rs"":""379"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+6GB Data+1000SMS. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+1.5GB\/Day+100SMS\/Day. Validity 56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""449"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks+2GB\/Day+100SMS\/Day. Validity:56 Days"",""validity"":""56 days"",""last_update"":""22-02-2020""},{""rs"":""599"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""699"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +2GB\/Day Data+100SMS\/Day. Validity 84 Days"",""validity"":""84 days"",""last_update"":""22-02-2020""},{""rs"":""1499"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +24GB Data+3600SMS. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""},{""rs"":""2399"",""desc"":""Now get Truly Unlimited Local\/National Calls to all Networks +1.5GB\/Day Data+100SMS\/Day. Validity: 365 Days"",""validity"":""365 days"",""last_update"":""22-02-2020""}]},""status"":1,""time"":null}");
                        //if (ds.Tables[0].Columns.Contains("records"))
                        //{
                        //DataView view = new DataView(ds.Tables[0]);
                        //DataTable dtrechargetype = view.ToTable(true, "records");




                        //str_tabheader += @"<li class=""nav-item""><a class=""nav-link active show"" data-toggle=""tab"" href=""#tab" + ds.Tables[i].TableName + @""" role=""tab"" aria-selected=""true"">" + ds.Tables[i].TableName.Replace("RATE_CUTTER", "RATE CUTTER").Replace("_3GOr4G", "3G/4G").Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + "</a></li>";

                        str_tabheader += @"<li ><a href=""#tabPlan"" class=""active"" data-toggle=""tab"">Plan</a></li>";
                        //DataView dvdata = new DataView(ds.Tables[i]);
                        //dvdata.RowFilter = "RechargeType= '" + dtrechargetype.Rows[i]["rechargetype"].ToString() + "'"; // query example = "id = 10"
                        //str_tabcontent += @"    <div class=""tab-pane active"" id=""tabPlan"">
                        //                 <table class=""table table-bordered table-striped table-hovered"">
                        //                <tr>
                        //                <th>
                        //                Months
                        //                </th>
                        //                <th>
                        //                Amount
                        //                </th>
                        //                <th>
                        //                Validity
                        //                </th>
                        //                <th>
                        //                Description
                        //                </th>
                        //                <th>
                        //                Select Plan
                        //                </th>
                        //                </tr>";
                        //foreach (DataRow r in dtjoin.Rows)
                        //{
                        //    str_tabcontent += @" <tr>
                        //             <td>
                        //             1 Month
                        //                </td>
                        //                <td>
                        //             " + r["_1MONTHS"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ") + @"  
                        //                </td>
                        //                <td>
                        //               " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ") + @"  
                        //                </td>
                        //                <td>
                        //                 " + r["plan_name"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ") + @"  
                        //                </td>
                        //                <td>
                        //                    <a style=""color:white;"" onclick=""selectplandth('" + r["_1MONTHS"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn btn-primary btn-round"">Select</a>
                        //                </td>
                        //                </tr>";
                        //}


                        str_tabcontent += @"   ";
                        foreach (DataRow r in dtjoin.Rows)
                        {
                            str_tabcontent += @"<div class=""row"" style=""padding-top: 2px;padding-bottom:2px;padding-left:20px""> <div class=""col-md-10"" style=""padding: 2px"">
                                     " + r["plan_name"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  <br/>
 " + r["desc"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                        </div>
                                        <div class=""col-md-2""><a onclick=""selectplandth('" + r["_1MONTHS"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9") + @"  ')"" class=""btn  bg-current text-white"" style=""width:80px;font-size:14px"">
                                     " + r["_1MONTHS"].ToString().Replace(@"_1", @"1").Replace(@"_2", @"2").Replace(@"_3", @"3").Replace(@"_4", @"4").Replace(@"_5", @"5").Replace(@"_6", @"6").Replace(@"_7", @"7").Replace(@"_8", @"8").Replace(@"_9", @"9").Replace("___", " ").Replace(@"__1", @"1").Replace(@"__2", @"2").Replace(@"__3", @"3").Replace(@"__4", @"4").Replace(@"__5", @"5").Replace(@"__6", @"6").Replace(@"__7", @"7").Replace(@"__8", @"8").Replace(@"__9", @"9") + @"  
                                       </a> </div></div><hr style=""margin-top: .2rem;margin-bottom: .2rem;"" />";
                        }

                        //str_tabcontent += @"
                        //                </div>";

                    }
                    catch (Exception ep)
                    {

                    }
                }

            }
            else
            {
                //lblrechargeplanresponse.Text = "No API Found";
            }

            //DataTable dt = new DataTable();
            //dt = objoperator.getCircle();
            //return new string[] { "value1", "value2" };
            //return dt;

            //ViewBag.tab = outputHtml;

            List<string> li = new List<string>();
            li.Add(str_tabheader);
            li.Add(str_tabcontent);
            li.Add(resp);
            return li;

        }

        [Route("getDashboard")]
        public clsDashboard getDashboard(clsUser objuser2)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_balance = "";
            string str_successrecharge = "";
            string str_failedrecharge = "";
            string str_username = "";

            DataSet ds = new DataSet();
            clsUser objuser = new clsUser();
            objuser.Email = objuser2.Email;
            ds = objuser.get_DashboardUser(objuser);

            clsDashboard objdashboard = new clsDashboard();


            if (ds.Tables.Count > 0)
            {
                //str_balance = ds.Tables[0].Rows[0]["balanceamount"].ToString();
                //str_successrecharge = ds.Tables[0].Rows[0]["successrecharge"].ToString();
                //str_failedrecharge = ds.Tables[0].Rows[0]["failrecharge"].ToString();
                //str_username = ds.Tables[0].Rows[0]["username"].ToString();

                objdashboard.Username = ds.Tables[0].Rows[0]["username"].ToString();
                objdashboard.BalanceAmount = ds.Tables[0].Rows[0]["balanceamount"].ToString();
                objdashboard.SuccessRecharge = ds.Tables[0].Rows[0]["successrecharge"].ToString();
                objdashboard.FailedRecharge = ds.Tables[0].Rows[0]["failrecharge"].ToString();
                objdashboard.RewardPointBalance = ds.Tables[0].Rows[0]["rewardpointbalance"].ToString();
                objdashboard.dtdata = ds.Tables[1];
            }

            //List<string> li = new List<string>();
            //li.Add(str_balance);
            //li.Add(str_successrecharge);
            //li.Add(str_failedrecharge);
            //li.Add(str_username);
            return objdashboard;

        }

        [Route("getRechargeHistory")]
        public clsDashboard getRechargeHistory(clsUser objuser2)
        {


            DataTable dt = new DataTable();
            clsUser objuser = new clsUser();
            objuser.Email = objuser2.Email;
            dt = objuser.get_RechargeHistory(objuser);

            clsDashboard objdashboard = new clsDashboard();
            objdashboard.dtdata = dt;
            return objdashboard;

        }
        [Route("getTransactionHistory")]
        public clsDashboard getTransactionHistory(clsUser objuser2)
        {


            DataTable dt = new DataTable();
            clsUser objuser = new clsUser();
            objuser.Email = objuser2.Email;
            dt = objuser.get_TransactionHistory(objuser);

            clsDashboard objdashboard = new clsDashboard();
            objdashboard.dtdata = dt;
            return objdashboard;

        }
        [Route("getUserDetail")]
        public List<string> getUserDetail(clsUser objuser2)
        {


            DataTable dt = new DataTable();
            clsUser objuser = new clsUser();
            objuser.Email = objuser2.Email;
            dt = objuser.getUserDetailByEmail(objuser);

            string str_name = "";
            string str_mobile = "";
            string str_email = "";

            if (dt.Rows.Count > 0)
            {
                str_name = dt.Rows[0]["name"].ToString();
                str_mobile = dt.Rows[0]["mobile"].ToString();
                str_email = dt.Rows[0]["email"].ToString();
            }

            List<string> li = new List<string>();
            li.Add(str_name);
            li.Add(str_mobile);
            li.Add(str_email);
            return li;

        }

        public DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
        {
            DataTable dt = new DataTable();
            PropertyInfo[] columns = null;

            if (Linqlist == null) return dt;

            foreach (T Record in Linqlist)
            {

                if (columns == null)
                {
                    columns = ((Type)Record.GetType()).GetProperties();
                    foreach (PropertyInfo GetProperty in columns)
                    {
                        Type colType = GetProperty.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
                        == typeof(Nullable<>)))
                        {
                            colType = colType.GetGenericArguments()[0];
                        }

                        dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
                    }
                }

                DataRow dr = dt.NewRow();

                foreach (PropertyInfo pinfo in columns)
                {
                    dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
                    (Record, null);
                }

                dt.Rows.Add(dr);
            }
            return dt;
        }
        [HttpPost]
        [Route("getOperatorcheck")]
        public List<string> getOperatorcheck(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_operatorid = "";
            string str_circleid = "";
            string strurl = "";
            string resp = "";


            strurl = "http://operatorcheck.mplan.in/api/operatorinfo.php?apikey=3365e368360b142e37652ddf1c2fd624&tel={mobile}";
            //strurl = "http://admin.rechargezap.com/webservices/secureservice.asmx/getOperatorCheck?Mobile={mobile}";
            // url = url.Replace("{mobile}", TxtCardNo.Text);
            strurl = strurl.Replace("{mobile}", objoperator.Number);
            //strurl = strurl.Replace("{operator}", dt.Rows[0]["operatorcodeinfo"].ToString());


            if (strurl != "")
            {
                try
                {
                    resp = strurl.CallURL();
                    //resp = @"{""tel"":""9889142222"",""records"":{""status"":1,""Operator"":""Jio"",""segment"":""PREPAID"",""circle"":""UP East"",""comcircle"":""UP East""},""time"":0.00011205673217773438}";

                    objoperator2.InsertOperatorCheckResponse(strurl,resp);

                    //var client = new RestClient(strurl);
                    //client.Timeout = -1;
                    //var request = new RestRequest(Method.GET);
                    //request.AddParameter("text/plain", "", ParameterType.RequestBody);
                    //IRestResponse response = client.Execute(request);
                    //resp = response.Content.ToString();
                    //resp += response.ErrorMessage.ToString();
                    //resp = @"{""tel"":""8888888888"",""records"":{""status"":1,""Operator"":""Vodafone"",""segment"":""PREPAID"",""circle"":""20"",""comcircle"":""UP East""},""time"":0.8509838581085205}";
                    DataSet ds = ReadDataFromJson(resp);
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            if (ds.Tables[1].Columns.Contains("Operator"))
                            {
                                str_operatorid = ds.Tables[1].Rows[0]["Operator"].ToString();
                            }
                            if (ds.Tables[1].Columns.Contains("comcircle"))
                            {
                                str_circleid = ds.Tables[1].Rows[0]["comcircle"].ToString();
                            }
                        }
                    }

                    DataTable dt = objoperator2.getOperatorCheckOperator(str_operatorid, str_circleid);
                    if (dt.Rows.Count > 0)
                    {
                        str_operatorid = dt.Rows[0]["operatorid"].ToString();
                        str_circleid = dt.Rows[0]["circleid"].ToString();
                    }

                }
                catch (Exception ep)
                {

                }
            }



            List<string> li = new List<string>();
            li.Add(str_operatorid);
            li.Add(str_circleid);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }
        [HttpPost]
        [Route("getOperatorcheckPostpaid")]
        public List<string> getOperatorcheckPostpaid(clsOperator objoperator)
        {
            clsOperator objoperator2 = new clsOperator();
            string str_operatorid = "";
            string str_circleid = "";
            string strurl = "";
            string resp = "";


            strurl = "http://operatorcheck.mplan.in/api/operatorinfo.php?apikey=3365e368360b142e37652ddf1c2fd624&tel={mobile}";
            //strurl= "https://www.mplan.in/api/Bsnl.php?apikey=3365e368360b142e37652ddf1c2fd624&offer=roffer&tel={mobile}&operator=[operator](, Given below)"
            //strurl = "http://admin.rechargezap.com/webservices/secureservice.asmx/getOperatorCheck?Mobile={mobile}";
            // url = url.Replace("{mobile}", TxtCardNo.Text);
            strurl = strurl.Replace("{mobile}", objoperator.Number);
            //strurl = strurl.Replace("{operator}", dt.Rows[0]["operatorcodeinfo"].ToString());


            if (strurl != "")
            {
                try
                {
                    resp = strurl.CallURL();

                    //var client = new RestClient(strurl);
                    //client.Timeout = -1;
                    //var request = new RestRequest(Method.GET);
                    //request.AddParameter("text/plain", "", ParameterType.RequestBody);
                    //IRestResponse response = client.Execute(request);
                    //resp = response.Content.ToString();
                    //resp += response.ErrorMessage.ToString();
                    //resp = @"{""tel"":""8888888888"",""records"":{""status"":1,""Operator"":""Vodafone"",""segment"":""PREPAID"",""circle"":""20"",""comcircle"":""UP East""},""time"":0.8509838581085205}";
                    DataSet ds = ReadDataFromJson(resp);
                    if (ds.Tables.Count == 2)
                    {
                        if (ds.Tables[1].Rows.Count > 0)
                        {
                            if (ds.Tables[1].Columns.Contains("Operator"))
                            {
                                str_operatorid = ds.Tables[1].Rows[0]["Operator"].ToString();
                            }
                            if (ds.Tables[1].Columns.Contains("comcircle"))
                            {
                                str_circleid = ds.Tables[1].Rows[0]["comcircle"].ToString();
                            }
                        }
                    }

                    DataTable dt = objoperator2.getOperatorCheckOperator(str_operatorid+"Postpaid", str_circleid);
                    if (dt.Rows.Count > 0)
                    {
                        str_operatorid = dt.Rows[0]["operatorid"].ToString();
                        str_circleid = dt.Rows[0]["circleid"].ToString();
                    }

                }
                catch (Exception ep)
                {

                }
            }



            List<string> li = new List<string>();
            li.Add(str_operatorid);
            li.Add(str_circleid);
            li.Add(resp);
            li.Add(strurl);
            return li;

        }


        [HttpPost]
        [Route("getBalance")]
        public List<string> getBalance(clsRecharge objrecharge)
        {
            string str_balance = "";
            string str_email = "";
            string str_mobile = "";
            string str_name = "";
            string str_zapcoinsbalance = "";

            DataTable dt = new DataTable();
            dt = objrecharge.getUserBalance(objrecharge);
            if (dt.Rows.Count > 0)
            {
                str_balance = dt.Rows[0]["balanceamount"].ToString();
                str_email = dt.Rows[0]["email"].ToString();
                str_mobile = dt.Rows[0]["mobile"].ToString();
                str_name = dt.Rows[0]["name"].ToString();
                str_zapcoinsbalance = dt.Rows[0]["zapcoinsbalance"].ToString();
            }
            else
            {
                str_balance = "";
                str_email = "";
                str_mobile = "";
                str_name = "";
                str_zapcoinsbalance = "";
            }



            List<string> li = new List<string>();
            li.Add(str_balance);
            li.Add(str_email);
            li.Add(str_mobile);
            li.Add(str_name);
            li.Add(str_zapcoinsbalance);
            return li;

        }

        [HttpPost]
        [Route("getElectricityOperatorByCircle")]
        public DataTable getElectricityOperatorByCircle(clsRecharge objrecharge)
        {
            clsOperator objoperator = new clsOperator();
            objoperator.CircleId = objrecharge.OperatorId;
            DataTable dt = new DataTable();
            dt = objoperator.GetAllOperatorElectricityByCircle(objoperator);
            //return new string[] { "value1", "value2" };
            return dt;

        }

        [HttpPost]
        [Route("ContactForm")]
        public List<string> ContactForm(clsUser objuser)
        {
            Data objdata = new Data();
            string str_subject = "Contact Request- Recharge Zap";
            string str_message = @"New Contact Request Recieved <br/>Name : " + objuser.UserName + "<br/>Email : " + objuser.Email + "<br/>Message : " + objuser.Message + "";
            objdata.SendMail("care@rechargezap.in", str_subject, str_message);



            List<string> li = new List<string>();
            li.Add("Request Submitted Successfuly");
            return li;

        }

        private static DataSet ReadDataFromJson(string jsonString, XmlReadMode mode = XmlReadMode.Auto)
        {
            //// Note:Json convertor needs a json with one node as root
            jsonString = "{ \"rootNode\": {" + jsonString.Trim().TrimStart('{').TrimEnd('}') + @"} }";
            jsonString = jsonString.Replace("RATE CUTTER", "RATE_CUTTER");
            jsonString = jsonString.Replace(@"3G\/ 4G", "_3GOr4G");
            //// Now it is secure that we have always a Json with one node as root 
            var xd = JsonConvert.DeserializeXmlNode(jsonString);

            //// DataSet is able to read from XML and return a proper DataSet
            var result = new DataSet();
            result.ReadXml(new XmlNodeReader(xd), mode);
            return result;
        }

        // GET: api/Recharge/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Recharge
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Recharge/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
