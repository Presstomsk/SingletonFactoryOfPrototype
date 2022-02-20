

using System;

namespace SingletonFactoryOfPrototype
{
    public interface IHuman : ICloneable
    {
        string Name { get; set; }
        int Age { get; set; }      

    }
}
