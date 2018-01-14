using System;
using System.Collections.Generic;
using System.Text;

namespace WorkersHierarchii
{
    class Manager : IWorker
    {
        private string FirstName, LastName, Degree;
        private List<IWorker> workers = new List<IWorker>();

        public Manager(string firstname, string lastname, string degree)
        {
            FirstName = firstname;
            LastName = lastname;
            Degree = degree;
        }

        public void AddWorker(IWorker worker)
        {
            workers.Add(worker);
        }

        public void DisplayInformationWorker()
        {
            Console.WriteLine("Subordinates manager: " + FirstName + " " + LastName);
            foreach (IWorker worker in workers)
            {
                worker.DisplayInformationWorker();
            }
        }
    }
}
