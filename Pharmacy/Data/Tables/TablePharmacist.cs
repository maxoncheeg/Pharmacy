using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TablePharmacist : DatabaseConnection, ITable<Pharmacist>
	{
		public TablePharmacist() : base() { }

		public async Task<bool> AddAsync(Pharmacist item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Фармацевт] VALUES ('{item.Surname}', '{item.Name}', " +
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
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Фармацевт] WHERE [id фармацевта] = {id}", _connection))
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

		public async Task<List<Pharmacist>> SearchAsync(string surname)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();
			List<Pharmacist> pharmacists = new List<Pharmacist>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Фармацевт] WHERE [Фамилия] LIKE '%{surname}%'", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					Pharmacist pharmacist = new Pharmacist(reader.GetInt64(0))
					{
						Surname = reader.GetString(1),
						Name = reader.GetString(2),
						Login = reader.GetString(3),
						Password = reader.GetString(4)
					};

					pharmacists.Add(pharmacist);
				}

			_connection.Close();
			return pharmacists;
		}

		public async Task<bool> UpdateAsync(Pharmacist item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Фармацевт] SET [Фамилия] = '{item.Surname}', " +
																				  $"[Имя] = '{item.Name}', " +
																				  $"[Логин] = '{item.Login}', " +
																				  $"[пароль] = '{item.Password}' " +
																				  $"WHERE [id фармацевта] = {item.Id};", _connection))
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
