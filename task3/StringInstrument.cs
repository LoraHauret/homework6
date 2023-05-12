using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class StringInstrument : MusicalInstrument
    {
        public int CountStrings { get; private set; }
        public StringInstrument(string name, string description, string history, int countStrings) : base(name, description, history)
        {
            CountStrings = countStrings;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Количество струн: {CountStrings}");

        }
        public override void Descr()
        {
            base.Descr();

        }

        public override void Hist()
        {
            base.Hist();
        }
        public override string ToString()
        {
            return base.ToString() + string.Format($"Количество струн: {CountStrings}");
        }

        public override void MakeSound()
        {
            Console.Write("Струнный инструмент ");
            base.MakeSound();
        }
    }
}
