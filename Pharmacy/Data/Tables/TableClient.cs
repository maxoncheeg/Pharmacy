using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	//унаследуемся от DatabaseConnection и интерфейса ITable
	internal class TableClient : DatabaseConnection, ITable<Client>
	{
		public TableClient() : base() { } //конструктор запускам DatabaseConnection

		public async Task<bool> AddAsync(Client item) //запрос на добавление
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync(); //открываем подключение

			try
			{
				//создаем комманду и пишем запрос
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Клиент] VALUES ('{item.Surname}', '{item.Name}', @date)", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = item.BirthDate;//такая реализация нужна
					//чтобы неочевидные типы данных(которые мы не знаем как выглядят в бд) нормально конвертировались.

					if (await command.ExecuteNonQueryAsync() <= 0)//выполняем запрос без возвращения данныъ
					{//в данном случае он вернет кол-во затронутых строк
						_connection.Close();//если оно меньше равно нулю, значит он ничего не добавил
						return false;
					}
				}
			}
			catch
			{
				_connection.Close();//если случилась ошибка
				return false;
			}

			_connection.Close();//закрываем подключение
			return true;
		}

		public async Task<bool> DeleteAsync(long id)//удаление
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Клиент] WHERE [id клиента] = {id}", _connection))
					if (await command.ExecuteNonQueryAsync() <= 0)
					{
						_connection.Close();
						return false;
					}
			}
			catch
			{
				_connection.Close();
				return false;
			}

			_connection.Close();
			return true;
		}

		public async Task<List<Client>> SearchAsync(string surname)//поиск
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();
			List<Client> clients = new List<Client>();//создаем лист

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Клиент] WHERE [Фамилия] like '%{surname}%'", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())//создаем читатель возвращаемых данных, ExecuteReaderAsync
				while (await reader.ReadAsync())//пока мы считываем данные из БД
				{
					Client client = new Client(reader.GetInt64(0))//будем создавать клиентов
					{
						Surname = reader.GetString(1),
						Name = reader.GetString(2),
						BirthDate = reader.GetDateTime(3)
					};

					clients.Add(client);//добавлять в лист
				}

			_connection.Close();
			return clients;
		}

		public async Task<bool> UpdateAsync(Client item)//обновление
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Клиент] SET [Фамилия] = '{item.Surname}'," +
														   $"[Имя] = '{item.Name}'," +
														   $"[Дата рождения] = @date " +
																				  $"WHERE [id клиента] = {item.Id};", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = item.BirthDate;

					if (await command.ExecuteNonQueryAsync() <= 0)
					{
						_connection.Close();
						return false;
					}
				}
			}
			catch
			{
				_connection.Close();
				return false;
			}

			_connection.Close();
			return true;
		}
	}
}
