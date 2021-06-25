using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Controllers
{
    public class NotaController : BaseController
    {
        public NotaController(string connString)
        {
            _connString = connString;
        }
    }
}
