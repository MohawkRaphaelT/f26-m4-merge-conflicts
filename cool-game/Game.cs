using System;
using System.Numerics;

namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Cool Game");
        Window.SetSize(1920, 1080);
    }

    public void Update()
    {
        Window.ClearBackground(Color.OffWhite);
    }
}
