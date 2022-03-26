using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas2_091
{
    class Program
    {
        public void CreateTable()
        {

            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("create table Staff (Id_Staff char(5) primary key, NamaStaff varchar(50), AlamatStaff varchar(100), Umur int,Tanggal_Masuk_Kerja date)" +
                    "create table Roti (Id_Roti char(5) primary key, NamaRoti varchar(50), Varian varchar(50), Jenis varchar(10), Stok int)" +
                    "create table Customer (Id_Cust char(5) primary key, NamaCust varchar(50), AlamatCust varchar(100))" + 
                    "create table Penjualan(Id_Jual char(5) primary key,Id_Staff char(5) foreign key references Staff(Id_Staff), Id_Roti char(5) foreign key references Roti(Id_Roti), Tanggal_Penjualan date, Total_Harga money)" +
                    "create table Pembelian (Id_Beli char(5) primary key, Id_Cust char(5) foreign key references Customer(Id_Cust), Id_Roti char(5) foreign key references Roti(Id_Roti), Jumlah_Beli int, Tanggal_Beli datetime, Total_Harga money)", con);
                cm.ExecuteNonQuery(); 

                Console.WriteLine("Tabel Berhasil Dibuat!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sepertinya querymu ada yang salah!!" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }

        }

        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=DESKTOP-MSE8SEM;database=PetaBakery;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Staff values ('S-101','Arvian Gunandar','Jalan Ahmad Dahlan',23,'2021-12-04')" +
"insert into Staff values('S-102', 'Lova Kurnawan', 'Jalan Mudah Bersama', 20, '2021-12-04')" +
"insert into Staff values('S-103', 'Bulan Anugerah', 'Jalan Kaki Saja', 23, '2021-12-04')" + 
"insert into Staff values('S-104', 'Siva Alfiana', 'Jalan Jalan Kemana Yuk', 22, '2021-12-04')" +
"insert into Staff values('S-105', 'Afwan Kasih', 'Jalan Bersama Kamu', 21, '2021-12-04')" +
"insert into Roti values('R-001', 'Donat Bolong', 'Strawberry Kacang', 'Basah', 20)" +
"insert into Roti values('R-002', 'Donat Bolong', 'Coklat Keju', 'Basah', 20)" + 
"insert into Roti values('R-003', 'Donat Isi', 'Strawberry Kacang', 'Basah', 20)" +
"insert into Roti values('R-004', 'Donat Isi', 'Coklat Keju', 'Basah', 20)" +
"insert into Roti values('R-005', 'Donat Panjang', 'Strawberry Kacang', 'Basah', 20)" +
"insert into Customer values('C-897', 'Yadi Hartanti', 'Jalan Kenanga')"+
"insert into Customer values('C-829', 'Ridwan Kamaludin', 'Jalan Senandi')"+
"insert into Customer values('C-889', 'Ratu Helmina', 'Jalan Kerangka')"+
"insert into Customer values('C-878', 'Fika Gunawan', 'Jalan Pahlawan')"+
"insert into Customer values('C-809', 'Siska Kohl', 'Jalan Rambutan')"+
"insert into Penjualan values('J-910', 'S-102', 'R-002', '2022-01-19', 750000)"+
"insert into Penjualan values('J-911', 'S-101', 'R-002', '2022-01-23', 800000)"+
"insert into Penjualan values('J-912', 'S-102', 'R-001', '2022-01-12', 70000)"+
"insert into Penjualan values('J-913', 'S-104', 'R-004', '2022-01-19', 50000)"+
"insert into Penjualan values('J-914', 'S-101', 'R-002', '2022-01-25', 75000)"+
"insert into Pembelian values('B-910', 'C-889', 'R-002', 20, '2022-01-19 08:23:11', 750000)"+
"insert into Pembelian values('B-911', 'C-878', 'R-002', 20, '2022-01-23 09:34:09', 800000)"+
"insert into Pembelian values('B-912', 'C-897', 'R-001', 20, '2022-01-12 12:31:56', 70000)"+
"insert into Pembelian values('B-913', 'C-809', 'R-004', 20, '2022-01-19 11:23:38', 50000)"+
"insert into Pembelian values('B-914', 'C-829', 'R-002', 20, '2022-01-25 12:20:44', 75000)", con);
                    cm.ExecuteNonQuery();


                Console.WriteLine("Sukses Memasukkan Data ke Tabel");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Sepertinya Querymu Salah!!" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            new Program().CreateTable();
            new Program().InsertData();
        }
    }

}
