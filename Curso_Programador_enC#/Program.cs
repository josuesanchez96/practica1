//************************************************************************//
//******************************* LECCIÓN 3 ******************************//
//************************************************************************//

/* // plantilla 
namespace ejercicio
{
    class MainClass
    {
        public static void Main(string[] args)
        {            
        }      
    }
}
// fin plantilla */
/* // CREACIÓN DE CLASE
namespace Appusuario
{
   class Program
   {
       static void Main(string[] args)
       {
           int numA = 4;
           int resultado1 = Cuadrado(numA);
           int resultado2 = Cuadrado(12);
           int resultado3 = Cuadrado(resultado1 * 3);
           Console.WriteLine(resultado3);
           Console.ReadKey();
       }
       public static int Cuadrado(int i)
       {
           return i * i;
       }
   }
} 
*/
// comentario prueba, este comentario se hizo desde la rama jdavid


/* // USO DE OBJETOS
namespace AppObjetoEstructura
{
  class Program
  {
      static void Main(string[] args)
      {
          Persona persona1 = new Persona();

          persona1.Name = "Octavio";
          persona1.Age = 30;
          Console.WriteLine("persona1 Name = {0} Age = {1}", persona1.Name, persona1.Age);

          Persona persona2 = persona1;
          persona2.Name = "Molly";
          persona2.Age = 16;

          Console.WriteLine("persona2 Name = {0} Age = {1}", persona2.Name, persona2.Age);

          Console.WriteLine("persona1 Name = {0} Age = {1}", persona1.Name, persona1.Age);

          Console.WriteLine("Press any key to exit.");
          Console.ReadKey();
      }
  }
  public struct Persona
  {
      public string Name;
      public int Age;
  }
}
*/

/* // CAMPOS, PROPIEDADES Y CONSTRUCTORES
namespace AppCampoPropiedadConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(450,340,670);
            

            Console.WriteLine("{0},{1},{2}",color1.R,color1.G,color1.B);
            Console.ReadKey();
        }
    }

    public class Color
    {
        private int r;
        private int g;
        private int b;

        // Definir propiedades:
        public int R
        {
            get { return r; }
            set
            {
                if (value <= 255) { r = value; }
                else { r = 255; }
            }            
        }
        public int G
        {
            get { return g; }
            set
            {
                if(value <= 255) { g = value; }
                else { g = 255; }
            }
        }
        public int B
        {
            get { return b; }
            set
            {
                if (value <= 255) { b = value; }
                else { b = 255; }
            }
        }

        //Creación método constructor
        public Color(int red, int green, int blue)
        {
            r = red;
            g = green;
            b = blue;
        }
    }
}


/* // CLASES ESTÁTICAS

namespace AppEstatico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado a = new Empleado("Octavio", "1234");
            Empleado b = new Empleado("Carlos", "2345");
            Empleado c = new Empleado("Fernanda", "3456");

            //Mostrar en pantalla el lcampo estático
            Console.WriteLine("Nuevo número de empleado: {0}",
                Empleado.contadorEmpleado);
            Console.ReadKey();
        }
    }
    public class Empleado
    {
        public string id;
        public string nombre;
        public static int contadorEmpleado;

        public Empleado(string nombre, string id)
        {
            this.nombre = nombre;
            this.id = id;
            ++contadorEmpleado;
        }
    }
}
*/

/* // HERENCIA DE CLASES
namespace AppHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Chihuahua perro1 = new Chihuahua();
            Console.WriteLine(perro1.PerroLadrar());
            Console.ReadKey();
        }
    }

    public class Perro
    {
        public string PerroLadrar() { return "Perro ladrando"; }
    }

    public class Chihuahua : Perro
    {
        public void ChihuahuaLadrar()
        {
            base.PerroLadrar();
        }     
    }
}
*/

// POLIMORFISMO = CON MUCHAS FORMAS
/*
namespace AppPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma forma1 = new Forma();
            Circulo forma2 = new Circulo();
            Rectangulo forma3 = new Rectangulo();

            forma1.Dibujo();
            forma2.Dibujo();
            forma3.Dibujo();

            Console.ReadKey();
        }
    }
    // Definir un miembro virtual:
    public class Forma
    {
        public virtual void Dibujo()
        {
            Console.WriteLine("Alguna forma");
        }
    }

    public class Circulo : Forma
    {
        // Declaración polimorfismo
        public override void Dibujo()
        {
            Console.WriteLine("Forma circular");
            base.Dibujo();
        }
    }

    public class Rectangulo : Forma
    {
        public override void Dibujo()
        {
            Console.WriteLine("Forma rectangular");
            base.Dibujo();
        }
    }
}
*/

/* // Evitar el polimorfismo
namespace AppPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            C saludo = new C();
            saludo.hola();

            Console.ReadKey();
        }
    }
    public class A
    {
        public virtual void hola()
        {
            Console.WriteLine("Hola soy A");
        }
    }
    public class B : A
    {
        public sealed override void hola()
        {
            //minuto 2:22
        }
    }
}
*/

// AREA PRACTICA LECCIÓN 3

/* // plantilla 
namespace ejercicio_funciones_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {            
        }      
    }
}
// fin plantilla */

/* // 1. Crea un método que nos salude, pasándole un nombre por parámetro
namespace ejercicio_funciones_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            saludar("Fernando"); //Llamada del método
            Console.ReadLine();
        }

        //Mpetodo que saluda
        public static void saludar(string nombre)
        {
            Console.WriteLine("¡Hola! " + nombre + " !");
        }
    }
}
*/

/* // Crea una función que sume dos números pasados por parámetros, devolverá el resultado.
namespace ejercicio_funciones_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int resultado = suma(5, 7); //Llamada de la función, lo guardo en una variable
            Console.WriteLine(resultado);
            Console.ReadLine();
        }
        public static int suma(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }
    }    
}
*/

/* // 3. Crea una función que calcule el factorial de un número.
namespace ejercicio_funciones_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadLine();
        }
        //Función que devuelve el factorial de un número
        public static int factorial(int num)
        {
            int resultado = num; //empiezo en el numero
            for (int i = num; i > 2; i--)
            {
                resultado *= i;
            }
            return resultado; //devuelvo el resultado
        }
    }
}
*/

//************************************************************************//
//******************************* LECCIÓN 4 ******************************//
//************************************************************************//

//INTERFACES
/* //Ejemplo de como definir e implementar una interfaz (LE FALTA ALGO, NO FUNCIONA)
public interface IConducible
{
    string Matricula { get; set; }

    //Métodos
    void Conducir();
    void Frenar();
}

public class Coche : IConducible
{
    // Implementación de propiedades
    public string Matricula { get; set; }

    // Implementación de métodos
    public void Conducir()
    {
        Console.WriteLine("El coche está en marcha.");
    }

    public void Frenar()
    {
        Console.WriteLine("El coche se ha detenido");
    }
}
*/

namespace ejercicio_funciones_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanque tanque1 = new Tanque();
            validar1(tanque1);
            validar2(tanque1);

            int x = 30;
            tanque1.Acelerar(x);
            tanque1.Disparar();
            tanque1.Frenar();
        }
        static void validar1(IVehiculo a)
        {
            Console.WriteLine("Esto es un vehículo");
        }
        static void validar2(IArmaDeGuerra a)
        {
            Console.WriteLine("Esto es un arma de guerra");
        }
    }
    interface IVehiculo
    {
        void Acelerar(int kmh);
        void Frenar();
        void Girar(int angulos);
    }
    interface IArmaDeGuerra
    {
        void Apuntar();
        void Disparar();
    }
    class Tanque:IVehiculo, IArmaDeGuerra
    {
        public void Acelerar(int kmh) { Console.WriteLine("Tanque acelerando a {0}", kmh);  }
        public void Frenar() { Console.WriteLine("Tanque frenando"); }
        public void Girar(int angulos) { Console.WriteLine("Tanque girando a {0}", angulos); }
        public void Apuntar() { Console.WriteLine("Tanque apuntando"); }
        public void Disparar() { Console.WriteLine("Tanque disparando"); }
    }
}

