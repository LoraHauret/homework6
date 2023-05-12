namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Device[] deviceArr = new Device[4];
            deviceArr[0] = new Cattle("Чайник ", Cattle.voiceArr[rand.Next(Cattle.voiceArr.Length)], "обычный", "хромированный", 4);
            deviceArr[1] = new Microwave("Микроволновая печь", Microwave.voiceArr[rand.Next(Microwave.voiceArr.Length)], "встраеваемая", "параллипепипед");
            deviceArr[2] = new Car("Opel Ascona C", Car.voiceArr[rand.Next(Car.voiceArr.Length)], "один из последних европейских двухдверных седанов", "Седан");
            deviceArr[3] = new Boat("Корабль", Boat.voiceArr[rand.Next(Boat.voiceArr.Length)], "летучий голландец", "500 тонн");
            foreach (var device in deviceArr) 
            {
                device.ShowName();
                device.ShowDescr();
                device.MakeSound();                
            }

        }
    }

    internal class Device
    {
        protected Random rand = new Random();
        public string Name { get; set; }
        public string Sound { get; set; }
        public string Description { get; set; }
        public Device() { }

        public Device(string name, string sound, string description)
        {
            this.Name = name;
            this.Sound = sound;
            this.Description = description;
        }
        public virtual void MakeSound()
        {
            Console.Write("\nЗвук: ");
            if (!string.IsNullOrEmpty(Sound))
                Console.Write(Sound + " ");
            else
                Console.WriteLine("Я не издаю звуков!");
        }

        public void ShowName()
        {
            Console.Write("\nНазвание: {0} ", Name);
        }
        public void ShowDescr()
        {
            Console.Write("\nОписание: {0} ", Description);
        }
        public override string ToString()
        {
            return string.Format($"\nНазвание: {Name}\nОписание: {Description}");
        }

    }

    internal class Cattle : Device
    {
        static public string[] voiceArr = { "Буль, буль", "nПфррр", "Пшшшш", "Иииии", "Звук физико-энергетического градиента, формирующегося на начальной стадии возникновения тепловой разности на границе поверхности нагревателя и водной субстанции.", "Рррр", "Иуиуууу", "Звук смятия конфетных оберток" };
        public string Color { get; set; }
        public int Volume { get; set; }
        public Cattle() { }
        public Cattle(string aName, string aSound, string aDescription, string aColor, int aVolume) : base(aName, aSound, aDescription)
        {
            Color = aColor;
            Volume = aVolume;
        }
        /*public override void ShowName()
        {
            base.ShowName();           
        }
        public override void ShowDescr()
        {
            base.ShowDescr();            
        }*/
        public override void MakeSound()
        {
            base.MakeSound();
            Console.Write(", ");
            Console.WriteLine(voiceArr[rand.Next(0, voiceArr.Length)]);

        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nЦвет: {Color},\nОбъем: [1]");
        }

    }
    internal class Microwave : Device
    {
        static public string[] voiceArr = { "Хлоп хлоп", "пиии пиии пиии", "Дзынь", "Чпок-чпок-чпок", "Брынь-брынь", "Звук схлопывающихся шариков", "Звук лопающегося попкорна", "УуууУууууУууу(Уууу)Дзынь", "[*], (Дзынь)" };

        public string Form { get; set; }
        public string Type { get; set; }
        public Microwave(string aName, string aSound, string aDescription, string aForm) : base(aName, aSound, aDescription)
        {
            Form = aForm;
        }
        public override void MakeSound()
        {
            base.MakeSound();
            Console.Write(", ");
            Console.WriteLine(voiceArr[rand.Next(0, voiceArr.Length)]);

        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"Форма: {Form}\nТип: {Type}");
        }

    }

    internal class Car : Device
    {
        static public string[] voiceArr = { "Шипение", "Клацанье", "Визжание(резкий визг)", "Металлический визг", "Треск и хруст", "Рычание и вибрация", "Звук удара, свист", "Звук дребезжания, стук", "Хруст", "Вой", "Ласковое, нежное мурчание", "Дыр-дыр-дыр", "Трррррррррр клац", "Тишина", };

        public string BodyType { get; set; }

        public Car(string aName, string aSound, string aDescription, string aBodyType) : base(aName, aSound, aDescription)
        {
            BodyType = aBodyType;
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.Write(", ");
            Console.WriteLine(voiceArr[rand.Next(0, voiceArr.Length)]);

        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nТип кузова: {BodyType}");
        }

    }

    internal class Boat : Device
    {
        static public string[] voiceArr = { "при падении:\"Бум!\"", "при сминании:\"Шршршршр!\"", "при стоянии:\"я гордый молчаливый корабль!\"", "при ношении:\"ааах!\"", "при поедании:\"Ойей!\"", "\"Там тагадам там там там там!\"", "\"я тише и ниже воды!\"", "Ту-ту!", "\"Смысл в имени моем!\"" };
        public string IndividualVoice { get; private set; }
        public string LoadCapacity { get; set; }

        public Boat(string aName, string aSound, string aDescription, string aLoadCapacity) : base(aName, aSound, aDescription)
        {
            LoadCapacity = aLoadCapacity;
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.Write(", ");
            Console.WriteLine(voiceArr[rand.Next(0, voiceArr.Length)]);

        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"\nГрузопьдъемность: {LoadCapacity}");
        }

    }
}