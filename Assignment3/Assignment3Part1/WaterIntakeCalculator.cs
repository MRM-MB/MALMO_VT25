using System;
namespace Assignment3Part1;

public class WaterIntakeCalculator
{
    private Person person;

    public WaterIntakeCalculator(Person person)
    {
        this.person = person;
    }

    public double CalculateDailyWaterIntake()
    {
        double baseIntake = person.Weight * 33; // Base intake in ml

        // Gender adjustment
        baseIntake *= (person.Gender == Gender.Male) ? 1.1 : 0.9;

        // Age adjustment
        if (person.Age < 30) baseIntake *= 1.1;
        else if (person.Age > 55) baseIntake *= 0.9;

        // Height adjustment
        if (person.Height > 175) baseIntake *= 1.05;
        else if (person.Height < 160) baseIntake *= 0.95;

        // Activity level adjustment
        switch (person.ActivityLevel)
        {
            case ActivityLevel.Medium:
                baseIntake *= 1.2;
                break;
            case ActivityLevel.High:
                baseIntake *= 1.5;
                break;
        }

        return baseIntake;
    }

    public double ConvertToOunces(double ml) => ml * 0.033814;
    public int ConvertToGlasses(double ml) => (int)(ml / 240);
}