using System;

namespace Ulong_bitwise
{
    struct Zbior
    {
        private ulong zbior;

        public Zbior(ulong initial = 0)
        {
            this.zbior = initial;
        }

        public Zbior(int initial) : this((ulong)initial)
        {
        }

        public Zbior(params int[] elements)
        {
            ulong zbior = 0;
            Array.ForEach(elements, delegate (int element)
            {
                if (element > 0 && element <= 63)
                    zbior |= (ulong)Math.Pow(2, element);
            });
            this.zbior = zbior;
        }

        public Zbior(Zbior zb)
        {
            this.zbior = zb.zbior;
        }

        public static implicit operator Zbior(int v)
        {
            if (v < 0 || v > 63)
                return new Zbior(0);

            return new Zbior((ulong)Math.Pow(2, v));
        }

        public static explicit operator ulong(Zbior zbior)
        {
            return zbior.zbior;
        }

        public static Zbior operator +(Zbior zbior1, Zbior zbior2)
        {
            return new Zbior(zbior1.zbior | zbior2.zbior);
        }
        
        public static Zbior operator -(Zbior zb1, Zbior zb2)
        {
            return new Zbior(zb1.zbior & ~zb2.zbior);
        }

        public static bool operator ==(Zbior zb1, Zbior zb2)
        {
            return zb1.zbior == zb2.zbior;
        }

        public static bool operator !=(Zbior zb1, Zbior zb2)
        {
            return !(zb1 == zb2);
        }

        public override bool Equals(object o)
        {
            if (o is Zbior)
                return this == (Zbior)o;
            else if (o is ulong)
                return this.zbior == (ulong)o;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return this.zbior.GetHashCode();
        }

        public bool this[int element]
        {
            get
            {
                return (this.zbior & (ulong)Math.Pow(2, element)) > 0;
            }
            set
            {
                if (value)
                    this.zbior |= (ulong)Math.Pow(2, element);
                else
                    this.zbior &= ~(ulong)Math.Pow(2, element);
            }
        }

        public override string ToString()
        {
            string output = "{ ";
            int elementsCount = 0;
            for (int i=0; i < 64; i++)
            {
                if (this[i])
                {
                    if (elementsCount > 0)
                        output += " ";
                    output += i;
                    elementsCount++;
                }
            }
            output += " }";
            return output;
        }

        public static Zbior operator *(Zbior zb1, Zbior zb2)
        {
            return new Zbior(zb1.zbior & zb2.zbior);
        }

        public static bool operator <=(Zbior zb1, Zbior zb2)
        {
            return (zb1 - zb2) == Zbior.Pusty;
        }

        public static bool operator >=(Zbior zb1, Zbior zb2)
        {
            return (zb2 - zb1) == Zbior.Pusty;
        }

        public static Zbior operator !(Zbior zb)
        {
            return new Zbior(~zb.zbior);
        }

        public int Ile
        {
            get
            {
                int count = 0;
                for (int i = 0; i < 64; i++)
                {
                    if (this[i])
                        count++;
                }
                return count;
            }
        }

        public int Max
        {
            get
            {
                for (int i = 63; i >= 0; i--)
                {
                    if (this[i])
                        return i;
                }
                return -1;
            }
        }

        public static Zbior Pusty
        {
            get
            {
                return new Zbior();
            }
        }

        public Zbior[] Podzbiory()
        {
            Zbior[] podzbiory = new Zbior[(int)Math.Pow(2, this.Ile)];
            int i = 0;
            Zbior.PodzbioryRek(this, new Zbior(), podzbiory, ref i);
            //return Zbior.getSubsets(this);
            return podzbiory;
        }

        private static Zbior[] getSubsets(Zbior zb)
        {
            Zbior[] subsets = new Zbior[(int)Math.Pow(2, zb.Ile)];
            subsets[0] = zb;
            int nextFree = 1;

            for (int i=0; i < 63; i++)
            {
                if (zb[i])
                {
                    zb[i] = true;
                    Zbior[] sub1 = Zbior.getSubsets(zb);
                    for (int j=0; j < sub1.Length; j++)
                        subsets[nextFree++] = sub1[j];
                    zb[i] = false;
                }
            }

            return subsets;
        }

        private static void PodzbioryRek(Zbior z1, Zbior z2, Zbior[] tab, ref int i)
        {
            for (int j=0; j < 63; j++)
            {
                if (z1[j])
                {
                    z1[j] = false;
                    z2[j] = true;
                    tab[i++] = z2;
                    Zbior.PodzbioryRek(z1, z2, tab, ref i);
                    z2[j] = false;
                }
            }
        }


    }
}
