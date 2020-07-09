namespace CitasEps.Models
{
    public class Official : IModel
    {
        private readonly int id;
        private readonly string identification;
        private readonly string name;
        private readonly string lastName;
        private readonly string email;
        private string password;
        private readonly string rol;
        private readonly bool status;

        public Official(int id, string identification, string name, string lastName, string email, string password, string rol, bool status)
        {
            this.id = id;
            this.identification = identification;
            this.name = name;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.rol = rol;
            this.status = status;
        }

        public object GetAll()=> this;
        public void SetPassword(string password) => this.password = password;

        public object GetAttribute(string attribute)
        {
            object attributeReturn = null;
            switch (attribute)
            {
                case "id":
                    attributeReturn = id;
                    break;
                case "identification":
                    attributeReturn = identification;
                    break;
                case "name":
                    attributeReturn = name;
                    break;
                case "last_name":
                    attributeReturn = lastName;
                    break;
                case "email":
                    attributeReturn = email;
                    break;
                case "password":
                    attributeReturn = password;
                    break;
                case "rol":
                    attributeReturn = rol;
                    break;
                case "status":
                    attributeReturn = status;
                    break;
            }
            return attributeReturn;
        }

    }
}
