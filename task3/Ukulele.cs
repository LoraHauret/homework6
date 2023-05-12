using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Ukulele : StringInstrument
    {
        public string UkuleleSound { get; set; }
        public Ukulele(string name, string description, string history, int countStrings, string ukuleleSound) : base(name, description, history, countStrings)
        {
            UkuleleSound = ukuleleSound;
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
            Console.WriteLine(UkuleleSound);
        }
    }
}
