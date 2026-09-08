namespace LotoSim.Core
{
    public class EnergySource
    {
        public readonly string Id;
        public readonly string DisplayName;
        public readonly EnergyType Type;
        public readonly ControlSteps Required;

        public EnergySource(string id, string displayName, EnergyType type, ControlSteps required)
        {
            Id = id;
            DisplayName = displayName;
            Type = type;
            Required = required;
        }
    }
}