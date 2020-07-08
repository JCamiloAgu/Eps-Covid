using CitasEps.Models;
using CitasEps.Services;
using MySql.Data.MySqlClient;
using System;

namespace CitasEps.Controllers {
	class Controller {
		private readonly string entity = "";
		private readonly ConnectionService connectionController = new ConnectionService();
		private MySqlCommand command;
		private MySqlDataReader reader;

		// Constructor
		public Controller(string entity) {
			this.entity = entity; //Nombre de la tabla
		}

		// Cerrar consulta
		public void Close() {
			connectionController.Close();
		}


		// Listar Registros
		public MySqlDataReader GetAllFromEntity() {
			string query = string.Format("SELECT * FROM {0};", entity);

			command = GetAndPrepareCommand(query);
			reader = command.ExecuteReader();
			return reader;
		}

		// Obtener registro
		public MySqlDataReader GetFromEntity(string attributte, string value, int limit = 1) {
			string query = string.Format("SELECT * FROM {0} WHERE {1} = '{2}' LIMIT {3};", entity, attributte, value, limit);

			command = GetAndPrepareCommand(query);
			reader = command.ExecuteReader();
			return reader;
		}

		// Consultar get por sql;
		public MySqlDataReader QueryBySqlGet(string query) {
			command = GetAndPrepareCommand(query);
			try {
				reader = command.ExecuteReader();
				return reader;
			}
			catch (Exception e) {
				Console.Write(e.Message);
				return null;
			}
		}

		// Consultar set por sql;
		public int QueryBySqlSet(string query) {
			command = GetAndPrepareCommand(query);
			try {
				return command.ExecuteNonQuery();
			}
			catch (Exception) {
				return -1;
			}
		}


		// Crear registro
		public int CreateEntity(IModel dataEntity, Array attributes) {
			string query = BuildSqlForCreate(attributes);
			command = GetAndPrepareCommand(query);
			AddValuesToCommand(dataEntity, attributes);

			try {
				command.ExecuteNonQuery();
				return int.Parse(command.LastInsertedId.ToString());
			}
			catch (Exception) {
				return -1;
			}
		}

		// Actualizar registro
		public bool UpdateEntity(IModel dataEntity, string attrToEvaluate, string value, Array attributes) {
			string query = BuildSqlForUpdate(attrToEvaluate, value, attributes);
			command = GetAndPrepareCommand(query);

			AddValuesToCommand(dataEntity, attributes);

			try {
				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception e) {
				Console.Write(e.Message);
				return false;
			}
		}

		// Eliminar registro
		public bool DeleteEntity(string attributte, string value) {
			try {
				string query = string.Format("DELETE FROM {0} WHERE {1} = {2};", entity, attributte, value);
				command = GetAndPrepareCommand(query);

				command.ExecuteNonQuery();
				return true;
			}
			catch (Exception) {
				return false;
			}
		}

		// Preparador de atributos para la consulta
		private void AddValuesToCommand(IModel dataEntity, Array attributes) {

			foreach (var item in attributes) {
				string[] itemSpit = item.ToString().Split(':');
				if (dataEntity.GetAttribute(itemSpit[0]).ToString() != "-1") {

					switch (itemSpit[1]) {
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

		// Preparador de consultas
		private MySqlCommand GetAndPrepareCommand(string query) {
			// Se usa un controlador que crea la conexion a la base de datos
			MySqlConnection connection = connectionController.Open();
			command = new MySqlCommand(query, connection);
			command.Prepare();
			return command;

		}

		// Generador de consulta INSERT
		string BuildSqlForCreate(Array attributes) {
			string attributesForInsert = "(";
			string valuesForInsert = "(";

			// Aramar la consulta con los attributos que vienen como parametro
			foreach (var item in attributes) {
				string[] itemSpit = item.ToString().Split(':');
				attributesForInsert += itemSpit[0] + ",";
				valuesForInsert += "@" + itemSpit[0] + ",";
			}
			attributesForInsert = attributesForInsert.Remove(attributesForInsert.Length - 1) + ")";
			valuesForInsert = valuesForInsert.Remove(valuesForInsert.Length - 1) + ")";

			return string.Format("INSERT INTO {0}{1} VALUES {2};", entity, attributesForInsert, valuesForInsert);
		}

		string BuildSqlForUpdate(string attrToEvaluate, string value, Array attributes) =>
				string.Format("UPDATE {0} set {1} WHERE {2} = {3};", entity, GenerateAttributesForUpdate(attributes), attrToEvaluate, value);


		// Generador de consulta UPDATE
		string GenerateAttributesForUpdate(Array attributes) {
			string attributesForUpdate = "";

			// Armar la consulta con los attributos que vienen como parametro
			foreach (var item in attributes) {
				string[] itemSpit = item.ToString().Split(':');
				if (itemSpit[0] != "id") {
					attributesForUpdate += itemSpit[0] + "=" + "@" + itemSpit[0] + ",";
				}
			}
			attributesForUpdate = attributesForUpdate.Remove(attributesForUpdate.Length - 1);

			return attributesForUpdate;
		}
	}
}
