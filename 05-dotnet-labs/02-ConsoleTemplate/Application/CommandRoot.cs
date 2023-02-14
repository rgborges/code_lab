using System.Collections;
using System.Collections.Generic;


namespace BgLab.ConsoleLib;


public class CommandRoot
{
      public List<Command> _commands;
      public CommandRoot()
      {
            _commands = new List<Command>();
      }
}