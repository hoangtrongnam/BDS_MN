using BDS_MN.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BDS_MN.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]

    public class DangTinController : ApiController
    {  
        //public DangTinController(IDataContext dataContext, IBIL110050S01DataAccess dataAccess)
        //    : base(dataContext)
        //{
        //    _dataAccess = dataAccess;
        //    GetMultiLang();
        //}

        /// <summary>
        /// Data Source=CPP00136655C\SQLEXPRESS;Initial Catalog=BDS_MN;Integrated Security=True
        /// </summary>
        /// 
        //DangTin[] dangTins = new DangTin[]
        //  {
        //      new DangTin {ID = 0, HinhThucDang = "edrgsdg", LoaiTin = "ksldfg", LoaiTaiSan = "lsdkf", TinhThanh = "jsdfhlsda", MaNen = "ksjdhfl", TenDuong = "kjsdfhsad", TenDuAn = "kjfdkdsf", GiaBan = 1223123, MatTien = 5, Hau = 6, ChieuDai = 18, TinhTrangPhapLy = "dat dsad"},
        //      new DangTin {ID = 0, HinhThucDang = "edrgsdg", LoaiTin = "ksldfg", LoaiTaiSan = "lsdkf", TinhThanh = "jsdfhlsda", MaNen = "ksjdhfl", TenDuong = "kjsdfhsad", TenDuAn = "kjfdkdsf", GiaBan = 1223123, MatTien = 5, Hau = 6, ChieuDai = 18, TinhTrangPhapLy = "dat dsad"},
        //      new DangTin {ID = 0, HinhThucDang = "edrgsdg", LoaiTin = "ksldfg", LoaiTaiSan = "lsdkf", TinhThanh = "jsdfhlsda", MaNen = "ksjdhfl", TenDuong = "kjsdfhsad", TenDuAn = "kjfdkdsf", GiaBan = 1223123, MatTien = 5, Hau = 6, ChieuDai = 18, TinhTrangPhapLy = "dat dsad"},
        //      new DangTin {ID = 0, HinhThucDang = "edrgsdg", LoaiTin = "ksldfg", LoaiTaiSan = "lsdkf", TinhThanh = "jsdfhlsda", MaNen = "ksjdhfl", TenDuong = "kjsdfhsad", TenDuAn = "kjfdkdsf", GiaBan = 1223123, MatTien = 5, Hau = 6, ChieuDai = 18, TinhTrangPhapLy = "dat dsad"},
        //      new DangTin {ID = 0, HinhThucDang = "edrgsdg", LoaiTin = "ksldfg", LoaiTaiSan = "lsdkf", TinhThanh = "jsdfhlsda", MaNen = "ksjdhfl", TenDuong = "kjsdfhsad", TenDuAn = "kjfdkdsf", GiaBan = 1223123, MatTien = 5, Hau = 6, ChieuDai = 18, TinhTrangPhapLy = "dat dsad"}
        //  };
        /// <summary>
        /// get connectionstring How to get Connection String from App.Config in C# 
        /// </summary>
        /// <returns></returns>


        public ObservableCollection<DangTin> GetAllDangTin()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            const string GetDangTinsQuery = "SELECT * FROM dbo.DangTin";

            var dangTins = new ObservableCollection<DangTin>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    if (conn.State == System.Data.ConnectionState.Open)
                    {
                        using (SqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText = GetDangTinsQuery;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    var dangTin = new DangTin();
                                    dangTin.ID = reader.GetInt32(0);
                                    dangTin.HinhThucDang = reader.GetString(1);
                                    dangTin.LoaiTin = reader.GetString(2);
                                    dangTin.LoaiTaiSan = reader.GetString(3);
                                    dangTin.TinhThanh = reader.GetString(4);
                                    dangTin.MaNen = reader.GetString(5);
                                    dangTin.TenDuong = reader.GetString(6);
                                    dangTin.TenDuAn = reader.GetString(7);
                                    dangTin.GiaBan = reader.GetInt32(8);
                                    dangTin.MatTien = reader.GetInt32(9);
                                    dangTin.Hau = reader.GetInt32(10);
                                    dangTin.ChieuDai = reader.GetInt32(11);
                                    dangTin.TinhTrangPhapLy= reader.GetString(12);
                                    dangTin.HinhAnh = reader.GetString(13);
                                    dangTins.Add(dangTin);
                                }
                            }
                        }
                    }
                }
                return dangTins;
            }
            catch (Exception eSql)
            {
                Debug.WriteLine("Exception: " + eSql.Message);
            }
            return null;
        }

        //public IEnumerable<DangTin> GetAllDangTin()
        //{

        //    //var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;



        //    //string queryString = "SELECT * FROM dbo.DangTin;";
        //    //using (var connection = new SqlConnection(connectionString))
        //    //{
        //    //    var command = new SqlCommand(queryString, connection);
        //    //    connection.Open();
        //    //    using (var reader = command.ExecuteReader())
        //    //    {
        //    //    }
        //    //}


        //    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        //    conn.Open();
        //    string checkuser = "SELECT * FROM dbo.DangTin";
        //    SqlCommand cmd = new SqlCommand(checkuser, conn);
        //    string temp =cmd.ExecuteScalar().ToString();

            

        //    return dangTins;

        //    conn.Close();

        //}

        //public IHttpActionResult GetDangTin(int id)
        //{
        //    var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //    var dangTin = dangTins.FirstOrDefault((p) => p.ID == id);
        //    if (dangTin == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(dangTin);
        //}
    }
}
