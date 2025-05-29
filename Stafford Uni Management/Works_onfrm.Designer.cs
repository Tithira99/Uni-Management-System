namespace Stafford_Uni_Management
{
    partial class Works_onfrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.worksonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet37 = new Stafford_Uni_Management.TithiDataSet37();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet33 = new Stafford_Uni_Management.TithiDataSet33();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet34 = new Stafford_Uni_Management.TithiDataSet34();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet35 = new Stafford_Uni_Management.TithiDataSet35();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.studentTableAdapter = new Stafford_Uni_Management.TithiDataSet33TableAdapters.StudentTableAdapter();
            this.courseTableAdapter = new Stafford_Uni_Management.TithiDataSet34TableAdapters.CourseTableAdapter();
            this.lecturerTableAdapter = new Stafford_Uni_Management.TithiDataSet35TableAdapters.LecturerTableAdapter();
            this.tithiDataSet36 = new Stafford_Uni_Management.TithiDataSet36();
            this.lecturerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter1 = new Stafford_Uni_Management.TithiDataSet36TableAdapters.LecturerTableAdapter();
            this.works_onTableAdapter = new Stafford_Uni_Management.TithiDataSet37TableAdapters.Works_onTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.worksonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID (Select)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course ID (Select)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ExamDate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Exam ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Grade (Select)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lecturer ID (Select)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Stafford_Uni_Management.Properties.Resources.Plus_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(22, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 58);
            this.button1.TabIndex = 12;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::Stafford_Uni_Management.Properties.Resources.Actions_edit_delete_icon__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(283, 515);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 58);
            this.button2.TabIndex = 13;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Stafford_Uni_Management.Properties.Resources.pencil_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(549, 515);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 58);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Stafford_Uni_Management.Properties.Resources.search_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(777, 515);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 58);
            this.button4.TabIndex = 15;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.worksonBindingSource, "StdntID", true));
            this.comboBox1.DataSource = this.studentBindingSource;
            this.comboBox1.DisplayMember = "StudentID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(232, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 24);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "StudentID";
            // 
            // worksonBindingSource
            // 
            this.worksonBindingSource.DataMember = "Works_on";
            this.worksonBindingSource.DataSource = this.tithiDataSet37;
            // 
            // tithiDataSet37
            // 
            this.tithiDataSet37.DataSetName = "TithiDataSet37";
            this.tithiDataSet37.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.tithiDataSet33;
            // 
            // tithiDataSet33
            // 
            this.tithiDataSet33.DataSetName = "TithiDataSet33";
            this.tithiDataSet33.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.worksonBindingSource, "CrsID", true));
            this.comboBox2.DataSource = this.courseBindingSource;
            this.comboBox2.DisplayMember = "CourseID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(232, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(342, 24);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "CourseID";
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.tithiDataSet34;
            // 
            // tithiDataSet34
            // 
            this.tithiDataSet34.DataSetName = "TithiDataSet34";
            this.tithiDataSet34.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "S",
            "F"});
            this.comboBox3.Location = new System.Drawing.Point(232, 351);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(342, 24);
            this.comboBox3.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.worksonBindingSource, "LectrID", true));
            this.comboBox4.DataSource = this.lecturerBindingSource;
            this.comboBox4.DisplayMember = "LID";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(232, 433);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(342, 24);
            this.comboBox4.TabIndex = 19;
            this.comboBox4.ValueMember = "LID";
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.tithiDataSet35;
            // 
            // tithiDataSet35
            // 
            this.tithiDataSet35.DataSetName = "TithiDataSet35";
            this.tithiDataSet35.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 195);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 22);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 271);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(342, 22);
            this.textBox2.TabIndex = 21;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // tithiDataSet36
            // 
            this.tithiDataSet36.DataSetName = "TithiDataSet36";
            this.tithiDataSet36.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturerBindingSource1
            // 
            this.lecturerBindingSource1.DataMember = "Lecturer";
            this.lecturerBindingSource1.DataSource = this.tithiDataSet36;
            // 
            // lecturerTableAdapter1
            // 
            this.lecturerTableAdapter1.ClearBeforeFill = true;
            // 
            // works_onTableAdapter
            // 
            this.works_onTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Stafford_Uni_Management.Properties.Resources.Go_back_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(777, 399);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 58);
            this.button5.TabIndex = 22;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Works_onfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stafford_Uni_Management.Properties.Resources.Common_int;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Works_onfrm";
            this.Text = "Student - Course (Examination Details)";
            this.Load += new System.EventHandler(this.Works_onfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.worksonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private TithiDataSet33 tithiDataSet33;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private TithiDataSet33TableAdapters.StudentTableAdapter studentTableAdapter;
        private TithiDataSet34 tithiDataSet34;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private TithiDataSet34TableAdapters.CourseTableAdapter courseTableAdapter;
        private TithiDataSet35 tithiDataSet35;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private TithiDataSet35TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private TithiDataSet36 tithiDataSet36;
        private System.Windows.Forms.BindingSource lecturerBindingSource1;
        private TithiDataSet36TableAdapters.LecturerTableAdapter lecturerTableAdapter1;
        private TithiDataSet37 tithiDataSet37;
        private System.Windows.Forms.BindingSource worksonBindingSource;
        private TithiDataSet37TableAdapters.Works_onTableAdapter works_onTableAdapter;
        private System.Windows.Forms.Button button5;
    }
}