
namespace SingletonFactoryOfPrototype
{
    public class Person : IHuman // Прототип
    {
        public string Name { get; set; } 
        public int Age { get; set; }       

        public Person(string name , int age)
        {
            Name = name;
            Age = age;
        }
       
        public object Clone()
        {
            return new Person(Name, Age);
        }
    }
}
