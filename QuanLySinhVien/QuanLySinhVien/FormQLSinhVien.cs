using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FormQLSinhVien : Form
    {
        public FormQLSinhVien()
        {
            InitializeComponent();
        }
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Desktop\.NET\ADO_TongHop\QuanLySinhVien\QuanLySinhVien\DB_QLSinhVien.mdf;Integrated Security=True";

        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";

        private void btn_Them_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into SINHVIEN values('" + txt_MaSV.Text + "', N'" + txt_HoTen.Text + "', Convert(Datetime, '" + dateTimePicker1.Text + "',103), '" + cb_Khoa.SelectedValue + "', '" + txt_Hinh.Text + "', '" + txt_Nam.Text + "','" + richTextBox1.Text + "','" + lb_TinhThanh.SelectedValue + "')";
            SqlCommand comm = new SqlCommand(sqlThem, conn);
            conn.Open();
            try
            {
                pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
            int ketqua = comm.ExecuteNonQuery();
            if (ketqua >= 1)
            {
                MessageBox.Show("Thêm thành công !!!");
            }
            else MessageBox.Show("Thêm thất bại !!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Trùng mã, lỗi SQL, thiếu Ghi chú hoặc phải nhập textbox hình ảnh");
            }
            finally
            {
                conn.Close();
            }
            LoadDataGridView();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            string sqldem = "select count (*) from SINHVIEN";
            SqlCommand comm = new SqlCommand(sqldem, conn);
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            txt_Dem.Text = ketqua.ToString();
        }

        private void FormQLSinhVien_Load(object sender, EventArgs e)
        {
            Load_Cb_Khoa();
            Load_lb_TinhThanh();
            LoadDataGridView();
        }

        public void Load_Cb_Khoa()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoad = "select * from KHOA";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cb_Khoa.DataSource = dt;
            cb_Khoa.DisplayMember = "TENKHOA";
            cb_Khoa.ValueMember = "MAKHOA";

        }

        public void Load_lb_TinhThanh()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoad = "select * from TINHTHANH";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lb_TinhThanh.DataSource = dt;
            lb_TinhThanh.DisplayMember = "TENTINH";
            lb_TinhThanh.ValueMember = "MATINH";
        }

        public void LoadDataGridView()
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlLoad = "select * from SINHVIEN";
            SqlDataAdapter da = new SqlDataAdapter(sqlLoad, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "SINHVIEN");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "SINHVIEN";
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            DialogResult DR = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (DR == DialogResult.Yes)
                try
                {
                    string sql = "delete from SINHVIEN where MSSV = '" + txt_MaSV.Text + "'";
                    File.Delete(duongdan + txt_Hinh.Text);
                    SqlCommand comm = new SqlCommand(sql, conn);
                    int ketqua = comm.ExecuteNonQuery();
                    if (ketqua >= 1)
                        MessageBox.Show("Xóa thành công");
                    else MessageBox.Show("Xóa thất bại, không có mã ....");
                }
                catch (Exception)
                {
                    MessageBox.Show(" (Catch) Xóa thất bại, Chưa có tên hình hoặc lỗi SQL....");
                }
            conn.Close();
            LoadDataGridView();
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            try
            {
                string sqlCapNhat = "update SINHVIEN set HOTEN = N'" + txt_HoTen.Text + "', NGAYNHAPHOC = Convert(Datetime, '" + dateTimePicker1.Value + "', 103), MAKHOA = '" + cb_Khoa.SelectedValue + "', HINHANH = N'" + txt_Hinh.Text + "', NAMTHU = '" + txt_Nam.Text + "', GHICHU = N'" + richTextBox1.Text + "', QUEQUAN = '" + lb_TinhThanh.SelectedValue + "' where MSSV = '" + txt_MaSV.Text + "' ";
                pictureBox1.Image.Save(duongdan + txt_Hinh.Text);
                SqlCommand comm = new SqlCommand(sqlCapNhat, conn);
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) MessageBox.Show("Cập nhật thành công");
                else MessageBox.Show("Cập nhật thất bại");
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi  try, chưa nhập mã để sửa, Thiếu Ghi chú, phải nhập textbox hình ảnh hoặc có thể lỗi Sql");
            }
            finally
            {
                conn.Close();
            }
            LoadDataGridView();
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            LoadDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dataGridView1.CurrentRow.Cells["MSSV"].Value.ToString();
            txt_HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["NGAYNHAPHOC"].Value.ToString();
            txt_Hinh.Text = dataGridView1.CurrentRow.Cells["HINHANH"].Value.ToString();
            pictureBox1.ImageLocation = (duongdan + txt_Hinh.Text);
            richTextBox1.Text = dataGridView1.CurrentRow.Cells["GHICHU"].Value.ToString();
            txt_Nam.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            chon = 1;
            lb_TinhThanh.SelectedValue = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            chon = 1;
            cb_Khoa.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        int chon = 0;

        private void cb_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Khoa.SelectedValue != null && chon == 0)
            {
                SqlConnection conn = new SqlConnection(chuoiketnoi);
                string text = cb_Khoa.SelectedValue.ToString();
                string sql = "select * from SINHVIEN where MAKHOA = N'" + text + "' ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            chon = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "Tất cả file|*.*|JPG|*.jpg|PNG|*.png|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(OFD.FileName);
        }

        private void btn_LoadNam_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            conn.Open();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DateTime svCurrentYear = DateTime.Parse(dataGridView1.Rows[i].Cells["NGAYNHAPHOC"].Value.ToString());
                string sqlSua = "Update SINHVIEN set NAMTHU = Convert(int,'" + ((DateTime.Today.Year + 1) - svCurrentYear.Year)
                    + "')  where MSSV = '" + dataGridView1.Rows[i].Cells["MSSV"].Value.ToString() + "'";
                SqlCommand comm = new SqlCommand(sqlSua, conn);
                comm.ExecuteNonQuery();
            }
            conn.Close();
            LoadDataGridView();
        }

        private void radio_Tang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["NAMTHU"], ListSortDirection.Ascending);
        }

        private void radio_Giam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Sort(dataGridView1.Columns["NAMTHU"], ListSortDirection.Descending);
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlTim = "select * from SINHVIEN where MSSV like '%" + txt_Tim.Text + "%' or HOTEN like N'%" + txt_Tim.Text + "%' "; //LIKE  ‘%”+…….+”%’  là gần giống    vd: Đức_Đ_ứ      ;  Nhật_N_h_ậ_t
            SqlDataAdapter da = new SqlDataAdapter(sqlTim, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txt_Tim_TextChanged(object sender, EventArgs e)
        {
            AcceptButton = btn_Tim;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int x = DateTime.Now.Year - dateTimePicker1.Value.Year + 1;
            txt_Nam.Text = x.ToString();
        }

        private void FormQLSinhVien_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult DR;
            DR = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.No)
                e.Cancel = true;
        }
















    }
}
