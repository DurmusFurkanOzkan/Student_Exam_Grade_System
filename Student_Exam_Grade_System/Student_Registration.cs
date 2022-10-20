using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Ogrenci_Sinav_Not_Kayit_Sistemi
{
    public partial class Ogrenci_Kayit : Form
    {
        public Ogrenci_Kayit()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {  
            Student_Info student_info = new Student_Info();
            student_info.numara1 = number_textbox.Text;
            student_info.Show();
            SqlConnection baglan = new SqlConnection();
        }

        

        private void number_textbox_TextChanged(object sender, EventArgs e)
        {
            if(number_textbox.Text=="1111")
            {
                Teacher_Info student_info = new Teacher_Info();
                student_info.Show();
            }
        }
    }
    
}
