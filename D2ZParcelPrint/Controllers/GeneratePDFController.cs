using D2ZParcelPrint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace D2ZParcelPrint.Controllers
{
    public class GeneratePDFController : ApiController
    {
        [HttpGet]//[HttpPost]
        public HttpResponseMessage GetPdf([FromBody] Label label)
        {
            var ep = new CreateEParcelcs();

            return ep.PdfWithhardcodedValue();
        }
    }
}
