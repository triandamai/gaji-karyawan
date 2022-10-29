using System;
namespace TesOOP.GajiKaryawan
{
    public struct Employe
    {
        private string _nama = "";
        private string _golongan = "A";
        private bool _sudahMenikah = false;
        private int _jumlahAnak = 0;

        public Employe()
        {
        }

        public string nama
        {
            set { _nama = value; }
            get { return _nama; }
        }

        public string golongan
        {
            set { _golongan = value; }
            get { return _golongan; }
        }

        public bool sudahMenikah
        {
            set { _sudahMenikah = value; }
            get { return _sudahMenikah; }
        }

        public int jumlahAnak
        {
            set { _jumlahAnak = value; }
            get { return _jumlahAnak; }
        }
    }
}

