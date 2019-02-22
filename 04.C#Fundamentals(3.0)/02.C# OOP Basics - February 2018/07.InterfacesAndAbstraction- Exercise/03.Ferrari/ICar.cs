using System;
using System.Collections.Generic;
using System.Text;

public interface ICar
{
    string Driver { get; }
    string Model { get; }

    string UseBrakes();
    string PushTheGasPedal();


}

