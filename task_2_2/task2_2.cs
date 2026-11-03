//using System;
//using System.Collections.Generic;
//using System.Text;

//public abstract class Worker
//{
//    public string Name { get; set; }
//    public string Position { get; set; }
//    public string WorkDay { get; protected set; } = "";

//    public Worker(string name, string position)
//    {
//        Name = name;
//        Position = position;
//    }

//    public void Call() => WorkDay += "Дзвінок; ";

//    public void WriteCode() => WorkDay += "Код; ";

//    public void Relax() => WorkDay += "Відпочинок; ";

//    public abstract void FillWorkDay();
//}

//public class Developer : Worker
//{
//    public Developer(string name) : base(name, "Розробник") { }

//    public override void FillWorkDay()
//    {
//        WriteCode();
//        Call();
//        Relax();
//        WriteCode();
//    }
//}

//public class Manager : Worker
//{
//    private Random _random = new Random();

//    public Manager(string name) : base(name, "Менеджер") { }

//    public override void FillWorkDay()
//    {
//        int CallNumber = _random.Next(1, 11);
//        for (int i = 0; i < CallNumber; i++)
//        {
//            Call();
//        }

//        Relax();

//        CallNumber = _random.Next(1, 6);
//        for (int i = 0; i < CallNumber; i++)
//        {
//            Call();
//        }
//    }
//}

//public class Team
//{
//    public string TeamName;
//    private List<Worker> _teammates = new List<Worker>();

//    public Team(string name)
//    {
//        TeamName = name;
//    }

//    public void AddWorker(Worker worker)
//    {
//        _teammates.Add(worker);
//    }

//    public void TypeTeamInfo()
//    {
//        Console.WriteLine("Team name: " + TeamName);
//        foreach (Worker teammate in _teammates)
//        {
//            Console.WriteLine(teammate.Name);
//        }
//    }

//    public void TypeDetailedTeamInfo()
//    {
//        Console.WriteLine("Team name: " + TeamName);
//        foreach (Worker teammate in _teammates)
//        {
//            Console.WriteLine(teammate.Name + " - " + teammate.Position + " - " + teammate.WorkDay);
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Console.InputEncoding = Encoding.Unicode;
//        Console.OutputEncoding = Encoding.Unicode;

//        List<Team> teams = new List<Team>();

//        while (true)
//        {
//            Console.Write("\nВведіть назву команди (або '-' для завершення): ");
//            string teamName = Console.ReadLine() ?? "";
//            if (teamName == "-")
//            {
//                break;
//            }

//            Team team = new Team(teamName);

//            while (true)
//            {
//                Console.Write("\nВведіть ПІБ співробітника (або '-' для завершення команди): ");
//                string workerName = Console.ReadLine() ?? "";
//                if (workerName == "-")
//                {
//                    break;
//                }

//                Console.WriteLine("Оберіть роль: 1 - Розробник, 2 - Менеджер");
//                Console.Write("Ваш вибір: ");
//                string WrittenPosition = Console.ReadLine() ?? "";

//                Worker worker;
//                if (WrittenPosition == "1")
//                {
//                    worker = new Developer(workerName);
//                }
//                else if (WrittenPosition == "2")
//                {
//                    worker = new Manager(workerName);
//                }
//                else
//                {
//                    Console.WriteLine("Некоректне введення, спробуйте ще раз.");
//                    continue;
//                }

//                worker.FillWorkDay();
//                team.AddWorker(worker);
//            }

//            teams.Add(team);
//        }

//        Console.WriteLine("\nПоказати загальну чи детальну інформацію? (1 - загальна, 2 - детальна)");
//        string choice = Console.ReadLine() ?? "";

//        foreach (Team t in teams)
//        {
//            Console.WriteLine();
//            if (choice == "2")
//            {
//                t.TypeDetailedTeamInfo();
//            }
//            else
//            {
//                t.TypeTeamInfo();
//            }
//        }

//        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
//        Console.ReadKey();
//    }
        
//}