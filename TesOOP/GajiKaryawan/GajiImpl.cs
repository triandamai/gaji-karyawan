using System;
namespace TesOOP.GajiKaryawan
{
    public class GajiImpl : Gaji
    {
        private int _gajiPokok = 0;
        private int _tunjanganIstri = 0;
        private int _tunjanganAnak = 0;

        private Employe _karyawan = new();

        public override void calculate(Employe employe)
        {
            _karyawan = employe;
            Console.Write("=== MENGHITUNG GAJI KARYAWAN ===\n");

            Console.Write("MENGHITUNG GAJI POKOK...\n");
            hitungGajiPokok();
            Console.Write("MENGHITUNG TUNJANGAN...\n");
            hitungTunjanganIstri();
            hitungTunganAnak();
            Console.Write("=== HASIL ===\n");
            showHasil();


        }

        private void showHasil() {


            Console.WriteLine("Nama Karyawan : " + this._karyawan.nama);

            Console.WriteLine("Gaji Pokok : Rp." + format( this._gajiPokok));

            if (this._karyawan.sudahMenikah)
            {
                Console.WriteLine("Tunjangan Istri(SUDAH MENIKAH) : Rp." + format(this._tunjanganIstri));
            }
            else {
                Console.WriteLine("Tunjangan Istri(BELUM MENIKAH) : Rp." + format(this._tunjanganIstri));
            }

            Console.WriteLine("Tunjangan Anak(" + this._karyawan.jumlahAnak + "): Rp." + format(this._tunjanganAnak));

            int total = (this._gajiPokok + this._tunjanganAnak + this._tunjanganIstri);

            Console.WriteLine("TOTAL PENDAPATAN : Rp." + format(total));
        }

        private void hitungGajiPokok()
        {
            if (this._karyawan.golongan == "A") {
                _gajiPokok = 1_200_000;

            }

            if (this._karyawan.golongan == "B") {
                _gajiPokok = 1_600_000;
            }

            if (this._karyawan.golongan == "C") {
                _gajiPokok = 2_300_000;
            }
        }

        private void hitungTunganAnak()
        {
            if (_karyawan.sudahMenikah) {
                if (_karyawan.jumlahAnak <= 2)
                {
                    if (this._karyawan.golongan == "A")
                    {
                        _tunjanganAnak = 150_000 * this._karyawan.jumlahAnak;

                    }

                    if (this._karyawan.golongan == "B")
                    {
                        _tunjanganAnak = 300_000 * this._karyawan.jumlahAnak;
                    }

                    if (this._karyawan.golongan == "C")
                    {
                        _tunjanganAnak = 350_000 * this._karyawan.jumlahAnak;
                    }

                }

                if (_karyawan.jumlahAnak > 2)
                {
                    if (this._karyawan.golongan == "A")
                    {
                        _tunjanganAnak = 150_000 * 2;

                    }

                    if (this._karyawan.golongan == "B")
                    {
                        _tunjanganAnak = 300_000 * 2;
                    }

                    if (this._karyawan.golongan == "C")
                    {
                        _tunjanganAnak = 350_000 * 2;
                    }
                }

            }
        }

        private void hitungTunjanganIstri()
        {
            if (_karyawan.sudahMenikah) {
                if (this._karyawan.golongan == "A")
                {
                    _tunjanganIstri = 150_000;

                }

                if (this._karyawan.golongan == "B")
                {
                    _tunjanganIstri = 300_000;
                }

                if (this._karyawan.golongan == "C")
                {
                    _tunjanganIstri = 350_000;
                }
            }
        }

        private string format(int i) {
            return String.Format("{0:#,0.00}",i);
        }
    }

    


}

