using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TechLibrary.Exception
{
    public class DataException : TechLibraryException
    {
        public override List<string> GetErrorMessages() => ["Esse medicamento não está cadastrado."];


        public override HttpStatusCode GetStatusCode() => HttpStatusCode.Unauthorized;

    }
}
