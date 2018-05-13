using System;
using System.Net;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    public class IpController : Controller
    {
        [HttpGet]
        public string Get()
        {
            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            Console.WriteLine(hostName);
            // Get the IP  
            return Dns.GetHostEntry(hostName).AddressList[0].ToString();
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            Thread.Sleep(5000);
            return Get();
        }
    }
}
