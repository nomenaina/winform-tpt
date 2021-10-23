using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class PariResponse : Response
    {
        public List<Pari> paris { get; set; }
    }
}
