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
    public partial class Student_Info : Form
    {
        public Student_Info()
        {
            InitializeComponent();
        }
        
        public string numara1;
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-48MHJFV;Initial Catalog=dbo_Ogrenci_Kayit_Sistemi;Integrated Security=True");
        private void Ogrenci_Detay_Load(object sender, EventArgs e)
        {
            number.Text= numara1;
            baglan.Open();
            SqlCommand sc = new SqlCommand("Select * From Ogrenci_Bilgi where Ogrenci_numara=@p1",baglan);
            sc.Parameters.AddWithValue("@p1", numara1);
            SqlDataReader dr = sc.ExecuteReader();
            while(dr.Read())
            {
                name.Text = dr[2].ToString();
                surname.Text = dr[3].ToString();
                grade1.Text = dr[4].ToString();
                grade2.Text = dr[5].ToString();
                grade3.Text = dr[6].ToString();
                average.Text = dr[7].ToString();
                state.Text = dr[8].ToString();
            }
            baglan.Close();
        }
    }
}
