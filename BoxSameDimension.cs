using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_1_Generics
{
    internal class BoxSameDimension : EqualityComparer<Box>
    {
        public override bool Equals([AllowNull] Box x, [AllowNull] Box y)
        {
            if(x.height == y.height && x.length == y.length && x.width == y.width)
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
            var hcode = obj.height ^ obj.length ^ obj.width;
            Console.WriteLine("HC: {0}", hcode.GetHashCode());
            return hcode.GetHashCode();
        }
    }
}
