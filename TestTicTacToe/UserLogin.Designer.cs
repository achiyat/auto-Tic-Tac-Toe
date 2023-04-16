namespace TestTicTacToe
{
    partial class UserLogin
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
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Continue = new System.Windows.Forms.Button();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(432, 55);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(250, 51);
            this.buttonSignUp.TabIndex = 18;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(582, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(193, 127);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 22);
            this.textPassword.TabIndex = 15;
            this.textPassword.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(432, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "email";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(43, 127);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(144, 22);
            this.textEmail.TabIndex = 17;
            this.textEmail.Text = "email";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Continue
            // 
            this.button_Continue.Location = new System.Drawing.Point(43, 176);
            this.button_Continue.Name = "button_Continue";
            this.button_Continue.Size = new System.Drawing.Size(250, 51);
            this.button_Continue.TabIndex = 12;
            this.button_Continue.Text = "Continue";
            this.button_Continue.UseVisualStyleBackColor = true;
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(43, 55);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(250, 51);
            this.button_LogIn.TabIndex = 13;
            this.button_LogIn.Text = "LogIn";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Continue);
            this.Controls.Add(this.button_LogIn);
            this.Name = "UserLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Continue;
        private System.Windows.Forms.Button button_LogIn;
    }
}

