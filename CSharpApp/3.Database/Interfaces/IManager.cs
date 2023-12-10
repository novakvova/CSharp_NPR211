using _3.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Database.Interfaces
{
    //Описує набір методів, якими має володіти сам об'єкт
    //Виконання опрецій над певною таблицею
    public interface IManager<T> : IDisposable
    {
        /// <summary>
        /// Списко об'єктів таблиці
        /// </summary>
        /// <returns>Повертає List елементів</returns>
        List<T> GetList();
        /// <summary>
        /// Додати новий запис в БД
        /// </summary>
        /// <param name="entity">Сам запис</param>
        void Insert();
        /// <summary>
        /// Повертає запис по int Id
        /// </summary>
        /// <param name="id">id - запису в БД</param>
        /// <returns>Повертає знайдени запис</returns>
        T GetById(int id);
        /// <summary>
        /// Видалити запис
        /// </summary>
        /// <param name="entity">Сам запис</param>
        void Delete(T entity);
        /// <summary>
        /// Оновити запис
        /// </summary>
        /// <param name="entity">Запис, який оновляємо</param>
        public void Update(T entity);
        /// <summary>
        /// Генерація рандомом вказаної кількості записів
        /// </summary>
        /// <param name="count">Необхідна кількість записів</param>
        public void GenerateRandom(int count);
    }
}
