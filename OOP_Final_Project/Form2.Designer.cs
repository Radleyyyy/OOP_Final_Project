namespace OOP_Final_Project
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            History = new Button();
            Return = new Button();
            Borrow = new Button();
            Logout = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Logout);
            groupBox1.Controls.Add(History);
            groupBox1.Controls.Add(Return);
            groupBox1.Controls.Add(Borrow);
            groupBox1.Location = new Point(169, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(268, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // History
            // 
            History.Location = new Point(42, 202);
            History.Name = "History";
            History.Size = new Size(181, 66);
            History.TabIndex = 2;
            History.Text = "History";
            History.UseVisualStyleBackColor = true;
            History.Click += History_Click;
            // 
            // Return
            // 
            Return.Location = new Point(42, 130);
            Return.Name = "Return";
            Return.Size = new Size(181, 66);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += button2_Click_1;
            // 
            // Borrow
            // 
            Borrow.Location = new Point(42, 58);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(181, 66);
            Borrow.TabIndex = 0;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = true;
            Borrow.Click += button1_Click;
            // 
            // Logout
            // 
            Logout.Location = new Point(42, 274);
            Logout.Name = "Logout";
            Logout.Size = new Size(181, 66);
            Logout.TabIndex = 3;
            Logout.Text = "Log-out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(588, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button History;
        private Button Return;
        private Button Borrow;
        private Button Logout;
    }
}