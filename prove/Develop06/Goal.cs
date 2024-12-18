public abstract class Goal
{
    private string _shortName;
    private string _descrition;
    private int _points;

    protected Goal(string name, string descrition, int points)
    {
        this._shortName = name;
        this._descrition =descrition;
        this._points = points;
    }
    public virtual void RecordEvent(){

    }
    public virtual void IsComplete(){

    }
    public virtual string GetDetailsString(){
        return"";

    }
    public virtual string GetStringRepresentation(){
        return"";

    }

}