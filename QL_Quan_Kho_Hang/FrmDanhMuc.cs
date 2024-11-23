using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Model;
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
    public partial class FrmDanhMuc : DevExpress.XtraEditors.XtraForm
    {
        public FrmDanhMuc()
        {
            InitializeComponent();
        }
        public FrmDanhMuc(DevExpress.XtraGrid.Views.Grid.GridView gvchitiet, string chuoi,int flag)
        {
            InitializeComponent();
            this._chuoi=chuoi;
            this._gvchitiet=gvchitiet;
            this._flag=flag;
        }
        string _chuoi;
        int _flag;
        DevExpress.XtraGrid.Views.Grid.GridView _gvchitiet;
        CHUNGTU_CT _chungtu_ct;
        HANGHOA _hanghoa;
        NHOMHH _nhomHH;
        private void FrmDanhMuc_Load(object sender, EventArgs e)
        {
            _chungtu_ct=new CHUNGTU_CT();
            _hanghoa=new HANGHOA();
            _nhomHH=new NHOMHH();
            loadnhom();
            if (_chuoi.Trim().Length == 1)
            {
                gcdanhsach.DataSource = _hanghoa.getlistbyNHOM_Full(cbb_id.SelectedValue.ToString());

            }
            else
            {
                gcdanhsach.DataSource = _hanghoa.getListByKeyWord(_chuoi.Substring(1, _chuoi.Length - 1).TrimStart().ToString());

            }
         
            cbb_id.SelectedIndexChanged += Cbb_id_SelectedIndexChanged1;
            cbb_id.DropDownStyle = ComboBoxStyle.DropDownList;
            gvdanhsach.OptionsBehavior.Editable = false;
        }

        private void Cbb_id_SelectedIndexChanged1(object sender, EventArgs e)
        {

            loadData();
        }

        void insert()
        {
            int[] _selectrow=gvdanhsach.GetSelectedRows();
            List<string> _selected=new List<string>();
            foreach (int item in _selectrow)
            {
                _selected.Add(gvdanhsach.GetRowCellValue(item, "BarCode").ToString());

            }
            List<errExport> _err = new List<errExport>();
            List<string> _valid = new List<string>();
            List<string> _exit = new List<string>();
            if (_gvchitiet.RowCount > 1)
            {
                if(_gvchitiet.GetRowCellValue(_gvchitiet.RowCount - 1, "TenHH") != null)
                {
                    for (int i = 0; i < _gvchitiet.RowCount; i++)
                    {
                        _exit.Add(_gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < _gvchitiet.RowCount - 1; i++)
                    {
                        _exit.Add(_gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                    }
                }
            }
            // kiem tra chi tiet tr khi import
            for (int i = 0; i < _selected.Count; i++)
            {
                tb_HangHoa hh = _hanghoa.getItem(_selected[i]);
                if (_exit.Contains(_selected[i])==true)
                {
                    errExport err=new errExport();
                    err._barcode=_selected[i];
                    err._soluong = 1;
                    err._errcode = "Ma da ton tai";
                    _err.Add(err);
                    continue;
                }
                else
                {
                    _valid.Add(_selected[i]);
                    continue;
                }
                
                
            }
            //import nhung mã hop le
            foreach (string _item in _valid)
            {
                tb_HangHoa hh = _hanghoa.getItem(_item);
                if (_gvchitiet.RowCount > 1)
                {
                    int mautin =_gvchitiet.RowCount;
                    _gvchitiet.SelectRow(mautin-1);
                    if (_gvchitiet.GetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH") == null)
                    {
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT",1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                    }
                    else
                    {
                        _gvchitiet.AddNewRow();
                        _gvchitiet.SelectRow(mautin);
                        mautin++;
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Chietkhau", 0);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                    }

                }
                else
                {
                    if (_gvchitiet.RowCount == 0)
                    {
                        _gvchitiet.AddNewRow();
                    }
                    int mautin = _gvchitiet.RowCount;
                    _gvchitiet.SelectRow(mautin - 1);
                    if (_gvchitiet.GetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH") == null)
                    {
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                    }
                    else
                    {
                        _gvchitiet.AddNewRow();
                        _gvchitiet.SelectRow(mautin);
                        mautin++;
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.DonGia);
                    }
                }
            }
            _gvchitiet.AddNewRow();
            _gvchitiet.SelectRow(_gvchitiet.RowCount - 1);
            _gvchitiet.DeleteSelectedRows();
            _gvchitiet.RefreshData();
            if(_err.Count > 0)
            {
                FrmHienLoi _errpopup = new FrmHienLoi(_err);
                _errpopup.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        void insert1()
        {
            int[] _selectrow=gvdanhsach.GetSelectedRows();
            List<string> _selected=new List<string>();
            foreach (int item in _selectrow)
            {
                _selected.Add(gvdanhsach.GetRowCellValue(item, "BarCode").ToString());

            }
            List<errExport> _err = new List<errExport>();
            List<string> _valid = new List<string>();
            List<string> _exit = new List<string>();
            if (_gvchitiet.RowCount > 1)
            {
                if(_gvchitiet.GetRowCellValue(_gvchitiet.RowCount - 1, "TenHH") != null)
                {
                    for (int i = 0; i < _gvchitiet.RowCount; i++)
                    {
                        _exit.Add(_gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                    }
                }
                else
                {
                    for (int i = 0; i < _gvchitiet.RowCount - 1; i++)
                    {
                        _exit.Add(_gvchitiet.GetRowCellValue(i, "Barcode").ToString());
                    }
                }
            }
            // kiem tra chi tiet tr khi import
            for (int i = 0; i < _selected.Count; i++)
            {
                tb_HangHoa hh = _hanghoa.getItem(_selected[i]);
                if (_exit.Contains(_selected[i])==true)
                {
                    errExport err=new errExport();
                    err._barcode=_selected[i];
                    err._soluong = 1;
                    err._errcode = "Ma da ton tai";
                    _err.Add(err);
                    continue;
                }
                else
                {
                    _valid.Add(_selected[i]);
                    continue;
                }
                
                
            }
            //import nhung mã hop le
            foreach (string _item in _valid)
            {
                tb_HangHoa hh = _hanghoa.getItem(_item);
                if (_gvchitiet.RowCount > 1)
                {
                    int mautin =_gvchitiet.RowCount;
                    _gvchitiet.SelectRow(mautin-1);
                    if (_gvchitiet.GetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH") == null)
                    {
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT",1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Chietkhau", 0);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                    }
                    else
                    {
                        _gvchitiet.AddNewRow();
                        _gvchitiet.SelectRow(mautin);
                        mautin++;
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Chietkhau", 0);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                    }

                }
                else
                {
                    if (_gvchitiet.RowCount == 0)
                    {
                        _gvchitiet.AddNewRow();
                    }
                    int mautin = _gvchitiet.RowCount;
                    _gvchitiet.SelectRow(mautin - 1);
                    if (_gvchitiet.GetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH") == null)
                    {
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Chietkhau", 0);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                    }
                    else
                    {
                        _gvchitiet.AddNewRow();
                        _gvchitiet.SelectRow(mautin);
                        mautin++;
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Stt", mautin);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Barcode", hh.BarCode);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "DVT", hh.DVT);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "TenHH", hh.TenHH);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "SoluongCT", 1);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Dongia", hh.DonGia);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "GiaBan", hh.GiaBan);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Chietkhau", 0);
                        _gvchitiet.SetRowCellValue(_gvchitiet.FocusedRowHandle, "Thanhtien", hh.GiaBan);
                    }
                }
            }
            _gvchitiet.AddNewRow();
            _gvchitiet.SelectRow(_gvchitiet.RowCount - 1);
            _gvchitiet.DeleteSelectedRows();
            _gvchitiet.RefreshData();
            if(_err.Count > 0)
            {
                FrmHienLoi _errpopup = new FrmHienLoi(_err);
                _errpopup.ShowDialog();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
       
        private void Import_Click(object sender, EventArgs e)
        {
            if (_flag == 1)
            {
                insert();
            }
            else
            {
                insert1();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        void loadData()
        {
            try
            {
                gcdanhsach.DataSource = _hanghoa.getlistbyNHOM_Full(cbb_id.SelectedValue.ToString());

            }
            catch (Exception ex)
            {
                // Bắt lỗi và hiển thị thông báo
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        void loadnhom()
        {
            cbb_id.DataSource = _nhomHH.getALL();
            cbb_id.DisplayMember = "TenNhom";
            cbb_id.ValueMember = "IdNhom";
            cbb_id.SelectedIndex = 0;

        }
    }
}