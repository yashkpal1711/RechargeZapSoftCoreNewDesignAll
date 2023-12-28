using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RechargeZapSoftCore.Models
{
    public static class SessionHelper
    {
        public static void SetObjectInSession(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetCustomObjectFromSession<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            //List<T> myDeserializedObjList = (List<T>)Newtonsoft.Json.JsonConvert.DeserializeObject(value, typeof(List<T>));
            if (value == null)
            {
                return default(T);
            }
            else {
                var myobjList = JsonConvert.DeserializeObject<List<T>>(value);
                var myObj = myobjList[0];
                return myobjList[0];
            }
          

            //return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);


        }
    }
}
