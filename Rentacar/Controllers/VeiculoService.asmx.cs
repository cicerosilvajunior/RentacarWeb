using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Rentacar.Controllers
{
    /// <summary>
    /// Summary description for VeiculoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class VeiculoService : System.Web.Services.WebService
    {

        [WebMethod]
        public string VerificaDisponibilidade(string tipoVeiculo, string dataRetireada, string dataDevolucao)
        {
            return "Hello World";
        }
    }
}
