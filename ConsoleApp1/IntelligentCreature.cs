using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class IntelligentCreature //абстрактный класс
    {
        private int lifelength;
        protected int LifeLength
        {
            get => lifelength; //крутые лямбда-функции для настоящих мужиков
            set => lifelength = value;
        }

        private string name;
        protected string Name
        {
            get => name;
            set => name = value;
        }
    }
}
