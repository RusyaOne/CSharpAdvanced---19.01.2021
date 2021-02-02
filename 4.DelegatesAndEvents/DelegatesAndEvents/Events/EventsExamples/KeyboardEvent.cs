using System;

namespace Events.EventsExamples
{
    public static class KeyboardEvent
    {
        public static void SpectateKeyboard()
        {
            Keyboard keyboard = new Keyboard();

            keyboard.PressKeyXEvent += PressXHandler;
            keyboard.PressKeyYEvent += PressYHandler;

            keyboard.PressKeyXEvent -= PressXHandler;

            keyboard.StartSpectate();
        }

        private static void PressXHandler()
        {
            Console.WriteLine("'x' letter has been pressed");
        }

        private static void PressYHandler()
        {
            Console.WriteLine("'y' letter has been pressed");
        }
    }


    public delegate void PressKeyHandler();

    public class Keyboard
    {
        public event PressKeyHandler PressKeyXEvent;
        public event PressKeyHandler PressKeyYEvent;

        public void StartSpectate()
        {
            string input = string.Empty;
            Console.WriteLine("Enter 'x' or 'y'");

            while (input != "exit")
            {
                input = Console.ReadLine();
                switch (input)
                {
                    case "x":
                        PressKeyXEvent?.Invoke();
                        break;
                    case "y":
                        PressKeyYEvent?.Invoke();
                        break;
                    default:
                        Console.WriteLine($"There is no handler for key {input}");
                        //input = "exit";
                        break;
                }
            }
        }
    }
}