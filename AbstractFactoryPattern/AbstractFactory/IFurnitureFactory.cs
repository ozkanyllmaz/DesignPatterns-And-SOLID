using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.AbstractFactory
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
