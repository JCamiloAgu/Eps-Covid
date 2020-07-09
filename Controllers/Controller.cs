using CitasEps.Models;
using CitasEps.Services;
using MySql.Data.MySqlClient;
using System;

namespace CitasEps.Controllers
{
    abstract class Controller
    {
        private readonly string tableName = "";
        private readonly ConnectionService connectionController = new ConnectionService();
        private MySqlCommand command;
        private MySqlDataReader reader;

        public Controller(string tableName)
        {
            this.tableName = tableName;
        }

        protected void Close() => connectionController.Close();

        protected MySqlDataReader GetAllFromEntity()
        {
            string query = string.Format("SELECT * FROM {0};", tableName);

            command = GetAndPrepareCommand(query);
            reader = command.ExecuteReader();
            return reader;
        }

        protected MySqlDataReader GetFromEntity(string attributte, string value, int limit = 1)
        {
            string query = string.Format("SELECT * FROM {0} WHERE {1} = '{2}' LIMIT {3};", tableName, attributte, value, limit);

            command = GetAndPrepareCommand(query);
            reader = command.ExecuteReader();
            return reader;
        }

        protected MySqlDataReader QueryBySqlGet(string query)
        {
            command = GetAndPrepareCommand(query);
            try
            {
                reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception)
            {
                return null;
            }
        }

        protected int QueryBySqlSet(string query)
        {
            command = GetAndPrepareCommand(query);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                return -1;
            }
        }

        protected int CreateEntity(IModel dataEntity, Array attributes)
        {
            string query = BuildSqlForCreate(attributes);
            command = GetAndPrepareCommand(query);
            AddValuesToCommand(dataEntity, attributes);

            try
            {
                command.ExecuteNonQuery();
                return int.Parse(command.LastInsertedId.ToString());
            }
            catch (Exception)
            {
                return -1;
            }
        }

        protected bool UpdateEntity(IModel dataEntity, string attrToEvaluate, string value, Array attributes)
        {
            string query = BuildSqlForUpdate(attrToEvaluate, value, attributes);
            command = GetAndPrepareCommand(query);

            AddValuesToCommand(dataEntity, attributes);

            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected bool DeleteEntity(string attributte, string value)
        {
            try
            {
                string query = string.Format("DELETE FROM {0} WHERE {1} = {2};", tableName, attributte, value);
                command = GetAndPrepareCommand(query);

                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void AddValuesToCommand(IModel dataEntity, Array attributes)
        {

            foreach (var item in attributes)
            {
                string[] itemSpit = item.ToString().Split(':');
                if (dataEntity.GetAttribute(itemSpit[0]).ToString() != "-1")
                {

                    switch (itemSpit[1])
                    {
                        case ("int"):
                            command.Parameters.AddWithValue("@" + itemSpit[0], int.Parse(dataEntity.GetAttribute(itemSpit[0]).ToString()));
                            break;
                        case ("double"):
                            command.Parameters.AddWithValue("@" + itemSpit[0], double.Parse(dataEntity.GetAttribute(itemSpit[0]).ToString()));
                            break;
                        case ("bool"):
                            bool boolEntity = Convert.ToBoolean(dataEntity.GetAttribute(itemSpit[0]).ToString());
                            command.Parameters.AddWithValue("@" + itemSpit[0], boolEntity);
                            break;
                        case ("date"):
                            DateTime date = DateTime.Parse(dataEntity.GetAttribute(itemSpit[0]).ToString());
                            string dateTimeFormated = HelpersService.DateFormatToString(date);
                            command.Parameters.AddWithValue("@" + itemSpit[0], dateTimeFormated);
                            break;
                        default:
                            command.Parameters.AddWithValue("@" + itemSpit[0], dataEntity.GetAttribute(itemSpit[0]).ToString());
                            break;
                    }
                }
            }
        }

        private MySqlCommand GetAndPrepareCommand(string query)
        {
            MySqlConnection connection = connectionController.Open();
            command = new MySqlCommand(query, connection);
            command.Prepare();
            return command;

        }

        private string BuildSqlForCreate(Array attributes)
        {
            string attributesForInsert = "(";
            string valuesForInsert = "(";

            foreach (var item in attributes)
            {
                string[] itemSpit = item.ToString().Split(':');
                attributesForInsert += itemSpit[0] + ",";
                valuesForInsert += "@" + itemSpit[0] + ",";
            }
            attributesForInsert = attributesForInsert.Remove(attributesForInsert.Length - 1) + ")";
            valuesForInsert = valuesForInsert.Remove(valuesForInsert.Length - 1) + ")";

            return string.Format("INSERT INTO {0}{1} VALUES {2};", tableName, attributesForInsert, valuesForInsert);
        }

        private string BuildSqlForUpdate(string attrToEvaluate, string value, Array attributes) =>
                string.Format("UPDATE {0} set {1} WHERE {2} = {3};", tableName, GenerateAttributesForUpdate(attributes), attrToEvaluate, value);


        private string GenerateAttributesForUpdate(Array attributes)
        {
            string attributesForUpdate = "";

            foreach (var item in attributes)
            {
                string[] itemSpit = item.ToString().Split(':');
                if (itemSpit[0] != "id")
                {
                    attributesForUpdate += itemSpit[0] + "=" + "@" + itemSpit[0] + ",";
                }
            }
            attributesForUpdate = attributesForUpdate.Remove(attributesForUpdate.Length - 1);

            return attributesForUpdate;
        }
    }
}
