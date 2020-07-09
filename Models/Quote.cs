using System;

namespace CitasEps.Models
{
    class Quote : IModel
    {
        private readonly int id;
        private readonly int idUsers;
        private readonly int idOfficials;
        private readonly int idMedia;
        private readonly DateTime dateTime;

        public Quote(int id, int idUsers, int idOfficials, int idMedia, DateTime dateTime)
        {
            this.id = id;
            this.idUsers = idUsers;
            this.idOfficials = idOfficials;
            this.dateTime = dateTime;
            this.idMedia = idMedia;
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
                case "id_users":
                    attributeReturn = idUsers;
                    break;
                case "id_officials":
                    attributeReturn = idOfficials;
                    break;
                case "id_media":
                    attributeReturn = idMedia;
                    break;
                case "date_time":
                    attributeReturn = dateTime;
                    break;
            }
            return attributeReturn;
        }
    }
}
