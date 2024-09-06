namespace WindowsFormsApp8
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerButton = new System.Windows.Forms.Label();
            this.passwordEye = new System.Windows.Forms.PictureBox();
            this.enterRegisterButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.registerButton);
            this.panel1.Controls.Add(this.passwordEye);
            this.panel1.Controls.Add(this.enterRegisterButton);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.userField);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 445);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(47)))));
            this.registerButton.Location = new System.Drawing.Point(163, 399);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(137, 26);
            this.registerButton.TabIndex = 8;
            this.registerButton.Text = "Регистрация";
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordEye
            // 
            this.passwordEye.Image = ((System.Drawing.Image)(resources.GetObject("passwordEye.Image")));
            this.passwordEye.Location = new System.Drawing.Point(412, 196);
            this.passwordEye.Name = "passwordEye";
            this.passwordEye.Size = new System.Drawing.Size(50, 49);
            this.passwordEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordEye.TabIndex = 7;
            this.passwordEye.TabStop = false;
            this.passwordEye.Click += new System.EventHandler(this.passwordEye_Click);
            // 
            // enterRegisterButton
            // 
            this.enterRegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(47)))));
            this.enterRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterRegisterButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(107)))), ((int)(((byte)(224)))));
            this.enterRegisterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.enterRegisterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.enterRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterRegisterButton.Location = new System.Drawing.Point(80, 338);
            this.enterRegisterButton.Name = "enterRegisterButton";
            this.enterRegisterButton.Size = new System.Drawing.Size(303, 58);
            this.enterRegisterButton.TabIndex = 6;
            this.enterRegisterButton.Text = "Войти";
            this.enterRegisterButton.UseVisualStyleBackColor = false;
            this.enterRegisterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.Location = new System.Drawing.Point(60, 198);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(345, 47);
            this.passwordField.TabIndex = 5;
            this.passwordField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // userField
            // 
            this.userField.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userField.Location = new System.Drawing.Point(57, 127);
            this.userField.Multiline = true;
            this.userField.Name = "userField";
            this.userField.Size = new System.Drawing.Size(345, 49);
            this.userField.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(164)))), ((int)(((byte)(47)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.registerLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 100);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Sitka Text", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(438, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // registerLabel
            // 
            this.registerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerLabel.Font = new System.Drawing.Font("Sitka Small", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.registerLabel.Location = new System.Drawing.Point(0, 0);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(465, 100);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Войти";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.registerLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 445);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userField;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button enterRegisterButton;
        private System.Windows.Forms.PictureBox passwordEye;
        private System.Windows.Forms.Label registerButton;
    }
}

