namespace Stafford_Uni_Management
{
    partial class LoginRegfrm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.loginBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet44 = new Stafford_Uni_Management.TithiDataSet44();
            this.adminBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tithiDataSet43 = new Stafford_Uni_Management.TithiDataSet43();
            this.tithiDataSet38 = new Stafford_Uni_Management.TithiDataSet38();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new Stafford_Uni_Management.TithiDataSet38TableAdapters.StudentTableAdapter();
            this.tithiDataSet39 = new Stafford_Uni_Management.TithiDataSet39();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter = new Stafford_Uni_Management.TithiDataSet39TableAdapters.LoginTableAdapter();
            this.tithiDataSet40 = new Stafford_Uni_Management.TithiDataSet40();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new Stafford_Uni_Management.TithiDataSet40TableAdapters.AdminTableAdapter();
            this.tithiDataSet42 = new Stafford_Uni_Management.TithiDataSet42();
            this.loginBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginTableAdapter1 = new Stafford_Uni_Management.TithiDataSet42TableAdapters.LoginTableAdapter();
            this.adminTableAdapter1 = new Stafford_Uni_Management.TithiDataSet43TableAdapters.AdminTableAdapter();
            this.loginTableAdapter2 = new Stafford_Uni_Management.TithiDataSet44TableAdapters.LoginTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(288, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(288, 242);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Stafford_Uni_Management.Properties.Resources.Plus_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(61, 436);
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
            this.button2.Location = new System.Drawing.Point(296, 436);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 58);
            this.button2.TabIndex = 5;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Stafford_Uni_Management.Properties.Resources.pencil_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(549, 436);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 58);
            this.button3.TabIndex = 6;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::Stafford_Uni_Management.Properties.Resources.search_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(796, 436);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 58);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::Stafford_Uni_Management.Properties.Resources.Go_back_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(796, 287);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 58);
            this.button5.TabIndex = 8;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Admin ID";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.loginBindingSource2, "adid", true));
            this.comboBox1.DataSource = this.adminBindingSource1;
            this.comboBox1.DisplayMember = "adminid";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(288, 335);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 24);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "adminid";
            // 
            // loginBindingSource2
            // 
            this.loginBindingSource2.DataMember = "Login";
            this.loginBindingSource2.DataSource = this.tithiDataSet44;
            // 
            // tithiDataSet44
            // 
            this.tithiDataSet44.DataSetName = "TithiDataSet44";
            this.tithiDataSet44.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource1
            // 
            this.adminBindingSource1.DataMember = "Admin";
            this.adminBindingSource1.DataSource = this.tithiDataSet43;
            // 
            // tithiDataSet43
            // 
            this.tithiDataSet43.DataSetName = "TithiDataSet43";
            this.tithiDataSet43.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tithiDataSet38
            // 
            this.tithiDataSet38.DataSetName = "TithiDataSet38";
            this.tithiDataSet38.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.tithiDataSet38;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // tithiDataSet39
            // 
            this.tithiDataSet39.DataSetName = "TithiDataSet39";
            this.tithiDataSet39.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "Login";
            this.loginBindingSource.DataSource = this.tithiDataSet39;
            // 
            // loginTableAdapter
            // 
            this.loginTableAdapter.ClearBeforeFill = true;
            // 
            // tithiDataSet40
            // 
            this.tithiDataSet40.DataSetName = "TithiDataSet40";
            this.tithiDataSet40.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "Admin";
            this.adminBindingSource.DataSource = this.tithiDataSet40;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // tithiDataSet42
            // 
            this.tithiDataSet42.DataSetName = "TithiDataSet42";
            this.tithiDataSet42.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource1
            // 
            this.loginBindingSource1.DataMember = "Login";
            this.loginBindingSource1.DataSource = this.tithiDataSet42;
            // 
            // loginTableAdapter1
            // 
            this.loginTableAdapter1.ClearBeforeFill = true;
            // 
            // adminTableAdapter1
            // 
            this.adminTableAdapter1.ClearBeforeFill = true;
            // 
            // loginTableAdapter2
            // 
            this.loginTableAdapter2.ClearBeforeFill = true;
            // 
            // LoginRegfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stafford_Uni_Management.Properties.Resources.Common_int;
            this.ClientSize = new System.Drawing.Size(989, 599);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginRegfrm";
            this.Text = "LoginReg";
            this.Load += new System.EventHandler(this.LoginRegfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tithiDataSet42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private TithiDataSet38 tithiDataSet38;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private TithiDataSet38TableAdapters.StudentTableAdapter studentTableAdapter;
        private TithiDataSet39 tithiDataSet39;
        private System.Windows.Forms.BindingSource loginBindingSource;
        private TithiDataSet39TableAdapters.LoginTableAdapter loginTableAdapter;
        private TithiDataSet40 tithiDataSet40;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private TithiDataSet40TableAdapters.AdminTableAdapter adminTableAdapter;
        private TithiDataSet42 tithiDataSet42;
        private System.Windows.Forms.BindingSource loginBindingSource1;
        private TithiDataSet42TableAdapters.LoginTableAdapter loginTableAdapter1;
        private TithiDataSet43 tithiDataSet43;
        private System.Windows.Forms.BindingSource adminBindingSource1;
        private TithiDataSet43TableAdapters.AdminTableAdapter adminTableAdapter1;
        private TithiDataSet44 tithiDataSet44;
        private System.Windows.Forms.BindingSource loginBindingSource2;
        private TithiDataSet44TableAdapters.LoginTableAdapter loginTableAdapter2;
    }
}