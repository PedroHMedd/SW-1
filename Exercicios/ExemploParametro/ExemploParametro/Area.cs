using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExemploParametro
{
    public class Area
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public float AreaCalculada { get; set; }

        public void Escolha(int opcao)
        {
            if (opcao == 1) 
            {
            float quadrado = CalculaAreaQuadrado();
            Console.WriteLine("Area do Quadrado é: " + quadrado);
            }
            if (opcao == 2)
            {
            float retangulo =  CalculaAreaRetangulo();
            Console.WriteLine("Area do Retangulo é: " + retangulo);
            }
            if (opcao == 3)
            {
            float triangulo  =  CalculaAreaTriangulo();
            Console.WriteLine("Area do Triangulo é: " + triangulo);
            }
        }
        public float CalculaAreaQuadrado()
        {
            return AreaCalculada;
        }
        public float CalculaAreaRetangulo()
        {
            return AreaCalculada;
        }
        public float CalculaAreaTriangulo()
        {
            return AreaCalculada;
        }
    }
}
