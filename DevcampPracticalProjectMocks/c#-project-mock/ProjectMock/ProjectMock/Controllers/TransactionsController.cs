using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectMock.Controllers
{
    [Route("[controller]")]
    public class TransactionsController : Controller
    {

        private IHostingEnvironment _hostingEnvironment;

        public TransactionsController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        [Route("pending")]
        public IActionResult Pending()
        {

            object jsonObject = GetJSON("pending-transactions.json");

            return Json(jsonObject);
        }

        [Route("confirmed")]
        public IActionResult Confirmed()
        {
            object jsonObject = GetJSON("confirmed-transactions.json");

            return Json(jsonObject);
        }

        [HttpGet("{id}")]
        public IActionResult TransactionById(string id)
        {
            object jsonObject = GetJSON("transaction.json");

            return Json(jsonObject);
        }
        
        [HttpPost("send")]
        public IActionResult Send()
        {

            object jsonObject = GetJSON("transaction-send.json");

            return Json(jsonObject);
        }

        public object GetJSON(string name)
        {
            string path = Path.Combine(_hostingEnvironment.WebRootPath, $"mocks/{name}");

            string json = System.IO.File.ReadAllText(path);

            object jsonObject = JsonConvert.DeserializeObject(json);

            return jsonObject;
        }
    }
}