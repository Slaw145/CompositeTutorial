using System;
using System.Collections.Generic;
using System.Text;

namespace WorkersHierarchii
{
    interface IWorker
    {
        void DisplayInformationWorker();
    }
    class Worker : IWorker
    {
        private string FirstName, LastName, Degree;

        public Worker(string firstname, string lastname, string degree)
        {
            FirstName = firstname;
            LastName = lastname;
            Degree = degree;
        }

        public void DisplayInformationWorker()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Degree);
        }
    }
}
