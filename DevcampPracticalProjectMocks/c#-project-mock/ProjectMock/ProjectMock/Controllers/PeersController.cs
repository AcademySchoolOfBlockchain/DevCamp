using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ProjectMock.Controllers
{
    [Route("[controller]")]
    public class PeersController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;

        public PeersController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        [HttpPost("connect")]
        public IActionResult Connect()
        {
            object jsonObject = GetJSON("peer-connected.json");

            return Json(jsonObject);
        }

        [HttpGet("")]
        public IActionResult List()
        {

            object jsonObject = GetJSON("peers.json");

            return Json(jsonObject);
        }

        [HttpPost("notify-new-block")]
        public IActionResult NotifyNewBlock()
        {

            object jsonObject = GetJSON("notify-new-block.json");

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