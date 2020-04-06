using System.ComponentModel.Composition;
using System;

namespace MusicApp
{
    [Export]
    public class HelloSayer
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
}