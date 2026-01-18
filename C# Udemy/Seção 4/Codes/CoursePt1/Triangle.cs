using System;

namespace CoursePt1{
    class Triangle {
        
        // O public nos atributos permite que eles sejam acessados por outro arquivo

        public double A, B, C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p-A) * (p-B) * (p-C));
            
        }
    }
}