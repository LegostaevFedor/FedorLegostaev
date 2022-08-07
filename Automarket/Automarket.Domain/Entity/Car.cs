using Automarket.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.Domain.Entity
{
    public class Car
    {
        public int Id { get; set; } 
        public string Name { get; set; } //название машины
        public string Description { get; set; } //описание машины
        public string Model { get; set; } //модель машины
        public double Speed { get; set; } //скорость машины
        public decimal Price { get; set; } //цена машины
        public DateTime DateCreate { get; set; } //дата создания машины (год выпуска)

        public TypeCar TypeCar { get; set; } //типы кузовов машин

    }
}
