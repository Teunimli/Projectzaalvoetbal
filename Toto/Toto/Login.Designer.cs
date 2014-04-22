namespace Toto
{
    partial class frm_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
			this.lbl_Username = new System.Windows.Forms.Label();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.txt_Username = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.btn_Login = new System.Windows.Forms.Button();
			this.btn_Register = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Username.Location = new System.Drawing.Point(12, 38);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(108, 25);
			this.lbl_Username.TabIndex = 0;
			this.lbl_Username.Text = "Username:";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Password.Location = new System.Drawing.Point(12, 97);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(104, 25);
			this.lbl_Password.TabIndex = 1;
			this.lbl_Password.Text = "Password:";
			// 
			// txt_Username
			// 
			this.txt_Username.Location = new System.Drawing.Point(127, 42);
			this.txt_Username.Name = "txt_Username";
			this.txt_Username.Size = new System.Drawing.Size(100, 20);
			this.txt_Username.TabIndex = 2;
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(127, 102);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(100, 20);
			this.txt_Password.TabIndex = 3;
			// 
			// btn_Login
			// 
			this.btn_Login.Location = new System.Drawing.Point(140, 154);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(87, 25);
			this.btn_Login.TabIndex = 4;
			this.btn_Login.Text = "Login";
			this.btn_Login.UseVisualStyleBackColor = true;
			// 
			// btn_Register
			// 
			this.btn_Register.Location = new System.Drawing.Point(17, 154);
			this.btn_Register.Name = "btn_Register";
			this.btn_Register.Size = new System.Drawing.Size(87, 25);
			this.btn_Register.TabIndex = 5;
			this.btn_Register.Text = "Register";
			this.btn_Register.UseVisualStyleBackColor = true;
			// 
			// frm_Login
			// 
			this.AcceptButton = this.btn_Login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 204);
			this.Controls.Add(this.btn_Register);
			this.Controls.Add(this.btn_Login);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_Username);
			this.Controls.Add(this.lbl_Password);
			this.Controls.Add(this.lbl_Username);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frm_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
    }
}

