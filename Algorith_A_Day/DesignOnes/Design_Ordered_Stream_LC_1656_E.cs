using System.Collections.Generic;

namespace Algorithm_A_Day.DesignOnes
{
    public class DesignOrderedStreamLc1656E
    {
        private string[] _result;
        private int _index = 1;

        public DesignOrderedStreamLc1656E(int n)
        {
            _result = new string[n + 1];
            _index = 1;
        }

        public IList<string> Insert(int id, string value)
        {
            var res = new List<string>();
            var current = id;
            _result[current] = value;

            if (_index == id)
            {
                for (; current < _result.Length; current++)
                {
                    if (_result[current] != null)
                    {
                        res.Add(_result[current]);
                    }
                    else break;
                }
                _index = current;
            }
            return res;
        }
    }
}
