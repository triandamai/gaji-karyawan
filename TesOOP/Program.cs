// See https://aka.ms/new-console-template for more information
using TesOOP.GajiKaryawan;

Console.WriteLine("=== GAJI KARYWAAN ===");

//inisiasi objek awal
KaryawanImpl karyawan = new();
GajiImpl gaji = new();

//kumpulkan data
karyawan.collectDataKaryawan();

//hitung gaji
gaji.calculate(karyawan.getEmployee());

