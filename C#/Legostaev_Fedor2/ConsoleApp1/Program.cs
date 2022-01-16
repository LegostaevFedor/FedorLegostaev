abstract class Person
{
    public string name = "Ivan";
    public DateTime yearBorn = new DateTime(1996, 06, 26);


    public abstract int yBorn(); // год рождения

    public virtual void info()
    {
        //информация о клиенте или работнике
    }
}
class Employee : Person
{
    public string Position = "Юрист";
    public int Experience = 5;
    public int StartJ;

    public override int yBorn()
    {
        throw new NotImplementedException();
    }

    public int StartJob()
    {
        var i = DateTime.Now;
        StartJ = i.Year - Experience;
        Console.WriteLine("Дата начала трудовой деятельности: " + StartJ);
        return StartJ;
    }
    public override void info()
    {
        Console.WriteLine("Имя: {0}. Год рождения: {1}. Специальность: {2}. Опыт работы: {3} (в годах).", name, yearBorn.Year, Position, Experience);
    }

}
class Customer : Person
{
    public string Address = "г.Минск, ул. Чкалова 10 кв 2";
    public override void info()
    {
        Console.WriteLine("Имя: {0}. Год рождения: {1}. Адрес: {2}.", name, yearBorn.Year, Address);
    }
    public override int yBorn() { return yearBorn.Year; }
}


class Test 
{

    static void Main(string[] args)
    {
        Employee y = new Employee();
        Console.WriteLine("\nИнформация о работнике:");
        y.info();
        y.StartJob();

        Person z = new Customer();
        Console.WriteLine("\nИнформация о клиенте:");
        z.info();
        Console.WriteLine("Год, в котором человек родился: {0}", z.yBorn());

    }
}