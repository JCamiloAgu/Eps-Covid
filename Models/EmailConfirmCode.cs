namespace CitasEps.Models
{
    class EmailConfirmCode : IModel
    {

        private readonly int id;
        private readonly int idUsers;
        private readonly string code;
        private readonly bool status;

        public EmailConfirmCode(int id, int idUsers, string code, bool status)
        {
            this.id = id;
            this.idUsers = idUsers;
            this.code = code;
            this.status = status;
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
                case "code":
                    attributeReturn = code;
                    break;
                case "status":
                    attributeReturn = status;
                    break;
            }
            return attributeReturn;
        }
    }
}
