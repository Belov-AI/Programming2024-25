using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class ReverseAlphabeticalOrderComparer : IComparer<User>
    {
        public int Compare(User x, User y) => -x.CompareTo(y);
    }
}
