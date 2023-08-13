using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Entity
{
    public class Personal
    {
        public int PersonalID { get; set; }
        public string PersonalAd { get; set; }
        public string PersonalSoyad { get; set; }
        public int RolID { get; set; }
        public Rol Rol { get; set; }
        public int IslemID { get; set; }
        public Islem Islem { get; set; }
    }
}
