using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjectMock.Models;

namespace ProjectMock.Controllers
{
    public class HomeController : Controller
    {
        private IHostingEnvironment _hostingEnvironment;


        public HomeController(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        [Route("info")]
        public IActionResult Info()
        {
            object jsonObject = GetJSON("info.json");
            
            return Json(jsonObject);
        }
       
        [Route("debug")]
        public IActionResult Debug()
        { 
            object jsonObject = GetJSON("debug.json");

            return Json(jsonObject);
        }

        [Route("debug/reset-chain")]
        public IActionResult ResetChain()
        {

            object jsonObject = GetJSON("reset-chain.json");

            return Json(jsonObject);
        }

        [HttpGet("debug/mine/{minerId}/{difficulty:int}")]
        public IActionResult TransactionsByMinerAndDifficulty(string minerId, int difficulty)
        {
            object jsonObject = GetJSON("miner-difficulty.json");
   
            return Json(jsonObject);
        }

        [Route("balances")]
        public IActionResult Balances()
        {
            object jsonObject = GetJSON("balances.json");

            return Json(jsonObject);
        }

        [Route("blocks")]
        public IActionResult Blocks()
        {
            object jsonObject = GetJSON("chain.json");

            return Json(jsonObject);
        }

        [HttpGet("blocks/{index:int}")]
        public IActionResult Block(int index)
        {
            object jsonObject = GetJSON("block.json");

            return Json(jsonObject);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
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
