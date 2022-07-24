//Similar to arranging playing cards
//Assume the first card is in its sorted position. 
//Take the second card and compare it with its previous postion and swap if not in order


namespace SortingAlgorithms.Sort
{
    internal class InsertionSort
    {
        public int[] Input { get; set; }

        public InsertionSort(int[] input)
        {
            Input = input;
        }

        public void Sort()
        {
            for (int i = 1; i < Input.Length; i++)
            {
                var val = Input[i];

                var index = i;

                while(index > 0 && Input[index - 1] > val)
                {
                    Input[index] = Input[index - 1];
                    index--;
                }

                Input[index] = val;
            }
        }

        public void Sort2()
        {
            for (int i = 0; i < Input.Length - 1; i++)
            {
                var j = i + 1;

                var sorted = false;

                do
                {
                    if (Input[i] > Input[j])
                    {
                        (Input[i], Input[j]) = (Input[j], Input[i]);

                        j--;
                        i--;
                    }
                    else
                        sorted = true;
                }
                while (!sorted && i >= 0);
            }
        }
    }
}
