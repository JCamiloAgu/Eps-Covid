namespace CitasEps.Models
{
    class UsersMedia : IModel
    {
        private readonly int idUsers;
        private readonly int idMedia;

        public UsersMedia(int idUsers, int idMedia)
        {
            this.idUsers = idUsers;
            this.idMedia = idMedia;
        }

        public object GetAll() => this;


        public object GetAttribute(string attribute)
        {
            object attributeReturn = null;
            switch (attribute)
            {
                case "id_media":
                    attributeReturn = idMedia;
                    break;
                case "id_users":
                    attributeReturn = idUsers;
                    break;
            }
            return attributeReturn;
        }
    }
}
