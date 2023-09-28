using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TableAdministrator : DatabaseConnection, ITable<Administrator>
	{
		public TableAdministrator() : base() { }

		public async Task<bool> AddAsync(Administrator item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Администратор] VALUES ('{item.Surname}', '{item.Name}', " +
																			$"'{item.Login}', '{item.Password}')", _connection))
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

		public async Task<bool> DeleteAsync(long id)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Администратор] WHERE [id администратора] = {id}", _connection))
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

		public async Task<List<Administrator>> SearchAsync(string surname)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			List<Administrator> administrators = new List<Administrator>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Администратор] WHERE [Фамилия] LIKE \'%{surname}%\'", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					Administrator administrator = new Administrator(reader.GetInt64(0))
					{
						Surname = reader.GetString(1),
						Name = reader.GetString(2),
						Login = reader.GetString(3),
						Password = reader.GetString(4)
					};

					administrators.Add(administrator);
				}

			_connection.Close();
			return administrators;
		}

		public async Task<bool> UpdateAsync(Administrator item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Администратор] SET [Фамилия] = '{item.Surname}', " +
																				  $"[Имя] = '{item.Name}', " +
																				  $"[Логин] = '{item.Login}', " +
																				  $"[Пароль] = '{item.Password}' " +
																				  $"WHERE [id администратора] = {item.Id};", _connection))
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
	}
}