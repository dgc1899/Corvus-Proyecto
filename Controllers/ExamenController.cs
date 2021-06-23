using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvus_Proyecto.Controllers
{
    public class ExamenController : BaseController
    {
        public ExamenController(string connString)
        {
            _connString = connString;
        }
    }
}
