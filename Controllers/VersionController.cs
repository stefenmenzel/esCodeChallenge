using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using VersionGetter;
using VersionApi.Models;

namespace VersionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {        
        public VersionController()
        {            
            
        }

        [HttpGet]
        public IEnumerable<Software> GetAllVersions(){
            return VersionGetter.SoftwareManager.GetAllSoftware();
        }

        [HttpGet("{version}")]
        public List<Software> GetVersions(string version){
            Console.Write("version received: " + version);
            return VersionGetter.SoftwareManager.doVersionComparison(version);
        }
    }
}