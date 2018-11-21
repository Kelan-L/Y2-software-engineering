namespace Software_Programmng
{
    partial class Vehicles
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
            this.vehiclesDataSet = new Software_Programmng.VehiclesDataSet();
            this.vehiclesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesTableAdapter = new Software_Programmng.VehiclesDataSetTableAdapters.VehiclesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tractorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seederDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.databaseDataSet1 = new Software_Programmng.DatabaseDataSet1();
            this.toolsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolsTableAdapter = new Software_Programmng.DatabaseDataSet1TableAdapters.ToolsTableAdapter();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harrowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cultivatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spreaderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.tractorDataGridViewTextBoxColumn,
            this.combineDataGridViewTextBoxColumn,
            this.truckDataGridViewTextBoxColumn,
            this.seederDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiclesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(127, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // vehiclesDataSet
            // 
            this.vehiclesDataSet.DataSetName = "VehiclesDataSet";
            this.vehiclesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclesBindingSource
            // 
            this.vehiclesBindingSource.DataMember = "Vehicles";
            this.vehiclesBindingSource.DataSource = this.vehiclesDataSet;
            // 
            // vehiclesTableAdapter
            // 
            this.vehiclesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // tractorDataGridViewTextBoxColumn
            // 
            this.tractorDataGridViewTextBoxColumn.DataPropertyName = "Tractor";
            this.tractorDataGridViewTextBoxColumn.HeaderText = "Tractor";
            this.tractorDataGridViewTextBoxColumn.Name = "tractorDataGridViewTextBoxColumn";
            // 
            // combineDataGridViewTextBoxColumn
            // 
            this.combineDataGridViewTextBoxColumn.DataPropertyName = "Combine";
            this.combineDataGridViewTextBoxColumn.HeaderText = "Combine";
            this.combineDataGridViewTextBoxColumn.Name = "combineDataGridViewTextBoxColumn";
            // 
            // truckDataGridViewTextBoxColumn
            // 
            this.truckDataGridViewTextBoxColumn.DataPropertyName = "Truck";
            this.truckDataGridViewTextBoxColumn.HeaderText = "Truck";
            this.truckDataGridViewTextBoxColumn.Name = "truckDataGridViewTextBoxColumn";
            // 
            // seederDataGridViewTextBoxColumn
            // 
            this.seederDataGridViewTextBoxColumn.DataPropertyName = "Seeder";
            this.seederDataGridViewTextBoxColumn.HeaderText = "Seeder";
            this.seederDataGridViewTextBoxColumn.Name = "seederDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.plowDataGridViewTextBoxColumn,
            this.rakeDataGridViewTextBoxColumn,
            this.harrowDataGridViewTextBoxColumn,
            this.cultivatorDataGridViewTextBoxColumn,
            this.spreaderDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.toolsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(79, 215);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(643, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet1";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolsBindingSource
            // 
            this.toolsBindingSource.DataMember = "Tools";
            this.toolsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // toolsTableAdapter
            // 
            this.toolsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // plowDataGridViewTextBoxColumn
            // 
            this.plowDataGridViewTextBoxColumn.DataPropertyName = "Plow";
            this.plowDataGridViewTextBoxColumn.HeaderText = "Plow";
            this.plowDataGridViewTextBoxColumn.Name = "plowDataGridViewTextBoxColumn";
            // 
            // rakeDataGridViewTextBoxColumn
            // 
            this.rakeDataGridViewTextBoxColumn.DataPropertyName = "Rake";
            this.rakeDataGridViewTextBoxColumn.HeaderText = "Rake";
            this.rakeDataGridViewTextBoxColumn.Name = "rakeDataGridViewTextBoxColumn";
            // 
            // harrowDataGridViewTextBoxColumn
            // 
            this.harrowDataGridViewTextBoxColumn.DataPropertyName = "Harrow";
            this.harrowDataGridViewTextBoxColumn.HeaderText = "Harrow";
            this.harrowDataGridViewTextBoxColumn.Name = "harrowDataGridViewTextBoxColumn";
            // 
            // cultivatorDataGridViewTextBoxColumn
            // 
            this.cultivatorDataGridViewTextBoxColumn.DataPropertyName = "Cultivator";
            this.cultivatorDataGridViewTextBoxColumn.HeaderText = "Cultivator";
            this.cultivatorDataGridViewTextBoxColumn.Name = "cultivatorDataGridViewTextBoxColumn";
            // 
            // spreaderDataGridViewTextBoxColumn
            // 
            this.spreaderDataGridViewTextBoxColumn.DataPropertyName = "Spreader";
            this.spreaderDataGridViewTextBoxColumn.HeaderText = "Spreader";
            this.spreaderDataGridViewTextBoxColumn.Name = "spreaderDataGridViewTextBoxColumn";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 391);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 37);
            this.button3.TabIndex = 2;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VehiclesDataSet vehiclesDataSet;
        private System.Windows.Forms.BindingSource vehiclesBindingSource;
        private VehiclesDataSetTableAdapters.VehiclesTableAdapter vehiclesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn combineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seederDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DatabaseDataSet1 databaseDataSet1;
        private System.Windows.Forms.BindingSource toolsBindingSource;
        private DatabaseDataSet1TableAdapters.ToolsTableAdapter toolsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn plowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn harrowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cultivatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spreaderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}