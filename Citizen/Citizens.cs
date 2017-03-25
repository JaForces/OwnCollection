using System.Collections;

namespace Citizen
{
    class Citizens : ICitizens
    {
        Citizen[] citizens;

        public Citizens()
        {
            citizens = new Citizen[0];
        }

        public Citizen this[int index]
        {
            get { return citizens[index]; }
        }

        public int Add(Citizen citizen)
        {
            if (!Addible(citizen))
                return 0;
            Citizen[] tmp = new Citizen[citizens.Length + 1];
            if (citizen as Pensioner == null)
            {
                for (int i = 0; i < citizens.Length; i++)
                {
                    tmp[i] = citizens[i];

                }
                tmp[citizens.Length] = citizen;
                citizens = tmp;
                return citizens.Length - 1;
            }
            else
            {
                int index = 0;
                foreach (var item in citizens)
                {
                    if (item as Pensioner != null)
                    {
                        index++;
                    }
                }
                for (int i = 0; i < index; i++)
                {
                    tmp[i] = citizens[i];
                }

                tmp[index] = citizen;

                for (int i = index+1; i < tmp.Length; i++)
                {
                    tmp[i] = citizens[i-1];
                }

                citizens = tmp;
                return citizens.Length - 1;
            }
            
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in citizens)
            {
                yield return item.FullInfo();
            }
        }

        private bool Addible( Citizen cit)
        {
            foreach (var item in citizens)
            {
                if (cit.Passport == item.Passport)
                {
                    return false;
                }
            }
            return true;
        }
        public void Clear()
        {
            citizens = null;
        }

        public bool Contains(Citizen cit)
        {
            foreach (var item in citizens)
            {
                if (item == cit)
                    return true;
            }
            return false;
        }

        public void Remove(Citizen cit)
        {
            Citizen[] tmp = new Citizen[citizens.Length - 1];
            int index = 0;

            for (int i = 0; i < citizens.Length; i++)
            {
                if (citizens[i] == cit)
                {
                    index = i;
                }
            }

            for (int i = 0; i < index; i++)
            {
                tmp[i] = citizens[i];
            }
            for (int i = index +1 ; i < citizens.Length; i++)
            {
                tmp[i-1] = citizens[i];
            }

            citizens = tmp;
        }
    }
}
