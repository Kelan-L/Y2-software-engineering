namespace Software_Programmng
{
    partial class ManagerCrops
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
            this.cropsDataSet = new Software_Programmng.CropsDataSet();
            this.cropsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropsTableAdapter = new Software_Programmng.CropsDataSetTableAdapters.CropsTableAdapter();
            this.cropIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.growTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plantTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harvestTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fertiliserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsBindingSource)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(126, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 144);
            this.dataGridView1.TabIndex = 0;
            // 
            // cropsDataSet
            // 
            this.cropsDataSet.DataSetName = "CropsDataSet";
            this.cropsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cropsBindingSource
            // 
            this.cropsBindingSource.DataMember = "Crops";
            this.cropsBindingSource.DataSource = this.cropsDataSet;
            // 
            // cropsTableAdapter
            // 
            this.cropsTableAdapter.ClearBeforeFill = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 58);
            this.button2.TabIndex = 2;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ManagerCrops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 371);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManagerCrops";
            this.Text = "ManagerCrops";
            this.Load += new System.EventHandler(this.ManagerCrops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CropsDataSet cropsDataSet;
        private System.Windows.Forms.BindingSource cropsBindingSource;
        private CropsDataSetTableAdapters.CropsTableAdapter cropsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cropIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn growTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plantTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harvestTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fertiliserDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}