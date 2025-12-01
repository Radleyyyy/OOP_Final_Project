namespace OOP_Final_Project
{
    partial class Selection
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
            Logout = new Button();
            History = new Button();
            Return = new Button();
            Borrow = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Logout);
            groupBox1.Controls.Add(History);
            groupBox1.Controls.Add(Return);
            groupBox1.Controls.Add(Borrow);
            groupBox1.Location = new Point(241, 47);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(383, 652);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // Logout
            // 
            Logout.Location = new Point(60, 457);
            Logout.Margin = new Padding(4, 5, 4, 5);
            Logout.Name = "Logout";
            Logout.Size = new Size(259, 110);
            Logout.TabIndex = 3;
            Logout.Text = "Log-out";
            Logout.UseVisualStyleBackColor = true;
            Logout.Click += Logout_Click;
            // 
            // History
            // 
            History.Location = new Point(60, 337);
            History.Margin = new Padding(4, 5, 4, 5);
            History.Name = "History";
            History.Size = new Size(259, 110);
            History.TabIndex = 2;
            History.Text = "History";
            History.UseVisualStyleBackColor = true;
            History.Click += History_Click;
            // 
            // Return
            // 
            Return.Location = new Point(60, 217);
            Return.Margin = new Padding(4, 5, 4, 5);
            Return.Name = "Return";
            Return.Size = new Size(259, 110);
            Return.TabIndex = 1;
            Return.Text = "Return";
            Return.UseVisualStyleBackColor = true;
            Return.Click += button2_Click_1;
            // 
            // Borrow
            // 
            Borrow.Location = new Point(60, 97);
            Borrow.Margin = new Padding(4, 5, 4, 5);
            Borrow.Name = "Borrow";
            Borrow.Size = new Size(259, 110);
            Borrow.TabIndex = 0;
            Borrow.Text = "Borrow";
            Borrow.UseVisualStyleBackColor = true;
            Borrow.Click += button1_Click;
            // 
            // Selection
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 750);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Selection";
            Text = "Selection";
            Load += Form2_Load;
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