// Müşteri "Modern" bir takım istedi!
using AbstractFactoryPattern;
using AbstractFactoryPattern.AbstractFactory;
using AbstractFactoryPattern.ConcreteFactory;

Console.WriteLine("--- Modern Takım Siparişi ---");
IFurnitureFactory modernFactory = new ModernFurnitureFactory();

// Patron fabrikadan takımı istiyor (Ne geldiğini bilmesine gerek yok, arayüz yeterli)
IChair chair1 = modernFactory.CreateChair();
ISofa sofa1 = modernFactory.CreateSofa();

chair1.SitOn();
sofa1.LieOn();