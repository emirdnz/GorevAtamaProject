using GorevAtama.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GorevAtama.Data.Abstarct
{
    public interface IIslemRepository
    {
        List<Islem> GetAll();
        List<Islem> GetListAll();   
    }
}
