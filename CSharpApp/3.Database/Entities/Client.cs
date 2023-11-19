using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Entities
{
    /// <summary>
    /// Інформація про клієнта
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Іd кліжнта
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Ім'я
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Прізвище
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// Дата народження
        /// </summary>
        public string DateOfBirth { get; set; }
        /// <summary>
        /// Дата створення
        /// </summary>
        public string CreatedDate { get; set; }
        /// <summary>
        /// Професія Id
        /// </summary>
        public int ProfessionId { get; set; }
        /// <summary>
        /// Назва професії
        /// </summary>
        public string ProfessionName { get; set; }
        /// <summary>
        /// Стать 1 - чоловік, 2 - жінка
        /// </summary>
        public bool Sex { get; set; }

        public override string ToString()
        {
            return Id + "\t" +
                        LastName + " " +FirstName + $"({ProfessionName})\t" +
                        Phone + "\t" +DateOfBirth+"\t"+CreatedDate;
        }
    }
}
