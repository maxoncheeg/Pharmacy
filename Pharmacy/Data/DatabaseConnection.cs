using System.Configuration;
using System.Data.SqlClient;

namespace Pharmacy.Data
{
	//подключение к БД
	internal abstract class DatabaseConnection
	{
		protected SqlConnection _connection;//класс подлючения

		protected DatabaseConnection() 
		{
			int connectionStringIndex = ConfigurationManager.ConnectionStrings.IndexOf(
													new ConnectionStringSettings() { Name = "DefaultConnection" });
			string connectionString = ConfigurationManager.ConnectionStrings[connectionStringIndex].ConnectionString;
			//^- получение строки подключения из App.config
			_connection = new SqlConnection(connectionString);//объявление класса
		}
	}
}
