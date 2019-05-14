using System;

namespace BDS_MN.Models
{
    public class DangTin
    {
        public int ID { get; set; }
        public String HinhThucDang { get; set; }
        public String LoaiTin { get; set; }
        public String LoaiTaiSan { get; set; }
        public String TinhThanh { get; set; }
        public String MaNen { get; set; }
        public String TenDuong { get; set; }
        public String TenDuAn { get; set; }
        public int GiaBan { get; set; }
        public int MatTien { get; set; }
        public int Hau { get; set; }
        public int ChieuDai { get; set; }
        public String TinhTrangPhapLy { get; set; }
        public String HinhAnh { get; set; }
    }
}