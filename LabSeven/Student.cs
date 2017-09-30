using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSeven
{
    class Student
    {

        private string name;
        private string hometown;
        private string favFood;

        public Student(string myName, string myTown, string myFavFood)
        {
            name = myName;
            hometown = myTown;
            favFood = myFavFood;
        }

        public string getName()
        {
            return name;
        }

        public string getHometown()
        {
            return hometown;
        }

        public string getFavFood()
        {
            return favFood;
        }
    }
}
