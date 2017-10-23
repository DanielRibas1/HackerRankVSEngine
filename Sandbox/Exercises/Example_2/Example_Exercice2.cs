using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Exercises.Example_2
{
    public class Example_Exercice2 : Engine
    {
        private static string basePath = NamespacePath(typeof(Example_Exercice2));
        public Example_Exercice2() : base(basePath + "CustomInputFile1.txt", basePath + "CustomOutputFile1.txt") { }

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
