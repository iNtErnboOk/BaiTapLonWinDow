using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_Tập_lớn_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_Sach1_Load(object sender, EventArgs e)
        {

        }
        private void LoadUC(UserControl uc)
        {
            splitContainer1.Panel2.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            splitContainer1.Panel2.Controls.Add(uc);
        }
        private void btnSach_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_Sach());
        }

        private void btnDocGia_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_DocGia());
        }

        private void btnMuonSach_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_MuonSach());
        }
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_TraSach());
        }
        private void btnGiaHanSach_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_GiaHanSach());
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadUC(new UserControls.UC_ThongKe());
        }
    }
}
