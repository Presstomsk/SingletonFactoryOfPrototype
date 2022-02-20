

namespace SingletonFactoryOfPrototype
{

    
    public class CloneHumanFactory  //Singletone фабрика
    {       

        private static CloneHumanFactory _singleton;        

        private CloneHumanFactory()
        {              
        }
        public static CloneHumanFactory GetSingletone()
        {
            if (_singleton == null)
            {
                _singleton = new CloneHumanFactory();
            }
            return _singleton;            
        }        

        public IHuman HumanCloneFactory(IHuman human)     
        {
            return human != default ? (IHuman)human?.Clone() : default;            
        }
    }
}
