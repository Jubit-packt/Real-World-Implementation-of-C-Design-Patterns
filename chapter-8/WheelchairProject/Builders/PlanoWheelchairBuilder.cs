﻿using System.Dynamic;

namespace WheelchairProject.Builders;

public class PlanoWheelchairBuilder : IWheelchairBuilder
{
    private PlanoWheelchair _wheelchair;

    public PlanoWheelchairBuilder()
    {
        Reset();
        
    }
    
    public void Reset()
    {
        _wheelchair = new PlanoWheelchair();
        
    }

    public void BuildFrame()
    {
        
    }

    public void BuildWheels()
    {
        throw new NotImplementedException();
    }

    public void BuildSeat()
    {
        // the seat is a leaf node so just make one ad add it as a component
        
        throw new NotImplementedException();
    }

    public void BuildComposite()
    {
        throw new NotImplementedException();
    }

    public void BuildFramePainter()
    {
        throw new NotImplementedException();
    }

    public Wheelchair GetProduct()
    {
        return new PlanoWheelchair();
    }
}