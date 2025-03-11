using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Student_Page : Form
    {
        public Student_Page()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                Form form2 = new Login_Page();
                form2.Show();
                Visible = false;
            }
        }
    }
}
