using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    
    public class Unit
    {
        /// <summary>
        /// Установка
        /// </summary>
        /// <param name="Id"> номер устанвоки</param>
        /// <param name="Name"> Название установки</param>
        /// <param name="Description"> Описание установки</param>
        /// <param name="FactoryId"> Номер завода, которой принадлежит данная установка</param>
        public int Id { get; init; } = 0;//также даем возможно задать Id только при создании чтобы не сломать связи
        public string Name { get; set; } = "Not Exists";
        public string Description { get; set; } = "Not Exists";
        public int FactoryId { get; init; } = 0;

        public Unit() { }//конструктор по умолчанию

        public Unit(int Id, string Name, string Description, int FactoryId)//конструктор с параметрами
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.FactoryId = FactoryId;
        }
    }
}
