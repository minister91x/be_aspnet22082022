using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;
using RestSharp;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;

namespace WebAPI.Controllers
{
    public class TestController : ApiController
    {
        string aa = "";
        /// <summary>
        /// Hàm này là hàm lấy danh sách 
        /// </summary>
        /// <returns>List<Person></returns>
        public StudentGetAllReturnData studentGetAll()
        {
            var response = new StudentGetAllReturnData();
            //var list = new List<Person>();
            //for (int i = 0; i < 10; i++)
            //{
            //    list.Add(new Person { Id = i, Name = "Ten:" + i });
            //}
            //response.lstPerson = list;

            return response;
        }

        //public List<Person> GetlistPeople()
        //{
        //    var list = new List<>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        list.Add(new Person { Id = i, Name = "Ten:" + i });
        //    }

        //    return list;
        //}

        public Exchange GetExchange()
        {
            var exchange = new Exchange();
            try
            {
                var client = new RestClient("https://www.dongabank.com.vn/exchange/export");
                var request = new RestRequest();
                request.Method = Method.Get;
                request.AddHeader("postman-token", "20a730df-f596-bd46-df6b-1f7ab2d295df");
                request.AddHeader("cache-control", "no-cache");
                var response = client.Execute(request);
                if (!string.IsNullOrEmpty(response.Content))
                {
                    var content = response.Content.Replace("(", "").Replace(")", "");
                    exchange = new JavaScriptSerializer().Deserialize<Exchange>(content);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return exchange;

        }
    }
}
