using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizationProfile
{
    public partial class Confirmation : Form
         
    {
        public Confirmation()
        {
            InitializeComponent();
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lblStudentNo.Text = StudentInformationClass.setStudentNo.ToString();
            lblName.Text = StudentInformationClass.setFullName;
            lblProgram.Text = StudentInformationClass.setProgram;
            lblBirthday.Text = StudentInformationClass.setBirthday;
            lblGender.Text = StudentInformationClass.setGender;
            lblContactNo.Text = StudentInformationClass.setContactNo.ToString();
            lblAge.Text = StudentInformationClass.setAge.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
