// See https://aka.ms/new-console-template for more information
using TesOOP.GajiKaryawan;

Console.WriteLine("=== GAJI KARYWAAN ===");

KaryawanImpl karyawan = new();
GajiImpl gaji = new();

karyawan.collectDataKaryawan();

gaji.calculate(karyawan.getEmployee());

