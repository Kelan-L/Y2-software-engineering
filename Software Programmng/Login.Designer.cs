namespace Software_Programmng
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.user_name = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.userID1 = new Software_Programmng.userID();
            this.passsword = new System.Windows.Forms.TextBox();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.password1 = new Software_Programmng.password();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.staffTableAdapter2 = new Software_Programmng.userIDTableAdapters.StaffTableAdapter();
            this.staffTableAdapter3 = new Software_Programmng.passwordTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userID1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password1)).BeginInit();
            this.SuspendLayout();
            // 
            // user_name
            // 
            this.user_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "userid", true));
            this.user_name.Location = new System.Drawing.Point(206, 53);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(149, 20);
            this.user_name.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Staff";
            this.bindingSource1.DataSource = this.userID1;
            // 
            // userID1
            // 
            this.userID1.DataSetName = "userID";
            this.userID1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // passsword
            // 
            this.passsword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource2, "password", true));
            this.passsword.Location = new System.Drawing.Point(206, 140);
            this.passsword.Name = "passsword";
            this.passsword.Size = new System.Drawing.Size(149, 20);
            this.passsword.TabIndex = 1;
            this.passsword.UseSystemPasswordChar = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Staff";
            this.bindingSource2.DataSource = this.password1;
            // 
            // password1
            // 
            this.password1.DataSetName = "password";
            this.password1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Log in";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(290, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // staffTableAdapter2
            // 
            this.staffTableAdapter2.ClearBeforeFill = true;
            // 
            // staffTableAdapter3
            // 
            this.staffTableAdapter3.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(473, 333);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passsword);
            this.Controls.Add(this.user_name);
            this.Name = "Login";
            this.Load += new System.EventHandler(this.Login_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userID1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.TextBox passsword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private userID userID1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private userIDTableAdapters.StaffTableAdapter staffTableAdapter2;
        private password password1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private passwordTableAdapters.StaffTableAdapter staffTableAdapter3;
    }
}

