// using System;
// using System.Globalization;

// namespace CoursePt1
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
            
//             // Problema Exemplo - Sem Usar Orientação a Objetos
//             // Fazer um programapara ler as medidas dos lados de dois triângulos X e Y
//             // (suponha medidas válidas). Em seguida mostrar o valor das áreas dos dois triângulos
//             // e dizer qual dos dois triângulos possui a maior área.
            
//             // A fórmula para calcular á area de um triângulo a partir das medidas de seus lados
//             // a, b e c é a seguinte (fórmula de Heron)

//             // area = sqrt(p(p-a)(p-b)(p-c)), em que p = (a+b+c)/2            


//             // Variáveis
//             double xA, xB, xC, yA, yB, yC;
            
//             Console.WriteLine("Entre com as medidas do triângulo X: ");
//             xA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
//             xB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
//             xC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

//             // O ! no ReadLine tira os warning CS8604

//             Console.WriteLine("Entre com as medidas do triângulo Y: ");
//             yA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
//             yB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
//             yC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);


//             double p = (xA + xB + xC) / 2.0;
//             double areaX = Math.Sqrt(p * (p-xA) * (p-xB) * (p-xC));

//             p = (yA + yB + yC) / 2.0;
//             double areaY = Math.Sqrt(p * (p-yA) * (p-yB) * (p-yC));

//             Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
//             Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

//             if (areaX > areaY)
//             {
//                 Console.WriteLine("Maior área: X");
//             }
//             else
//             {
//                 Console.WriteLine("Maior área: Y");
//             }

//         }
//     }
// }