using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PO_Serialization
{
	class Program
	{
		static void Main(string[] args)
		{
			// usuwamy wszystkie stare dane.
			if (Directory.Exists("Data"))
			{
				Directory.Delete("Data", true);
			}

			var db = new Database("Data");

			var lukeSkywalker = new Person { Id = 1, FirstName = "Luke", LastName = "Skywalker", SecretPassword = Order.Password };
			lukeSkywalker.Planets.Add(new Planet() { Name = "Tatooine" });
			lukeSkywalker.Planets.Add(new Planet() { Name = "Alderaan" });

			db.Add(lukeSkywalker);

			var order1 = new Order(lukeSkywalker, 10) {Id = 1};
			db.Add(order1);

			var hanSolo = new Person { Id = 2, FirstName = "Han", LastName = "Solo" };
			db.Add(hanSolo);

			var order2 = new Order(lukeSkywalker, 20) {Id = 2};
			db.Add(order2);


			var lukeSkywalkerDeserialized = db.Get<Person>(1);
			var hanSoloDeserialized = db.Get<Person>(2);
			var order1Deserialized = db.Get<Order>(1);
			var order2Deserialized = db.Get<Order>(2);

			Console.WriteLine("Basic serialization/deserialization tests");
			Console.WriteLine(lukeSkywalkerDeserialized.ToString());
			Console.WriteLine(ComparePerson(lukeSkywalkerDeserialized, lukeSkywalker) ? "OK" : "FAIL");

			Console.WriteLine(hanSoloDeserialized.ToString());
			Console.WriteLine(ComparePerson(hanSoloDeserialized, hanSolo) ? "OK" : "FAIL");

			Console.WriteLine(order1Deserialized.ToString());
			Console.WriteLine(CompareOrder(order1Deserialized, order1) ? "OK" : "FAIL");

			Console.WriteLine(order2Deserialized.ToString());
			Console.WriteLine(CompareOrder(order2Deserialized, order2) ? "OK" : "FAIL");

			Console.WriteLine("Add existing object test");
			ThrowTest(() => db.Add(order1));

			Console.WriteLine("Basic update test");
			order1.Amount = 11;
			db.Update(order1);

			order1.Amount = 12;
			db.Update(order1);

			order1Deserialized = db.Get<Order>(1);
			Console.WriteLine(order1Deserialized.ToString());
			Console.WriteLine(CompareOrder(order1Deserialized, order1) ? "OK" : "FAIL");

			Console.WriteLine("Create order without password");
			ThrowTest(() => new Order(lukeSkywalkerDeserialized, 0));

			Console.WriteLine("update object without id test");
			ThrowTest(() =>db.Update(new Order(lukeSkywalker, 10)));

			Console.WriteLine("update not persisted object test");
			ThrowTest(() => db.Update(new Order(lukeSkywalker, 10){Id = 50}));

			Console.WriteLine("Basic delete test");
			db.Delete<Order>(2);
			ThrowTest(() => db.Get<Order>(2));

			Console.WriteLine("delete not existing object test");
			ThrowTest(() => db.Delete<Order>(50));

			Console.WriteLine("basic assign id if 0 test");
			order2 = new Order(lukeSkywalker, 30);
			db.Add(order2);
			order2Deserialized = db.Get<Order>(2);
			Console.WriteLine(CompareOrder(order2Deserialized, order2) ? "OK" : "FAIL");

			Console.WriteLine("basic getCollection test");
			var persons = db.GetCollection<Person>().ToList();
			Console.WriteLine(persons.Any(p => p.FullName == "Luke Skywalker") && persons.Any(p => p.FullName == "Han Solo") ? "OK" : "FAIL");

			Console.WriteLine("getCollection on empty collection test");
			db.Delete<Order>(1);
			db.Delete<Order>(2);
			var orders = db.GetCollection<Order>().ToList();
			Console.WriteLine(orders.Count == 0 ? "OK" : "FAIL");
		}

		private static bool ComparePerson(Person deserialized, Person original)
		{
			return (deserialized.FirstName == original.FirstName &&
			        deserialized.LastName == original.LastName &&
			        deserialized.Id == original.Id && 
					deserialized.Planets.Count == original.Planets.Count &&
					deserialized.Planets.Zip(original.Planets, (d, o) => new {d,o}).All((v) => v.d.Name == v.o.Name));
		}
		private static bool CompareOrder(Order deserialized, Order original)
		{
			return (deserialized.Amount == original.Amount &&
					deserialized.Id == original.Id &&
					deserialized.PersonId == original.PersonId);
		}

		private static void ThrowTest(Action action)
		{
			try
			{
				action();
				Console.WriteLine("FAIL");
			}
			catch (Exception)
			{
				Console.WriteLine("OK");
			}
		}
	}

	public interface IEntity
	{
		int Id { get; set; }
	}
}
