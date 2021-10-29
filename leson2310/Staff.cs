using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    abstract class Staff
    {
        public string name { get; private set; }
        public int lastID { get; private set; }
        public Staff head { get; private set; }
        public string surname { get; private set; }
        private int warnings = 0;
        public string post { get; protected set; }
        private List<Mission> missions = new List<Mission>();
        public Staff()
        {

        }
        public Staff(string name, ref int lastID)
        {
            lastID++;
            this.name = name;
            this.lastID = lastID;
        }
        public Staff(string name, ref int lastID, Staff head)
        {
            lastID++;
            this.name = name;
            this.lastID = lastID;
            this.head = head;
        }
        public Staff(string name, string surname, Staff head, ref int lastID)
        {
            lastID++;
            this.name = name;
            this.surname = surname;
            this.lastID = lastID;
            this.head = head;
        }
        public static void GiveMission(List<Staff> staffs)
        {
            Console.WriteLine("Кто дает задачу?");
            string name = Console.ReadLine();
            Staff staff = new Developer();
            bool isCanGiveMission = false;
            Type typeBossGivingTask = staff.GetType();
            foreach (var Staff in staffs)
            {
                if (staff.name == name && !(staff is Systemdevelopers) && !(staff is Developer))
                {
                    isCanGiveMission = true;
                    typeBossGivingTask = staff.GetType();
                    Console.WriteLine("Данный работник был найден");
                    Console.WriteLine("Его данные");
                    staff.PrintInfo();
                    Console.WriteLine("Данный работник может дать задачу");
                }
            }
            if (!isCanGiveMission)
            {
                Console.WriteLine("Данный работник не может дать задачу");
            }
            else
            {
                Console.WriteLine("Введите имя работника, кому дадут задачу");
                name = Console.ReadLine();
                isCanGiveMission = false;
                for (int i = 0; i < staffs.Count; i++)
                {
                    if (staffs[i].head == null)
                    {
                        continue;
                    }
                    else if (staffs[i].name == name && staffs[i].head.GetType() == typeBossGivingTask)
                    {
                        isCanGiveMission = true;
                        if (staffs[i].missions.Count < 1)
                            {
                                Console.WriteLine("Задача передается");
                                Console.WriteLine("Согласен ли работник на задание? да или нет");
                                string input = Console.ReadLine().ToLower();
                                if (!input.Equals("нет"))
                                {
                                    staffs[i].missions.Add(Mission.EmployeeisTask());
                                }
                                else
                                {
                                    staffs[i].warnings++;
                                }
                            }
                        if (staffs[i].warnings >= 3)
                        {
                            Console.WriteLine($"Работник {staffs[i].name} получил 3 или более предупреждения");
                        }
                    }

                }
            }
            if (!isCanGiveMission)
            {
                Console.WriteLine("Невозможно передать задачу этому работнику");
            }
        }
        public virtual void PrintInfo()
        {
            if (surname == null)
            {
                surname = "У работника нет фамилии";
            }
            if (head == null)
            {
                Console.WriteLine("Он босс");
            }
            Console.WriteLine($"Имя работника {name}, фамилия работника {surname}, id работника {lastID}");
        }
        public static void SwapMission(List<Staff> staffs)
        {
            Console.WriteLine("Введите имя работника,кто хочет передать задачу?");
            string name = Console.ReadLine();
            bool swaped = false;
            foreach (var Staff in staffs)
            {
                if (Staff.name.Equals(name) && !(Staff is Developer) && !(Staff is Systemdevelopers))
                {
                    Console.WriteLine("Данный работник был найден!");
                    Type type = Staff.GetType();
                    Console.WriteLine("Кому вы хотите передать задачу?");
                    string nameWorker = Console.ReadLine();
                    foreach (var workingpeople in staffs)
                    {
                        if (Staff.head == null)
                        {
                            continue;
                        }
                        if (workingpeople.name.Equals(nameWorker) && type == workingpeople.head.GetType() && workingpeople.name != Staff.name)
                        {
                            Console.WriteLine("Задача может быть передана!");
                            if (Staff.missions.Count != 0)
                            {
                                var SwapMission = Staff.missions.Last();
                                Staff.missions.Remove(Staff.missions.Last());
                                workingpeople.missions.Add(SwapMission);
                                swaped = true;
                                Console.WriteLine($"Задача была передана от {Staff.name} к {workingpeople.name}");
                            }
                            else
                            {
                                Console.WriteLine($"У {Staff.name} и так нет задач!");
                            }
                        }
                    }
                }
            }
            if (!swaped)
            {
                Console.WriteLine("Данный работник не может дать задачу по определенным причинам!");
            }

        }
    }
}
