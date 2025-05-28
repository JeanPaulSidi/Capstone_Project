using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Milestone1
{
    // Comment
    public class Combination
    {
        //Instance Variables
        private List<int> _elements = new List<int>();
        private List<int[]> _combinations = new List<int[]>();
        private int _combinationCount;
        Random _random = new Random();

        //Constructor
        public Combination(int ElementMax, int CombinationLength)
        {
            CreateElementList(ElementMax);
            GenerateCombinations(_elements, 0, new List<int>(), _combinations, CombinationLength);
            _combinationCount = _combinations.Count;
        }

        //Properties
        public int CombinationCount 
        {
            get { return _combinationCount; }
        }

        //Methods
        private void CreateElementList(int Max) 
        {
            for (int i = 1; i <= Max; i++) 
            {
                _elements.Add(i);
            }
        }
        private void GenerateCombinations(List<int> elements, int start, List<int> current, List<int[]> combinations, int length)
        {
            // Base case: When the current combination reaches the desired length
            if (current.Count == length)
            {
                combinations.Add(current.ToArray());
                return;
            }

            // Recursive case: Add elements starting from 'start' index
            for (int i = start; i < elements.Count; i++)
            {
                current.Add(elements[i]);
                GenerateCombinations(elements, i + 1, current, combinations, length);
                current.RemoveAt(current.Count - 1); // Backtrack
            }

        }

        private int GenerateRandomNumber(int Max)
        {
            return _random.Next(0, Max);
        }

        public int[] GetCombination()
        {
            if (_combinations.Count == 0)
                return null;

            int Index = GenerateRandomNumber(_combinations.Count);
            var CombinationPicked = _combinations[Index];

            _combinations.RemoveAt(Index);

            return CombinationPicked;
        }

    }
}
