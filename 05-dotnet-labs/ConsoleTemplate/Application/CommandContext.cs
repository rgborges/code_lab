using System;

namespace BgLab.ConsoleLib
{
      public class CommandContext<T> : ValidationObject
      {
            private string[] _args;
            private int _keyIndex = 0;
            private int _keyParameter = 0;
            
            public CommandContext(string[] args)
            {
                  _args = args;
            }
            private void Parse()
            {

            }
      }
}