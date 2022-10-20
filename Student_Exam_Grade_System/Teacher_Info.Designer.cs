
namespace Ogrenci_Sinav_Not_Kayit_Sistemi
{
    partial class Teacher_Info
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ogrenciBilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_Ogrenci_Kayit_SistemiDataSet2 = new Ogrenci_Sinav_Not_Kayit_Sistemi.dbo_Ogrenci_Kayit_SistemiDataSet2();
            this.ogrenciBilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.surname = new System.Windows.Forms.MaskedTextBox();
            this.name = new System.Windows.Forms.MaskedTextBox();
            this.Number = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Numara = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.grade3 = new System.Windows.Forms.MaskedTextBox();
            this.grade2 = new System.Windows.Forms.MaskedTextBox();
            this.grade1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ogrenci_BilgiTableAdapter = new Ogrenci_Sinav_Not_Kayit_Sistemi.dbo_Ogrenci_Kayit_SistemiDataSet2TableAdapters.Ogrenci_BilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_Ogrenci_Kayit_SistemiDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView1.DataSource = this.ogrenciBilgiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(2, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(799, 213);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ogrenci_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Ogrenci_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ogrenci_numara";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ogrenci_numara";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Ogrenci_ad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ogrenci_ad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Ogrenci_soyad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Ogrenci_soyad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sinav1";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sinav1";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Sinav2";
            this.dataGridViewTextBoxColumn6.HeaderText = "Sinav2";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sinav3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sinav3";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Ortalama";
            this.dataGridViewTextBoxColumn8.HeaderText = "Ortalama";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Durum";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Durum";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // ogrenciBilgiBindingSource2
            // 
            this.ogrenciBilgiBindingSource2.DataMember = "Ogrenci_Bilgi";
            this.ogrenciBilgiBindingSource2.DataSource = this.dbo_Ogrenci_Kayit_SistemiDataSet2;
            // 
            // dbo_Ogrenci_Kayit_SistemiDataSet2
            // 
            this.dbo_Ogrenci_Kayit_SistemiDataSet2.DataSetName = "dbo_Ogrenci_Kayit_SistemiDataSet2";
            this.dbo_Ogrenci_Kayit_SistemiDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBilgiBindingSource1
            // 
            this.ogrenciBilgiBindingSource1.DataMember = "Ogrenci_Bilgi";
            // 
            // ogrenciBilgiBindingSource
            // 
            this.ogrenciBilgiBindingSource.DataMember = "Ogrenci_Bilgi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.surname);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.Number);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Numara);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(259, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ogrenci Ekle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(135, 91);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 22);
            this.surname.TabIndex = 5;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(135, 65);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(135, 35);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 22);
            this.Number.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // Numara
            // 
            this.Numara.AutoSize = true;
            this.Numara.Location = new System.Drawing.Point(19, 35);
            this.Numara.Name = "Numara";
            this.Numara.Size = new System.Drawing.Size(58, 17);
            this.Numara.TabIndex = 0;
            this.Numara.Text = "Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.grade3);
            this.groupBox2.Controls.Add(this.grade2);
            this.groupBox2.Controls.Add(this.grade1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(258, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(248, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Güncelle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(139, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // grade3
            // 
            this.grade3.Location = new System.Drawing.Point(139, 94);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(100, 22);
            this.grade3.TabIndex = 5;
            // 
            // grade2
            // 
            this.grade2.Location = new System.Drawing.Point(139, 62);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(100, 22);
            this.grade2.TabIndex = 4;
            // 
            // grade1
            // 
            this.grade1.Location = new System.Drawing.Point(139, 29);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(100, 22);
            this.grade1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Grade3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Grade2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grade1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(512, 1);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(295, 155);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sınav Notları";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Failed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Past ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Average";
            // 
            // ogrenci_BilgiTableAdapter
            // 
            this.ogrenci_BilgiTableAdapter.ClearBeforeFill = true;
            // 
            // Ogretmen_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 360);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ogretmen_Detay";
            this.Text = "Ogretmen_Detay";
            this.Load += new System.EventHandler(this.Ogretmen_Detay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_Ogrenci_Kayit_SistemiDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox surname;
        private System.Windows.Forms.MaskedTextBox name;
        private System.Windows.Forms.MaskedTextBox Number;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Numara;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox grade3;
        private System.Windows.Forms.MaskedTextBox grade2;
        private System.Windows.Forms.MaskedTextBox grade1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        //   private dbo_Ogrenci_Kayit_SistemiDataSet dbo_Ogrenci_Kayit_SistemiDataSet;
        private System.Windows.Forms.BindingSource ogrenciBilgiBindingSource;
        //    private dbo_Ogrenci_Kayit_SistemiDataSetTableAdapters.Ogrenci_BilgiTableAdapter ogrenci_BilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencinumaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrencisoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sinav3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ortalamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn durumDataGridViewCheckBoxColumn;
        //    private dbo_Ogrenci_Kayit_SistemiDataSet1 dbo_Ogrenci_Kayit_SistemiDataSet1;
        private System.Windows.Forms.BindingSource ogrenciBilgiBindingSource1;
        private dbo_Ogrenci_Kayit_SistemiDataSet2 dbo_Ogrenci_Kayit_SistemiDataSet2;
        private System.Windows.Forms.BindingSource ogrenciBilgiBindingSource2;
        private dbo_Ogrenci_Kayit_SistemiDataSet2TableAdapters.Ogrenci_BilgiTableAdapter ogrenci_BilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        //   private dbo_Ogrenci_Kayit_SistemiDataSet1TableAdapters.Ogrenci_BilgiTableAdapter ogrenci_BilgiTableAdapter1;
    }
}