using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PO_Serialization
{
	public class Person : IEntity
	{
		public Person()
		{
			Planets = new List<Planet>();
		}

		public int Id { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }

		/// <summary>
		/// Właściwość wyliczana z FirstName i LastName.
		/// Wartość nie powinna być serializowana tylko wyliczana po deserializacji.
		/// </summary>
		public string FullName
		{
			get { throw new NotImplementedException();}
		}

		/// <summary>
		/// Właściwość nie powinna być serializowana
		/// </summary>
		public string SecretPassword { get; set; }

		public List<Planet> Planets { get; private set; }

		public override string ToString()
		{
			return string.Format("Person: id {0}, Name: {1}, \n\tPlanets: \n\t{2}", Id, FullName, string.Join(",\n\t", Planets));
		}
	}

	public class Planet
	{
		public string Name { get; set; }
		public override string ToString()
		{
			return string.Format("Planet: name {0}", Name);
		}
	}

	public class Order : IEntity
	{
		public const string Password = "yabba dabba doo";

		/// <summary>
		/// Na potrzeby serializacji
		/// </summary>
		private Order() { }

		/// <summary>
		/// Jeśli przekazany obiekt person ma właściwość SecretPassword o wartości innej niż "yabba dabba doo" należy rzucić wyjątek.
		/// </summary>
		public Order(Person person, int amount)
		{
		}

		public int Id { get; set; }
		public int PersonId { get; set; }

		public int Amount { get; set; }

		public override string ToString()
		{
			return string.Format("Order: id {0}, PersonId: {1}, Amount: {2}", Id, PersonId, Amount);
		}
	}
}
