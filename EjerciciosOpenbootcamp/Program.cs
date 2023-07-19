using System;

namespace EjerciciosOpenbootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //EJERCICIO 1


            Console.WriLine("Porfavor ingrese los siguientes datos:");
            Console.Write("Nombre:");
            string nombre = Console.ReadLine().ToString();
            Console.Write("Apellido:");
            string apellido = Console.ReadLine().ToString;
            Console.Write("Edad:");
            int edad =Convert.ToInt32(Console.ReadLine()) ;
            Console.Write("Sabe Programar: S/N");
            char programar = Console.ReadLine();
            var mensaje = "hola " + nombre + apellido;
            if(programar == "S" || programar== "s"){mensaje = mensaje + " Nos encanta que sepas programar " }
            mensaje = mensaje + " tenemos un programa de estudio justo para gente de la edad de " + edad +" contactanos ";

            //EJERCICIO 2

            //coche  
            int puertas=4;
            int ruedas=4;
            string marca="honda";
            bool ITV_vigente=true;
            //mesa
            float peso=10.7;
            float largo=2.5;
            string material= "madera";
            string color= "marron";
            Console.WriteLine("El auto tiene " + ruedas " ruedas " + puertas + " puertas  es de marca " + marca + " y la ITV " + ITV_vigente);
            Console.WriteLine("la mesa tiene un peso de " + peso + " un largo de " + largo + " su material es de " + material + " y su color es " + color);

            //EJERCICIO 3

            Console.WriteLine("Ingrese un numero:");
            int numero = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Ingrese una letra:");
            char letra =Convert.ToChar(Console.ReadLine());
            bool cond1 = (numero >= 18 && letra == 'a');
            bool cond2 = (numero >= 18 || letra == 'a');
        }
    }
}
