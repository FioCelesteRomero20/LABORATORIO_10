using LABORATORIO_10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = InterfazConsola.menuPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = InterfazConsola.menuPrincipal();
                        break;
                    case 1:
                        opcion = InterfazConsola.mPhone();
                        break;
                    case 2:
                        opcion = InterfazConsola.mPad();
                        break;
                    case 3:
                        opcion = InterfazConsola.MAPBrook();
                        break;
                    case 4:
                        opcion = InterfazConsola.mWatch();
                        break;

                }
            } while (opcion!=5);
        }

        private static int menuPrincipal()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Productos de mPhone\n" +
                            "================================\n" +
                            "1: Ventas de mPhone 3000\n" +
                            "2: Ventas de mPad 3500\n" +
                            "3: Ventas de MAPBrook 3800\n" +
                            "4: Ventas de mWatch 8000\n" +
                            "5: Salir\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            return getOpcion();
            
        }

        private static int mPhone()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Registrar Venta de mPhone 3000\n" +
                            "================================\n" +
                            "1: Registrar Venta\n" +
                            "2: Registrar Devolución\n" +
                            "3: Menu Principal\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 2) return 0;
            return opcion;
        }

        private static int mPad()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Registrar Venta de mPad 3500\n" +
                            "================================\n" +
                            "1: Registrar Venta\n" +
                            "2: Registrar Devolución\n" +
                            "3: Menu Principal\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 1) return 2;
            if (opcion == 2) return 0;
            return opcion;
        }

        private static int MAPBrook()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Registrar Venta de MAPBrook 3800\n" +
                            "================================\n" +
                            "1: Registrar Venta\n" +
                            "2: Registrar Devolución\n" +
                            "3: Menu Principal\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 1) return 3;
            if (opcion == 2) return 0;
            return opcion;
        }

        private static int mWatch()
        {
            Console.Clear();
            Console.Write("" +
                            "================================\n" +
                            "Registrar Venta de mWatch 8000\n" +
                            "================================\n" +
                            "1: Registrar Venta\n" +
                            "2: Registrar Devolución\n" +
                            "3: Menu Principal\n" +
                            "================================\n" +
                            "Ingrese una opción: ");
            int opcion = getOpcion();
            if (opcion == 1) return 4;
            if (opcion == 2) return 0;
            return opcion;
        }


        private static int getOpcion()
        {
            string opcionTexto = Console.ReadLine();
            return int.Parse(opcionTexto);
        }
    }
}
