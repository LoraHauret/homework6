namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List<Worker> workers = new List<Worker>();
            // workers.Add(new Worker("Александров Александр Александрович"));
            Worker w1 = new Worker("Александров Александр Александрович", 31, 10000);
            Worker w2 = new Worker("Олеговский Олег Олегович", 32, 10050);
            Worker w3 = new Worker("Кравец Екатерина Валерьевна", 24, 10100);
            Worker w4 = new Worker("Белобород Игорь Федорович", 26, 101010);
            Worker w5 = new Worker("Сковорода Иван Григорьевич", 21, 10000);
            Worker w6 = new Worker("Пагода Алена Мирославовна", 27, 10111);
            Worker w7 = new Worker("Абдулов Денис Леонидович", 34, 1000);
            Security s1 = new Security("Муха Боб Халкович", 30, 10500, "D-OUt453");
            Security s2 = new Security("Мухтар Джек Бузович", 30, 10500, "L-IN_Out82-3");
            Engineer e1 = new Engineer("Грамотный Человек Человекович", 30, 40000, "Разработка ПО");
            Engineer e2 = new Engineer("Умный Мудр Мудрович", 30, 40000, "Разработка межсетевой коммуникации");
            Manager m1 = new Manager("Крылова Ольга Александровна", 35, 15000, new Worker[] { w1, w2, w3, w4, s1, e1}, "Отдел продаж");
            Manager m2 = new Manager("Ялынько Кирилл Михайлович", 35, 15500, new Worker[] { w5, w6, w7, s2, e2 }, "Отдел логистики");
            President p = new President("Олигархов Олигарх Олигархович", 39, 0, new Manager[] { m1, m2 });
            p.Print();

        }
    }
}