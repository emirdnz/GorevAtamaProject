using GorevAtama.Data.Abstarct;
using GorevAtama.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Data.Concrete
{
    public class PersonelRepository : GenereticRepository <Personal, GorevAtamaContext> , IPersonelRepository
    {
        public List<Personal> GetAllList()
        {
            using (var context = new GorevAtamaContext())
            {
                return context.Personels.Include(i => i.Islem).ToList(); 
            }

        }

    }
}
