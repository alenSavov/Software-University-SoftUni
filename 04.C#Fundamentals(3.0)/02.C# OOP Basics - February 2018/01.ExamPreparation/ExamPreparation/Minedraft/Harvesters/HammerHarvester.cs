﻿using System;
using System.Collections.Generic;
using System.Text;


public class HammerHarvester : Harvester
{
    public override string Type => "Hammer";

    public HammerHarvester(string id, double oreOutput, double energuRequirement)
        : base(id, oreOutput * 3, energuRequirement * 2)
    {
    }

}

