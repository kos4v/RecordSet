using RecordSetProjectForOOAD.Model;
using RecordSetProjectForOOAD.Сontroller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordSetProjectForOOAD
{
    public partial class Form1 : Form
    {
        PersonСontroller PerC = new PersonСontroller();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SaveChanges();
        }
        private void SaveChanges()
        {
            List<Person> peoples = PerC.GetPerson();
            clbPerson.Items.Clear();
            foreach (var it in peoples)
            {
                clbPerson.Items.Add((it.FullName).TrimEnd(' ') + "||" + it.Email);
            }
            RecordSet rs = new RecordSet();
        }
        private void btAddPerson_Click(object sender, EventArgs e)
        {
            if (PerC.AddPerson(tbFullName.Text, tbEmail.Text))
            {
                clbPerson.Items.Add("+ "+tbFullName.Text+ "||" + tbEmail.Text);
                tbEmail.BackColor = tbFullName.BackColor = Color.White;
            }
            else
                tbEmail.BackColor = tbFullName.BackColor = Color.Red;
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            foreach (var item in clbPerson.CheckedItems)
            {
                    clbMailing.Items.Add(item);
            }
        }
        private void btSave_Click(object sender, EventArgs e)
        {
            RecordSet rs = new RecordSet();
            SaveChanges();

        }
        private void btClear_Click(object sender, EventArgs e)
        {
            CheckedListBox x = new CheckedListBox();
            for (int i = 0; i < clbMailing.Items.Count; i++)
            {
                if (clbMailing.GetItemChecked(i))
                    clbMailing.SetItemChecked(i, false);
                else
                clbMailing.SetItemChecked(i, true);
            }
            foreach (var item in clbMailing.CheckedItems)
            {
                x.Items.Add(item);
            }
            clbMailing.Items.Clear();
            foreach (var item in x.Items)
            {
                clbMailing.Items.Add(item);
            }

        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            List<Person> DeleteContacts = new List<Person>();
            foreach (var item in clbPerson.CheckedItems)
            {
                string nameplusmail = (item).ToString();
                int x = nameplusmail.IndexOf('|');
                string name = (item).ToString().Substring(0,x);
                string mail = (item).ToString().Substring(x+2);
                DeleteContacts.Add(new Person(name, mail));
            }
            PerC.DeleteContact(DeleteContacts);
            btSave_Click(sender, e);
        }
        private void btSendLetters_Click(object sender, EventArgs e)
        {
            if (clbMailing.Items.Count<1)
            {
                return;
            }
            PersonСontroller cont = new PersonСontroller();
            foreach (var item in clbMailing.Items)
            {
                string nameplusmail = (item).ToString();
                int x = nameplusmail.IndexOf('|');
                string Email = (item).ToString().Substring(x + 2);
                cont.SendOut(Email, rtbMailText.Text);
                lblMessage.Text = Email;
            }
        }
    }
}
