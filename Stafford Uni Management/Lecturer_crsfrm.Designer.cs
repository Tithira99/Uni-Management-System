namespace Stafford_Uni_Management
{
    partial class Lecturer_crsfrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lecturercourseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet27 = new Stafford_Uni_Management.TithiDataSet27();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet26 = new Stafford_Uni_Management.TithiDataSet26();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet28 = new Stafford_Uni_Management.TithiDataSet28();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cid2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTableAdapter = new Stafford_Uni_Management.TithiDataSet26TableAdapters.CourseTableAdapter();
            this.lecturer_courseTableAdapter = new Stafford_Uni_Management.TithiDataSet27TableAdapters.Lecturer_courseTableAdapter();
            this.lecturerTableAdapter = new Stafford_Uni_Management.TithiDataSet28TableAdapters.LecturerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lecturercourseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Stafford_Uni_Management.Properties.Resources.Plus_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(206, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 58);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Stafford_Uni_Management.Properties.Resources.Actions_edit_delete_icon__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(614, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lecturercourseBindingSource, "Cid2", true));
            this.comboBox1.DataSource = this.courseBindingSource;
            this.comboBox1.DisplayMember = "CourseID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(346, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "CourseID";
            // 
            // lecturercourseBindingSource
            // 
            this.lecturercourseBindingSource.DataMember = "Lecturer_course";
            this.lecturercourseBindingSource.DataSource = this.tithiDataSet27;
            // 
            // tithiDataSet27
            // 
            this.tithiDataSet27.DataSetName = "TithiDataSet27";
            this.tithiDataSet27.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.tithiDataSet26;
            // 
            // tithiDataSet26
            // 
            this.tithiDataSet26.DataSetName = "TithiDataSet26";
            this.tithiDataSet26.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.lecturercourseBindingSource, "LecID", true));
            this.comboBox2.DataSource = this.lecturerBindingSource;
            this.comboBox2.DisplayMember = "LID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(346, 296);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(332, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.ValueMember = "LID";
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.tithiDataSet28;
            // 
            // tithiDataSet28
            // 
            this.tithiDataSet28.DataSetName = "TithiDataSet28";
            this.tithiDataSet28.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid2DataGridViewTextBoxColumn,
            this.lecIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lecturercourseBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(290, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(411, 114);
            this.dataGridView1.TabIndex = 8;
            // 
            // cid2DataGridViewTextBoxColumn
            // 
            this.cid2DataGridViewTextBoxColumn.DataPropertyName = "Cid2";
            this.cid2DataGridViewTextBoxColumn.HeaderText = "Cid2";
            this.cid2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cid2DataGridViewTextBoxColumn.Name = "cid2DataGridViewTextBoxColumn";
            this.cid2DataGridViewTextBoxColumn.Width = 125;
            // 
            // lecIDDataGridViewTextBoxColumn
            // 
            this.lecIDDataGridViewTextBoxColumn.DataPropertyName = "LecID";
            this.lecIDDataGridViewTextBoxColumn.HeaderText = "LecID";
            this.lecIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecIDDataGridViewTextBoxColumn.Name = "lecIDDataGridViewTextBoxColumn";
            this.lecIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // lecturer_courseTableAdapter
            // 
            this.lecturer_courseTableAdapter.ClearBeforeFill = true;
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
            this.button3.Location = new System.Drawing.Point(802, 262);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 58);
            this.button3.TabIndex = 9;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lecturer_crsfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stafford_Uni_Management.Properties.Resources.Common_int;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Lecturer_crsfrm";
            this.Text = "Lecturer - Course Registration";
            this.Load += new System.EventHandler(this.Lecturer_crsfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturercourseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TithiDataSet26 tithiDataSet26;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private TithiDataSet26TableAdapters.CourseTableAdapter courseTableAdapter;
        private TithiDataSet27 tithiDataSet27;
        private System.Windows.Forms.BindingSource lecturercourseBindingSource;
        private TithiDataSet27TableAdapters.Lecturer_courseTableAdapter lecturer_courseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecIDDataGridViewTextBoxColumn;
        private TithiDataSet28 tithiDataSet28;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private TithiDataSet28TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.Button button3;
    }
}