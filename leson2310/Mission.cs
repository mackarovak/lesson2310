using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Mission
    {
        public string name { get; private set; }
        public string taskdescription { get; private set; }
        public string apersontoperform { get; private set; }
        public Mission(string name,string taskdescription, string apersontoperform)
        {
            this.name = name;
            this.taskdescription= taskdescription;
            this.apersontoperform = apersontoperform;
        }
        public static Mission EmployeeisTask()
        {
            Console.WriteLine("Какое название у задачи?");
            string name = Console.ReadLine();
            Console.WriteLine("Что необходимо сделать в целях задчаи?");
            string taskdescription = Console.ReadLine();
            Console.WriteLine("Кому надо выполнить эту задачу?");
            string apersontoperform = Console.ReadLine();
            return new Mission(name, taskdescription, apersontoperform);
        }
    }
}