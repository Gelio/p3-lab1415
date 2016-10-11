using System;

namespace PO_BST
{

// Klasę WierzcholekIndeksowalny należy uzupełnić

	public class WierzcholekIndeksowalny<TWartosc> : IIndeksowalny
	{
		private readonly TWartosc _value;
		public WierzcholekIndeksowalny(TWartosc value)
		{
			_value = value;
		}

		public TWartosc Wartosc { get { return _value; } }

		public int IndeksWejsciowy { get; set; }

		public int IndeksWyjsciowy { get; set; }

		public override string ToString()
		{
			return string.Format("{0}<{1},{2}>", Wartosc, IndeksWejsciowy, IndeksWyjsciowy);
		}
	}

}
