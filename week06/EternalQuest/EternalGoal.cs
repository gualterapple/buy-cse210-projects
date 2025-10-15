using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Nice work! You earned {GetPoints()} points!");
    }

    public override bool IsComplete() => false;

    public override string GetDetailsString()
    {
        return $"[∞] {GetName()} ({GetDescription()})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetPoints()}";
    }
}
