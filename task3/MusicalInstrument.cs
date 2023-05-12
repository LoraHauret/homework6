using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class MusicalInstrument
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string History { get; private set; }
        public MusicalInstrument(string name, string descr, string history) 
        { 
            Name = name;
            Description = descr;
            History = history;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Название инструмента: {Name}"); //\n\nИстория: {History}");
        }
        public virtual void Descr()
        {
            Console.WriteLine($"Опиcание: {Description}");
        }

        public virtual void Hist()
        {
            Console.WriteLine($"История: {History}");
        }
        public override string ToString() 
        {
            return string.Format("\n***Название инструмента: {0},\nОпиcание: {1},\nИстория: {2}", Name, Description, History);
        }

        public virtual void MakeSound()
        {
            Console.Write($"{Name} звучит: ");
        }
    }

}
