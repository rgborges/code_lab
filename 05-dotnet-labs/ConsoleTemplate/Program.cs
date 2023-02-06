// See https://aka.ms/new-console-template for more information
using System;
using BgLab.ConsoleLib;
using BgLab.ConsoleLib.Test.Function;

Console.WriteLine("Hello, World!");

var command = new Command("--name", "set the name");
command.SetAction((argumentBus) => {
    if(argumentBus.Length < 1) return;

    HelloAction.SayHi(argumentBus[1]);
});
/*

var command = new CommandBuilder()
                     .AddCommand("--build", "build things")
                     .WithOption("-c", "change the color")
                     .WithAction((c) => {
                                var parameter = c.CommandParameter;
                                   if(paramter is not validated)
                                          Display.ErrorMessage
                                   
                                   follow the procedure 
                                   Function.BuildCarCommand(c.CommandParameter);
                     });

app.AddCommand(command);

app.Run();

program.exe --build car -c blue

context

Build Command (--build, car)
Build Option  (-c blue)
*/
