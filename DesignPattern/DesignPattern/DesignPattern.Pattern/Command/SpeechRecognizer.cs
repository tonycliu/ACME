using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Pattern.Command
{
    public class SpeechRecognizer
    {
        private IVoiceCommand upCommand, downCommand;

        public virtual void SetCommands(IVoiceCommand upCommand, IVoiceCommand downCommand)
        {
            this.upCommand = upCommand;
            this.downCommand = downCommand;
        }

        public virtual void HearUpCommand()
        {
            upCommand.Execute();
        }

        public virtual void HearDownCommand()
        {
            downCommand.Execute();
        }
    }
}
