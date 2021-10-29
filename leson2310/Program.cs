using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leson2310
{
    class Program
    {
        static void Main(string[] args)
        {
            var staffs = new List<Staff>();
            int lastID = 0;
            staffs.Add(new Boss("Борис", ref lastID));
            staffs.Add(new Deputy_boss("О Ильхaм", ref lastID, staffs[lastID - 1]));
            staffs.Add(new Chief_among_developers("Сергей", ref lastID, staffs[lastID - 1]));
            staffs.Add(new Chief_among_the_system_engineers("Ильшат", ref lastID, staffs[lastID - 2]));
            staffs.Add(new Deputy_system_engineer("Иваныч", ref lastID, staffs[lastID - 1]));
            staffs.Add(new Deputy_developer("Ляйсан", ref lastID, staffs[lastID - 3]));
            staffs.Add(new Developer("Марат", ref lastID, staffs[lastID - 1]));
            staffs.Add(new Developer("Антон", ref lastID, staffs[lastID - 2]));
            staffs.Add(new Developer("Ильдар", ref lastID, staffs[lastID - 3]));
            staffs.Add(new Developer("Дина", ref lastID, staffs[lastID - 4]));
            staffs.Add(new Systemdevelopers("Илья", ref lastID, staffs[lastID - 6]));
            staffs.Add(new Systemdevelopers("Витя", ref lastID, staffs[lastID - 7]));
            staffs.Add(new Systemdevelopers("Женя", ref lastID, staffs[lastID - 8]));
            bool flag = true;
            while (flag)
            {
                string text = Console.ReadLine().ToLower();
                switch (text)
                {
                    case "поменять":
                        Staff.SwapMission(staffs);
                        break;
                    case "задача":
                        Staff.GiveMission(staffs);
                        break;
                    case "выйти":
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Такой команды нет, плакатц идем");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
