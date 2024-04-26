using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingSource bs = new BindingSource();
        Handler listhandler = new Handler();
        private void btnAll_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in listhandler.People)
            {
                item.calculateAge(item);
            }
           listhandler.People.Sort();
           bs.DataSource = listhandler.People;
           dgPeople.DataSource = bs;
        }

        private void Lectures_Click(object sender, EventArgs e)
        {
            List<Lecturer> lectures = new List<Lecturer>();
            foreach (var item in listhandler.People)
            {
                if (item is Lecturer)
                {
                    lectures.Add((Lecturer)item);
                }
            }
            bs.DataSource = lectures;
            dgPeople.DataSource = bs;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person addperson = new Person();
            addperson.Name = txtName.Text;
            addperson.Dob = DateTime.Parse(dtpDOB.Value.ToShortDateString());
            addperson.calculateAge(addperson);
            if (rdbStudentType.Checked)
            {

                listhandler.People.Add(new Student(addperson.Name, addperson.Dob, addperson.Age));

            }
            else if (rbttypeLecturer.Checked)
            {
                listhandler.People.Add(new Lecturer(addperson.Name, addperson.Dob, addperson.Age));
            }
            dgPeople.DataSource = null;
            bs.DataSource=listhandler.People;
            listhandler.People.Sort();
            dgPeople.DataSource = bs;
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDOB_Click(object sender, EventArgs e)
        {

        }
    }
}
