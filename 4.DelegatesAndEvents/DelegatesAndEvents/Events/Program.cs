using Events.EventsExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var exampleToRun = ExamplesEnumeration.KeyboardEvent;

            switch (exampleToRun)
            {
                case ExamplesEnumeration.EventBasicSyntax:
                    BasicSyntaxEvent.ShowEvent();
                    break;
                case ExamplesEnumeration.ShortSyntaxEvent:
                    ShortSyntaxEvent.ShowShortSyntaxEvent();
                    break;
                case ExamplesEnumeration.EvenShorterSyntax:
                    //EvenShorterSyntaxEvent.ShowEvent();
                    break;
                case ExamplesEnumeration.KeyboardEvent:
                    KeyboardEvent.SpectateKeyboard();
                    break;
            }

            Console.Read();
        }
    }
}
