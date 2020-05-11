using System.Collections.Generic;
using System.Threading.Tasks;
using RecordSetProjectForOOAD.Model;
using System.Net;
using System.Net.Mail;


namespace RecordSetProjectForOOAD.Сontroller
{
    class  PersonСontroller
    {
        List<Person> peoples = new List<Person>();
        public bool AddPerson(string FullName, string Email)
        {
            if (Person.ValidEmail(Email) & Person.ValidFullName(FullName))
            {
                peoples.Add(new Person(FullName, Email));
                return true;
            }
            return false;
        }

        public List<Person> GetPerson()
        {
            return Person.GetPersons();
        }

        public string SaveRecords()
        {
            return Person.SaveChanges(peoples);
             
        }

        public void SendEmail(string Email, string subject, string body)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("ha6n@yandex.ru", "Господин Дубощит");
            // кому отправляем
            MailAddress to = new MailAddress(Email);
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = subject;
            // текст письма
            m.Body = "<h2>" + body + "</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.yandex.com", 587);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("ha6n@yandex.ru", "162534iva");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }

        public void DeleteContact(List<Person> deleteContacts)
        {
            Person.ToDelete(deleteContacts);
        }

        public void SendOut(string Email, string Text)
        {
                SendEmail(Email, "From OOAD", Text);
        }
    }
}
