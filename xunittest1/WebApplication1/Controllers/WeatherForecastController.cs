using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            string strOutput;
            using (var process = new Process())
            {
                process.StartInfo.FileName = "cmd.exe"; // relative path. absolute path works too.
                process.StartInfo.Arguments = "/c dotnet test";
                process.StartInfo.WorkingDirectory = @"..\XUnitTestProject1";
                //process.StartInfo.Arguments = @"/c dir"; 

                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.RedirectStandardError = true;
                Console.WriteLine("starting");
                process.Start();
                var exited = process.WaitForExit(1000 * 10);     // (optional) wait up to 10 seconds
                Console.WriteLine($"exit {exited}");
                strOutput = process.StandardOutput.ReadToEnd();
            }
            return strOutput;
        }

    }
}
