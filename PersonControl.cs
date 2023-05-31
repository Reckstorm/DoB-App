using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DoB_App
{
    public partial class PersonControl : UserControl
    {
        public PersonControl()
        {
            InitializeComponent();
            this.Res_lb.Text = string.Empty;
            Load += DefaultValues;
        }
        private void DefaultValues(object sender, EventArgs e)
        {
            Form1 parent = this.Parent as Form1;
            this.IDVal_lb.Text = (parent.people.Last().ID + 1).ToString();
            this.FName_tb.Text = string.Empty;
            this.LName_tb.Text = string.Empty;
            this.DoB_pkr.Value = DateTime.Now;
        }

        public void SetPersonEntry(PersonEntry person)
        {
            this.IDVal_lb.Text = person.IDVal_lb.Text;
            this.FName_tb.Text = person.FNameVal_lb.Text;
            this.LName_tb.Text = person.LNameVal_lb.Text;
            this.DoB_pkr.Value = DateTime.Parse(person.DoBVal_lb.Text);
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            Form1 parent = this.Parent as Form1;
            this.Res_lb.Text = string.Empty;
            DefaultValues(sender, e);
            parent.RenderPeople(sender, e);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            Form1 parent = this.Parent as Form1;
            Person person = new Person(int.Parse(this.IDVal_lb.Text), this.FName_tb.Text, this.LName_tb.Text, this.DoB_pkr.Value);
            parent.Delete(person);
            this.Res_lb.ForeColor = Color.Green;
            this.Res_lb.Text = "Person removed";
            parent.RenderPeople(sender, e);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Form1 parent = this.Parent as Form1;
            Person person = new Person(int.Parse(this.IDVal_lb.Text), this.FName_tb.Text, this.LName_tb.Text, this.DoB_pkr.Value);
            if (parent.people.Any(x => x.ID.Equals(person.ID)))
            {
                parent.Update(person);
                this.Res_lb.ForeColor = Color.Green;
                this.Res_lb.Text = "Person updated";
            }
            else
            {
                parent.Insert(person);
                this.Res_lb.ForeColor = Color.Green;
                this.Res_lb.Text = "Person added";
            }
            parent.RenderPeople(sender, e);
        }
    }
}
