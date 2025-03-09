using System;
using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    public partial class Login_Page : Form
    {
        private const string ValidUsername = "Jian";
        private const string ValidPassword = "4567";
        private int failedLoginAttempts = 0;
        private const int maxLoginAttempts = 5;
        private ErrorProvider errorProvider;

        public Login_Page()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider(); // Initialize the ErrorProvider
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Clear previous errors
            errorProvider.Clear();

            // Check if the username and password are correct
            if (UsernameTxtbox.Text == ValidUsername && PasswordTxtBox.Text == ValidPassword)
            {
                // Successful login
                Form form2 = new Student_Page();
                form2.Show();
                Visible = false;
            }
            else
            {
                // Increment failed login attempts
                failedLoginAttempts++;

                // Check if the maximum number of attempts has been reached
                if (failedLoginAttempts >= maxLoginAttempts)
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts. " +
                                    "Please reset your password at: .resetpassword.com/reset",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    Application.Exit(); // Close the application
                }
                else
                {
                    // Display appropriate error messages
                    if (string.IsNullOrEmpty(UsernameTxtbox.Text))
                    {
                        errorProvider.SetError(UsernameTxtbox, "Username is required!");
                        UsernameTxtbox.Focus();
                    }
                    else if (string.IsNullOrEmpty(PasswordTxtBox.Text))
                    {
                        errorProvider.SetError(PasswordTxtBox, "Password is required");
                        PasswordTxtBox.Focus();
                    }
                    else if (UsernameTxtbox.Text != ValidUsername && PasswordTxtBox.Text != ValidPassword)
                    {
                        MessageBox.Show("Both username and password are incorrect.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (UsernameTxtbox.Text != ValidUsername)
                    {
                        MessageBox.Show("Please input the correct username.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider.SetError(UsernameTxtbox, "Please input the right username");
                        UsernameTxtbox.Focus();
                    }
                    else if (PasswordTxtBox.Text != ValidPassword)
                    {
                        MessageBox.Show("Please use the correct password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorProvider.SetError(PasswordTxtBox, "Please use the right password");
                        PasswordTxtBox.Focus();
                    }
                }
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PasswordLbl_Click(object sender, EventArgs e)
        {

        }
    }
}