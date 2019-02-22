using System;
using System.Collections.Generic;
using System.Text;


public interface IBuyer
{
    string Name { get; }
    void BuyFood();

     int Food { get; }
}

