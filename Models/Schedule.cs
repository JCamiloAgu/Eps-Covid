using System;

namespace CitasEps.Models
{
    class Schedule : IModel
    {
        private readonly int id;
        private readonly int idOfficials;
        private readonly DateTime initHour;
        private readonly DateTime endHour;

        public Schedule(int id, int idOfficials, DateTime initHour, DateTime endHour)
        {
            this.id = id;
            this.idOfficials = idOfficials;
            this.initHour = initHour;
            this.endHour = endHour;
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
                case "init_hour":
                    attributeReturn = initHour;
                    break;
                case "end_hour":
                    attributeReturn = endHour;
                    break;
            }
            return attributeReturn;
        }
    }
}
