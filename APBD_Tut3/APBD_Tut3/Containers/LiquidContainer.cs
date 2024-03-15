namespace APBD_Tut3.Containers;

public class LiquidContainer : Container
{
    public LiquidContainer(double cargoMass, int height) : base(cargoMass, height)
    {
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }
}