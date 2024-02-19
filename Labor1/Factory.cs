using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
 
    public class Factory
    {
        /// <summary>
        /// Завод
        /// </summary>
        /// <param name="Id"> номер завода</param>
        /// <param name="Name"> Название завода</param>
        /// <param name="Description"> Описание завода</param>
        public int Id { get; init; } = 0; //Id можно поставить только при создании объекта класса потому что если менять его, то можно сломать связи между заводом-установкой
        public string Name { get; set; } = "Not Exists"; //Аббревиатуру вроде можно поменять
        public string Description { get; set; } = "Not Exists"; //Полное название завода вроде тоже можно поменять

        public Factory(int Id, string Name, string Description) //конструктор с параментрами
        { 
            this.Id = Id;
            this.Name = Name;   
            this.Description = Description;
        }
        public Factory() { } //конструктор по умолчанию
    }
    
}
