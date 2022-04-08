using System;

namespace loop_121_12321
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            Console.WriteLine("loop program");
            Console.WriteLine("enter the how many times run the pyramid shap\n");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for (j = i; j <= n - 1; j++)
                {
                    Console.Write(" ");
                }
                for(j=1;j<=i;j++)
                {
                    Console.Write(j);  
                }
                for(int k=i-1;k>=1;k--)
                {
                    Console.Write(k);
                }
                Console.Write("\n ");
            }

        }
    }
}
