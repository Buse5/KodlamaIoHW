using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary <D>
    {
            D[] names;
            public MyDictionary()
            {
                names = new D[0];
            }
            public void Add(D name)
            {
                D[] tempArray = names;
                names = new D[names.Length + 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    names[i] = tempArray[i];
                }

                names[names.Length - 1] = name;
            }

            public void Listeleniyor()
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }

