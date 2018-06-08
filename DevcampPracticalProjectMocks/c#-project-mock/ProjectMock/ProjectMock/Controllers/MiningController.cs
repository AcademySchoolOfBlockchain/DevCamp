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
    public class MiningController : Controller
    {

        private IHostingEnvironment _hostingEnvironment;

        public MiningController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }


        [HttpPost("submit-mined-block")]
        public IActionResult SubmitMinedBlock()
        {
            object jsonObject = GetJSON("submit-new-block.json");

            return Json(jsonObject);
        }

        [Route("get-mining-job/{address}")]
        public IActionResult GetMiningJob(string address)
        {
            object jsonObject = GetJSON("mining-job.json");

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