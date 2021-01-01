using System;

namespace Algorithms_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = 20000;
            if(args.Length > 0
                && !int.TryParse(args[0],out iterations)
                && iterations <= 0){
                    Console.WriteLine("Error: iteration count should be positive interget");
            }
            else{
                RunTest(iterations);
            }
        }

        private static void RunTest(int iterations)
        {
            throw new NotImplementedException();
        }
    }
}
