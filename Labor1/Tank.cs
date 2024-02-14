using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    /// <summary>
    /// Резервуар
    /// </summary>
    public class Tank
    {
        public int Id { get; init; } = 0;
        public string Name { get; set; } = "Not Exists";
        public string Description { get; set; } = "Not Exists";
        public int Volume { get; set; } = 0; //текущее заполнение резервуара может меняться
        public int MaxVolume { get; init; } = 0; //Увеличить или уменьшить максимальный объем вроде как тоже невозможно, поэтому задаем этот параметр единожды 
        public int UnitId { get; init; } = 0;
    }
}
