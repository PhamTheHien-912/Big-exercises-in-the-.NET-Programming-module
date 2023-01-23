using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class DeTaiKH
    {
        Data da = new Data();
        public DataTable HienthiDeTai()
        {
            string sql = "Select * from tbDeTai";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        
        

        public void ThemDeTai(string madt, string tendt, string thoigian, string maloaidt, string matg)
        {


            string sql = "insert into tbDeTai (MaDeTai, TenDeTai, ThoiGian, MaLoaiDeTai, MaTacGia) values('" + madt + "',N'" + tendt + "', N'" + thoigian + "',N'" + maloaidt + "',N'" + matg + "')";
            da.ExecuteNonQuery(sql);

        }

        public void SuaDeTai(string madt, string tendt, string thoigian, string maloaidt, string matg)
        {
            string sql = "update tbDeTai set   TenDeTai=N'" + tendt + "', ThoiGian=N'" + thoigian+ "', MaLoaiDeTai=N'" + maloaidt + "', MaTacGia=N'" + matg + "' where MaDeTai=N'" + madt + "'";
            da.ExecuteNonQuery(sql);
        }

        public void XoaDeTai(string ml)
        {
            string sql = "delete tbDeTai where MaDeTai=N'" + ml + "'";
            da.ExecuteNonQuery(sql);
        }


        public DataTable TimKiemDeTai(string dk)
        {
            string sql = "select * from tbDeTai where MaDeTai like N'%" + dk + "%' or TenDeTai like N'%" + dk + "%' or MaLoaiDeTai like N'%" + dk + "%' or MaTacGia like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    
    }
    public class BaiBaoKH
    {
        Data da = new Data();
        public DataTable HienthiBaiBao()
        {
            string sql = "Select * from tblBaiBaoKH";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }



        public void ThemBaiBao(string madt, string tendt, string thoigian, string mota, string maloaidt, string matg)
        {


            string sql = "insert into tblBaiBaoKH (MaBaiBao, TenBaiBao, ThoiGian,MoTa, MaLoaiBaiBao, MaTacGia) values('" + madt + "',N'" + tendt + "', N'" + thoigian + "',N'" + mota + "',N'" + maloaidt + "',N'" + matg + "')";
            da.ExecuteNonQuery(sql);

        }

        public void SuaBaiBao(string madt, string tendt, string thoigian, string mota, string maloaidt, string matg)
        {
            string sql = "update tblBaiBaoKH set   TenBaiBao=N'" + tendt + "', ThoiGian=N'" + thoigian + "', MoTa=N'" + mota + "', MaLoaiBaiBao=N'" + maloaidt + "', MaTacGia=N'" + matg + "' where MaBaiBao=N'" + madt + "'";
            da.ExecuteNonQuery(sql);
        }

        public void XoaBaiBao(string ml)
        {
            string sql = "delete tblBaiBaoKH where MaBaiBao=N'" + ml + "'";
            da.ExecuteNonQuery(sql);
        }


        public DataTable TimKiemBaiBao(string dk)
        {
            string sql = "select * from tblBaiBaoKH where MaBaiBao like N'%" + dk + "%' or TenBaiBao like N'%" + dk + "%' or MaLoaiBaiBao like N'%" + dk + "%' or MaTacGia like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

    }
    public class TacGia
    {
        Data da = new Data();
        public DataTable HienthiTacGia()
        {
            string sql = "Select * from tbTacGia";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }



        public void ThemTacGia(string matg, string tentg, string donvi, string sdt, string email, string chucvu)
        {


            string sql = "insert into tbTacGia (MaTacGia, TenTacGia, DonVi,DienThoai, Email, ChucVu) values('" + matg + "',N'" + tentg + "', N'" + donvi + "',N'" + sdt + "',N'" + email + "',N'" + chucvu + "')";
            da.ExecuteNonQuery(sql);

        }

        public void SuaTacGia(string matg, string tentg, string donvi, string sdt, string email, string chucvu)
        {
            string sql = "update tbTacGia set   TenTacGia=N'" + tentg + "', DonVi=N'" + donvi + "', DienThoai=N'" + sdt + "', Email=N'" + email + "', ChucVu=N'" + chucvu + "' where MaTacGia=N'" + matg + "'";
            da.ExecuteNonQuery(sql);
        }

        public void XoaTacGia(string ml)
        {
            string sql = "delete tbTacGia where MaTacGia=N'" + ml + "'";
            da.ExecuteNonQuery(sql);
        }


        public DataTable TimKiemTacGia(string dk)
        {
            string sql = "select * from tbTacGia where MaTacGia like N'%" + dk + "%' or TenTacGia like N'%" + dk + "%' or DienThoai like N'%" + dk + "%' or ChucVu like N'%" + dk + "%' or DonVi like N'%" + dk + "%' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

    }
    

    public class XemDeTai
    {
        Data da = new Data(); 
        public DataTable HienThiXemDeTai()
        {
            string sql;
            sql = "Select * from View_2"; 
            DataTable dt = new DataTable(); 
            dt = da.GetTable(sql); 
            return dt;
        }

        

        public DataTable TimKiemXemDeTai(string dk) // tìm kiếm theo điều kiện dk.
        {
            
            string sql = "select * from View_2 where MaDeTai like N'%" + dk + "%' or TenDeTai like N'%" + dk + "%' or DienThoai like N'%" + dk + "%' or TenLoai like N'%" + dk + "%' or ChucVu like N'%" + dk + "%'  or TenTacGia like N'%" + dk + "%' or DonVi like N'%" + dk + "%'";
            DataTable dt = new DataTable(); 
            dt = da.GetTable(sql);
            return dt;
        }
       

    }
    public class XemBaiBao
    {
        Data da = new Data();
        public DataTable HienThiXemBaiBao()
        {
            string sql;
            sql = "Select * from View_3";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }



        public DataTable TimKiemXemBaiBao(string dk) // tìm kiếm theo điều kiện dk.
        {

            string sql = "select * from View_3 where MaBaiBao like N'%" + dk + "%' or TenBaiBao like N'%" + dk + "%' or DienThoai like N'%" + dk + "%' or TenLoaibaiBao like N'%" + dk + "%' or ChucVu like N'%" + dk + "%'  or TenTacGia like N'%" + dk + "%' or DonVi like N'%" + dk + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }


    }

    public class DiemRL
    {
        Data da = new Data(); 
        public DataTable HienThiDiem()
        {
            string sql;
            sql = "Select * from tblDiem"; 
            DataTable dt = new DataTable(); 
            dt = da.GetTable(sql); 
            return dt;
        }
        public DataTable HienThiDiemHocVien(string dk)//Hien thi diem học viên theo mã sinh viê
        {
            string sql;
            sql = "Select Thang, Nam, Diem ,GhiChu from tblDiem where MaSV like N'%" + dk + "%' Order by MaSV DESC";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable HienThiDiemChonLoc(string dk,string thang,string nam)//Hien thi diem học viên theo mã sinh viê
        {
            string sql;
            sql = "Select Thang, Nam, Diem ,GhiChu from tblDiem where MaSV like N'%" + dk + "%' AND Thang = '" + thang + "' AND Nam = '" + nam + "'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
      /*  public DataTable HienThiGhiChu(string dk)
        {
            string sql;
            sql = "Select GhiChu from tblDiem where MaSV like N'%" + dk + "%' Order by MaSV DESC";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        */
        public int InsertDiem(string mtn, string masv, string diem, string thang, string nam, string ghichu)
        {
            DataTable dt = kiemtra(mtn);
            if (dt.Rows.Count == 0)
            {
                string sql = "insert into tblDiem (MaThangNam, MaSV, Diem, Thang, Nam, GhiChu) values('" + mtn + "',N'" + masv + "', N'" + diem + "', N'" + thang + "', N'" + nam + "', N'" + ghichu + "')";
                da.ExecuteNonQuery(sql);
                return 1;
            }
            else return 0;
        }

        public void UpdateDiem(string mtn, string masv, string diem, string thang, string nam, string ghichu)
        {
            string sql = "update tblDiem set MaSV=N'" + masv + "', Diem=N'" + diem + "', Thang=N'" + thang + "' , Nam=N'" + nam + "' , GhiChu=N'" + ghichu + "' where MaThangNam=N'" + mtn + "'";
            da.ExecuteNonQuery(sql);
        }

        public void DeleteDiem(string mtn)
        {
            string sql = "delete tblDiem where MaThangNam=N'" + mtn + "'";
            da.ExecuteNonQuery(sql);
        }

        public DataTable kiemtra(string ma_tn)
        {
            string sql = "select * from tblDiem where MaThangNam like N'%" + ma_tn + "%'";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
    public class Join
    {
        Data da = new Data(); 
        public DataTable HienThiTong(string thang,string nam,string dk)
        {
            string sql;
            sql = "SELECT tblHocVien.MaSV,Ho, Ten, MaLop,Diem,Thang,Nam,GhiChu FROM tblHocVien LEFT JOIN tblDiem ON tblHocVien.MaSV = tblDiem.MaSV AND Thang = '" + thang + "' AND Nam = '" + nam + "'WHERE tblHocVien.MaSV like N'%"+dk+"%' Order by MaSV ASC;";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }

    public class DangNhapTaiKhoan
    {
        Data da = new Data();
        public DataTable Hienthitaikhoan()
        {
            string sql = "Select * from tblDangNhap";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
        public DataTable KTDangnhap(string ten, string pass)
        {
            string sql = "SELECT COUNT(*) AS ketqua FROM tblDangNhap WHERE(TenDangnhap = N'" + ten + "') AND(MatKhau = N'" + pass + "')";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;

        }

        public void ThemTaiKhoan(string tk, string mk, int quyen)
        {
            
                string sql = "insert into tblDangNhap (TenDangNhap, MatKhau, QuyenDangNhap) values(N'" + tk + "',N'" + mk + "',N'" + quyen + "')";
                da.ExecuteNonQuery(sql);
            
        }

        public void SuaTaiKhoan(string tk, string mk, int quyen)
        {
            string sql = "update tblDangNhap set MatKhau=N'" + mk  + "', QuyenDangNhap=N'" + quyen  + "' where TenDangNhap=N'" + tk + "'";
            da.ExecuteNonQuery(sql);
        }

        public void XoaTaiKhoan(string tk)
        {
            string sql = "delete tblDangNhap where TenDangNhap=N'" + tk + "'";
            da.ExecuteNonQuery(sql);
        }
        public DataTable TimKiemTK(string ma_tn)
        {
            string sql = "select * from tblDangNhap where TenDangNhap like N'%" + ma_tn + "%' ";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }

    }

}

