using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RecordSetProjectForOOAD.Model
{
    class Person
    {
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public Person(string FullName, string Email)
        {
            this.FullName = FullName;
            this.Email = Email;
        }
        public static List<string> FindEmail(string PartOfEmail)
        {
            List<string> Emails = new List<string>();

            return Emails;
        }
        public static bool ValidEmail(string Email)
        {
            string pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            Match isMatch = Regex.Match(Email, pattern, RegexOptions.IgnoreCase);
            return (!string.IsNullOrEmpty(Email) & isMatch.Success);
        }
        public static bool ValidFullName(string FullName)
        {
            if (string.IsNullOrEmpty(FullName) || FullName.Length > 50)
                return false;
            return true;
        }
        public static string SaveChanges(List<Person> peoples)
        {
            RecordSet rs = new RecordSet();
            return (rs.AddRowsPerson(peoples));
        }
        public static List<Person> GetPersons()
        { 
            RecordSet rs = new RecordSet();
            return rs.GetPersons();
        }
        internal static void ToDelete(List<Person> deleteContacts)
        {
            RecordSet rs = new RecordSet();
            rs.toDelete(deleteContacts);
        }
    }
}
