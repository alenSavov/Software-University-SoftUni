using System;
using System.Collections.Generic;
using System.Text;


public interface ICommando : ISpecialisedSoldier
{
    IList<IMission> Missions { get; }
}

