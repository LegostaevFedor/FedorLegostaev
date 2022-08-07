using Automarket.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automarket.DAL
{
    //класс DbContext позволяет исп. функционал EntityFrameworkCore
    public class ApplicationDbContext : DbContext
    {
        //регистрация в самом приложении (Automarket) класса ApplicationDbContext,
        //чтобы установить связь с БД
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           //Database.EnsureCreated(); //создаётся база данных если ещё не создана
        }
        public DbSet<Car> Car { get; set; } //создание сущности для взаимодействия с объектами из БД
    }
}
