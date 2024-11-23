using BusinessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_Quan_Kho_Hang
{
    public partial class FrmHienLoi : DevExpress.XtraEditors.XtraForm
    {
        List<errExport> _err;
        public FrmHienLoi()
        {
            InitializeComponent();
        }
        public FrmHienLoi(List<errExport>err)
        {
            InitializeComponent();
            this._err = err;
        }
       

        private void FrmHienLoi_Load(object sender, EventArgs e)
        {
            gcerr.DataSource=_err;
            gverr.OptionsBehavior.Editable = false;
        }
    }
}