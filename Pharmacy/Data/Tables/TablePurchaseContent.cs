using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TablePurchaseContent : DatabaseConnection, ITable<PurchaseContent>
	{
		public TablePurchaseContent() : base() { }

		public async Task<bool> AddAsync(PurchaseContent item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Содержимое покупки] VALUES ({item.MedicationId}, {item.PurchaseId})", _connection))
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
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Содержимое покупки] WHERE [id содержимого] = {id}", _connection))
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

		public async Task<List<PurchaseContent>> SearchAsync(string index)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			List<PurchaseContent> purchaseContents = new List<PurchaseContent>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Содержимое покупки]", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					PurchaseContent purchaseContent = new PurchaseContent(reader.GetInt64(0))
					{
						MedicationId = reader.GetInt64(1),
						PurchaseId = reader.GetInt64(2)
					};

					purchaseContents.Add(purchaseContent);
				}

			_connection.Close();
			return purchaseContents;
		}

		public async Task<bool> UpdateAsync(PurchaseContent item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Карта лояльности] SET [id препарата] = {item.MedicationId}," +
																						 $"[id покупки] = {item.PurchaseId} " +
																				  $"WHERE [id содержимого] = {item.Id};", _connection))
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
