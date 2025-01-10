using Flight_Ticket_Management.Model.Context;
using Flight_Ticket_Management_V2.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management_V2.Model.Repository
{
    public class ScheduleRepository
    {
        private SQLiteConnection _conn;

        public ScheduleRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public List<ScheduleEntity> ReadAll()
        {
            List<ScheduleEntity> lisfOfSchedule = new List<ScheduleEntity>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"SELECT p.maskapai, p.jenis_pesawat, j.waktu_berangkat, j.waktu_sampai, r.harga, r.asal,r.tujuan FROM tiket t JOIN pesawat p ON t.kd_pesawat = p.kd_pesawat JOIN jadwal j ON t.kd_jadwal = j.kd_jadwal JOIN rute r ON t.kd_rute = r.kd_rute ORDER BY maskapai;";
                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            ScheduleEntity schedule = new ScheduleEntity();
                            // proses konversi dari row result set ke object
                            schedule.Airline = dtr["maskapai"].ToString();
                            schedule.AircraftType = dtr["jenis_pesawat"].ToString();
                            schedule.DepartureTime = dtr["waktu_berangkat"].ToString();
                            schedule.ArrivalTime = dtr["waktu_sampai"].ToString();
                            schedule.Price = int.TryParse(dtr["harga"].ToString(), out int price) ? schedule.Price = price : schedule.Price = 0;
                            schedule.Origin = dtr["asal"].ToString();
                            schedule.Destination = dtr["tujuan"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            lisfOfSchedule.Add(schedule);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print($"ReadAll error: {ex.Message}");
            }

            return lisfOfSchedule;
        }

        public List<ScheduleEntity> ReadByAsalTujuan(string asal, string tujuan)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<ScheduleEntity> lisfOfSchedule = new List<ScheduleEntity>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"
                    SELECT p.maskapai, 
	                    p.jenis_pesawat, 
	                    j.waktu_berangkat, 
	                    j.waktu_sampai, 
	                    r.harga, r.asal, 
	                    r.tujuan 
                    FROM 
	                    tiket t 
                    JOIN pesawat p ON t.kd_pesawat = p.kd_pesawat 
                    JOIN jadwal j ON t.kd_jadwal = j.kd_jadwal 
                    JOIN rute r ON t.kd_rute = r.kd_rute 
                    WHERE asal LIKE @asal AND tujuan LIKE @tujuan
                    ORDER BY maskapai;
                ";
                // membuat objek command menggunakan blok using
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@asal", string.Format("%{0}%", asal));
                    cmd.Parameters.AddWithValue("@tujuan", string.Format("%{0}%", tujuan));
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            ScheduleEntity schedule = new ScheduleEntity();
                            // proses konversi dari row result set ke object
                            schedule.Airline = dtr["maskapai"].ToString();
                            schedule.AircraftType = dtr["jenis_pesawat"].ToString();
                            schedule.DepartureTime = dtr["waktu_berangkat"].ToString();
                            schedule.ArrivalTime = dtr["waktu_sampai"].ToString();
                            schedule.Price = int.TryParse(dtr["harga"].ToString(), out int harga) ? schedule.Price = harga : schedule.Price = 0;
                            schedule.Origin = dtr["asal"].ToString();
                            schedule.Destination = dtr["tujuan"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            lisfOfSchedule.Add(schedule);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print($"ReadByNama error: {ex.Message}");
            }
            return lisfOfSchedule;
        }
    }
}
