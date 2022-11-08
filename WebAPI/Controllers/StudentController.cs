using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        /// <summary>
        /// Hàm này trả về danh sách abc 
        /// </summary>
        /// <returns>stringabcs</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        public StudentGetAllReturnData GetAll(string token)
        {
            var retunData = new StudentGetAllReturnData();
            var studentRepo = new WebAPI.Entites.StudentModels();
            //var sign = ClassLibrary1123.Security.sHA256_EnCrypt("quannt", "BI_MAT_!@#");

            //if (string.IsNullOrEmpty(token) || token != sign)
            //{
            //    retunData.Code = -1;
            //    retunData.Desc = "token không hợp lệ";
            //    return retunData;
            //}

            var list = new List<Student>();
            var lst = studentRepo.Students;
            if (lst.Count() > 0)
            {
                foreach (var item in lst)
                {
                    list.Add(new Student { Id = item.Id, Name = item.Name });
                }

            }
            retunData.Code = 1;
            retunData.Desc = "ok";
            retunData.lstPerson = list;

            return retunData;
        }

        // GET: api/Student/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Student
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Student/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Student/5
        public void Delete(int id)
        {
        }
    }
}
