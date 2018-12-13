namespace Software_Programmng
{
    partial class LandingPage
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.UserWelcome = new System.Windows.Forms.ComboBox();
            this.userID = new Software_Programmng.userID();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Software_Programmng.userIDTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.userID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "ViewCrops";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 78);
            this.button2.TabIndex = 1;
            this.button2.Text = "ViewStorage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(218, 78);
            this.button3.TabIndex = 2;
            this.button3.Text = "ViewTimetable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(492, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(218, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "ViewVehicles";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // UserWelcome
            // 
            this.UserWelcome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "userid", true));
            this.UserWelcome.FormattingEnabled = true;
            this.UserWelcome.Location = new System.Drawing.Point(123, 33);
            this.UserWelcome.Name = "UserWelcome";
            this.UserWelcome.Size = new System.Drawing.Size(187, 21);
            this.UserWelcome.TabIndex = 4;
            this.UserWelcome.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userID
            // 
            this.userID.DataSetName = "userID";
            this.userID.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.userID;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(851, 408);
            this.Controls.Add(this.UserWelcome);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "LandingPage";
            this.Text = "LandingPage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox UserWelcome;
        private userID userID;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private userIDTableAdapters.StaffTableAdapter staffTableAdapter;
    }
}