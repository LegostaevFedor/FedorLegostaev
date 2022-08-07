using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.DAL.Interfaces
{
    //описание общих методов для взаимодействия с БД

    //IBaseRepository дженерик т.к будет наследоваться другими интерфейсами и будем точно
    //указывать какой объект будем передавать (если объект Car - то взаимодействие с соотв. таблицей
    public interface IBaseRepository<T>
    {
        bool Create(T entity); //если запись добавлена в БД - возвращает true

        T Get(int id); //получение объекта по его Id

        Task<List<T>> SelectAsync(); //получение коллекции элементов Т

        bool Delete(T entity); //если объект удалился из БД - true, в параметры получаем объект удаления

    }
}
