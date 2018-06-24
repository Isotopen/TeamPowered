using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    class Program
    {
        static void Main(string[] args)
        {
			Person person = new Person();
			person.FirstName = "Matthew";

			Console.WriteLine($"{0} is without a doubt the best name I know.", person.FirstName);

				}
    }
}
