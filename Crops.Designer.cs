namespace Software_Programmng
{
    partial class Crops
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cropIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.growTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertiliserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cropsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.croptabledata = new Software_Programmng.croptabledata();
            this.cropsTableAdapter = new Software_Programmng.croptabledataTableAdapters.CropsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.croptabledata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cropIDDataGridViewTextBoxColumn,
            this.growTimeDataGridViewTextBoxColumn,
            this.plantTimeDataGridViewTextBoxColumn,
            this.harvestTimeDataGridViewTextBoxColumn,
            this.fertiliserDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cropsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(122, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 148);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cropIDDataGridViewTextBoxColumn
            // 
            this.cropIDDataGridViewTextBoxColumn.DataPropertyName = "CropID";
            this.cropIDDataGridViewTextBoxColumn.HeaderText = "CropID";
            this.cropIDDataGridViewTextBoxColumn.Name = "cropIDDataGridViewTextBoxColumn";
            // 
            // growTimeDataGridViewTextBoxColumn
            // 
            this.growTimeDataGridViewTextBoxColumn.DataPropertyName = "GrowTime";
            this.growTimeDataGridViewTextBoxColumn.HeaderText = "GrowTime";
            this.growTimeDataGridViewTextBoxColumn.Name = "growTimeDataGridViewTextBoxColumn";
            // 
            // plantTimeDataGridViewTextBoxColumn
            // 
            this.plantTimeDataGridViewTextBoxColumn.DataPropertyName = "PlantTime";
            this.plantTimeDataGridViewTextBoxColumn.HeaderText = "PlantTime";
            this.plantTimeDataGridViewTextBoxColumn.Name = "plantTimeDataGridViewTextBoxColumn";
            // 
            // harvestTimeDataGridViewTextBoxColumn
            // 
            this.harvestTimeDataGridViewTextBoxColumn.DataPropertyName = "HarvestTime";
            this.harvestTimeDataGridViewTextBoxColumn.HeaderText = "HarvestTime";
            this.harvestTimeDataGridViewTextBoxColumn.Name = "harvestTimeDataGridViewTextBoxColumn";
            // 
            // fertiliserDataGridViewTextBoxColumn
            // 
            this.fertiliserDataGridViewTextBoxColumn.DataPropertyName = "Fertiliser";
            this.fertiliserDataGridViewTextBoxColumn.HeaderText = "Fertiliser";
            this.fertiliserDataGridViewTextBoxColumn.Name = "fertiliserDataGridViewTextBoxColumn";
            // 
            // cropsBindingSource
            // 
            this.cropsBindingSource.DataMember = "Crops";
            this.cropsBindingSource.DataSource = this.croptabledata;
            // 
            // croptabledata
            // 
            this.croptabledata.DataSetName = "croptabledata";
            this.croptabledata.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cropsTableAdapter
            // 
            this.cropsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(633, 372);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Crops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Crops";
            this.Text = "Crops";
            this.Load += new System.EventHandler(this.Crops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.croptabledata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private croptabledata croptabledata;
        private System.Windows.Forms.BindingSource cropsBindingSource;
        private croptabledataTableAdapters.CropsTableAdapter cropsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn growTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertiliserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}