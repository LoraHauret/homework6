using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Trombone:MusicalInstrument
    {
        public string TromboneSound { get; set; }
        public Trombone(string name, string description, string history, string tromboneSound):base(name,  description,  history)
        {
            TromboneSound = tromboneSound;
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
            Console.WriteLine(TromboneSound);
        }
    }
}
