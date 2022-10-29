using System;
namespace TesOOP.GajiKaryawan
{
    public class KaryawanImpl: Karyawan
    {
        private Employe employe;

        public override void collectDataKaryawan()
        {

            employe = new();

            Console.Write("Masukkan nama pegawai = ");
            employe.nama = Console.ReadLine();

            Console.WriteLine("");

            bool golonganFAIL = true;
            while (golonganFAIL)
            {
                Console.Write("Masukkan Golongan(A,B,C) =");
                employe.golongan = Console.ReadLine();

                if (employe.golongan == "A" || employe.golongan == "B" || employe.golongan == "C") {
                    golonganFAIL = false;
                }
            }

            Console.WriteLine("");

            bool menikahFAIL = true;
            while (menikahFAIL) {
                Console.Write("Sudah Menikah(Y/N) ? =");
                string sudah = Console.ReadLine();
                if(sudah == "Y" || sudah == "N") {
                    employe.sudahMenikah = sudah == "Y" ? true : false;

                    menikahFAIL = false;
                }
                
            }

            Console.WriteLine("");

            if (employe.sudahMenikah)
            {
                Console.Write("Jumlah Anak(1,2,3..dst) =");
                employe.jumlahAnak = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");
        }

        public override Employe getEmployee()
        {
            return this.employe;
        }
    }
}

