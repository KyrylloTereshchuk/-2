using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class IEqualityComparer : IEqualityComparer<Magazine>
    {
        public bool Equals(Magazine x, Magazine y)
        {
            bool Result = false;
            if (x.Id == y.Id &&
                x.Name == y.Name &&
                x.Periodicity == y.Periodicity &&
                x.Date == y.Date &&
                x.Circulation == y.Circulation)
                Result = true;
            return Result;
        }

        public int GetHashCode(Magazine obj)
        {
            return obj.Id;
        }
    }

}
