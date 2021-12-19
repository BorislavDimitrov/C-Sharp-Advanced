using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            return new LakeEnumarator(stones);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }



        private class LakeEnumarator : IEnumerator<int>
        {
            private int index;
            private List<int> stones;
            private bool isAtBack;

            public LakeEnumarator(List<int> stones)
            {
                index = -2;
                this.stones = stones;
                isAtBack = false;

            }

            public int Current => stones[index];

            object IEnumerator.Current => Current;

            public bool MoveNext()
            {
                
                if (!isAtBack)
                {
                    index += 2;
                    if (index > stones.Count - 1)
                    {
                        isAtBack = true;
                        if (index - 1 == stones.Count - 1)
                        {
                            index -= 1;
                            return true;
                        }
                        else if (index - 3 >= 0)
                        {
                            index -= 3;
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    index -= 2;
                    if (index < 0)
                    {
                        return false;
                    }
                    return true;
                }
            }

            public void Reset()
            {

            }

            public void Dispose() { }


        }
    }
}
