using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\.NET\ADO_TongHop\QuanLySinhVien\QuanLySinhVien\DB_QLSinhVien.mdf;Integrated Security=True";
        int dem = 0;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlDangNhap = "select count (*) from TAIKHOAN where TENDANGNHAP = '" + txt_User.Text + "' and MATKHAU = '"+txt_Pass.Text+"'";
            SqlCommand comm = new SqlCommand(sqlDangNhap, conn);
            conn.Open();
            try
            {
                int ketqua = (int)comm.ExecuteScalar();
                if (ketqua >= 1)
                {
                    FormMain frm = new FormMain();
                    frm.Show();
                }
                else
                {
                    dem++;
                    MessageBox.Show("Lỗi đăng nhập lần" + dem);
                    if(dem == 3)
                    {
                        MessageBox.Show("Bạn đã nhập sai 3 lần. Thoát chương trình");
                        Application.Exit();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi sql");
            }
            conn.Close();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
