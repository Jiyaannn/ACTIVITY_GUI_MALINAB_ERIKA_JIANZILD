using System.Windows.Forms;

namespace Windows_Forms_Sample
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            UserNameLbl = new Label();
            PasswordLbl = new Label();
            UsernameTxtbox = new TextBox();
            PasswordTxtBox = new TextBox();
            LoginBtn = new Button();
            CancelBtn = new Button();
            ErrorProvider1 = new ErrorProvider(components);
            logInphoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logInphoto).BeginInit();
            SuspendLayout();
            // 
            // UserNameLbl
            // 
            UserNameLbl.AutoSize = true;
            UserNameLbl.Location = new Point(408, 93);
            UserNameLbl.Name = "UserNameLbl";
            UserNameLbl.Size = new Size(102, 25);
            UserNameLbl.TabIndex = 0;
            UserNameLbl.Text = "Username:";
            // 
            // PasswordLbl
            // 
            PasswordLbl.AutoSize = true;
            PasswordLbl.Location = new Point(408, 190);
            PasswordLbl.Name = "PasswordLbl";
            PasswordLbl.Size = new Size(92, 25);
            PasswordLbl.TabIndex = 1;
            PasswordLbl.Text = "Password";
            PasswordLbl.Click += PasswordLbl_Click;
            // 
            // UsernameTxtbox
            // 
            UsernameTxtbox.BackColor = Color.White;
            ErrorProvider1.SetIconAlignment(UsernameTxtbox, ErrorIconAlignment.TopRight);
            UsernameTxtbox.Location = new Point(408, 135);
            UsernameTxtbox.Name = "UsernameTxtbox";
            UsernameTxtbox.Size = new Size(323, 31);
            UsernameTxtbox.TabIndex = 2;
            // 
            // PasswordTxtBox
            // 
            PasswordTxtBox.BackColor = Color.White;
            PasswordTxtBox.Location = new Point(408, 229);
            PasswordTxtBox.Name = "PasswordTxtBox";
            PasswordTxtBox.PasswordChar = '*';
            PasswordTxtBox.Size = new Size(323, 31);
            PasswordTxtBox.TabIndex = 3;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = SystemColors.HighlightText;
            LoginBtn.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            LoginBtn.FlatAppearance.BorderSize = 5;
            LoginBtn.FlatStyle = FlatStyle.Popup;
            LoginBtn.ImageAlign = ContentAlignment.BottomLeft;
            LoginBtn.Location = new Point(408, 298);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(123, 48);
            LoginBtn.TabIndex = 4;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // CancelBtn
            // 
            CancelBtn.BackColor = SystemColors.HighlightText;
            CancelBtn.FlatAppearance.BorderColor = SystemColors.ButtonShadow;
            CancelBtn.FlatAppearance.BorderSize = 5;
            CancelBtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            CancelBtn.FlatStyle = FlatStyle.Popup;
            CancelBtn.Location = new Point(608, 298);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(123, 48);
            CancelBtn.TabIndex = 5;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = false;
            CancelBtn.Click += CancelBtn_Click;
            // 
            // ErrorProvider1
            // 
            ErrorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            ErrorProvider1.ContainerControl = this;
            // 
            // logInphoto
            // 
            logInphoto.BackgroundImage = (Image)resources.GetObject("logInphoto.BackgroundImage");
            logInphoto.BackgroundImageLayout = ImageLayout.Zoom;
            logInphoto.Location = new Point(114, 93);
            logInphoto.Name = "logInphoto";
            logInphoto.Size = new Size(216, 191);
            logInphoto.TabIndex = 6;
            logInphoto.TabStop = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(880, 450);
            Controls.Add(logInphoto);
            Controls.Add(CancelBtn);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTxtBox);
            Controls.Add(UsernameTxtbox);
            Controls.Add(PasswordLbl);
            Controls.Add(UserNameLbl);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Login_Page";
            Text = "Login_Page";
            ((System.ComponentModel.ISupportInitialize)ErrorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)logInphoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNameLbl;
        private Label PasswordLbl;
        private TextBox UsernameTxtbox;
        private TextBox PasswordTxtBox;
        private Button LoginBtn;
        private Button CancelBtn;
        private ErrorProvider ErrorProvider1;
        private PictureBox logInphoto;
    }
}
