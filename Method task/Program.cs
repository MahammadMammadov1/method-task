using System.Xml.Linq;

namespace Method_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("first task");
            Console.WriteLine(Task1Int(9));
            Task1Void(9);
            Console.WriteLine("--------------------------------");

            Console.WriteLine("second task");
            Console.WriteLine(Task2("    Code academy      ")); 

            Console.WriteLine("--------------------------------");
            Console.WriteLine("third task");
            Console.WriteLine(Task3("Hello World"));

        }

        #region Task1
        static int Task1Int(int a)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        static void Task1Void(int a)
        {
            int sum = 0;
            for (int i = 0; i < a; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum); ;

        }
        #endregion




        #region Task2
        static string Task2(string a)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != ' ')
                {
                    b += a[i];
                }
            }
            return b;
        }
        #endregion




        #region task3
        static string Task3(string a)
        {
            string b = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ' ' && a[i + 1] != ' ')
                {
                    b += a[i + 1];
                }

            }
            return a[0] + b;
        }
        #endregion





    }
}
