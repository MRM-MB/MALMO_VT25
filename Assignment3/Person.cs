namespace Assignment3;

public class Person
{
    private string name = string.Empty;
    private decimal height;
    private decimal heightInches;
    private decimal weight;
    private int birthYear;
    private Gender gender;
    private ActivityLevel activityLevel;
    private UnitSystem unitSystem;

    public string Name { get => name; set => name = value; }
    public decimal Height { get => height; set => height = value; }
    public decimal HeightInches { get => heightInches; set => heightInches = value; }
    public decimal Weight { get => weight; set => weight = value; }
    public int BirthYear { get => birthYear; set => birthYear = value; }
    public Gender Gender { get => gender; set => gender = value; }
    public ActivityLevel ActivityLevel { get => activityLevel; set => activityLevel = value; }
    public UnitSystem UnitSystem { get => unitSystem; set => unitSystem = value; }

    public int GetAge() => DateTime.Now.Year - birthYear;

    public decimal GetHeightInCm()
    {
        if (unitSystem == UnitSystem.Metric)
            return height;
        return (height * 30.48m) + (heightInches * 2.54m);
    }

    public decimal GetWeightInKg()
    {
        if (unitSystem == UnitSystem.Metric)
            return weight;
        return weight * 0.453592m;
    }
}
