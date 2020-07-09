using System;

namespace CitasEps.Models
{
    class Log : IModel
    {
        private readonly int id;
        private readonly int id_officials;
        private readonly DateTime date_time;
        private readonly string description;

        public Log(int id, int id_officials, DateTime date_time, string description)
        {
            this.id = id;
            this.id_officials = id_officials;
            this.date_time = date_time;
            this.description = description;
        }

        public object GetAll()
        {
            return this;
        }

        public object GetAttribute(string attribute)
        {
            object attributeReturn = null;
            switch (attribute)
            {
                case "id":
                    attributeReturn = id;
                    break;
                case "id_officials":
                    attributeReturn = id_officials;
                    break;
                case "date_time":
                    attributeReturn = date_time;
                    break;
                case "description":
                    attributeReturn = description;
                    break;
            }
            return attributeReturn;
        }
    }
}
