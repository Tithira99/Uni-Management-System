namespace Stafford_Uni_Management
{
    partial class Student_lecfrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.studentLecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet29 = new Stafford_Uni_Management.TithiDataSet29();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet30 = new Stafford_Uni_Management.TithiDataSet30();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet31 = new Stafford_Uni_Management.TithiDataSet31();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.student_LecturerTableAdapter = new Stafford_Uni_Management.TithiDataSet29TableAdapters.student_LecturerTableAdapter();
            this.studentTableAdapter = new Stafford_Uni_Management.TithiDataSet30TableAdapters.StudentTableAdapter();
            this.lecturerTableAdapter = new Stafford_Uni_Management.TithiDataSet31TableAdapters.LecturerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentLecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentLecturerBindingSource, "sid2", true));
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "StudentID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(348, 233);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(318, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "StudentID";
            // 
            // studentLecturerBindingSource
            // 
            this.studentLecturerBindingSource.DataMember = "student_Lecturer";
            this.studentLecturerBindingSource.DataSource = this.tithiDataSet29;
            // 
            // tithiDataSet29
            // 
            this.tithiDataSet29.DataSetName = "TithiDataSet29";
            this.tithiDataSet29.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.tithiDataSet30;
            // 
            // tithiDataSet30
            // 
            this.tithiDataSet30.DataSetName = "TithiDataSet30";
            this.tithiDataSet30.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.studentLecturerBindingSource, "Lid2", true));
            this.comboBox2.DataSource = this.lecturerBindingSource;
            this.comboBox2.DisplayMember = "LID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(348, 312);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(318, 24);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "LID";
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.tithiDataSet31;
            // 
            // tithiDataSet31
            // 
            this.tithiDataSet31.DataSetName = "TithiDataSet31";
            this.tithiDataSet31.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Stafford_Uni_Management.Properties.Resources.Plus_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(191, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Stafford_Uni_Management.Properties.Resources.Actions_edit_delete_icon__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(595, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid2DataGridViewTextBoxColumn,
            this.lid2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentLecturerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(214, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(452, 121);
            this.dataGridView1.TabIndex = 7;
            // 
            // sid2DataGridViewTextBoxColumn
            // 
            this.sid2DataGridViewTextBoxColumn.DataPropertyName = "sid2";
            this.sid2DataGridViewTextBoxColumn.HeaderText = "sid2";
            this.sid2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sid2DataGridViewTextBoxColumn.Name = "sid2DataGridViewTextBoxColumn";
            this.sid2DataGridViewTextBoxColumn.Width = 125;
            // 
            // lid2DataGridViewTextBoxColumn
            // 
            this.lid2DataGridViewTextBoxColumn.DataPropertyName = "Lid2";
            this.lid2DataGridViewTextBoxColumn.HeaderText = "Lid2";
            this.lid2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lid2DataGridViewTextBoxColumn.Name = "lid2DataGridViewTextBoxColumn";
            this.lid2DataGridViewTextBoxColumn.Width = 125;
            // 
            // student_LecturerTableAdapter
            // 
            this.student_LecturerTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Stafford_Uni_Management.Properties.Resources.Go_back_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(800, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 58);
            this.button3.TabIndex = 8;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Student_lecfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stafford_Uni_Management.Properties.Resources.Common_int;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Student_lecfrm";
            this.Text = "Lecturer - Student Registration";
            this.Load += new System.EventHandler(this.Student_lecfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentLecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TithiDataSet29 tithiDataSet29;
        private System.Windows.Forms.BindingSource studentLecturerBindingSource;
        private TithiDataSet29TableAdapters.student_LecturerTableAdapter student_LecturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lid2DataGridViewTextBoxColumn;
        private TithiDataSet30 tithiDataSet30;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private TithiDataSet30TableAdapters.StudentTableAdapter studentTableAdapter;
        private TithiDataSet31 tithiDataSet31;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private TithiDataSet31TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}