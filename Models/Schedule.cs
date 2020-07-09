using System;

namespace CitasEps.Models
{
    class Schedule : IModel
    {
        private readonly int id;
        private readonly int id_officials;
        private readonly DateTime init_hour;
        private readonly DateTime end_hour;

        public Schedule(int id, int id_officials, DateTime init_hour, DateTime end_hour)
        {
            this.id = id;
            this.id_officials = id_officials;
            this.init_hour = init_hour;
            this.end_hour = end_hour;
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
                case "init_hour":
                    attributeReturn = init_hour;
                    break;
                case "end_hour":
                    attributeReturn = end_hour;
                    break;
            }
            return attributeReturn;
        }
    }
}
