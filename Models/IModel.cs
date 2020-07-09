namespace CitasEps.Models
{
    interface IModel
    {
        public object GetAll();
        public object GetAttribute(string attribute);
    }
}
