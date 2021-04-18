
namespace Event_Diary
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EventDate = new System.Windows.Forms.TextBox();
            this.EventName = new System.Windows.Forms.TextBox();
            this.EventNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.storyBox = new System.Windows.Forms.TextBox();
            this.user_DBDataSet = new Event_Diary.user_DBDataSet();
            this.tbeventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_eventTableAdapter = new Event_Diary.user_DBDataSetTableAdapters.tb_eventTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.user_DBDataSet2 = new Event_Diary.user_DBDataSet2();
            this.tablefnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_fnTableAdapter = new Event_Diary.user_DBDataSet2TableAdapters.table_fnTableAdapter();
            this.user_DBDataSet3 = new Event_Diary.user_DBDataSet3();
            this.tablefnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_fnTableAdapter1 = new Event_Diary.user_DBDataSet3TableAdapters.table_fnTableAdapter();
            this.label7 = new System.Windows.Forms.Label();
            this.filenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imporanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbeventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "High ",
            "Moderate ",
            "Less Important"});
            this.comboBox1.Location = new System.Drawing.Point(102, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 20);
            this.textBox1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Importance";
            // 
            // EventDate
            // 
            this.EventDate.Location = new System.Drawing.Point(102, 61);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(210, 20);
            this.EventDate.TabIndex = 24;
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(102, 33);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(210, 20);
            this.EventName.TabIndex = 23;
            // 
            // EventNo
            // 
            this.EventNo.Location = new System.Drawing.Point(102, 6);
            this.EventNo.Name = "EventNo";
            this.EventNo.Size = new System.Drawing.Size(210, 20);
            this.EventNo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Event No ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Event Date ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Event Name ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Picture";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Story";
            // 
            // storyBox
            // 
            this.storyBox.Location = new System.Drawing.Point(461, 36);
            this.storyBox.Multiline = true;
            this.storyBox.Name = "storyBox";
            this.storyBox.Size = new System.Drawing.Size(327, 160);
            this.storyBox.TabIndex = 34;
            // 
            // user_DBDataSet
            // 
            this.user_DBDataSet.DataSetName = "user_DBDataSet";
            this.user_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbeventBindingSource
            // 
            this.tbeventBindingSource.DataMember = "tb_event";
            this.tbeventBindingSource.DataSource = this.user_DBDataSet;
            // 
            // tb_eventTableAdapter
            // 
            this.tb_eventTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(353, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(353, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(353, 85);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 38;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(318, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(713, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // user_DBDataSet2
            // 
            this.user_DBDataSet2.DataSetName = "user_DBDataSet2";
            this.user_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablefnBindingSource
            // 
            this.tablefnBindingSource.DataMember = "table_fn";
            this.tablefnBindingSource.DataSource = this.user_DBDataSet2;
            // 
            // table_fnTableAdapter
            // 
            this.table_fnTableAdapter.ClearBeforeFill = true;
            // 
            // user_DBDataSet3
            // 
            this.user_DBDataSet3.DataSetName = "user_DBDataSet3";
            this.user_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tablefnBindingSource1
            // 
            this.tablefnBindingSource1.DataMember = "table_fn";
            this.tablefnBindingSource1.DataSource = this.user_DBDataSet3;
            // 
            // table_fnTableAdapter1
            // 
            this.table_fnTableAdapter1.ClearBeforeFill = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "All Events ";
            // 
            // filenameDataGridViewTextBoxColumn
            // 
            this.filenameDataGridViewTextBoxColumn.DataPropertyName = "filename";
            this.filenameDataGridViewTextBoxColumn.HeaderText = "filename";
            this.filenameDataGridViewTextBoxColumn.Name = "filenameDataGridViewTextBoxColumn";
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            // 
            // imporanceDataGridViewTextBoxColumn
            // 
            this.imporanceDataGridViewTextBoxColumn.DataPropertyName = "imporance";
            this.imporanceDataGridViewTextBoxColumn.HeaderText = "imporance";
            this.imporanceDataGridViewTextBoxColumn.Name = "imporanceDataGridViewTextBoxColumn";
            // 
            // eventDateDataGridViewTextBoxColumn
            // 
            this.eventDateDataGridViewTextBoxColumn.DataPropertyName = "eventDate";
            this.eventDateDataGridViewTextBoxColumn.HeaderText = "eventDate";
            this.eventDateDataGridViewTextBoxColumn.Name = "eventDateDataGridViewTextBoxColumn";
            // 
            // eventNameDataGridViewTextBoxColumn
            // 
            this.eventNameDataGridViewTextBoxColumn.DataPropertyName = "eventName";
            this.eventNameDataGridViewTextBoxColumn.HeaderText = "eventName";
            this.eventNameDataGridViewTextBoxColumn.Name = "eventNameDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.eventNameDataGridViewTextBoxColumn,
            this.eventDateDataGridViewTextBoxColumn,
            this.imporanceDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.filenameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tablefnBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(803, 191);
            this.dataGridView1.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Welcome to Admin Panel";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.storyBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EventDate);
            this.Controls.Add(this.EventName);
            this.Controls.Add(this.EventNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Photo Diary ";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbeventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablefnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EventDate;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.TextBox EventNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox storyBox;
        private user_DBDataSet user_DBDataSet;
        private System.Windows.Forms.BindingSource tbeventBindingSource;
        private user_DBDataSetTableAdapters.tb_eventTableAdapter tb_eventTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private user_DBDataSet2 user_DBDataSet2;
        private System.Windows.Forms.BindingSource tablefnBindingSource;
        private user_DBDataSet2TableAdapters.table_fnTableAdapter table_fnTableAdapter;
        private user_DBDataSet3 user_DBDataSet3;
        private System.Windows.Forms.BindingSource tablefnBindingSource1;
        private user_DBDataSet3TableAdapters.table_fnTableAdapter table_fnTableAdapter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn filenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imporanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
    }
}