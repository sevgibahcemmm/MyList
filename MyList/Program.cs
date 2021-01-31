using System;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            BenimListem<string> programlamaDilleri = new BenimListem<string>();
            programlamaDilleri.Add("Pascal");// hey gidi günler hey :)
            programlamaDilleri.Add("Cobol");
            Console.WriteLine(programlamaDilleri.Count);


        }
    }
    class BenimListem<T>
    {
        T[] _array;
        T[] _tempArray;

        public BenimListem()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;

        }


        public int Count
        {
            get { return _array.Length; }

        }

    }
}

