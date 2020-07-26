using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            long us1 = 40211111111, us2 = 40222222222, us3 = 40233333333, us4 = 40244444444, us5 = 40255555555;
            int clave1 = 12345, clave2 = 54321, clave3 = 12354, clave4 = 54312, clave5 = 43251, clave = 0;
            Console.WriteLine("                        INICIAR SESION");
            Console.WriteLine(" ");
            Console.WriteLine("            USUARIOS PARA ELEGIR");
            Console.WriteLine(" ");
            Program.Saludo(us1, clave1, 1);
            Program.Saludo(us2, clave2, 2);
            Program.Saludo(us3, clave3, 3);
            Program.Saludo(us4, clave4, 4);
            Program.Saludo(us5, clave5, 5);
            Console.WriteLine(" ");
            Procedimiento.Mostrar(us1, us2, us3, us4, us5, clave, clave1, clave2, clave3, clave4, clave5);

            Console.ReadKey();
        }
        static void Saludo(long usuari, int clav, int cont)
        {
            Console.WriteLine(" Usuario " + cont + " = " + usuari + "      clave = " + clav);
        }
    }
}
