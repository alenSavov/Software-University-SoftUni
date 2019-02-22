using System;
using System.Collections.Generic;
using System.Text;


public abstract class Harvester : Unit
{
    const double MAX_ENERGY_REQUIREMENT = 10_000;

    private double oreOutput;
    private double energyRequirement;

    public double OreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's OreOutput");
            }
            oreOutput = value;
        }
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 || value >= MAX_ENERGY_REQUIREMENT)
            {
                throw new ArgumentException($"Harvester is not registered, because of it's EnergyRequirement");
            }
            energyRequirement = value;
        }
    }

    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        OreOutput = oreOutput;
        EnergyRequirement = energyRequirement;
    }

    public override string ToString()
    {
        return $"{Type} Harvester - {Id}" + Environment.NewLine +
                $"Ore Output: {OreOutput}" + Environment.NewLine +
                $"Energy Requirement: {EnergyRequirement}";

    }
}

