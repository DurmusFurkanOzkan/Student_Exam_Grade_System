using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ogrenci_Sinav_Not_Kayit_Sistemi
{
    public partial class Teacher_Info : Form
    {   
        public Teacher_Info()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Ogrenci_Kayit_Sistemi;Integrated Security=True");



        private void button1_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert into Ogrenci_Bilgi (Ogrenci_numara,Ogrenci_ad,Ogrenci_soyad) values (@p1,@p2,@p3)",baglan);
            komut.Parameters.AddWithValue("@p1", Number.Text);
            komut.Parameters.AddWithValue("@p2", name.Text);
            komut.Parameters.AddWithValue("@p3", surname.Text);
            MessageBox.Show("Ogrenci Eklendi");
            komut.ExecuteNonQuery();
            baglan.Close();
        }

        private void Ogretmen_Detay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbo_Ogrenci_Kayit_SistemiDataSet2.Ogrenci_Bilgi' table. You can move, or remove it, as needed.
            this.ogrenci_BilgiTableAdapter.Fill(this.dbo_Ogrenci_Kayit_SistemiDataSet2.Ogrenci_Bilgi);
            // TODO: This line of code loads data into the 'dbo_Ogrenci_Kayit_SistemiDataSet1.Ogrenci_Bilgi' table. You can move, or remove it, as needed.
            // this.ogrenci_BilgiTableAdapter1.Fill(this.dbo_Ogrenci_Kayit_SistemiDataSet1.Ogrenci_Bilgi);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            s1 = Convert.ToDouble(grade1.Text);
            s2 = Convert.ToDouble(grade2.Text);
            s3 = Convert.ToDouble(grade3.Text);
            int durum;
            ortalama = (s1 + s2 + s3) / 3;
            if(ortalama>50)
            {
                durum = 1;
            }
            else
            {
                durum = 0;
            }
            baglan.Open();
            SqlCommand komut = new SqlCommand("Update Ogrenci_Bilgi set Sinav1=@p1,Sinav2=@p2,Sinav3=@p3,Ortalama=@p4,Durum=@p5 where Ogrenci_numara=@p6",baglan);
            komut.Parameters.AddWithValue("@p1", int.Parse(grade1.Text));
            komut.Parameters.AddWithValue("@p2", int.Parse(grade2.Text));
            komut.Parameters.AddWithValue("@p3", int.Parse(grade3.Text));
            komut.Parameters.AddWithValue("@p4", decimal.Parse(ortalama.ToString()));
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", Number.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Guncellendi");  
            baglan.Close();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;

            Number.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            name.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            surname.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            grade1.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            grade2.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
            grade3.Text = dataGridView1.Rows[seçilen].Cells[6].Value.ToString();
        }
    }
}
