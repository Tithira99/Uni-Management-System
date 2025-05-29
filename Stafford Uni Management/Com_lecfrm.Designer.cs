namespace Stafford_Uni_Management
{
    partial class Com_lecfrm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.committeeLecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet24 = new Stafford_Uni_Management.TithiDataSet24();
            this.committeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet23 = new Stafford_Uni_Management.TithiDataSet23();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet25 = new Stafford_Uni_Management.TithiDataSet25();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.committeeTableAdapter = new Stafford_Uni_Management.TithiDataSet23TableAdapters.CommitteeTableAdapter();
            this.committee_LecTableAdapter = new Stafford_Uni_Management.TithiDataSet24TableAdapters.Committee_LecTableAdapter();
            this.lecturerTableAdapter = new Stafford_Uni_Management.TithiDataSet25TableAdapters.LecturerTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.committeeLecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Committee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(173, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lecturer ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Stafford_Uni_Management.Properties.Resources.Plus_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(212, 431);
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
            this.button2.Location = new System.Drawing.Point(609, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.committeeLecBindingSource, "ComID", true));
            this.comboBox1.DataSource = this.committeeBindingSource;
            this.comboBox1.DisplayMember = "CommitteeID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(318, 239);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(358, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "CommitteeID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // committeeLecBindingSource
            // 
            this.committeeLecBindingSource.DataMember = "Committee_Lec";
            this.committeeLecBindingSource.DataSource = this.tithiDataSet24;
            // 
            // tithiDataSet24
            // 
            this.tithiDataSet24.DataSetName = "TithiDataSet24";
            this.tithiDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // committeeBindingSource
            // 
            this.committeeBindingSource.DataMember = "Committee";
            this.committeeBindingSource.DataSource = this.tithiDataSet23;
            // 
            // tithiDataSet23
            // 
            this.tithiDataSet23.DataSetName = "TithiDataSet23";
            this.tithiDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.committeeLecBindingSource, "LecID2", true));
            this.comboBox2.DataSource = this.lecturerBindingSource;
            this.comboBox2.DisplayMember = "LID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(318, 321);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(358, 24);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.ValueMember = "LID";
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.tithiDataSet25;
            // 
            // tithiDataSet25
            // 
            this.tithiDataSet25.DataSetName = "TithiDataSet25";
            this.tithiDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.comIDDataGridViewTextBoxColumn,
            this.lecID2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.committeeLecBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(298, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 148);
            this.dataGridView1.TabIndex = 10;
            // 
            // comIDDataGridViewTextBoxColumn
            // 
            this.comIDDataGridViewTextBoxColumn.DataPropertyName = "ComID";
            this.comIDDataGridViewTextBoxColumn.HeaderText = "ComID";
            this.comIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comIDDataGridViewTextBoxColumn.Name = "comIDDataGridViewTextBoxColumn";
            this.comIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // lecID2DataGridViewTextBoxColumn
            // 
            this.lecID2DataGridViewTextBoxColumn.DataPropertyName = "LecID2";
            this.lecID2DataGridViewTextBoxColumn.HeaderText = "LecID2";
            this.lecID2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lecID2DataGridViewTextBoxColumn.Name = "lecID2DataGridViewTextBoxColumn";
            this.lecID2DataGridViewTextBoxColumn.Width = 125;
            // 
            // committeeTableAdapter
            // 
            this.committeeTableAdapter.ClearBeforeFill = true;
            // 
            // committee_LecTableAdapter
            // 
            this.committee_LecTableAdapter.ClearBeforeFill = true;
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
            this.button3.Location = new System.Drawing.Point(802, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Com_lecfrm
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
            this.Name = "Com_lecfrm";
            this.Text = "Lecturer - Committee Registration";
            this.Load += new System.EventHandler(this.Com_lecfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.committeeLecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.committeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet25)).EndInit();
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
        private TithiDataSet23 tithiDataSet23;
        private System.Windows.Forms.BindingSource committeeBindingSource;
        private TithiDataSet23TableAdapters.CommitteeTableAdapter committeeTableAdapter;
        private TithiDataSet24 tithiDataSet24;
        private System.Windows.Forms.BindingSource committeeLecBindingSource;
        private TithiDataSet24TableAdapters.Committee_LecTableAdapter committee_LecTableAdapter;
        private TithiDataSet25 tithiDataSet25;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private TithiDataSet25TableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn comIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
    }
}