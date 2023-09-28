using Pharmacy.Data;
using Pharmacy.Data.Classes;
using Pharmacy.Data.Tables;
using Pharmacy.Data.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Managers
{
	internal class DatabaseManager
	{
		private static DatabaseManager _databaseManager;//статичная переменная для хранения класса
		//нужна для реализации паттерна Singleton
		//суть в том, что при создании объекта класса, если _databaseManager != null, мы будет возвращать его.
		//Поэтому в любой части приложения это будет один и тот же класс.

		private ITable<Medication> _tableMedication;//создаем таблицы
		private ITable<Client> _tableClient;
		private ITable<LoyaltyCard> _tableLoyaltyCard;
		private ITable<Purchase> _tablePurchase;
		private ITable<PurchaseContent> _tablePurchaseContent;
		private ITable<Pharmacist> _tablePharmacist;

		private ViewAdditiveCriterion _viewAdditiveCriterion;//представление

		public List<Medication> CartMedications { get; private set; }//корзина препаратов
		public Dictionary<long, long> Cart { get; private set; }//корзина препаратов с Id препаратов и их кол-вом

		private DatabaseManager() {
			_tableMedication = new TableMedication();
			_tableClient = new TableClient();
			_tableLoyaltyCard = new TableLoyaltyCard();
			_tablePurchase = new TablePurchase();
			_tablePurchaseContent = new TablePurchaseContent();
			_tablePharmacist = new TablePharmacist();

			_viewAdditiveCriterion = new ViewAdditiveCriterion();

			Cart = new Dictionary<long, long>();
			CartMedications = new List<Medication>();
			//объявляем всё
		}

		public static DatabaseManager Create()//статический метод для Singleton
		{
			if(_databaseManager == null)
				_databaseManager = new DatabaseManager();

			return _databaseManager;
		}

		public static DatabaseManager CreateSingleton()//статический метод для создания нового класса
		{
			_databaseManager = new DatabaseManager();

			return _databaseManager;
		}

		public async Task<List<Medication>> GetMedicationsAsync(string name)//получить все препараты
		{
			List<Medication> medications = await _tableMedication.SearchAsync(name);

			return medications;
		}

		public async Task<List<Client>> GetClientsAsync(string name) =>
				await _tableClient.SearchAsync(name); //получить всех клиентов

		public async Task<bool> AddClientAsync(Client client)
		{
			if (!await _tableClient.AddAsync(client)) return false;//добавляем клиента

			LoyaltyCard loyaltyCard = new LoyaltyCard() { RegistrationDate = DateTime.Today };//создаем класс карты,
																							//с датой в данный момент времени

			await _tableLoyaltyCard.AddAsync(loyaltyCard);//добавляем карту

			return true;
		}

		public async Task<int> GetDiscountAsync(long cardNumber)
		{
			List<AdditiveCriterion> additiveCriteria = await _viewAdditiveCriterion.GetAdditiveCriteriaAsync();//получить все критерии

			if (additiveCriteria.Find(x => x.ClientId == cardNumber) == null) return 0; //если вдруг нашего клиента нету.

			double totalExpr = additiveCriteria.Sum(x => x.Expr), // сумирование всех
				clientExpr = additiveCriteria.Find(x => x.ClientId == cardNumber).Expr, // конкретный клиент
				fraction = clientExpr / totalExpr; // доля клиента от всех Expr

			int discount = 0;

			if (fraction >= 0.7) discount = 15; //формирование скидки
			else if (fraction >= 0.4) discount = 10;
			else discount = 5;

			return discount;
		}

		public async Task<bool> PurchaseMedicationAsync(Pharmacist pharmacist, long cardNumber, double price)
		{
			Purchase purchase = new Purchase() //создаем покупку
			{
				ClientId = cardNumber,
				PurchaseDate = DateTime.Now,
				PursacheTime = DateTime.Now.TimeOfDay,
				TotalPrice = price,
				PharmacistId = pharmacist.Id
			};

			if(await _tablePurchase.AddAsync(purchase)) // добавляем в базу данных
			{
				long purchaseId = (await _tablePurchase.SearchAsync("")).Last().Id; //получаем ее id
				foreach (var medicationId in Cart.Keys) // и для всех препаратов
				{
					Medication medication = CartMedications.Find(x => x.Id == medicationId);
					long amount;
					Cart.TryGetValue(medicationId, out amount); //получаем кол-во

					PurchaseContent content = new PurchaseContent()
					{
						MedicationId = medicationId,
						PurchaseId = purchaseId
					};

					await _tablePurchaseContent.AddAsync(content);//и добавляем Содержимое покупки


					medication.Amount -= amount;
					await _tableMedication.UpdateAsync(medication);//Затем уменьшаем кол-во препаратов

				}

				Cart = new Dictionary<long, long>();
				CartMedications = new List<Medication>();//очищаем корзину

				return true;
			}

			return false;
		}

		public async Task<bool> PurchaseMedicationAsync()//такой же метод для покупки без карты
		{
			foreach (var medicationId in Cart.Keys)
			{
				Medication medication = CartMedications.Find(x => x.Id == medicationId);
				long amount;
				Cart.TryGetValue(medicationId, out amount);

				medication.Amount -= amount;
				await _tableMedication.UpdateAsync(medication);

			}

			Cart = new Dictionary<long, long>();
			CartMedications = new List<Medication>();

			return true;
		}

		public async Task<bool> IsCardExistAsync(long cardId)//существует ли карта
		{
			List<LoyaltyCard> loyaltyCards = await _tableLoyaltyCard.SearchAsync("");

			foreach (var item in loyaltyCards)
				if(item.Id == cardId)
					return true;

			return false;
		}

		public async Task<bool> AddMedicationAsync(Medication medication)//добавить препарат
		{
			return await _tableMedication.AddAsync(medication);
		}

		public async Task<bool> UpdateMedicationAsync(Medication medication)//обновить препарат
		{
			return await _tableMedication.UpdateAsync(medication);
		}

		public async Task<bool> DeleteClientAsync(Client client)//удалить клиента
		{
			List<Purchase> purchases = (await _tablePurchase.SearchAsync("")).FindAll(x => x.ClientId == client.Id);//получаем все покупки клиента

			foreach (var purchase in purchases)
			{//для всех покупок
				List<PurchaseContent> contents = (await _tablePurchaseContent.SearchAsync("")).FindAll(x => x.PurchaseId == purchase.Id);
				//получаем содержимые
				foreach (var content in contents)//удаляем все содержимые
					if (!await _tablePurchaseContent.DeleteAsync(content.Id)) return false;

				await _tablePurchase.DeleteAsync(purchase.Id);//удаляем покупку
			}

			LoyaltyCard loyaltyCard = (await _tableLoyaltyCard.SearchAsync("")).Find(x => x.Id == client.Id);
			await _tableLoyaltyCard.DeleteAsync(loyaltyCard.Id);//удаляем карту и клиента.
			await _tableClient.DeleteAsync(client.Id);
			
			return true;
		}

		public async Task<bool> UpdateClientAsync(Client client)//обновить клиента
		{
			return await _tableClient.UpdateAsync(client);
		}

		public async Task<int> GetPurchaseAmountAsync(long pharmacistId)//достать кол-во продаж за месяц
		{
			DateTime monthAgo = DateTime.Now.AddMonths(-1);
			List<Purchase> purchases = (await _tablePurchase.SearchAsync("")).FindAll(x => x.PharmacistId == pharmacistId && x.PurchaseDate >= monthAgo);
			return purchases.Count;
		}

		public async Task<List<Pharmacist>> GetPharmacistAsync(string text)//достать фармацевтов
		{
			return await _tablePharmacist.SearchAsync(text);
		}

		public async Task<bool> AddPharmacistAsync(Pharmacist pharmacist)//добавить фармацевта
		{
			return await _tablePharmacist.AddAsync(pharmacist);
		}

		public async Task<bool> UpdatePharmacistAsync(Pharmacist pharmacist)//обновить фармацевта
		{
			return await _tablePharmacist.UpdateAsync(pharmacist);
		}

	}
}
