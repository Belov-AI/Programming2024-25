using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sequences
{
    public class Sequence
    {
        public IEnumerable<BigInteger> Fibonacci()
        {
            BigInteger a = 1;
            BigInteger b = 1;

            yield return a;
            yield return b;

            BigInteger c;

            do
            {
                c = b + a;
                yield return c;
                a = b;
                b = c;
            } while (true);
        }

        public IEnumerable<BigInteger> Factorial()
        {
            BigInteger n = 1;
            BigInteger factorial = 1;

            yield return factorial;

            do
            {
                factorial *= n;
                yield return factorial;
                n++;
            } while (true);
        }

        public IEnumerable<BigInteger> Collattz(int n) 
        {
            BigInteger a = n;

            do
            {
                yield return a;
                
                if(a == 1)
                    yield break;

                if (a % 2 == 0)
                    a /= 2;
                else
                    a = 3 * a + 1;
            }while (true);
        }
    }
}
