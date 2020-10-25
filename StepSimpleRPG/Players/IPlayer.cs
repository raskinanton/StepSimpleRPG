using StepSimpleRPG.Misc;

namespace StepSimpleRPG.Players
{
    public interface IPlayer
    {
        string ToString();

        void pushItems();
        Specifications Specs { get; set; }
    }
}
