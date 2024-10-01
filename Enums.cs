using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Enums
    {
        public enum Season
        {
            Summer,
            Autumn,
            Spring,
            Winter
        }

        public void DisplayEnums()
        {
            Console.WriteLine($"{(int)Season.Summer}");
        }
    }
}
