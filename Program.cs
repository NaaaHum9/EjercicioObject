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

            Console.WriteLine("Caracteristicas sedan: " + sedan.movilidad);
            Console.WriteLine("Caracteristicas de la motocicleta: " + chopper);
            Console.WriteLine("Caracteristicas camion: " + remolque);
            Console.WriteLine();

            // Ejemplos de métodos básicos de la clase object
            Console.WriteLine("ToString del Automovil: " + sedan.ToString());
            Console.WriteLine("HashCode del Motocicleta: " + chopper.GetHashCode());

            // Ejemplo de Equals comparando dos objetos
            Console.WriteLine("¿El Automovil es igual a la Motocicleta?: " + sedan.Equals(chopper));
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

         // Sobrescribir ToString para personalizar la representación de cadena
        public override string ToString()
        {
            return "Clase Vehiculos";
        }
        // Sobrescribir Equals para comparar por igualdad
        public override bool Equals(object obj)
        {
            if (obj is Vehiculos)
            {
                return true; // Implementa la lógica de igualdad según tus necesidades
            }
            return false;
        }
        // Sobrescribir GetHashCode para generar un código hash único
        public override int GetHashCode()
        {
            return base.GetHashCode(); // Implementa la lógica de generación de hash según tus necesidades
        }
    }

    class Automovil : Vehiculos
    {
        public void numerosdepsajero()
        {
            Console.WriteLine("Tengo una cantidad limitada de asientos");
        }

         // Sobrescribir ToString para personalizar la representación de cadena
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

        // Sobrescribir GetHashCode para generar un código hash único específico para Motocicleta
        public override int GetHashCode()
        {
            return base.GetHashCode();// Utilizar el tipo para generar un código hash único
        }
    }

    class Camion : Vehiculos
    {
        public void tonelajedeaguate()
        {
            Console.WriteLine("Puedo cargar muchas toneladas");
        }

        // Sobrescribir Equals para comparar por igualdad
        public override bool Equals(object? obj)
        {
            if (obj is Camion)
            {
                return true;// Implementa la lógica de igualdad según tus necesidades
            }
            return false;
        }
    }
}