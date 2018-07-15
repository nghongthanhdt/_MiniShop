using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH.InSTTKB
{
    public class STT
    {
        public int Nut;
        public string TenNut;
        public int SoHienTai;
        public DateTime NgayGioIn;
    }
    public class ConfigBatSoTT
    {
        public string TenBenhVien;
        public string TenMayIn;
        public DateTime ThoiDiemReset;
        public List<STT> listSTT;
        public int ThoiGianCho;
        public ConfigBatSoTT()
        {
            TenBenhVien = "";
            TenMayIn = "";
            ThoiDiemReset = DateTime.MinValue;
            
            listSTT = new List<STT>();
            STT stt;
            for (int i = 1; i<=10; i++)
            {
                stt = new STT();
                stt.Nut = i;
                stt.TenNut = "";
                stt.SoHienTai = 0;
                stt.NgayGioIn = DateTime.MinValue;
                listSTT.Add(stt);                    
            }            
        }
    }


}
