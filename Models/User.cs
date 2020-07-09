namespace CitasEps.Models
{
    class User : IModel
    {
        private readonly int id;
        private readonly int idAffiliates;
        private readonly string phone;
        private readonly string address;
        private readonly string email;
        private string password;

        public User(int id, int idAffiliates, string phone, string address, string email, string password)
        {
            this.id = id;
            this.idAffiliates = idAffiliates;
            this.phone = phone;
            this.address = address;
            this.email = email;
            this.password = password;
        }

        public object GetAll() => this;

        public void SetPassword(string password) => this.password = password;

        public object GetAttribute(string attribute)
        {
            object attributeReturn = null;
            switch (attribute)
            {
                case "id":
                    attributeReturn = id;
                    break;
                case "id_affiliates":
                    attributeReturn = idAffiliates;
                    break;
                case "phone":
                    attributeReturn = phone;
                    break;
                case "address":
                    attributeReturn = address;
                    break;
                case "email":
                    attributeReturn = email;
                    break;
                case "password":
                    attributeReturn = password;
                    break;
            }
            return attributeReturn;
        }

    }
}
