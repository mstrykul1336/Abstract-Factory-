using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicleFactory
{
    IVehicle Create(VehicleRequirements requirements);
}


public class CycleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.NumberOfBlocks)
        {
            case 1:
                if (requirements.NumberOfBodySeg == 1) return new Fish();
                if (requirements.NumberOfBodySeg == 3) return new Snowman();
                return new TryAgain();
            case 2:
                if (requirements.NumberOfBodySeg == 2) return new Spider();
                return new TryAgain();
            default:
                return new Silverfish();
        }

    }

}

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.NumberOfBodySeg)
        {
            case 2:
                if (requirements.NumberOfBlocks == 1) return new BabyCat();
                return new Cat();
            case 3:
                if (requirements.NumberOfBlocks == 1) return new BabyFox();
                return new Fox();
            case 4:
                if (requirements.Chest && requirements.NumberOfBlocks == 2)return new Donkey();
                else if (requirements.NumberOfBlocks == 2) return new Llama();
                else if (requirements.NumberOfBlocks == 1) return new TryAgain();
                return new Villager();
            default:
                return new Turtle();
        }
    }
}

public abstract class AbstractVehicleFactory
{
    //public abstract IVehicleFactory CycleFactory();
    //public abstract IVehicleFactory MotorVehicleFactory();

    public abstract IVehicle Create();
}



public class VehicleFactory : AbstractVehicleFactory
{
    //public override IVehicleFactory CycleFactory()
    //{
    //    return new CycleFactory();
    //}

    //public override IVehicleFactory MotorVehicleFactory()
    //{
    //    return new MotorVehicleFactory();
    //}

    private readonly IVehicleFactory _factory;
    private readonly VehicleRequirements _requirements;

    public VehicleFactory(VehicleRequirements requirements)
    {
        _factory = requirements.Tamable ? (IVehicleFactory) new MotorVehicleFactory() : new CycleFactory();
        _requirements = requirements;
    }

    public override IVehicle Create()
    {
        return _factory.Create(_requirements);
    }


}