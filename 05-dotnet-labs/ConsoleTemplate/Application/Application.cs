using System;
using System.Collections;
using System.Collections.Generic;


namespace BgLab.ConsoleLib;


/// <summary>
/// Application abstract class to encapsulate a minimum console app.
/// Basic command line structure
/// L1         L2        L3   L4
/// --command VALUE      -c   OPTION_VALUE
/// </summary>
public class Application
{
     private string _appname = string.Empty;
     private string _helpTemplate = string.Empty;
     
     public Application(string name)
     {
          _appname = name;
     }
     public void AddCommand(Command command)
     {

     }
    public void Run()
    {
      //command logi pattern

    }

}
