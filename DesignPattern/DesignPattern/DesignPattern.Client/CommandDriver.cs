using DesignPattern.Model;
using DesignPattern.Pattern.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class CommandDriver
    {
        public static void Run()
        {
            Radio radio = new Radio();
            radio.SwitchOn();
            IVoiceCommand volumeUpCommand = new VolumeUpCommand(radio);
            IVoiceCommand volumeDownCommand = new VolumeDownCommand(radio);

            ElectricWindow window = new ElectricWindow();
            IVoiceCommand windowUpCommand = new WindowUpCommand(window);
            IVoiceCommand windowDownCommand = new WindowDownCommand(window);

            SpeechRecognizer sr = new SpeechRecognizer();
            Console.WriteLine("Radio is ready for commands");       
            sr.SetCommands(volumeUpCommand, volumeDownCommand);
            sr.HearUpCommand();
            sr.HearUpCommand();
            sr.HearUpCommand();
            sr.HearDownCommand();
            radio.SwtichOff();

            Console.WriteLine("Window is ready for commands");
            sr.SetCommands(windowUpCommand, windowDownCommand);
            sr.HearDownCommand();
            sr.HearUpCommand();
        }
    }
}
