using CitasEps.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace CitasEps.Controllers
{
    class SchedulesController : Controller
    {
        public SchedulesController() : base("schedules") { }

        public List<Schedule> GetAllByOfficialId(string officialId)
        {
            MySqlDataReader reader = GetFromEntity("id_officials", officialId, 999);
            List<Schedule> data = ScheduleListGenerate(reader);
            Close();
            return data;
        }

        public Schedule GetById(string value)
        {
            MySqlDataReader reader = GetFromEntity("id", value);
            List<Schedule> data = ScheduleListGenerate(reader);
            Close();
            return data.Count > 0 ? data[0] : null;
        }

        public int CreateSchedule(Schedule schedule)
        {
            string[] attributes = { "init_hour:date", "end_hour:date", "id_officials:int" };

            int id = CreateEntity(schedule, attributes);
            Close();

            return id;
        }

        public bool UpdateSchedule(Schedule schedule)
        {
            string[] attributes = { "init_hour:date", "end_hour:date", "id_officials:int" };

            bool isOk = UpdateEntity(schedule, "id", schedule.GetAttribute("id").ToString(), attributes);
            Close();

            return isOk;
        }

        public bool DeleteSchedule(string scheduleId)
        {
            bool isOk = DeleteEntity("id", scheduleId);
            Close();

            return isOk;
        }

        public List<Schedule> ScheduleListGenerate(MySqlDataReader readerData)
        {
            List<Schedule> scheduleList = new List<Schedule>();
            while (readerData.Read())
            {
                int id = readerData.GetInt32(0);
                DateTime initHour = DateTime.Parse(readerData.GetString(1));
                DateTime endHour =  DateTime.Parse(readerData.GetString(2));
                int idOfficial = readerData.GetInt32(3);

                scheduleList.Add(new Schedule(id, idOfficial, initHour, endHour));
            }
            return scheduleList;
        }
    }
}
