using APBD_Tut3.Exceptions;
using APBD_Tut3.Interfaces;

namespace APBD_Tut3;

public class Container : IContainer
{
    public double CargoMass { get; set; }
    public int Height { get; set; }

    public Container(double cargoMass, int height)
    {
        CargoMass = cargoMass;
        Height = height;
    }


    public void Unload()
    {
        throw new NotImplementedException();
    }

    
    public virtual void Load(double cargoWeight)
    {
        throw new OverfillException();
    }
}
