namespace JSON
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;
    using UnityEngine;

    public class Array : IEnumerable, IEnumerable<Value>
    {
        private readonly List<Value> values;

        public Array()
        {
            this.values = new List<Value>();
        }

        public Array(JSON.Array array)
        {
            this.values = new List<Value>();
            this.values = new List<Value>();
            foreach (Value value2 in array.values)
            {
                this.values.Add(new Value(value2));
            }
        }

        public void Add(Value value)
        {
            this.values.Add(value);
        }

        public void Clear()
        {
            this.values.Clear();
        }

        public IEnumerator<Value> GetEnumerator()
        {
            return this.values.GetEnumerator();
        }

        public static JSON.Array operator +(JSON.Array lhs, JSON.Array rhs)
        {
            JSON.Array array = new JSON.Array(lhs);
            foreach (Value value2 in rhs.values)
            {
                array.Add(value2);
            }
            return array;
        }

        public static JSON.Array Parse(string jsonString)
        {
            JSON.Object obj2 = JSON.Object.Parse("{ \"array\" :" + jsonString + '}');
            return ((obj2 != null) ? obj2.GetValue("array").Array : null);
        }

        public void Remove(int index)
        {
            if ((index >= 0) && (index < this.values.Count))
            {
                this.values.RemoveAt(index);
            }
            else
            {
                Debug.LogError(string.Concat(new object[] { "index out of range: ", index, " (Expected 0 <= index < ", this.values.Count, ")" }));
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.values.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('[');
            foreach (Value value2 in this.values)
            {
                builder.Append(value2.ToString());
                builder.Append(',');
            }
            if (this.values.Count > 0)
            {
                builder.Remove(builder.Length - 1, 1);
            }
            builder.Append(']');
            return builder.ToString();
        }

        public Value this[int index]
        {
            get
            {
                return this.values[index];
            }
            set
            {
                this.values[index] = value;
            }
        }

        public int Length
        {
            get
            {
                return this.values.Count;
            }
        }
    }
}

