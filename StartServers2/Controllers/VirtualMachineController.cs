using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VMManagementDF.Helpers;

namespace StartServers2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VirtualMachineController : ControllerBase
    {

        // GET /
        [HttpGet]
        public IEnumerable<VirtualMachineHelper> Get()
        {
            var GetMachines = new AzureConnection("4bc6eea4-c3ed-4346-84a8-18f6868195ac",
                                        "9e497778-66dd-4947-828e-720f6595ff69",
                                        "=RST6396Q_h_rodQR]Lj7O86pckrc.-z").VirtualMachines;

            return GetMachines;
        }


        // POST /
        //[HttpPost]
        //public void StartServer([FromQuery]string vmid)
        //{
        //    var queryString = Request.QueryString;

        //    //https://vmmanagementdf20191127080759.azurewebsites.net/api/vmManagementOrchestration_Run?vmid=

        //    new AzureConnection("4bc6eea4-c3ed-4346-84a8-18f6868195ac",
        //                                "9e497778-66dd-4947-828e-720f6595ff69",
        //                                "=RST6396Q_h_rodQR]Lj7O86pckrc.-z").ToggleMachineState(vmid);
        //}
    }
}
