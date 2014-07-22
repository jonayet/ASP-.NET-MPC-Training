using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonApp
{
    public partial class PersonUI : Form
    {
        Person p = new Person("Kazi", "Mohammad");

        public PersonUI()
        {
            InitializeComponent();
        }

        private void getFullNameButton_Click(object sender, EventArgs e)
        {
            p = new Person(firstNameTextBox.Text, middleNameTextBox.Text, lastNameTextBox.Text);
            MessageBox.Show(p.GetFullName());
        }

        private void getReverseNameButton_Click(object sender, EventArgs e)
        {
            p = new Person();
            p.FirstName = firstNameTextBox.Text;
            p.LastName = lastNameTextBox.Text;
            MessageBox.Show(p.GetReverseName());
        }
    }
}
