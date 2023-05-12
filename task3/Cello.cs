using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Cello : StringInstrument
    {
        public string CelloSound { get; set; }
        public Cello(string name, string description, string history, int countStrings, string celloSound) : base(name, description, history, countStrings)
        {
            CelloSound = celloSound;
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
            Console.WriteLine(CelloSound);
        }
    }
}
