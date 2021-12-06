using System;

public class Program
{
	public static void Main()
	{
		int Dataa = 10000000;
		int Status = 0;
		string[,] DataLengkap = new string[Dataa, 6];
		Dataa = 0;
		while (Status == 0)
		{
			Console.Write("Berapa Data = ");
			int Data = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine();
			Dataa = Dataa + Data;
			for (int Perulangan = Dataa - Data + 1; Perulangan <= Dataa; Perulangan++)
			{
				Console.WriteLine("Data ke-" + Perulangan);
				Console.Write(String.Format("{0,-20} {1, 0}", "NIM", " : "));
				DataLengkap[Perulangan - 1, 0] = Console.ReadLine();
				for (int perulangan = 0; perulangan <= Perulangan; perulangan++)
				{
					if (Perulangan - 1 != perulangan)
					{
						while (DataLengkap[Perulangan - 1, 0] == DataLengkap[perulangan, 0])
						{
							Console.WriteLine("NIM SUDAH ADA, MASUKKAN NIM LAIN !!!");
							Console.Write(String.Format("{0,-20} {1, 0}", "NIM", " : "));
							DataLengkap[Perulangan - 1, 0] = Console.ReadLine();
						}
					}
				}

				Console.Write(String.Format("{0,-20} {1, 0}", "NAMA", " : "));
				DataLengkap[Perulangan - 1, 1] = Console.ReadLine();
				Console.Write(String.Format("{0,-20} {1, 0}", "JENIS KELAMIN", " : "));
				DataLengkap[Perulangan - 1, 2] = Console.ReadLine();
				Console.Write(String.Format("{0,-20} {1, 0}", "TAHUN MASUK", " : "));
				DataLengkap[Perulangan - 1, 3] = Console.ReadLine();
				Console.Write(String.Format("{0,-20} {1, 0}", "PROGRAM STUDI", " : "));
				DataLengkap[Perulangan - 1, 4] = Console.ReadLine();
				Console.Write(String.Format("{0,-20} {1, 0}", "KELAS", " : "));
				DataLengkap[Perulangan - 1, 5] = Console.ReadLine();
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("PRINT HASIL? (y/n) . . . ");
			string Print = Console.ReadLine();
			while (Print != "y" && Print != "n")
			{
				Console.WriteLine("PRINT HASIL? (y/n) . . . ");
				string Printt = Console.ReadLine();
				Print = Printt;
			}

			if (Print == "y")
			{
				Console.Clear();
				Console.WriteLine(String.Format("{0,-5} {1, -10} {2,-25} {3, -15} {4,-15} {5, -15}", "NO", "NIM", "NAMA", "JENIS KELAMIN", "TAHUN MASUK", "PROGRAM STUDI", "KELAS"));
				for (int Perulangan = 0; Perulangan < Dataa; Perulangan++)
				{
					Console.WriteLine(String.Format("{0,-5} {1, -10} {2,-25} {3, -15} {4,-15} {5, -15}", (Perulangan + 1), DataLengkap[Perulangan, 0], DataLengkap[Perulangan, 1].ToUpper(), DataLengkap[Perulangan, 2].ToUpper(), DataLengkap[Perulangan, 3], DataLengkap[Perulangan, 4].ToUpper(), DataLengkap[Perulangan, 5].ToUpper()));
				}

				Console.WriteLine();
				Console.Write("Tambah Data? (y/n) ...");
				string TambahData = Console.ReadLine();
				while (TambahData != "y" && TambahData != "n")
				{
					Console.WriteLine("Tambah Data? (y/n) . . . ");
					string TambahDataa = Console.ReadLine();
					TambahData = TambahDataa;
				}

				if (TambahData == "y")
				{
					Status = 0;
					Console.Clear();
				}
				else
				{
					Status = 1;
				}
			}
			else if (Print == "n")
			{
				Status = 1;
			}
		}
	}
}
