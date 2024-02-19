using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor1
{
    public class Tank
    {
        public int Id { get; init; } = 0;
        public string Name { get; set; } = "Not Exists";
        public string Description { get; set; } = "Not Exists";
        public int Volume { get; set; } = 0; //текущее заполнение резервуара может меняться
        public int MaxVolume { get; init; } = 0; //Увеличить или уменьшить максимальный объем вроде как тоже невозможно, поэтому задаем этот параметр единожды 
        public int UnitId { get; init; } = 0;

        /// <summary>
        /// Резервуар
        /// </summary>
        /// <param name="Id"> номер резервуара</param>
        /// <param name="Name"> Название резервуара</param>
        /// <param name="Description"> Описание резервуара</param>
        /// <param name="Volume"> Текущая заполненность резервуара</param>
        /// <param name="MaxVolume"> Максимальная заполняемость резервуара</param>
        /// <param name="UnitId"> Номер установки, которой принадлежит резервуар</param>
        public Tank() { }//конструктор по умолчанию

        public Tank(int Id, string Name, string Description, int Volume, int MaxVolume, int UnitId)//конструктор с параметрами
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Volume = Volume;
            this.MaxVolume = MaxVolume;
            this.UnitId = UnitId;
        }
    }
    
}
