using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Entity
{
    public class Rol
    {
        public int RolID { get; set; }
        public string RolAd { get; set; }
        public List<Personal> Personels { get; set; }
    }
}
