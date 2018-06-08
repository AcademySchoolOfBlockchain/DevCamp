using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectMock.Controllers
{
    [Route("[controller]")]
    public class AddressController : Controller
    {

        IHostingEnvironment _hostingEnvironment;


        public AddressController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("{id}/transactions")]
        public IActionResult Transactions(string id)
        {

            object jsonObject = GetJSON("address-transactions.json");

            return Json(jsonObject);
        }

        [HttpGet("{id}/balance")]
        public IActionResult Balances(string id)
        {

            object jsonObject = GetJSON("address-balance.json");

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