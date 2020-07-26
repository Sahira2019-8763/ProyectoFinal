using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
   public class Procedimiento
    {
        static public void Mostrar(long us1, long us2, long us3, long us4, long us5, int c, int c1, int c2, int c3, int c4, int c5)

        {
            Console.WriteLine("1- ESCRIBA SU NOMBRE ");
            string n = Convert.ToString(Console.ReadLine());
            Console.WriteLine("2- INGRESE SU USUARIO");
            long us = Convert.ToInt64(Console.ReadLine());

            if ((us == us1) || (us == us2) || (us == us3) || (us == us4) || (us == us5))
            {
                Console.WriteLine("3- INGRESE SU CLAVE");
                c = Convert.ToInt32(Console.ReadLine());
            }

            else if ((us != us1) || (us != us2) || (us != us3) || (us != us4) || (us != us5))
            {
                while (us != us1 && us != us2 && us != us3 && us != us4 && us != us5)
                {
                    Console.WriteLine("¡USUARIO INCORRECTO! ");
                    Console.WriteLine("DIGITE OTRO USUARIO");
                    us = Convert.ToInt64(Console.ReadLine());
                }
                Console.WriteLine("INGRESE SU CLAVE:");
                c = Convert.ToInt32(Console.ReadLine());
            }

            if ((c != c1) && (c != c2) && (c != c3) && (c != c4) && (c != c5))
            {
                do
                {
                    Console.WriteLine("¡CONTRASEÑA INCORRECTA!");
                    Console.WriteLine("INGRESE SU CLAVE:");
                    c = Convert.ToInt32(Console.ReadLine());
                }

                while ((c != c1) && (c != c2) && (c != c3) && (c != c4) && (c != c5));
            }
            else if ((c == c4 && us == us4) || (c == c5 && us == us5))
            {
                do
                {
                    Console.WriteLine("ESTE USUARIO ESTÁ INACTIVO, POR FAVOR VUELVA Y VALIDE OTRO USUARIO.");
                    Console.WriteLine("INGRESE OTRO USUARIO");
                    us = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine("INGRESE SU CLAVE");
                    c = Convert.ToInt32(Console.ReadLine());
                }

                while (c == c4 && us == us4 || c == c5 && us == us5);
            }

            if ((c == c1) && (us == us1))
            {
                Console.WriteLine(" ");
                Console.WriteLine("                    ESTADO ACTIVO");
                Console.WriteLine(" ");
                Console.WriteLine("La fecha de creacion de este usuario es: " + Procedimiento.fecha());
                Console.WriteLine("Bienvenido " + n.ToUpper() + ", usted ingreso con el USUARIO 1. Su rol es el de ADMINISTRADOR");
                Console.WriteLine("NO HAY ASIGNACIONES PENDIENTES, PUEDE RETIRARSE");
            }
            else if ((c == c2) && (us == us2))
            {
                Console.WriteLine(" ");
                Console.WriteLine("                    ESTADO ACTIVO");
                Console.WriteLine(" ");
                Console.WriteLine("La fecha de creacion de este usuario es: " + Procedimiento.fecha2());
                Console.WriteLine("Bienvenido " + n.ToUpper() + ", usted ingreso con el USUARIO 2. Su rol es el de SUPERVISOR");
                Console.WriteLine("NO HAY SUPERVISIONES PENDIENTES, PUEDE RETIRARSE");
            }
            else if ((c == c3) && (us == us3))
            {
                Console.WriteLine(" ");
                Console.WriteLine("                    ESTADO ACTIVO");
                Console.WriteLine(" ");
                Console.WriteLine("La fecha de creacion de este usuario es: " + Procedimiento.fecha3());
                Console.WriteLine("Bienvenido " + n.ToUpper() + ", usted ingreso con el USUARIO 3. Su rol es el de VENDEDOR");
                Console.WriteLine("NO HAY VENTAS PENDIENTES, PUEDE RETIRARSE");
            }

            else
            {
                Console.WriteLine("LA CONTRASEÑA QUE ESCRIBIÓ NO COINCIDE CON EL USUARIO INGRESADO");
                Console.WriteLine("¡Hasta luego! vuelva cuando sepa la contraseña de SU USUARIO");
            }
        }

        public static DateTime fecha()
        {
            DateTime fecha1 = new DateTime(2019, 11, 23);
            return fecha1;
        }

        public static DateTime fecha2()
        {
            DateTime fecha2 = new DateTime(2019, 11, 18);
            return fecha2;
        }
        public static DateTime fecha3()
        {
            DateTime fecha3 = new DateTime(2020, 03, 15);
            return fecha3;
        }
    }
}
