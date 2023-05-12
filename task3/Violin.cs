using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Violin:StringInstrument
    {
        public string ViolinSound { get; set; }
        public Violin(string name, string description, string history, int countStrings, string violinSound) : base(name, description, history, countStrings)
        {
            ViolinSound = violinSound;
        }
        public override void Show()
        {
            base.Show();

        }
        public override void Descr()
        {
            base.Descr();

        }

        public override void Hist()
        {
            base.Hist();
        }

        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine(ViolinSound);
        }
    }
}
