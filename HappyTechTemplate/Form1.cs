using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTechTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Interview_Click(object sender, EventArgs e)
        {

        }

        private void TecRev_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user1 = new User();
            user1.FirstName = "George";

            Applicant app1 = new Applicant();
            app1.FirstName = "John";

            Template temp1 = new Template();
            temp1.Name = "CV";

            Feedback f1 = new Feedback();
            f1.User = user1;
            f1.Applicant = app1;
            f1.Template = temp1;


        }

        private void btnCV_Click(object sender, EventArgs e)
        {

        }
    }
}
