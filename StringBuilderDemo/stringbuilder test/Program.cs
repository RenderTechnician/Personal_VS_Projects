using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringbuilder_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Values.Value val = new Values.Value();
            Console.WriteLine("Enter a word or phrase and i'll attempt to replicate it");
            val.GetInput = Console.ReadLine();
            val.GetOutput = Constructor(val.GetInput);
            Console.WriteLine(val.GetOutput);
            Console.ReadLine();
        }
        static string Constructor(string bridge)
        {
            StringBuilder str = new StringBuilder();
            int count = 0;
            do
            {
                str.Append(bridge[count] + " ");
                count++;
            } while (bridge.Length > count);
            bridge = str.ToString();
            return bridge;
        }
    }
    
}
namespace Values
{
    public class Value
    {
        private string Input;
        private string Output;

        public string GetInput
        {
            get { return Input; }
            set { Input = value; }
        }
        public string GetOutput
        {
            get { return Output; }
            set { Output = value; }
        }
    }
}
