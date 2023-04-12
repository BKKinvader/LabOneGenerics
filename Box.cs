using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance.NET_labb1
{
    public class Box : IEquatable<Box>
    {
        
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }


        public Box(int h, int l, int w)
        {
            
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }
       

        public bool Equals(Box other)
        {
            if (new BoxSameDim().Equals(this, other))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Equals(object obj) 
        {
            return base.Equals(obj);
        }

      
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
