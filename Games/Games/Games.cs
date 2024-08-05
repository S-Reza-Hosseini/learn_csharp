using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.consoleApp;

public abstract class Game
{
    public abstract string Name { get;}
    
    public virtual string Description => String.Empty;
    public void Start()
    {
        Console.WriteLine($"Game {Name} started");
        Play();
    }

    protected abstract void Play();
}
