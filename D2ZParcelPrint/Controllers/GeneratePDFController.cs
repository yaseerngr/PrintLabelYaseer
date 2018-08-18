using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NeoPrintLabel.Controllers
{
    public class GeneratePDFController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage GetPdf()
        {
            var ep = new CreateEParcelcs();

            return ep.PdfWithhardcodedValue();
        }
    }
}
