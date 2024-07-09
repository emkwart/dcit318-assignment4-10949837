namespace Address_Book
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.Button btnSave;

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
            this.textName = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(207, 67);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(179, 20);
            this.textName.TabIndex = 0;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(207, 124);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(179, 20);
            this.textEmail.TabIndex = 1;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(207, 185);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(179, 20);
            this.textPhone.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(207, 48);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(61, 13);
            this.name.TabIndex = 3;
            this.name.Text = "Enter name";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(207, 105);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(59, 13);
            this.email.TabIndex = 4;
            this.email.Text = "Enter email";
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Location = new System.Drawing.Point(207, 166);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(106, 13);
            this.phoneNumber.TabIndex = 5;
            this.phoneNumber.Text = "Enter Phone Number";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(207, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.email);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Address form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

