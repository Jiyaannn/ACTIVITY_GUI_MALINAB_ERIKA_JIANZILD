namespace Windows_Forms_Sample
{
    partial class Student_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Page));
            DataLbl = new Label();
            studDetails = new Label();
            label1 = new Label();
            LogOutBtn = new Button();
            EditBtn = new Button();
            SavedPicture = new PictureBox();
            InformationLlb = new Label();
            ((System.ComponentModel.ISupportInitialize)SavedPicture).BeginInit();
            SuspendLayout();
            // 
            // DataLbl
            // 
            DataLbl.AutoSize = true;
            DataLbl.Location = new Point(73, 370);
            DataLbl.Name = "DataLbl";
            DataLbl.Size = new Size(279, 375);
            DataLbl.TabIndex = 15;
            DataLbl.Text = "Course:\r\nYear:\r\n\r\nPERSONAL INFORMATION\r\nName:\r\nAge:\r\nAddress:\r\nContact Number:\r\nEmail Address:\r\nHobbies:\r\nNickname:\r\n\r\nEMERGENCY CONTACT\r\nName of Parent/Guardian:\r\nParent/Guardian Contact Number:\r\n";
            // 
            // studDetails
            // 
            studDetails.AutoSize = true;
            studDetails.FlatStyle = FlatStyle.Popup;
            studDetails.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studDetails.ForeColor = SystemColors.ActiveCaptionText;
            studDetails.Location = new Point(345, 48);
            studDetails.Name = "studDetails";
            studDetails.Size = new Size(273, 38);
            studDetails.TabIndex = 14;
            studDetails.Text = "STUDENT DETAILS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(275, 48);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 13;
            // 
            // LogOutBtn
            // 
            LogOutBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LogOutBtn.Location = new Point(647, 938);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(183, 34);
            LogOutBtn.TabIndex = 2;
            LogOutBtn.Text = "Log Out";
            LogOutBtn.UseVisualStyleBackColor = true;
            LogOutBtn.Click += button2_Click;
            // 
            // EditBtn
            // 
            EditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EditBtn.Location = new Point(435, 938);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(183, 34);
            EditBtn.TabIndex = 1;
            EditBtn.Text = "Edit/Update";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += button1_Click_1;
            // 
            // SavedPicture
            // 
            SavedPicture.BackgroundImage = (Image)resources.GetObject("SavedPicture.BackgroundImage");
            SavedPicture.BackgroundImageLayout = ImageLayout.Zoom;
            SavedPicture.BorderStyle = BorderStyle.Fixed3D;
            SavedPicture.Location = new Point(377, 121);
            SavedPicture.Name = "SavedPicture";
            SavedPicture.Size = new Size(199, 191);
            SavedPicture.TabIndex = 0;
            SavedPicture.TabStop = false;
            // 
            // InformationLlb
            // 
            InformationLlb.AutoSize = true;
            InformationLlb.BackColor = Color.Transparent;
            InformationLlb.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InformationLlb.Location = new Point(410, 370);
            InformationLlb.Name = "InformationLlb";
            InformationLlb.Size = new Size(415, 400);
            InformationLlb.TabIndex = 16;
            InformationLlb.Text = resources.GetString("InformationLlb.Text");
            // 
            // Student_Page
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(908, 1050);
            Controls.Add(InformationLlb);
            Controls.Add(DataLbl);
            Controls.Add(studDetails);
            Controls.Add(label1);
            Controls.Add(LogOutBtn);
            Controls.Add(EditBtn);
            Controls.Add(SavedPicture);
            Name = "Student_Page";
            Text = "Student_Page";
            ((System.ComponentModel.ISupportInitialize)SavedPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label DataLbl;
        private Label studDetails;
        private Button BackBtn;
        private Button EditBtn;
        private PictureBox SavedPicture;
        private Label InformationLlb;
        private Button LogOutBtn;
    }
}