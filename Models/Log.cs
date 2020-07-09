using System;

namespace CitasEps.Models
{
    class Log : IModel
    {
        private readonly int id;
        private readonly int idOfficials;
        private readonly DateTime dateTime;
        private readonly string description;

        public Log(int id, int idOfficials, DateTime dateTime, string description)
        {
            this.id = id;
            this.idOfficials = idOfficials;
            this.dateTime = dateTime;
            this.description = description;
        }

        public object GetAll() => this;

        public object GetAttribute(string attribute)
        {
            object attributeReturn = null;
            switch (attribute)
            {
                case "id":
                    attributeReturn = id;
                    break;
                case "id_officials":
                    attributeReturn = idOfficials;
                    break;
                case "date_time":
                    attributeReturn = dateTime;
                    break;
                case "description":
                    attributeReturn = description;
                    break;
            }
            return attributeReturn;
        }
    }
}
