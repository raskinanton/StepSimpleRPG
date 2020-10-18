using StepSimpleRPG.Misc;

namespace StepSimpleRPG.Players
{
    public interface IPlayer
    {
        string ToString();
        Specifications Specs { get; set; }
    }
}
