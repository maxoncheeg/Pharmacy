using Pharmacy.Data.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Pharmacy.Data.Views
{
	//для представлений нам нужет только Select Запрос
	internal class ViewAdditiveCriterion : DatabaseConnection
	{
		public ViewAdditiveCriterion() : base() { }

		public async Task<List<AdditiveCriterion>> GetAdditiveCriteriaAsync()
		{
			await _connection.OpenAsync();

			List<AdditiveCriterion> additiveCriterions = new List<AdditiveCriterion>();

			using (SqlCommand command = new SqlCommand($"SELECT * FROM [аддитивный критерий]", _connection))
			using (SqlDataReader reader = await command.ExecuteReaderAsync())
				while (await reader.ReadAsync())
				{
					AdditiveCriterion additiveCriterion = new AdditiveCriterion()
					{
						Expr = (double)reader.GetDecimal(0),
						ClientId = reader.GetInt64(1)
					};

					additiveCriterions.Add(additiveCriterion);
				}

			_connection.Close();
			return additiveCriterions;
		}
	}
}
