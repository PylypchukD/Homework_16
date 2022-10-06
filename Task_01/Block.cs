using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    internal class Block
    {
        private int s1,s2,s3,s4;

        public Block(int s1, int s2, int s3, int s4)
        {
            this.s1 = s1;
            this.s2 = s2;
            this.s3 = s3;
            this.s4 = s4;
        }

        public override string ToString()
        {
            return $"Блок: {s1} {s2} {s3} {s4}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Block other = (Block)obj;
            return (s1 == other.s1) && (s2 == other.s2) && (s3 == other.s3) && (s4 == other.s4);
        }

        public override int GetHashCode()
        {
            return s1.GetHashCode() ^ s2.GetHashCode() ^ s3.GetHashCode() ^ s4.GetHashCode();
        }
    }
}
