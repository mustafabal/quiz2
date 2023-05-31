using Quiz2;

Console.WriteLine("---------------------------------------------");
List<Person> list = new List<Person>
{
    new Person { Id = 1, Name = "Ahmet Kaya", Nation = "TR", WeeklyOffDayNumber = 0, WeeklyWorkHour = 30 },
    new Person { Id = 1, Name = "Ahmet Kaya", Nation = "TR", WeeklyOffDayNumber = 1, WeeklyWorkHour = 40 },
    new Person { Id = 1, Name = "Mehmet Kaya", Nation = "TR", WeeklyOffDayNumber = 1, WeeklyWorkHour = 40 },
    new Person { Id = 1, Name = "Julia", Nation = "MBB", WeeklyOffDayNumber = 8, WeeklyWorkHour = 38 },
    new Person { Id = 1, Name = "Michale", Nation = "MBB", WeeklyOffDayNumber = 2, WeeklyWorkHour = 35 },
    new Person { Id = 1, Name = "Ayşe", Nation = "UK", WeeklyOffDayNumber = 1, WeeklyWorkHour = 45 },
    new Person { Id = 1, Name = "Ali", Nation = "UK", WeeklyOffDayNumber = 2.7, WeeklyWorkHour = 77 },
    new Person { Id = 1, Name = "Ömer", Nation = "Italy", WeeklyOffDayNumber = 4, WeeklyWorkHour = 55 },
    new Person { Id = 1, Name = "Mustafa", Nation = "italy", WeeklyOffDayNumber = 2, WeeklyWorkHour = 30 }
};


WorkRule wr = new WorkRule();
foreach (var item in list)
{
    var message = wr.PersonRulesCheck(item);
    message.ForEach(msg => Console.WriteLine(msg));
}

