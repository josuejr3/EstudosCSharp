using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiposValorEReferencia
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}