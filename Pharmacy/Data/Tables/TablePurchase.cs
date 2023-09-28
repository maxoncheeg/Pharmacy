using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TablePurchase : DatabaseConnection, ITable<Purchase>
	{
		public TablePurchase() : base() { }

		public async Task<bool> AddAsync(Purchase item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			item.PursacheTime = new System.TimeSpan(item.PursacheTime.Hours, item.PursacheTime.Minutes, item.PursacheTime.Seconds);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Покупка] VALUES ({item.ClientId}, @date, @totalPrice, @time, {item.PharmacistId})", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = item.PurchaseDate;
					command.Parameters.Add("@time", System.Data.SqlDbType.Time).Value = item.PursacheTime;
					command.Parameters.Add("@totalPrice", System.Data.SqlDbType.Decimal).Value = item.TotalPrice;

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
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Покупка] WHERE [id покупки] = {id}", _connection))
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

		public async Task<List<Purchase>> SearchAsync(string index = "")
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();
			List<Purchase> purchases = new List<Purchase>();


			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Покупка]", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					Purchase purchase = new Purchase(reader.GetInt64(0))
					{

					};

					purchase.ClientId = reader.GetInt64(1);
					purchase.PurchaseDate = reader.GetDateTime(2);
					purchase.TotalPrice = (double)reader.GetDecimal(3);
					purchase.PursacheTime = reader.GetTimeSpan(4);
					purchase.PharmacistId = reader.GetInt64(5);

					purchases.Add(purchase);
				}

			_connection.Close();
			return purchases;
		}

		public async Task<bool> UpdateAsync(Purchase item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);


			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Покупка] SET [id клиента] = {item.ClientId}, " +
																						 $"[дата покупки] = @date, " +
																						 $"[сумма покупки] = @totalPrice, " +
																						 $"[время покупки] = @time, " +
																						 $"[id фармацевта] = {item.PharmacistId} " +
																				  $"WHERE [id покупки] = {item.Id};", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.DateTime).Value = item.PurchaseDate;
					command.Parameters.Add("@time", System.Data.SqlDbType.Time).Value = item.PursacheTime;
					command.Parameters.Add("@totalPrice", System.Data.SqlDbType.Decimal).Value = item.TotalPrice;

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

