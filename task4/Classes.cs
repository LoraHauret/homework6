namespace task4
{
    internal class Worker
    {
        public static uint Id = 0;

        public uint ID { get; }
        public string NSF { get; private set; }
        public ushort Age{get; protected set;}

        public double Salary { get; protected set;}
        public Worker(string nsf, ushort age, double salary)
        {
            ID = ++Id;
            this.NSF = nsf;
            Age = age;
            Salary = salary;
        }
        public virtual void Print()
        {            
            Console.WriteLine($"\n\n{ID}\nФИО: {NSF}\nВозраст: {Age}\nЗарплата: {Salary}");
        }
    }
    
    internal class President:Worker
    {
        public Manager[] ManagerArr { get; private set; }
        public President(string nsf, ushort age, uint salary, Manager[] managers):base(nsf, age, salary) 
        {
            ManagerArr = managers;
        }
        public override void Print()
        {
            
            base.Print();
            Console.WriteLine("Должность: Президент");
            Console.WriteLine("\n\t\tМенеджеры: ");
            foreach (Manager m in ManagerArr) 
            {
                m.Print();
               // Console.Write("\t{0}. {1}", m.ID, m.NSF);
            }
        }
    }
    internal class Security : Worker
    {
        public string SecurityAreaCode { get; private set; }
        public Security(string nsf, ushort age, uint salary, string securityAreaCode) : base(nsf, age, salary)
        {
            SecurityAreaCode = securityAreaCode;
        }
        public override void Print()
        {            
            base.Print();
            Console.WriteLine("Должность: Охранник");
        }
    }
    internal class Manager : Worker
    {
        public Worker[] Workers { get; protected set; }
        public string Department { get; private set; }
        public Manager(string nsf, ushort age, uint salary, Worker[] workers, string department) : base(nsf, age, salary)
        {
            Workers = workers;
            Department = department;
        }
        public override void Print()
        {            
            base.Print();
            Console.WriteLine("Должность: Менеджер");
            Console.WriteLine("Отделение: {0}", Department);
            Console.WriteLine("\n\t\tРаботники: ");
            foreach (Worker w in Workers)
            {
                w.Print();
            }
        }
    }

    internal class Engineer : Worker
    {
        public string Specialisation { get; private set; }
        public Engineer(string nsf, ushort age, uint salary, string specialisation) : base(nsf, age, salary)
        {
            Specialisation = specialisation;
        }
        public override void Print()
        {            
            base.Print();
            Console.WriteLine("Инженер");
            Console.WriteLine($"Специализация: {Specialisation}");
        }
    }
}