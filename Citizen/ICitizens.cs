using System.Collections;

namespace Citizen
{
    interface ICitizens
    {
        Citizen this[int index] { get; }
        int Add(Citizen citizen);
        void Clear();
        bool Contains(Citizen cit);
        IEnumerator GetEnumerator();
        void Remove(Citizen cit);
    }
}