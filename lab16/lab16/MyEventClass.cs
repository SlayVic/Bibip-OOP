using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16
{
  internal class MyEventClass
  {
    public delegate void myEventHandler();
    public event myEventHandler? SEvent;
    public event myEventHandler? EscEvent;

    public MyEventClass()
    {
      StartChecking();
    }

    private void StartChecking()
    {
      Task.Run(() =>
      {
        ConsoleKeyInfo cki;
        while (true)
        {
          cki = Console.ReadKey();
          switch (cki.Key)
          {
            case ConsoleKey.S:
              SEvent?.Invoke();
              break;
            case ConsoleKey.Escape:
              EscEvent?.Invoke();
              break;
          }
        }
      });
    }
  }
}
