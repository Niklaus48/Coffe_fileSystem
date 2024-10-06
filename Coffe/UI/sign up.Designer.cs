namespace Coffe.form
{
    partial class Sign_UP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.signupDis = new System.Windows.Forms.TextBox();
            this.signupPhone = new System.Windows.Forms.TextBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.sendToSignin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "displayName:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 37);
            this.label6.TabIndex = 7;
            this.label6.Text = "phoneNumber:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "UserName:";
            // 
            // signupUsername
            // 
            this.signupUsername.Location = new System.Drawing.Point(248, 43);
            this.signupUsername.Multiline = true;
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(434, 37);
            this.signupUsername.TabIndex = 9;
            // 
            // signupPassword
            // 
            this.signupPassword.Location = new System.Drawing.Point(248, 99);
            this.signupPassword.Multiline = true;
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.Size = new System.Drawing.Size(434, 37);
            this.signupPassword.TabIndex = 10;
            // 
            // signupDis
            // 
            this.signupDis.Location = new System.Drawing.Point(248, 157);
            this.signupDis.Multiline = true;
            this.signupDis.Name = "signupDis";
            this.signupDis.Size = new System.Drawing.Size(434, 37);
            this.signupDis.TabIndex = 11;
            // 
            // signupPhone
            // 
            this.signupPhone.Location = new System.Drawing.Point(248, 218);
            this.signupPhone.Multiline = true;
            this.signupPhone.Name = "signupPhone";
            this.signupPhone.Size = new System.Drawing.Size(434, 42);
            this.signupPhone.TabIndex = 12;
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.PapayaWhip;
            this.buttonSignup.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignup.Location = new System.Drawing.Point(133, 276);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(475, 76);
            this.buttonSignup.TabIndex = 13;
            this.buttonSignup.Text = "SIGN UP ";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // sendToSignin
            // 
            this.sendToSignin.AutoSize = true;
            this.sendToSignin.Font = new System.Drawing.Font("MRT_Nawress", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendToSignin.ForeColor = System.Drawing.Color.Red;
            this.sendToSignin.Location = new System.Drawing.Point(-1, 355);
            this.sendToSignin.Name = "sendToSignin";
            this.sendToSignin.Size = new System.Drawing.Size(286, 29);
            this.sendToSignin.TabIndex = 17;
            this.sendToSignin.Text = "Have you already registered?";
            // 
            // Sign_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 388);
            this.Controls.Add(this.sendToSignin);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.signupPhone);
            this.Controls.Add(this.signupDis);
            this.Controls.Add(this.signupPassword);
            this.Controls.Add(this.signupUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "Sign_UP";
            this.Text = "Sign_UP";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.TextBox signupDis;
        private System.Windows.Forms.TextBox signupPhone;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.Label sendToSignin;
    }
}