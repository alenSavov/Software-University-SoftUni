using System;
using System.Collections.Generic;
using System.Text;

public class Dough
{
    private const int CALORIES_PER_GRAM = 2;

    private const double CALORIES_WHITE = 1.5;
    private const double CALORIES_WHOLEGRAIN = 1.0;

    private const double CALORIES_CRISPY = 0.9;
    private const double CALORIES_CHEWY = 1.1;
    private const double CALORUES_HOMEMADE = 1.0;

    private const string DOUGH_TYPE_ERROR = "Invalid type of dough.";
    private const string DOUGH_WEIGHT_ERROR = "Dough weight should be in the range [1..200].";

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }

    public string FlourType
    {
        get
        {
            return this.flourType;
        }
        private set
        {
            if (value != "white" && value != "wholegrain")
            {
                throw new Exception(DOUGH_TYPE_ERROR);
            }

            this.flourType = value;

        }
    }

    public string BakingTechnique
    {
        get
        {
            return this.bakingTechnique;
        }
        private set
        {
            if (value != "crispy" && value != "chewy" && value != "homemade")
            {
                throw new Exception(DOUGH_TYPE_ERROR);
            }

            this.bakingTechnique = value;
        }
    }


    public double Weight
    {
        get
        {
            return this.weight;
        }
        private set
        {
            if (value < 1 || value > 200)
            {
                throw new Exception(DOUGH_WEIGHT_ERROR);
            }

            this.weight = value;
        }
    }

    public double DoughCalories()
    {
        return (CALORIES_PER_GRAM * this.Weight) * FlourModifier() * BankingTechniqueModifier();
    }

    public double BankingTechniqueModifier()
    {
        if (this.FlourType == "white")
        {
            return CALORIES_WHITE;
        }

        return CALORIES_WHOLEGRAIN;
    }

    private double FlourModifier()
    {
        if (this.BakingTechnique == "crispy")
        {
            return CALORIES_CRISPY;
        }
        else if (this.BakingTechnique == "chewy")
        {
            return CALORIES_CHEWY;
        }
        else
        {
            return CALORUES_HOMEMADE;
        }
    }
}