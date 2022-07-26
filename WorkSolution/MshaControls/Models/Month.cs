namespace MshaControls.Models;

public class Month
{
    private string _name { get; set; }
    public Month(string name)
    {
        _name = name;
    }

    public override string ToString()
    {
        return _name;
    }

    public override int GetHashCode()
    {
        return _name.GetHashCode();
    }
}