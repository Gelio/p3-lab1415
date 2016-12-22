using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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
            string filePath = GetFilePath(entity);
            if (entity.Id == 0)
            {
                string[] filePaths = Directory.GetFiles(_baseDir);
                foreach (var nextPath in filePaths)
                {
                    string fileName = Path.GetFileNameWithoutExtension(nextPath);
                    string[] fileNameParts = fileName.Split('_');
                    if (fileNameParts.Length == 1)
                        continue;

                    // Nazwa klasy może zawierać podkreślenia, więc należy zbudować całą nazwę klasy
                    StringBuilder sb = new StringBuilder();
                    for (int i=0; i < fileNameParts.Length - 1; i++)
                    {
                        if (sb.Length > 0)
                            sb.Append("_");
                        sb.Append(fileNameParts[i]);
                    }
                    if (sb.ToString() != typeof(TEntity).Name)
                        continue;

                    int existingId = int.Parse(fileNameParts[fileNameParts.Length - 1]);
                    if (entity.Id <= existingId)
                        entity.Id = existingId + 1;
                }
                filePath = GetFilePath(entity);
            }
            else
            {
                if (File.Exists(filePath))
                    throw new Exception("ID already exists");
            }

            var xmlSerializer = new XmlSerializer(typeof(TEntity));
            FileStream fs = new FileStream(filePath, FileMode.Create);
            xmlSerializer.Serialize(fs, entity);
            fs.Close();
        }

		/// <summary>
		/// Aktualizuje obiekt w bazie danych (nadpisuje zstarą wersję). Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public void Update<TEntity>(TEntity entity)
			where TEntity : IEntity
		{
            string filePath = GetFilePath(entity);
            if (!File.Exists(filePath))
                throw new Exception("Entity does not exist");

            var xmlSerializer = new XmlSerializer(typeof(TEntity));
            FileStream fs = new FileStream(filePath, FileMode.Truncate);
            xmlSerializer.Serialize(fs, entity);
            fs.Close();
        }

		/// <summary>
		/// Usuwa obiekt z bazy danych. Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public void Delete<TEntity>(int id) where TEntity : IEntity
		{
            string filePath = GetFilePath<TEntity>(id);
            if (!File.Exists(filePath))
                throw new Exception("Entity does not exist");

            File.Delete(filePath);
        }

		/// <summary>
		/// Pobiera obiekt z bazy dancyh. Jeśli obiekt o danym Id nie istnieje nalży rzucić wyjątek.
		/// </summary>
		public TEntity Get<TEntity>(int id) where TEntity : IEntity
		{
            string filePath = GetFilePath<TEntity>(id);
            if (!File.Exists(filePath))
                throw new Exception("Entity does not exist");

            var xmlSerializer = new XmlSerializer(typeof(TEntity));
            FileStream fs = new FileStream(filePath, FileMode.Open);
            TEntity entity = (TEntity)xmlSerializer.Deserialize(fs);
            fs.Close();
            return entity;
        }

		/// <summary>
		/// Pobiera wszystkie obiekty danego typu z bazy dancyh.
		/// </summary>
		public IEnumerable<TEntity> GetCollection<TEntity>() where TEntity : IEntity
		{
            string[] filePaths = Directory.GetFiles(_baseDir);
            foreach (var nextPath in filePaths)
            {
                string fileName = Path.GetFileNameWithoutExtension(nextPath);
                string[] fileNameParts = fileName.Split('_');
                if (fileNameParts.Length == 1)
                    continue;

                // Nazwa klasy może zawierać podkreślenia, więc należy zbudować całą nazwę klasy
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < fileNameParts.Length - 1; i++)
                {
                    if (sb.Length > 0)
                        sb.Append("_");
                    sb.Append(fileNameParts[i]);
                }
                if (sb.ToString() != typeof(TEntity).Name)
                    continue;

                yield return Get<TEntity>(int.Parse(fileNameParts[fileNameParts.Length - 1]));
            }
        }

        private string GetFilePath<TEntity>(TEntity entity) where TEntity : IEntity
        {
            return GetFilePath<TEntity>(entity.Id);
        }
        private string GetFilePath<TEntity>(int id) where TEntity : IEntity
        {
            string filePath = Path.Combine(_baseDir, typeof(TEntity).Name + "_" + id + ".xml");
            CreateDirectoryIfMissing(filePath);
            return filePath;
        }

        private void CreateDirectoryIfMissing(string filePath)
        {
            string directoryPath = Path.GetDirectoryName(filePath);
            if (Directory.Exists(directoryPath))
                return;

            Directory.CreateDirectory(directoryPath);
        }
	}
}
