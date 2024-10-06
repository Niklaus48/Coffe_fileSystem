namespace Coffe.UI
{
    partial class Sign_IN
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
            this.signinPassword = new System.Windows.Forms.TextBox();
            this.signinUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonSignin = new System.Windows.Forms.Button();
            this.sendToSignup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signinPassword
            // 
            this.signinPassword.Location = new System.Drawing.Point(186, 81);
            this.signinPassword.Multiline = true;
            this.signinPassword.Name = "signinPassword";
            this.signinPassword.Size = new System.Drawing.Size(284, 37);
            this.signinPassword.TabIndex = 14;
            // 
            // signinUsername
            // 
            this.signinUsername.Location = new System.Drawing.Point(186, 25);
            this.signinUsername.Multiline = true;
            this.signinUsername.Name = "signinUsername";
            this.signinUsername.Size = new System.Drawing.Size(284, 37);
            this.signinUsername.TabIndex = 13;
            this.signinUsername.TextChanged += new System.EventHandler(this.signinUsername_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "UserName:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "password:";
            // 
            // buttonSignin
            // 
            this.buttonSignin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSignin.Font = new System.Drawing.Font("MV Boli", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSignin.Location = new System.Drawing.Point(131, 138);
            this.buttonSignin.Name = "buttonSignin";
            this.buttonSignin.Size = new System.Drawing.Size(245, 68);
            this.buttonSignin.TabIndex = 15;
            this.buttonSignin.Text = "SIGN IN ";
            this.buttonSignin.UseVisualStyleBackColor = false;
            this.buttonSignin.Click += new System.EventHandler(this.buttonSignin_Click);
            // 
            // sendToSignup
            // 
            this.sendToSignup.AutoSize = true;
            this.sendToSignup.Font = new System.Drawing.Font("MRT_Nawress", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendToSignup.ForeColor = System.Drawing.Color.Red;
            this.sendToSignup.Location = new System.Drawing.Point(12, 219);
            this.sendToSignup.Name = "sendToSignup";
            this.sendToSignup.Size = new System.Drawing.Size(253, 26);
            this.sendToSignup.TabIndex = 16;
            this.sendToSignup.Text = "Have you not registered yet??";
            this.sendToSignup.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sign_IN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(495, 247);
            this.Controls.Add(this.sendToSignup);
            this.Controls.Add(this.buttonSignin);
            this.Controls.Add(this.signinPassword);
            this.Controls.Add(this.signinUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sign_IN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_IN ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox signinPassword;
        private System.Windows.Forms.TextBox signinUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonSignin;
        private System.Windows.Forms.Label sendToSignup;
    }
}