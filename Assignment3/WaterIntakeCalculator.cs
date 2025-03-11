// Finished by Manish Raj Moriche on 11th March 2025

namespace Assignment3;

public class WaterIntakeCalculator(Person person)
{
    private readonly Person person = person;

    // Calculate daily water intake
    public (decimal amount, int glasses) Calculate()
    {
        decimal baseIntake = GetBaseIntake();
        decimal adjustedIntake = baseIntake * GetGenderMultiplier()
                                         * GetAgeMultiplier()
                                         * GetHeightMultiplier()
                                         * GetActivityMultiplier();

        int glasses = (int)Math.Round((double)(adjustedIntake / 240.0m));
        
        if (person.UnitSystem == UnitSystem.Imperial)
            adjustedIntake *= 0.033814m; // Convert to fluid ounces

        return (adjustedIntake, glasses);
    }

    // Base intake based on weight
    private decimal GetBaseIntake()
    {
        return person.GetWeightInKg() * 33m; // 33ml per kg
    }

    // Multiplier based on gender
    private decimal GetGenderMultiplier() =>
        person.Gender == Gender.Male ? 1.1m : 0.9m;

    // Multiplier based on age
    private decimal GetAgeMultiplier()
    {
        int age = person.GetAge();
        if (age < 30) return 1.1m;
        if (age > 55) return 0.9m;
        return 1.0m;
    }

    // Multiplier based on height
    private decimal GetHeightMultiplier()
    {
        decimal heightCm = person.GetHeightInCm();
        if (heightCm > 175) return 1.05m;
        if (heightCm < 160) return 0.95m;
        return 1.0m;
    }

    // Multiplier based on activity level
    private decimal GetActivityMultiplier() =>
        person.ActivityLevel switch
        {
            ActivityLevel.Low => 1.0m,
            ActivityLevel.Medium => 1.2m,
            ActivityLevel.High => 1.5m,
            _ => 1.0m
        };
}