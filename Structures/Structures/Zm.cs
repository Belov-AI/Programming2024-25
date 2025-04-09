using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public struct Zm
    {
        int mod;
        public int Mod
        {
            get => mod;

            private set 
            {
                if (value < 2)
                    throw new ArgumentOutOfRangeException();

                mod = value;
            }
        }

        int val;
        public int Value
        {
            get => val;

            set
            {
                if (mod < 2)
                    throw new Exception("Неправильный модуль");
                       
                val = value % mod;
            }
        }

        public Zm(int module, int val)
        {
            this.mod = 0;
            this.val = 0;

            Mod = module;
            Value = val;
        }

        public override string ToString() => $"{Value} (mod {Mod})";

        public override bool Equals(object obj)
        {
            if(obj is Zm zm)
                return zm.Mod == Mod && zm.Value == Value;
            else
                return false;
        }

        public override int GetHashCode()
        {
            var hash = 19;

            var p = 31;

            unchecked
            {
                hash = hash * p + mod.GetHashCode();
                hash = hash * p + val.GetHashCode();
            }

            return hash;
        }

        public static Zm operator +(Zm x, Zm y)
        {
            if (x.Mod != y.Mod)
                throw new ArgumentException();

            return new Zm(x.Mod, (x.Value + y.Value) % x.Mod);
        }

        public static Zm operator *(Zm x, Zm y)
        {
            if (x.Mod != y.Mod)
                throw new ArgumentException();

            return new Zm(x.Mod, (x.Value * y.Value) % x.Mod);
        }
    }
}
