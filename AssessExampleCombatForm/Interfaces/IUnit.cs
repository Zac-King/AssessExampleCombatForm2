using System.Xml;

namespace Combat.Interfaces
{
    public interface IUnit
    {
        string Name         { get; }
        string ClassName    { get; }

        int MaxHealth       { get; }
        int Health          { get; set; }

        float Speed         { get; set; }

        float Dexerity      { get; set; }
        float Intelligence  { get; set; }
        float Strength      { get; set; }
    }
}
