using System;

namespace BgLab.ConsoleLib;


public class Command : IConsoleArgBus
{
      private string[]? _args;
      private string _key;
      private string _description;
      private Action<string[]>? _action;
      
      public Command(string key, string description = " ")
      {
            _key = key;
            _description = description;
      }
      public void SetAction(Action<string[]> action)
      {
            _action = action;
      }

      public void LoadArgs(string[] args)
      {
            _args = args;
      }
      public bool KeyValidate(string input)
      {
            if(input == _key) return true;
            return false;
      }
      public void Invoke()
      {
            if(_action is null) throw new NullReferenceException(nameof(_action));
            if(_args is null) throw new NullReferenceException(nameof(_args));

            _action(this._args);
      }


}