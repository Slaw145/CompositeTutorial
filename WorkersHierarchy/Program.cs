using System;
using System.Collections.Generic;

namespace WorkersHierarchii
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("Andrej", "Wardalo", "head of the technology department");
            manager1.AddWorker(new Worker("Anna", "Karbowska", "embedded systems engineer"));
            manager1.AddWorker(new Worker("Mark", "Zelinski", "IOS application developer"));
            manager1.AddWorker(new Worker("Slawomir", "Kowalski", "Web application developer"));

            Manager manager2 = new Manager("Jacek", "Nowak", "team manager");
            manager1.AddWorker(manager2);
            manager2.AddWorker(new Worker("Waldemar", "Musal", "Evaluator"));
            manager2.AddWorker(new Worker("Jan", "Pufund", "Graphic designer"));

            manager1.DisplayInformationWorker();

            Console.ReadKey();
        }
    }
}
