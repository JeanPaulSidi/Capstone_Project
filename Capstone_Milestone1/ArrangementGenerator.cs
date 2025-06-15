using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone_Milestone1
{
    public class ArrangementGenerator
    {
        private List<List<int>> _results = new List<List<int>>();
        private List<int> _elements = new List<int>();

        public ArrangementGenerator(int elementMax, int ArrangementLength) 
        {
            CreateElementList(elementMax);
            GenerateArrangements(_elements, ArrangementLength);
        }

        private void CreateElementList(int max)
        {
            int i = 1;
            while (i <= max)
            {
                _elements.Add(i);
                i++;
            }
        }

        public void GenerateArrangements(List<int> elements, int length)
        {
            _results.Clear();
            GenerateRecursive(elements, length, new List<int>(), new List<int>());
        }

        private void GenerateRecursive(List<int> elements, int length, List<int> current, List<int> used)
        {
            if (current.Count == length)
            {
                _results.Add(new List<int>(current));
                return;
            }

            foreach (int num in elements)
            {
                if (used.Contains(num)) continue;

                used.Add(num);
                current.Add(num);

                GenerateRecursive(elements, length, current, used);

                current.RemoveAt(current.Count - 1);
                used.RemoveAt(used.Count - 1); // Removes the last added item
            }
        }

    }
}
