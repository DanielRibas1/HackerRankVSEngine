using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Exercises.Example_1
{
    public class Example_Exercice1 : Engine
    {
        public Example_Exercice1() : base()
        {
        }

        public override void Main(string[] args)
        {
            //Get Data
            var n = int.Parse(Console.ReadLine());
            var testMatrix = new int[n];
            for (int i = 0; i < n; i++)
                testMatrix[i] = Convert.ToInt32(Console.ReadLine());

            //Do Stuff


            //WriteData
            for (int i = 0; i < n; i++)
                Console.WriteLine(testMatrix[n]);
        }
    }
}
