using CitasEps.Constants;
using CitasEps.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;


namespace CitasEps.Controllers
{
    class LogsController : Controller
    {
        public LogsController() : base("logs") { }

        public List<Log> GetAll()
        {
            MySqlDataReader reader = GetAllFromEntity();
            List<Log> data = LogListGenerate(reader);
            Close();
            return data;
        }

        public int CreateLog(string description)
        {
            Log log = new Log(0, CurrentUser.currentUserId, DateTime.Now, description);

            string[] attributes = { "id_officials:int", "date_time:date", "description:string" };

            int id = CreateEntity(log, attributes);
            Close();

            return id;
        }

        public List<Log> LogListGenerate(MySqlDataReader readerData)
        {
            List<Log> logList = new List<Log>();
            while (readerData.Read())
            {
                int id = int.Parse(readerData.GetString(0));
       
                DateTime dateTime = DateTime.Parse(readerData.GetString(1));
                string description = readerData.GetString(2);
                int idOfficials = int.Parse(readerData.GetString(3));
                logList.Add(new Log(id, idOfficials, dateTime, description));
            }
            return logList;
        }
    }
}

