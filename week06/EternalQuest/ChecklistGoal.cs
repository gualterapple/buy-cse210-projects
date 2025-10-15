using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Goal completed! You earned {GetPoints() + _bonus} points!");
        }
        else
        {
            Console.WriteLine($"Progress made! You earned {GetPoints()} points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[X]" : "[ ]")} {GetName()} ({GetDescription()}) -- Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetName()},{GetDescription()},{GetPoints()},{_bonus},{_target},{_amountCompleted}";
    }
}
