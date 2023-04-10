using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class DataEqualityComparer : IEqualityComparer<Magazin>
    {
        public bool Equals(Magazin x, Magazin y)
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

        public int GetHashCode(Magazin obj)
        {
            return obj.Id;
        }
    }

}
