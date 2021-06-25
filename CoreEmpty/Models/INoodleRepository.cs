using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEmpty.Models
{
    public interface INoodleRepository
    {
        IEnumerable<Noodle> GetAllNoodles();
        Noodle GetNooldeById(int id);
    }
}
