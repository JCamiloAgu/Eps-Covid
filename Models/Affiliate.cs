namespace CitasEps.Models
{
    class Affiliate : IModel
    {
        private readonly int id;
        private readonly string name;
        private readonly string lastName;
        private readonly string identification;
        private readonly bool status;

        public Affiliate(int id, string name, string lastName, string identification, bool status)
        {
            this.id = id;
            this.name = name;
            this.lastName = lastName;
            this.identification = identification;
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
                case "name":
                    attributeReturn = name;
                    break;
                case "last_name":
                    attributeReturn = lastName;
                    break;
                case "identification":
                    attributeReturn = identification;
                    break;
                case "status":
                    attributeReturn = status;
                    break;
            }
            return attributeReturn;
        }
    }
}
