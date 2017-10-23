using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public abstract class Engine
    {
        private string _inputFile;
        private string _outputFile;

        private MemoryStream _dataBuffer;
        private StreamWriter _sw;
        private StreamReader _sr;    

        public Engine()
        {
            var basePath = NamespacePath(this.GetType());
            SetStreams($"{basePath}input.txt", $"{basePath}output.txt");
        }

        public Engine(string inputFile, string outputFile)
        {
            SetStreams(inputFile, outputFile);
        }

        private void SetStreams(string inputFile, string outputFile)
        {
            _inputFile = inputFile;
            _outputFile = outputFile;

            _dataBuffer = new MemoryStream();
            _sw = new StreamWriter(_dataBuffer);
            _sr = new StreamReader(_inputFile);

            Console.SetIn(_sr);
            Console.SetOut(_sw);
        }

        public bool Validate()
        {
            _sw.Flush();
            _dataBuffer.Position = 0;
            using (var resultReader = new StreamReader(_dataBuffer))
            {
                using (var compareReader = new StreamReader(_outputFile))
                {
                    var resultText = resultReader.ReadToEnd().Trim();
                    System.Diagnostics.Debug.WriteLine(resultText);
                    var compareText = compareReader.ReadToEnd().Trim();
                    return resultText.Equals(compareText);
                }
            }
        }

        public abstract void Main(string[] args);

        protected static string NamespacePath(Type type)
        {
            var split = new List<string>(type.Namespace.Split('.'));
            split.RemoveAt(0);
            return String.Join("\\", split) + "\\";
        }

        ~Engine()
        {
            _sw.Close();
            _sr.Close();
        }
        
    }
}
