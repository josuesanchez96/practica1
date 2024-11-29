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
*/

 // CLASES ESTÁTICAS

namespace AppEstatico2
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado a = new Empleado("Octavio","1234");
            Empleado b = new Empleado("Carlos","2345");
            Empleado c = new Empleado("Fernanda","3456");

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

/*// HERENCIA DE CLASES
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

        public Chihuahua(string y): base("Soy un perro")
        {
            Console.WriteLine(y);
        }

    }
}*/