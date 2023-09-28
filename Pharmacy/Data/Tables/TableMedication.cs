using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TableMedication : DatabaseConnection, ITable<Medication>
	{
		public TableMedication() : base() { }
		private object _lock = new object();

		public async Task<bool> AddAsync(Medication item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Препарат] VALUES ('{item.Name}', {item.Amount}, " +
																			$"@price)", _connection))
				{
					command.Parameters.Add("@price", System.Data.SqlDbType.Decimal).Value = item.Price;
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

		public async Task<bool> DeleteAsync(long id)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Препарат] WHERE [id препарата] = {id}", _connection))
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

		public async Task<List<Medication>> SearchAsync(string name)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();
			List<Medication> medications = new List<Medication>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Препарат] WHERE [название препарата] LIKE '%{name}%'", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					Medication medication = new Medication(reader.GetInt64(0))
					{
						Name = reader.GetString(1),
						Amount = reader.GetInt64(2),
						Price = (double)reader.GetDecimal(3)
					};

					medications.Add(medication);
				}

			_connection.Close();
			return medications;
		}

		public async Task<bool> UpdateAsync(Medication item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Препарат] SET [название препарата] = '{item.Name}', " +
																				  $"[количество на складе] = {item.Amount}, " +
																				  $"[стоимость] = @price " +
																				  $"WHERE [id препарата] = {item.Id}", _connection))
				{
					command.Parameters.Add("@price", System.Data.SqlDbType.Float).Value = item.Price;
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
