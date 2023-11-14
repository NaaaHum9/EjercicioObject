using System;

namespace claseObject
{
    class Program
    {
        static void  Main(string[] args)
        {
            Automovil sedan = new Automovil();
            Motocicleta chopper = new Motocicleta();
            Camion remolque = new Camion();

            Console.WriteLine("Caracteristicas sedan: " + sedan);
            Console.WriteLine("Caracteristicas de la motocicleta: " + chopper);
            Console.WriteLine("Caracteristicas camion: " + remolque);
            Console.WriteLine();

            // Ejemplos de métodos básicos de la clase object
            Console.WriteLine("ToString del Automovil: " + sedan.ToString());
            Console.WriteLine("HashCode del Motocicleta: " + chopper.GetHashCode());

            // Ejemplo de Equals comparando dos objetos
            Console.WriteLine("El Automovil es igual a la Motocicleta?: " + sedan.Equals(chopper));
        }
    }

    class Vehiculos
    {
        public void movilidad()
        {
            Console.WriteLine("Me muevo");
        }
        public void motor()
        {
            Console.WriteLine("Tengo un motor");
        }

         //ToString para personalizar la representación de cadena
        public override string ToString()
        {
            return "Clase Vehiculos";
        }
        //Equals para comparar por igualdad
        public override bool Equals(object obj)
        {
            if (obj is Vehiculos)
            {
                return true;
            }
            return false;
        }
        //GetHashCode para generar un código hash único
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Automovil : Vehiculos
    {
        public void numerosdepsajero()
        {
            Console.WriteLine("Tengo una cantidad limitada de asientos");
        }

         //ToString para personalizar la representación de cadena
        public override string ToString()
        {
            return "Clase Automovil";
        }
    }

    class Motocicleta : Vehiculos
    {
        public void dosllantas()
        {
            Console.WriteLine("Solo tengo 2 llantas");
        }

        //GetHashCode para generar un código hash único específico para Motocicleta
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    class Camion : Vehiculos
    {
        public void tonelajedeaguate()
        {
            Console.WriteLine("Puedo cargar muchas toneladas");
        }

        //Equals para comparar por igualdad
        public override bool Equals(object? obj)
        {
            if (obj is Camion)
            {
                return true;
            }
            return false;
        }
    }
}