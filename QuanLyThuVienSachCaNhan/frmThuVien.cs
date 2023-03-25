using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVienSachCaNhan
{
    public partial class frmThuVien : Form
    {
        List<string> list = new List<string>();
        public frmThuVien()
        {
            InitializeComponent();
        }

        private void btnTrinhTham_Click(object sender, EventArgs e)
        {
            frmTrinhTham frmTT = new frmTrinhTham();
            frmTT.ShowDialog();
        }

        private void btnKinhDi_Click(object sender, EventArgs e)
        {
            frmKinhDi frmKD = new frmKinhDi();
            frmKD.ShowDialog();
        }

        private void btnTamLy_Click(object sender, EventArgs e)
        {
            frmTamLy frmTL = new frmTamLy();
            frmTL.ShowDialog();
        }

        private void btnVHNN_Click(object sender, EventArgs e)
        {
            frmVHNN frmNN = new frmVHNN();
            frmNN.ShowDialog();
        }

        private void btnVHVN_Click(object sender, EventArgs e)
        {
            frmVHVN frmVN = new frmVHVN();
            frmVN.ShowDialog();
        }

        private void btnNgonTinh_Click(object sender, EventArgs e)
        {
            frmNgonTinh frmNT = new frmNgonTinh();
            frmNT.ShowDialog();
        }
    }
}
