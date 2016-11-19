using System.Collections;

namespace Lab8
{
    /// <summary>
    /// Interfejs łączenia dwóch sekwencji w jedną według jakiejś reguły
    /// </summary>
    public interface IMerger
    {
        /// <summary>
        /// Nazwa metody łączenia sekwencji
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Metoda łącząca sekwencji
        /// </summary>
        /// <param name="IEnumerable1">Pierwsza sekwencji</param>
        /// <param name="IEnumerable2">Druga sekwencji</param>
        /// <returns>Sekwencja będąca wynikiem połączenia pierwszej i drugiej sekwencji</returns>
        IEnumerable Merge(IEnumerable sequence1, IEnumerable sequence2);
    }

    class Add : IMerger
    {
        public string Name
        {
            get
            {
                return "Add";
            }
        }

        public IEnumerable Merge(IEnumerable sequence1, IEnumerable sequence2)
        {
            IEnumerator enumerator1 = sequence1.GetEnumerator(),
                enumerator2 = sequence2.GetEnumerator();

            while (enumerator1.MoveNext() && enumerator2.MoveNext())
                yield return (int)enumerator1.Current + (int)enumerator2.Current;
        }
    }
}
