using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PO_Serialization
{
	public class Database
	{
		private string _baseDir;

		public Database(string baseDir)
		{
			_baseDir = baseDir;

		}

		/// <summary>
		/// Dodaje nowy obiekt do bazy danych. Jeśli obiekt o danym Id już istnieje należy rzucić wyjątek. Jeśli Id == 0 należy zmienić Id zapisywanego obiektu na wartość o 1 większą niż największa wartość Id do tej pory zapisanych obiektów tego typu.
		/// </summary>
		public void Add<TEntity>(TEntity entity)
			where TEntity : IEntity
		{
		}

		/// <summary>
		/// Aktualizuje obiekt w bazie danych (nadpisuje zstarą wersję). Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public void Update<TEntity>(TEntity entity)
			where TEntity : IEntity
		{
		}

		/// <summary>
		/// Usuwa obiekt z bazy danych. Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public void Delete<TEntity>(int id)
		{
		}

		/// <summary>
		/// Pobiera obiekt z bazy dancyh. Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public TEntity Get<TEntity>(int id)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Pobiera wszystkie obiekty danego typu z bazy dancyh.
		/// </summary>
		public IEnumerable<TEntity> GetCollection<TEntity>()
		{
			throw new NotImplementedException();

		}
	}
}
