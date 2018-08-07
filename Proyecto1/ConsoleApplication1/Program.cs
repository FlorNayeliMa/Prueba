using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication1{

    class Program{

        static void Main(string[] args){
            Program ob = new Program();
            //ob.ImprimirDatos();
            Console.WriteLine("Resultado: "+ob.CalculaMayor());

            Console.ReadKey();
        }

        public void ImprimirDatos(){
            String Nombre;
            String ApellidoP;
            String ApellidoM;
            int Edad;

            Console.Write("Digita tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Digita tu Apellido Paterno: ");
            ApellidoP = Console.ReadLine();

            Console.Write("Digita tu Apellido Materno: ");
            ApellidoM = Console.ReadLine();

            Console.Write("Digita tu Edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();//Detener la pantalla al correr
        }

        public int CalculaMayor(){

            Console.Write("Ingresa la cantidad de numeros:");
            int n = Convert.ToInt32(Console.ReadLine());

            int auxiliar=0;

            

            return auxiliar;
        }
    }
}
