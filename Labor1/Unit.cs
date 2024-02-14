using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    /// <summary>
    /// Установка
    /// </summary>
    public class Unit
    {
        public int Id { get; init; } = 0;//также даем возможно задать Id только при создании чтобы не сломать связи
        public string Name { get; set; } = "Not Exists";
        public string Description { get; set; } = "Not Exists";
        public int FactoryId { get; init; } = 0;
    }
}
