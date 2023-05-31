using System.Data.SqlClient;
using System.Data;
using Dapper.Contrib.Extensions;
using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace DoB_App
{
    public partial class Form1 : Form
    {
        private string connStr = @"Data Source=DESKTOP-604CIS3\SQLEXPRESS;" +
                        "Initial catalog=PersonsDB;" +
                         "Integrated Security=True;" +
                         "TrustServerCertificate = True;" +
                         "Trusted_Connection=True";
        public List<Person> people = new List<Person>();
        public PersonControl control = new PersonControl();
        public Form1()
        {
            InitializeComponent();
            Load += InitControl;
        }

        public void InitControl(object sender, EventArgs e)
        {
            people = Select();
            control.Location = new Point(0, 0);
            RenderPeople(sender, e);
        }

        public List<Person> Select()
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                return conn.GetAll<Person>().ToList();
            }
        }

        public void Insert(Person person)
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                conn.Insert(person);
            }
        }

        public void Delete(Person person)
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                conn.Delete(person);
            }
        }

        public void Update(Person person)
        {
            using (IDbConnection conn = new SqlConnection(connStr))
            {

                conn.Open();
                conn.Update(person);
            }
        }

        public void RenderPeople(object sender, EventArgs e)
        {
            this.Controls.Clear();
            people = Select();
            this.Controls.Add(control);
            int y = control.Location.Y + control.Height + 2;
            people.ForEach(person =>
            {
                PersonEntry temp = new PersonEntry();
                temp.IDVal_lb.Text = person.ID.ToString();
                temp.FNameVal_lb.Text = person.FirstName;
                temp.LNameVal_lb.Text = person.LastName;
                temp.DoBVal_lb.Text = person.DoB.ToShortDateString();
                temp.Location = new Point(0, y);
                temp.Click += (s, e) => control.SetPersonEntry(temp);
                this.Controls.Add(temp);
                y += temp.Height + 2;
            });
        }
    }
}