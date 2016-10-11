using System;

namespace PO_BST
{
	public class DrzewoBinarne<TWierzch> where TWierzch : IComparable<TWierzch>, IEquatable<TWierzch>
	{
		public static int Licznik { get; private set; }
		private readonly TWierzch _wartosc;
		private readonly DrzewoBinarne<TWierzch> _prawe;
		private readonly DrzewoBinarne<TWierzch> _lewe;

		private DrzewoBinarne(TWierzch value, DrzewoBinarne<TWierzch> left, DrzewoBinarne<TWierzch> right)
		{
			Licznik++;
			_wartosc = value;
			_prawe = right;
			_lewe = left;
		}

		public static DrzewoBinarne<TWierzch> Start(TWierzch wartosc)
		{
			return new DrzewoBinarne<TWierzch>(wartosc, null, null);
		}

		public TWierzch Wartosc { get { return _wartosc; } }

		public DrzewoBinarne<TWierzch> Prawe { get { return _prawe; } }

		public DrzewoBinarne<TWierzch> Lewe { get { return _lewe; } }

		public DrzewoBinarne<TWierzch> Dodaj(TWierzch wartosc)
		{
			throw new NotImplementedException();
		}

		public DrzewoBinarne<TWierzch> UsunPoddrzewo(TWierzch wartosc)
		{
			throw new NotImplementedException();
		}

	}
}
