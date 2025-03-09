namespace Windows_Forms_Sample
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            pictureBox1 = new PictureBox();
            studDetails = new TextBox();
            ChangeBtn = new Button();
            CourseLbl = new ComboBox();
            YearLbl = new ComboBox();
            courseProg = new Label();
            yearLevel = new Label();
            PersonalLbl = new Label();
            NameLbl = new Label();
            AgeLbl = new Label();
            AddressLbl = new Label();
            ContactLbl = new Label();
            EmailLbl = new Label();
            HobbiesLbl = new Label();
            nickNameLbl = new Label();
            EmergencyName = new Label();
            EmergencyLbl = new Label();
            EmeergencyContact = new Label();
            Cancel1 = new Button();
            SaveBtn = new Button();
            nameTxtBox = new RichTextBox();
            AddressTxtBox = new RichTextBox();
            EmailTxtBox = new RichTextBox();
            HobbiesTxtBox = new RichTextBox();
            NicknameTxtBox = new RichTextBox();
            AgeMaskedTxtBox = new MaskedTextBox();
            ContactMaskedTxtBox = new MaskedTextBox();
            EmergencyParentBox = new RichTextBox();
            EmergencyContactBox = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(612, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 208);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // studDetails
            // 
            studDetails.BorderStyle = BorderStyle.None;
            studDetails.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studDetails.Location = new Point(258, 73);
            studDetails.Name = "studDetails";
            studDetails.Size = new Size(366, 38);
            studDetails.TabIndex = 1;
            studDetails.Text = "STUDENT DETAILS";
            studDetails.TextAlign = HorizontalAlignment.Center;
            studDetails.TextChanged += textBox1_TextChanged;
            // 
            // ChangeBtn
            // 
            ChangeBtn.BackColor = Color.White;
            ChangeBtn.BackgroundImageLayout = ImageLayout.Center;
            ChangeBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeBtn.ForeColor = SystemColors.ActiveCaptionText;
            ChangeBtn.Location = new Point(648, 361);
            ChangeBtn.Name = "ChangeBtn";
            ChangeBtn.Size = new Size(170, 35);
            ChangeBtn.TabIndex = 2;
            ChangeBtn.Text = "Change Photo";
            ChangeBtn.UseVisualStyleBackColor = false;
            // 
            // CourseLbl
            // 
            CourseLbl.BackColor = SystemColors.Info;
            CourseLbl.FormattingEnabled = true;
            CourseLbl.Items.AddRange(new object[] { "BSIT", "ABEL", "BSBA", "BPA" });
            CourseLbl.Location = new Point(245, 161);
            CourseLbl.Name = "CourseLbl";
            CourseLbl.RightToLeft = RightToLeft.No;
            CourseLbl.Size = new Size(257, 33);
            CourseLbl.TabIndex = 17;
            CourseLbl.Text = "BSIT";
            // 
            // YearLbl
            // 
            YearLbl.BackColor = SystemColors.Info;
            YearLbl.FormattingEnabled = true;
            YearLbl.Items.AddRange(new object[] { "FIRST", "SECOND", "THIRD", "FOURTH", "IRREGULAR" });
            YearLbl.Location = new Point(245, 217);
            YearLbl.Name = "YearLbl";
            YearLbl.Size = new Size(257, 33);
            YearLbl.TabIndex = 18;
            YearLbl.Text = "THIRD";
            // 
            // courseProg
            // 
            courseProg.AutoSize = true;
            courseProg.BackColor = Color.Transparent;
            courseProg.ForeColor = Color.Black;
            courseProg.Location = new Point(94, 164);
            courseProg.Name = "courseProg";
            courseProg.Size = new Size(67, 25);
            courseProg.TabIndex = 19;
            courseProg.Text = "Course";
            courseProg.Click += label1_Click;
            // 
            // yearLevel
            // 
            yearLevel.AutoSize = true;
            yearLevel.BackColor = Color.Transparent;
            yearLevel.ForeColor = Color.Black;
            yearLevel.Location = new Point(94, 220);
            yearLevel.Name = "yearLevel";
            yearLevel.Size = new Size(44, 25);
            yearLevel.TabIndex = 20;
            yearLevel.Text = "Year";
            yearLevel.Click += label2_Click;
            // 
            // PersonalLbl
            // 
            PersonalLbl.AutoSize = true;
            PersonalLbl.BackColor = SystemColors.GradientActiveCaption;
            PersonalLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PersonalLbl.ForeColor = Color.Black;
            PersonalLbl.Location = new Point(94, 306);
            PersonalLbl.Name = "PersonalLbl";
            PersonalLbl.Size = new Size(191, 25);
            PersonalLbl.TabIndex = 21;
            PersonalLbl.Text = "Personal Information";
            PersonalLbl.Click += label4_Click;
            // 
            // NameLbl
            // 
            NameLbl.AutoSize = true;
            NameLbl.BackColor = Color.Transparent;
            NameLbl.ForeColor = Color.Black;
            NameLbl.Location = new Point(94, 361);
            NameLbl.Name = "NameLbl";
            NameLbl.Size = new Size(59, 25);
            NameLbl.TabIndex = 22;
            NameLbl.Text = "Name";
            NameLbl.Click += label5_Click;
            // 
            // AgeLbl
            // 
            AgeLbl.AutoSize = true;
            AgeLbl.BackColor = Color.Transparent;
            AgeLbl.ForeColor = Color.Black;
            AgeLbl.Location = new Point(94, 412);
            AgeLbl.Name = "AgeLbl";
            AgeLbl.Size = new Size(44, 25);
            AgeLbl.TabIndex = 23;
            AgeLbl.Text = "Age";
            AgeLbl.Click += label1_Click_1;
            // 
            // AddressLbl
            // 
            AddressLbl.AutoSize = true;
            AddressLbl.BackColor = Color.Transparent;
            AddressLbl.ForeColor = Color.Black;
            AddressLbl.Location = new Point(94, 468);
            AddressLbl.Name = "AddressLbl";
            AddressLbl.Size = new Size(77, 25);
            AddressLbl.TabIndex = 24;
            AddressLbl.Text = "Address";
            AddressLbl.Click += label1_Click_2;
            // 
            // ContactLbl
            // 
            ContactLbl.AutoSize = true;
            ContactLbl.BackColor = Color.Transparent;
            ContactLbl.ForeColor = Color.Black;
            ContactLbl.Location = new Point(94, 518);
            ContactLbl.Name = "ContactLbl";
            ContactLbl.Size = new Size(106, 25);
            ContactLbl.TabIndex = 25;
            ContactLbl.Text = "Contact No.";
            // 
            // EmailLbl
            // 
            EmailLbl.AutoSize = true;
            EmailLbl.BackColor = Color.Transparent;
            EmailLbl.ForeColor = Color.Black;
            EmailLbl.Location = new Point(94, 571);
            EmailLbl.Name = "EmailLbl";
            EmailLbl.Size = new Size(124, 25);
            EmailLbl.TabIndex = 26;
            EmailLbl.Text = "Email Address";
            // 
            // HobbiesLbl
            // 
            HobbiesLbl.AutoSize = true;
            HobbiesLbl.BackColor = Color.Transparent;
            HobbiesLbl.ForeColor = Color.Black;
            HobbiesLbl.Location = new Point(94, 629);
            HobbiesLbl.Name = "HobbiesLbl";
            HobbiesLbl.Size = new Size(79, 25);
            HobbiesLbl.TabIndex = 27;
            HobbiesLbl.Text = "Hobbies";
            // 
            // nickNameLbl
            // 
            nickNameLbl.AutoSize = true;
            nickNameLbl.BackColor = Color.Transparent;
            nickNameLbl.ForeColor = Color.Black;
            nickNameLbl.Location = new Point(559, 629);
            nickNameLbl.Name = "nickNameLbl";
            nickNameLbl.Size = new Size(93, 25);
            nickNameLbl.TabIndex = 28;
            nickNameLbl.Text = "NickName";
            // 
            // EmergencyName
            // 
            EmergencyName.AutoSize = true;
            EmergencyName.BackColor = Color.Transparent;
            EmergencyName.ForeColor = Color.Black;
            EmergencyName.Location = new Point(94, 786);
            EmergencyName.Name = "EmergencyName";
            EmergencyName.Size = new Size(213, 25);
            EmergencyName.TabIndex = 29;
            EmergencyName.Text = "Name of Parent/Guardian";
            // 
            // EmergencyLbl
            // 
            EmergencyLbl.AutoSize = true;
            EmergencyLbl.BackColor = SystemColors.GradientActiveCaption;
            EmergencyLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmergencyLbl.ForeColor = Color.Black;
            EmergencyLbl.Location = new Point(94, 728);
            EmergencyLbl.Name = "EmergencyLbl";
            EmergencyLbl.Size = new Size(193, 25);
            EmergencyLbl.TabIndex = 30;
            EmergencyLbl.Text = "In case of emergency";
            // 
            // EmeergencyContact
            // 
            EmeergencyContact.AutoSize = true;
            EmeergencyContact.BackColor = Color.Transparent;
            EmeergencyContact.ForeColor = Color.Black;
            EmeergencyContact.Location = new Point(94, 835);
            EmeergencyContact.Name = "EmeergencyContact";
            EmeergencyContact.Size = new Size(102, 25);
            EmeergencyContact.TabIndex = 31;
            EmeergencyContact.Text = "Contact No";
            // 
            // Cancel1
            // 
            Cancel1.BackColor = Color.White;
            Cancel1.BackgroundImageLayout = ImageLayout.Center;
            Cancel1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cancel1.ForeColor = SystemColors.ActiveCaptionText;
            Cancel1.Location = new Point(454, 950);
            Cancel1.Name = "Cancel1";
            Cancel1.Size = new Size(170, 35);
            Cancel1.TabIndex = 32;
            Cancel1.Text = "Cancel";
            Cancel1.UseVisualStyleBackColor = false;
            Cancel1.Click += Cancelbtn;
            // 
            // SaveBtn
            // 
            SaveBtn.BackColor = Color.White;
            SaveBtn.BackgroundImageLayout = ImageLayout.Center;
            SaveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.ForeColor = SystemColors.ActiveCaptionText;
            SaveBtn.Location = new Point(659, 950);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(170, 35);
            SaveBtn.TabIndex = 33;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = false;
            SaveBtn.Click += Savebtn;
            // 
            // nameTxtBox
            // 
            nameTxtBox.BackColor = SystemColors.Info;
            nameTxtBox.Location = new Point(159, 358);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(409, 38);
            nameTxtBox.TabIndex = 34;
            nameTxtBox.Text = "ERIKA JIANZILD C. MALINAB";
            // 
            // AddressTxtBox
            // 
            AddressTxtBox.BackColor = SystemColors.Info;
            AddressTxtBox.Location = new Point(188, 465);
            AddressTxtBox.Name = "AddressTxtBox";
            AddressTxtBox.Size = new Size(621, 37);
            AddressTxtBox.TabIndex = 35;
            AddressTxtBox.Text = "PANGASINAN, PHILIPPINES";
            // 
            // EmailTxtBox
            // 
            EmailTxtBox.BackColor = SystemColors.Info;
            EmailTxtBox.Location = new Point(224, 568);
            EmailTxtBox.Name = "EmailTxtBox";
            EmailTxtBox.Size = new Size(511, 37);
            EmailTxtBox.TabIndex = 36;
            EmailTxtBox.Text = "malinab_ipt@gmail.edu.ph";
            // 
            // HobbiesTxtBox
            // 
            HobbiesTxtBox.BackColor = SystemColors.Info;
            HobbiesTxtBox.Location = new Point(179, 629);
            HobbiesTxtBox.Name = "HobbiesTxtBox";
            HobbiesTxtBox.Size = new Size(358, 66);
            HobbiesTxtBox.TabIndex = 37;
            HobbiesTxtBox.Text = "SINGING, CROCHET, WATCHING DOCUMENTRIES";
            // 
            // NicknameTxtBox
            // 
            NicknameTxtBox.BackColor = SystemColors.Info;
            NicknameTxtBox.Location = new Point(668, 626);
            NicknameTxtBox.Name = "NicknameTxtBox";
            NicknameTxtBox.Size = new Size(169, 40);
            NicknameTxtBox.TabIndex = 38;
            NicknameTxtBox.Text = "JIAN";
            // 
            // AgeMaskedTxtBox
            // 
            AgeMaskedTxtBox.BackColor = SystemColors.Info;
            AgeMaskedTxtBox.Location = new Point(159, 412);
            AgeMaskedTxtBox.Mask = "00";
            AgeMaskedTxtBox.Name = "AgeMaskedTxtBox";
            AgeMaskedTxtBox.Size = new Size(148, 31);
            AgeMaskedTxtBox.TabIndex = 39;
            AgeMaskedTxtBox.Text = "21";
            AgeMaskedTxtBox.ValidatingType = typeof(int);
            // 
            // ContactMaskedTxtBox
            // 
            ContactMaskedTxtBox.BackColor = SystemColors.Info;
            ContactMaskedTxtBox.Location = new Point(206, 518);
            ContactMaskedTxtBox.Mask = "(999) 000-0000";
            ContactMaskedTxtBox.Name = "ContactMaskedTxtBox";
            ContactMaskedTxtBox.Size = new Size(305, 31);
            ContactMaskedTxtBox.TabIndex = 40;
            ContactMaskedTxtBox.Text = "9875462737";
            // 
            // EmergencyParentBox
            // 
            EmergencyParentBox.BackColor = SystemColors.Info;
            EmergencyParentBox.Location = new Point(318, 783);
            EmergencyParentBox.Name = "EmergencyParentBox";
            EmergencyParentBox.Size = new Size(511, 37);
            EmergencyParentBox.TabIndex = 41;
            EmergencyParentBox.Text = "DUEDITH MALINAB\n";
            // 
            // EmergencyContactBox
            // 
            EmergencyContactBox.BackColor = SystemColors.Info;
            EmergencyContactBox.Location = new Point(206, 835);
            EmergencyContactBox.Mask = "(999) 000-0000";
            EmergencyContactBox.Name = "EmergencyContactBox";
            EmergencyContactBox.Size = new Size(305, 31);
            EmergencyContactBox.TabIndex = 42;
            EmergencyContactBox.Text = "9947862339";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(908, 1050);
            Controls.Add(EmergencyContactBox);
            Controls.Add(EmergencyParentBox);
            Controls.Add(ContactMaskedTxtBox);
            Controls.Add(AgeMaskedTxtBox);
            Controls.Add(NicknameTxtBox);
            Controls.Add(HobbiesTxtBox);
            Controls.Add(EmailTxtBox);
            Controls.Add(AddressTxtBox);
            Controls.Add(nameTxtBox);
            Controls.Add(SaveBtn);
            Controls.Add(Cancel1);
            Controls.Add(EmeergencyContact);
            Controls.Add(EmergencyLbl);
            Controls.Add(EmergencyName);
            Controls.Add(nickNameLbl);
            Controls.Add(HobbiesLbl);
            Controls.Add(EmailLbl);
            Controls.Add(ContactLbl);
            Controls.Add(AddressLbl);
            Controls.Add(AgeLbl);
            Controls.Add(NameLbl);
            Controls.Add(PersonalLbl);
            Controls.Add(yearLevel);
            Controls.Add(courseProg);
            Controls.Add(YearLbl);
            Controls.Add(CourseLbl);
            Controls.Add(ChangeBtn);
            Controls.Add(studDetails);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ControlLightLight;
            Name = "Form3";
            Text = "Edit_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox studDetails;
        private Button ChangeBtn;
        private ComboBox CourseLbl;
        private ComboBox YearLbl;
        private Label courseProg;
        private Label yearLevel;
        private Label PersonalLbl;
        private Label NameLbl;
        private Label AgeLbl;
        private Label AddressLbl;
        private Label ContactLbl;
        private Label EmailLbl;
        private Label HobbiesLbl;
        private Label nickNameLbl;
        private Label EmergencyName;
        private Label EmergencyLbl;
        private Label EmeergencyContact;
        private Button Cancel1;
        private Button SaveBtn;
        private RichTextBox nameTxtBox;
        private RichTextBox AddressTxtBox;
        private RichTextBox EmailTxtBox;
        private RichTextBox HobbiesTxtBox;
        private RichTextBox NicknameTxtBox;
        private MaskedTextBox AgeMaskedTxtBox;
        private MaskedTextBox ContactMaskedTxtBox;
        private RichTextBox EmergencyParentBox;
        private MaskedTextBox EmergencyContactBox;
    }
}