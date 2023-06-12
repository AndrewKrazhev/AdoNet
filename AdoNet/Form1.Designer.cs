namespace AdoNet
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPOO = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.dataMain = new System.Windows.Forms.DataGridView();
            this.baseDataSet = new AdoNet.BaseDataSet();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTableAdapter = new AdoNet.BaseDataSetTableAdapters.MainTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пООDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерУчастникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumber);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPOO);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxName);
            this.splitContainer1.Panel1.Controls.Add(this.buttonDelete);
            this.splitContainer1.Panel1.Controls.Add(this.buttonUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAdd);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataMain);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(9, 388);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(90, 388);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(171, 388);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Фамилия имя отчество", true));
            this.textBoxName.Location = new System.Drawing.Point(45, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 20);
            this.textBoxName.TabIndex = 3;
            // 
            // textBoxPOO
            // 
            this.textBoxPOO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "ПОО", true));
            this.textBoxPOO.Location = new System.Drawing.Point(45, 81);
            this.textBoxPOO.Name = "textBoxPOO";
            this.textBoxPOO.Size = new System.Drawing.Size(186, 20);
            this.textBoxPOO.TabIndex = 4;
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "НомерУчастника", true));
            this.textBoxNumber.Location = new System.Drawing.Point(45, 107);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(186, 20);
            this.textBoxNumber.TabIndex = 5;
            // 
            // dataMain
            // 
            this.dataMain.AutoGenerateColumns = false;
            this.dataMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn,
            this.пООDataGridViewTextBoxColumn,
            this.номерУчастникаDataGridViewTextBoxColumn});
            this.dataMain.DataSource = this.mainBindingSource;
            this.dataMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataMain.Location = new System.Drawing.Point(0, 0);
            this.dataMain.Name = "dataMain";
            this.dataMain.Size = new System.Drawing.Size(530, 450);
            this.dataMain.TabIndex = 0;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "Main";
            this.mainBindingSource.DataSource = this.baseDataSet;
            // 
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияИмяОтчествоDataGridViewTextBoxColumn
            // 
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.DataPropertyName = "Фамилия имя отчество";
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.HeaderText = "Фамилия имя отчество";
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn.Name = "фамилияИмяОтчествоDataGridViewTextBoxColumn";
            // 
            // пООDataGridViewTextBoxColumn
            // 
            this.пООDataGridViewTextBoxColumn.DataPropertyName = "ПОО";
            this.пООDataGridViewTextBoxColumn.HeaderText = "ПОО";
            this.пООDataGridViewTextBoxColumn.Name = "пООDataGridViewTextBoxColumn";
            // 
            // номерУчастникаDataGridViewTextBoxColumn
            // 
            this.номерУчастникаDataGridViewTextBoxColumn.DataPropertyName = "НомерУчастника";
            this.номерУчастникаDataGridViewTextBoxColumn.HeaderText = "НомерУчастника";
            this.номерУчастникаDataGridViewTextBoxColumn.Name = "номерУчастникаDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPOO;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataMain;
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private BaseDataSetTableAdapters.MainTableAdapter mainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИмяОтчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пООDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерУчастникаDataGridViewTextBoxColumn;
    }
}

