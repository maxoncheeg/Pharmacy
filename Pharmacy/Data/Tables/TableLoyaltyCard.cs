using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Tables
{
	internal class TableLoyaltyCard : DatabaseConnection, ITable<LoyaltyCard>
	{
		public TableLoyaltyCard() : base() { }

		public async Task<bool> AddAsync(LoyaltyCard item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"INSERT INTO [Карта лояльности] VALUES (@date)", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = item.RegistrationDate;

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
				using (SqlCommand command = new SqlCommand($"DELETE FROM [Карта лояльности] WHERE [id карты лояльности] = {id}", _connection))
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

		public async Task<List<LoyaltyCard>> SearchAsync(string cardNumber)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			List<LoyaltyCard> loyaltyCards = new List<LoyaltyCard>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [Карта лояльности]", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					LoyaltyCard loyaltyCard = new LoyaltyCard(reader.GetInt64(0))
					{
						RegistrationDate = reader.GetDateTime(1),
					};

					loyaltyCards.Add(loyaltyCard);
				}

			_connection.Close();
			return loyaltyCards;
		}

		public async Task<bool> UpdateAsync(LoyaltyCard item)
		{
			while (_connection.State != System.Data.ConnectionState.Closed)
				await Task.Delay(100);

			await _connection.OpenAsync();

			try
			{
				using (SqlCommand command = new SqlCommand($"UPDATE [Карта лояльности] SET [дата регистрации в программе] = @date " +
																				  $"WHERE [id карты лояльности] = {item.Id};", _connection))
				{
					command.Parameters.Add("@date", System.Data.SqlDbType.Date).Value = item.RegistrationDate;

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
