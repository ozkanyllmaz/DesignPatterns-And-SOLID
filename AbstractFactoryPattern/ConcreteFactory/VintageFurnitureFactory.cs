using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.ConcreteFactory
{
    public class VintageFurnitureFactory : IFurnitureFactory
    {
        public IChair CreateChair() => new ModernChair();

        public ISofa CreateSofa() => new ModernSofa();
    }
}
