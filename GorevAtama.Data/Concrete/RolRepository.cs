using GorevAtama.Data.Abstarct;
using GorevAtama.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Data.Concrete
{
    public class RolRepository : GenereticRepository<Rol, GorevAtamaContext > ,IRolRepository
    {
    }
}
