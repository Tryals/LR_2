using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_2
{
    internal class ClassAero
    {
        //поля
        private string name;
        private double number;
        private string type;
        // свойства для доступа к полям
        public string NAME
        {
            get { return name; }//возвращает значение поля
            set { name = value; } //устанавливает значение поля
        }

        public double Num
        {
            get { return number; }
            set { number = value; }
        }
        public string TYPE
        {
            get { return type; }
            set { type = value; }
        }

        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClassAero()
        {
            name = "";
            number = 0;
            type = "";
        }
        //конструктор с параметрами
        public ClassAero(string f, double d, string s)
        {
            name = f;
            number = d;
            type = s;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
            string line = $"Пункт назначения {name} рейс № {number}" + "\n";
            line += $"Тип самолёта {type}" + "\n";

            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Рейс");
            streamWriter.WriteLine($"Место назначения: {name}");
            streamWriter.WriteLine($"Номер: {number.ToString()}");
            streamWriter.WriteLine($"Самолёт: {type}");
            streamWriter.Close();
        }


    }
}
