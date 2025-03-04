using System;
namespace Assignment3Part1;

public enum Gender { Male, Female }
public enum ActivityLevel { Low, Medium, High }

public class Person
{
    private double weight;  // kg
    private double height;  // cm
    private int birthYear;
    private Gender gender;
    private ActivityLevel activityLevel;

    public Person(double weight, double height, int birthYear, Gender gender, ActivityLevel activityLevel)
    {
        this.weight = weight;
        this.height = height;
        this.birthYear = birthYear;
        this.gender = gender;
        this.activityLevel = activityLevel;
    }

    public double Weight => weight;
    public double Height => height;
    public int Age => DateTime.Now.Year - birthYear;
    public Gender Gender => gender;
    public ActivityLevel ActivityLevel => activityLevel;
}