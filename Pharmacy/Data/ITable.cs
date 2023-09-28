using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pharmacy.Data
{
	//интерфейс таблицы, нужен для структурирования
	internal interface ITable<T> where T : class //T - класс который хранится в таблице
	{
		Task<Boolean> AddAsync(T item);
		Task<Boolean> UpdateAsync(T item);
		Task<Boolean> DeleteAsync(long id);
		Task<List<T>> SearchAsync(string name);//прототипы методов
	}
}
