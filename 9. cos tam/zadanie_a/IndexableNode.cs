using System;

namespace PO_BST
{
	public interface IIndexable
	{
		int EntryIndex { get; set; }
		int ExitIndex { get; set; }
	}


// Klasę IndexableNode należy uzupełnić

	public class IndexableNode<TValue> : IIndexable
	{
		private readonly TValue _value;
		public IndexableNode(TValue value)
		{
			_value = value;
		}

		public TValue Value { get { return _value; } }

		public int EntryIndex { get; set; }

		public int ExitIndex { get; set; }

		public override string ToString()
		{
			return string.Format("{0}<{1},{2}>", Value, EntryIndex, ExitIndex);
		}
	}

}
