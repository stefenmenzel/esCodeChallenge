using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using VersionGetter;

namespace VersionApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {        
        public VersionController()
        {            
            
        }

        //if the user doesn't enter a version number, return all versions.
        [HttpGet]
        public IEnumerable<Software> GetAllVersions(){
            return VersionGetter.SoftwareManager.GetAllSoftware();
        }

        //if the user enters a version number, check version numbers.
        [HttpGet("{version}")]
        public List<Software> GetVersions(string version){
            Console.Write("version received: " + version);
            return VersionGetter.SoftwareManager.doVersionComparison(version);
        }
    }
}