using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTVDTO;
using QLTVBUS;

namespace QLThuVien
{
    public partial class frmSuaTheDocGia : Form
    {
        private DocGiaBUS dgBus;
        private LoaiDocGiaBUS ldgBus;
        public frmSuaTheDocGia()
        {
            InitializeComponent();
        }
        private void loadLoaiDocGia_Combobox()
        {
            List<LoaiDocGiaDTO> listLoaiDocGia = ldgBus.select();

            if (listLoaiDocGia == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            cb_LaiDocGia.DataSource = new BindingSource(listLoaiDocGia, String.Empty);
            cb_LaiDocGia.DisplayMember = "tenLoaiDocGia";
            cb_LaiDocGia.ValueMember = "maLoaiDocGia";

            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_LaiDocGia.DataSource];
            myCurrencyManager.Refresh();

            if (cb_LaiDocGia.Items.Count > 0)
            {
                cb_LaiDocGia.SelectedIndex = 0;
            }

        }

        private void loadDocGia_Combobox()
        {
            List<DocGiaDTO> listDocGia = dgBus.select();

            if (listDocGia == null)
            {
                MessageBox.Show("Có lỗi khi lấy Món ăn từ DB");
                return;
            }
            
            
            cb_MaDocGia.DataSource = new BindingSource(listDocGia, String.Empty);
            //Console.WriteLine(cb_LaiDocGia.);
            cb_MaDocGia.DisplayMember = "Ma";
            cb_MaDocGia.ValueMember = "Ma";


            CurrencyManager myCurrencyManager = (CurrencyManager)this.BindingContext[cb_LaiDocGia.DataSource];
            myCurrencyManager.Refresh();

            if (cb_LaiDocGia.Items.Count > 0)
            {
                cb_LaiDocGia.SelectedIndex = 0;
            }

        }


        private void frmSuaTheDocGia_Load(object sender, EventArgs e)
        {
            dgBus = new DocGiaBUS();
            ldgBus = new LoaiDocGiaBUS();
            loadLoaiDocGia_Combobox();
            loadDocGia_Combobox();
            getThongTinDocGia();

        }


        private void bnt_SuaTheDocGia_Click(object sender, EventArgs e)
        {
            //1. Map data from GUI
            DocGiaDTO dg = new DocGiaDTO();


           
            dg.HovaTen = TB_HoVaTen.Text;
            dg.maLoaiDocGia = cb_LaiDocGia.SelectedValue.ToString();
            dg.NgayLapThe = date_NgayLapThe.Value;
            dg.NgaySinh = date_NgaySinh.Value;
            dg.DiaChi = tb_DiaChi.Text;
            dg.Email = tb_Email.Text;
            dg.HanSuDung = int.Parse(tb_HanSuDung.Text);

            //2. Kiểm tra data hợp lệ or not

            //3. Thêm vào DB
            bool kq = dgBus.sua(dg);
            if (kq == false)
                MessageBox.Show("Sửa thông tin Độc giả thất bại. Vui lòng kiểm tra lại dũ liệu");
            else
                MessageBox.Show("Sửa thông tin Độc giả thành công");

        }
        private void getThongTinDocGia()
        {
            DocGiaDTO dg = new DocGiaDTO();
            Console.WriteLine(" Ma da chon: " + cb_MaDocGia.SelectedValue.ToString());
            dg = dgBus.get(cb_MaDocGia.SelectedValue.ToString());
            if (dg == null)
            {
                MessageBox.Show("Get thong tin DG tu db that bai");
            }
            else
            {
                TB_HoVaTen.Text = dg.HovaTen;
                tb_DiaChi.Text = dg.DiaChi;
                tb_Email.Text = dg.Email;
                tb_HanSuDung.Text = dg.HanSuDung + "";
            }
        }

        private void cb_MaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            getThongTinDocGia();
        }
    }
}
