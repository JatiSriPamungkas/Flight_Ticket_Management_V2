using Flight_Ticket_Management.Model.Context;
using Flight_Ticket_Management_V2.Model.Entity;
using Flight_Ticket_Management_V2.Model.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Ticket_Management_V2.Controller
{
    public class ScheduleController
    {
        private ScheduleRepository _repository;

        public List<ScheduleEntity> ReadAll()
        {
            List<ScheduleEntity> listOfSchedule = new List<ScheduleEntity>();
            using (DbContext context = new DbContext())
            {
                _repository = new ScheduleRepository(context);
                listOfSchedule = _repository.ReadAll();
            }
            return listOfSchedule;
        }

        public List<ScheduleEntity> ReadByOriginAndDestination(string asal, string tujuan)
        {
            // membuat objek collection
            List<ScheduleEntity> listOfSchedule = new List<ScheduleEntity>();
            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new ScheduleRepository(context);
                // panggil method GetByNama yang ada di dalam class repository
                listOfSchedule = _repository.ReadByAsalTujuan(asal, tujuan);
            }
            return listOfSchedule;
        }
    }
}
