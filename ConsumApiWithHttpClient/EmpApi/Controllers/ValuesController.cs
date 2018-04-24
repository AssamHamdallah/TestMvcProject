using EmpApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<EmpModel> Get()
        {
            List<EmpModel> list = new List<EmpModel>( );
            EmpModel n1 = new EmpModel (){ Id=1 , Name="ali" ,City="ta"};
            list.Add(n1);
            EmpModel n2 = new EmpModel() { Id = 2, Name = "ali2", City = "ta2" };
            list.Add(n2);
            EmpModel n3 = new EmpModel() { Id = 3, Name = "ali3", City = "ta3" };
            list.Add(n3);

            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
