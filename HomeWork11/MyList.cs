
using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace HomeWork11
{
    public class MyList<T> : IEnumerable, IEnumerator
    {
        private const int DefaultCapacity = 4;

        internal T[] _items;
        internal int _size;
        private static readonly T[] s_emptyArray = new T[0];

        public MyList()
        {
            _items = s_emptyArray;
        }

        public MyList(int capacity)
        {
            if (capacity < 0)
                throw new ArgumentOutOfRangeException();

            if (capacity == 0)
                _items = s_emptyArray;
            else
                _items = new T[capacity];
        }

        //Длина массива
        public int Count => _size;

        //Добавление элемента
        public void Add(T item)
        {
            T[] array = _items;
            int size = _size;
            if ((uint)size < (uint)array.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
            {
                AddWithResize(item);
            }
        }

        //добавленеи с изменением размера
        private void AddWithResize(T item)
        {
            Debug.Assert(_size == _items.Length);
            int size = _size;
            Grow(size + 1);
            _size = size + 1;
            _items[size] = item;
        }

        //Метод для увеличения размера
        internal void Grow(int capacity)
        {
            Debug.Assert(_items.Length < capacity);

            int newCapacity = _items.Length == 0 ? DefaultCapacity : 2 * _items.Length;

            if ((uint)newCapacity > Array.MaxLength) newCapacity = Array.MaxLength;

            if (newCapacity < capacity) newCapacity = capacity;

            Capacity = newCapacity;
        }

        public int Capacity
        {
            get => _items.Length;
            set
            {
                if (value < _size)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value != _items.Length)
                {
                    if (value > 0)
                    {
                        T[] newItems = new T[value];
                        if (_size > 0)
                        {
                            Array.Copy(_items, newItems, _size);
                        }
                        _items = newItems;
                    }
                    else
                    {
                        _items = s_emptyArray;
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        int position = -1;
        public object Current
        {
            get
            {
                if (position == -1 || position >= _items.Length)
                    throw new ArgumentException();
                return _items[position];
            }
        }
        public bool MoveNext()
        {
            if (position < _items.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset() => position = -1;

        //Элемент по индексу
        public T this[int index]
        {
            get
            {
                // Following trick can reduce the range check by one
                if ((uint)index >= (uint)_size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _items[index];
            }

            set
            {
                if ((uint)index >= (uint)_size)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _items[index] = value;
                //_version++;
            }
        }

        //Удаление из массива
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if ((uint)index >= (uint)_size)
            {
                throw new ArgumentOutOfRangeException();
            }
            _size--;
            if (index < _size)
            {
                Array.Copy(_items, index + 1, _items, index, _size - index);
            }
            if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
            {
                _items[_size] = default!;
            }
            // _version++;
        }

        public int IndexOf(T item)
           => Array.IndexOf(_items, item, 0, _size);

        public override string ToString()
        {
            string result = "";

            for (var i = 0; i < _size; i++)
            {
                result += _items[i].ToString() + " ";
            }

            return result;
        }


    }

}


/*Напишите обобщенный класс, который может хранить в массиве объекты любого
типа. Кроме того, данный класс должен иметь методы для добавления данных в
массив, удаления из массива, получения элемента из массива по индексу и
метод, возвращающий длину массива.*/
