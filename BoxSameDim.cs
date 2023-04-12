using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.NET_labb1
{
    internal class BoxSameDim : EqualityComparer<Box>
    {
        public override bool Equals(Box? B1, Box? B2)
        {
            if (B1.Height == B2.Height && B1.Length == B2.Length && B1.Width == B2.Width)


            {
                return true;
            }
            else
            {
                return false;
            }
        }

      
        public override int GetHashCode([DisallowNull] Box obj)
        {
            var hcode = obj.Height ^ obj.Length ^ obj.Width;
            return hcode.GetHashCode();
        }
    }
}
