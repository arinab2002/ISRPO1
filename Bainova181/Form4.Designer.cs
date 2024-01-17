namespace Bainova181
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.database1DataSet = new Bainova181.Database1DataSet();
            this.view_stock_updatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_stock_updatesTableAdapter = new Bainova181.Database1DataSetTableAdapters.view_stock_updatesTableAdapter();
            this.tableAdapterManager = new Bainova181.Database1DataSetTableAdapters.TableAdapterManager();
            this.view_stock_updatessBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_stock_updatessTableAdapter = new Bainova181.Database1DataSetTableAdapters.view_stock_updatessTableAdapter();
            this.view_stock_updatessDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatessBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatessDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_stock_updatesBindingSource
            // 
            this.view_stock_updatesBindingSource.DataMember = "view_stock_updates";
            this.view_stock_updatesBindingSource.DataSource = this.database1DataSet;
            // 
            // view_stock_updatesTableAdapter
            // 
            this.view_stock_updatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.employeesTableAdapter = null;
            this.tableAdapterManager.goodsTableAdapter = null;
            this.tableAdapterManager.st_updatesTableAdapter = null;
            this.tableAdapterManager.typesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Bainova181.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_stock_updatessBindingSource
            // 
            this.view_stock_updatessBindingSource.DataMember = "view_stock_updatess";
            this.view_stock_updatessBindingSource.DataSource = this.database1DataSet;
            // 
            // view_stock_updatessTableAdapter
            // 
            this.view_stock_updatessTableAdapter.ClearBeforeFill = true;
            // 
            // view_stock_updatessDataGridView
            // 
            this.view_stock_updatessDataGridView.AutoGenerateColumns = false;
            this.view_stock_updatessDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_stock_updatessDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.view_stock_updatessDataGridView.DataSource = this.view_stock_updatessBindingSource;
            this.view_stock_updatessDataGridView.Location = new System.Drawing.Point(12, 12);
            this.view_stock_updatessDataGridView.Name = "view_stock_updatessDataGridView";
            this.view_stock_updatessDataGridView.Size = new System.Drawing.Size(443, 395);
            this.view_stock_updatessDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код обновления";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код обновления";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата обновления";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата обновления";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ответственный сотрудник";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ответственный сотрудник";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Код продукта";
            this.dataGridViewTextBoxColumn4.HeaderText = "Код продукта";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(467, 419);
            this.Controls.Add(this.view_stock_updatessDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Последние изменения";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatessBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_stock_updatessDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource view_stock_updatesBindingSource;
        private Database1DataSetTableAdapters.view_stock_updatesTableAdapter view_stock_updatesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_stock_updatessBindingSource;
        private Database1DataSetTableAdapters.view_stock_updatessTableAdapter view_stock_updatessTableAdapter;
        private System.Windows.Forms.DataGridView view_stock_updatessDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}