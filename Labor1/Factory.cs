using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    /// <summary>
    /// Завод
    /// </summary>
    public class Factory
    {
        public int Id { get; init; } = 0; //Id можно поставить только при создании объекта класса потому что если менять его, то можно сломать связи между заводом-установкой
        public string Name { get; set; } = "Not Exists"; //Аббревиатуру вроде можно поменять
        public string Description { get; set; } = "Not Exists"; //Полное название завода вроде тоже можно поменять
    }

}
