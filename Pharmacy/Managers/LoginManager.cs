using Pharmacy.Classes;
using Pharmacy.Data;
using Pharmacy.Data.Classes;
using Pharmacy.Data.Tables;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy.Managers
{
	public class LoginManager 
	{
		private ITable<Administrator> _tableAdministrator;
		private ITable<Pharmacist> _tablePharmacist;

		public LoginResult LoginResult { get; private set; } //здесь информация кто вошел
		public Object LoginUser { get; private set; } // здесь будет храниться админ или фармацевт

		private LoginManager() 
		{
			_tableAdministrator = new TableAdministrator();
			_tablePharmacist = new TablePharmacist();

			LoginUser = null;
			LoginResult = LoginResult.Failed;
		}

		public static LoginManager Create() => new LoginManager(); //создание

		public async Task<LoginResult> Login(string login, string password)
		{
			Administrator administrator = (await _tableAdministrator.SearchAsync("")).FirstOrDefault(x => x.Login == login);
			//ищем админа с таким же логином
			if (administrator != null)//если он есть
				if (administrator.Password == password)
				{//проверяем пароль и входим, если все верно
					LoginUser = administrator;
					LoginResult = LoginResult.Administrator;
					return LoginResult.Administrator;
				}

			Pharmacist pharmacist = (await _tablePharmacist.SearchAsync("")).FirstOrDefault(x => x.Login == login);

			if (pharmacist != null)
				if (pharmacist.Password == password)
				{
					LoginUser = pharmacist;
					LoginResult = LoginResult.Pharmacist;
					return LoginResult.Pharmacist;
				}

			LoginUser = null;
			LoginResult = LoginResult.Failed;//иначе ошибка.
			return LoginResult.Failed;
		}
	}
	
}
