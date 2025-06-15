using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Milestone1
{
    public class PTupleGenerator
    {
        // Instance variables
        private List<int> _elements = new List<int>();
        private List<int[]> _tuples = new List<int[]>();
       // private int _tupleCount;
        private Random _random = new Random();

        // Constructor
        public PTupleGenerator(int elementMax, int tupleLength)
        {
            CreateElementList(elementMax);
            GenerateTuples(_elements, new List<int>(), tupleLength);
            //_tupleCount = _tuples.Count;
        }

        // Property

        // Methods
        private void CreateElementList(int max)
        {
            int i = 1;
            while (i <= max)
            {
                _elements.Add(i);
                i++;
            }
        }

        private void GenerateTuples(List<int> elements, List<int> current, int length)
        {
            if (current.Count == length)
            {
                _tuples.Add(current.ToArray());
                return;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                current.Add(elements[i]);
                GenerateTuples(elements, current, length);
                current.RemoveAt(current.Count - 1);
            }
        }

        private int GenerateRandomIndex(int max)
        {
            return _random.Next(0, max);
        }

        public int GetSetCount() 
        {
            return _tuples.Count;
        }

        public int[] GetTuple()
        {
            if (_tuples.Count == 0)
                return null;

            int index = GenerateRandomIndex(_tuples.Count);
            int[] result = _tuples[index];
            _tuples.RemoveAt(index);
            return result;
        }
    }

}
