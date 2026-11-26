using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Cool Game");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        Window.ClearBackground(Color.Red);
    }
}
