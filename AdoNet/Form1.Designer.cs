﻿namespace AdoNet
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
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelPOO = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxPOO = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dataMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseDataSet = new AdoNet.BaseDataSet();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияИмяОтчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пООDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерУчастникаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mainTableAdapter = new AdoNet.BaseDataSetTableAdapters.MainTableAdapter();
            this.buttonRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataMain)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.labelNumber);
            this.splitContainer1.Panel1.Controls.Add(this.labelPOO);
            this.splitContainer1.Panel1.Controls.Add(this.labelFIO);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxNumber);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPOO);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataMain);
            this.splitContainer1.Size = new System.Drawing.Size(932, 528);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(12, 123);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(95, 13);
            this.labelNumber.TabIndex = 8;
            this.labelNumber.Text = "Номер участника";
            // 
            // labelPOO
            // 
            this.labelPOO.AutoSize = true;
            this.labelPOO.Location = new System.Drawing.Point(12, 79);
            this.labelPOO.Name = "labelPOO";
            this.labelPOO.Size = new System.Drawing.Size(31, 13);
            this.labelPOO.TabIndex = 7;
            this.labelPOO.Text = "ПОО";
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(12, 39);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "НомерУчастника", true));
            this.textBoxNumber.Location = new System.Drawing.Point(45, 139);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(186, 20);
            this.textBoxNumber.TabIndex = 5;
            // 
            // textBoxPOO
            // 
            this.textBoxPOO.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "ПОО", true));
            this.textBoxPOO.Location = new System.Drawing.Point(45, 95);
            this.textBoxPOO.Name = "textBoxPOO";
            this.textBoxPOO.Size = new System.Drawing.Size(186, 20);
            this.textBoxPOO.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mainBindingSource, "Фамилия имя отчество", true));
            this.textBoxName.Location = new System.Drawing.Point(45, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(186, 20);
            this.textBoxName.TabIndex = 3;
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
            this.dataMain.Size = new System.Drawing.Size(618, 528);
            this.dataMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 100);
            this.panel1.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(203, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(113, 24);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(84, 23);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update/Save";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(32, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataMember = "Main";
            this.mainBindingSource.DataSource = this.baseDataSet;
            // 
            // baseDataSet
            // 
            this.baseDataSet.DataSetName = "BaseDataSet";
            this.baseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // mainTableAdapter
            // 
            this.mainTableAdapter.ClearBeforeFill = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(203, 53);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(84, 23);
            this.buttonRefresh.TabIndex = 14;
            this.buttonRefresh.Text = "button2";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 528);
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
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxPOO;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataMain;
        private BaseDataSet baseDataSet;
        private System.Windows.Forms.BindingSource mainBindingSource;
        private BaseDataSetTableAdapters.MainTableAdapter mainTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияИмяОтчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пООDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерУчастникаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelPOO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRefresh;
    }
}

