public class CheckListGoal : Goal{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string amountCompleted, int target, int bonus, string descrition, string shortName, int points) :base(shortName,descrition,points){}

    public override void RecordEvent(){

    }
    public override void IsComplete()
    {
    }
    public override string GetDetailsString()
    {
        return base.GetDetailsString();
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}