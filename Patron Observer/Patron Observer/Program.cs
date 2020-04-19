using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns
{
    public class FallIllEventArgs
    {
        public string Address;
    }

    public class Person
    {
        public void CatchAcold()
        {
            FallsIll?.Invoke(this, new FallIllEventArgs { Address = "123 Londo Roand" });
        }
        public event EventHandler<FallIllEventArgs> FallsIll;
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.FallsIll += CallDoctor;
            person.CatchAcold();
            person.FallsIll -= CallDoctor;
        }

        private static void CallDoctor(object sender, FallIllEventArgs e)
        {
            Console.WriteLine($"A doctor has been called to {e.Address}");
        }
    }
}
