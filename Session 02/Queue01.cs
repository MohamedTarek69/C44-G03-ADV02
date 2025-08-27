using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Session_02
{
    internal class Queue01
    {
        #region Attributes
        private object[] Items;
        private int Front;
        private int Rear;
        private int Count;

        private int Capacity = 4; 

        #endregion

        #region Constructoes
        public Queue01()
        {
            Items = new object[Capacity];
            Front = 0;
            Rear = -1;
            Count = 0;
        } 
        #endregion

        #region Methods
        public void Enqueue(object item)
        {
            if (Count == Items.Length)
            {
                Resize();
            }
            MoveNext(ref Rear);
            Items[Rear] = item;
            Count++;
        }

        private void Resize()
        {
            object[] newArray = new object[Items.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                newArray[i] = Items[(Front + i) % Items.Length];
            }
            Items = newArray;
            Front = 0;
            Rear = Count - 1;
        }

        private void MoveNext(ref int index)
        {
            int tmp = index + 1;
            if (tmp == Items.Length)
            {
                tmp = 0;
            }
            index = tmp;
        }

        public object Dequeue()
        {
            if (Count == 0)
                Console.WriteLine("Queue is empty");

            object value = Items[Front];
            MoveNext(ref Front);
            Count--;
            return value;
        }

        public void ShowQueue()
        {
            if (Items is not null && Count > 0)
            {
                for (int i = 0; i < Count; i++)
                {
                    Console.WriteLine(Items[(Front + i) % Items.Length]);
                }
            }
            else
            {
                Console.WriteLine("Queue is empty");
            }
        } 

        #endregion



    }
}
