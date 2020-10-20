using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WEBAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values

     private  static List<string> items = new List<string> { "item1", "item2", "item3", "item4" };
        public IEnumerable<string> GetList()
        {
            return items;
        }

        // GET api/values/5
        public string GetItem(int id)
        {
            return items[id];
        }

        // POST api/values
        public List<string> Post(string value)
        {
            items.Add(value);
            return items;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public List<string> Delete(int id)
        {
            items.Remove(items.Find((i=>i.ToString().Contains(id.ToString()))));
            return items;
        }
    }
}
