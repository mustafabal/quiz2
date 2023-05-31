using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public class Person
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int WeeklyWorkHour { get; set; }
        public double WeeklyOffDayNumber { get; set; }
        public string? Nation { get; set; }
    }

    public class WorkRule
    {
        private Dictionary<string, double> leaveDaysByCountry = new Dictionary<string, double>()
    {
        { "italy", 3 },
        { "uk", 2.5 },
        { "tr", 1 },
        { "mbb", 2 }
    };

        private Dictionary<string, int> workingHoursByCountry = new Dictionary<string, int>()
    {
        { "italy", 30 },
        { "uk", 30 },
        { "tr", 45 },
        { "mbb", 40 }
    };

        public List<string> PersonRulesCheck(Person person)
        {
            var culture = new CultureInfo("en-EN");
            List<string> messages = new List<string>();

            if (leaveDaysByCountry.ContainsKey(key: person.Nation.ToLower(culture)))
            {
                double leaveDays = leaveDaysByCountry[person.Nation.ToLower(culture)];
                int workingHours = workingHoursByCountry[person.Nation.ToLower(culture)];

                if (person.WeeklyOffDayNumber > leaveDays)
                {
                    messages.Add(person.Name + ": için Haftalık en az " + leaveDays + " gün izin olması gerekir.");
                }

                if (person.WeeklyWorkHour > workingHours)
                {
                    messages.Add(person.Name + ": için Haftalık çalışma saati " + workingHours + " saatten fazla olamaz.");
                }

                return messages;
            }

            messages.Add("Invalid nation: " + person.Nation);
            return messages;
        }

    }
}
