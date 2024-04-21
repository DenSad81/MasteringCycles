using System;

namespace MasteringCycles
{
    class Program
    {
        static void Main(string[] args) {
            string message;
            int repititionCount;

            Console.Write("Ваше сообщение: ");
            message = (Console.ReadLine());
            Console.Write("Количество повторений: ");
            repititionCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < repititionCount; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
