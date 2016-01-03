namespace JSON
{
    using System;
    using System.Runtime.CompilerServices;

    public class Value
    {
        public Value(JSON.Array array)
        {
            this.Type = JSON.ValueType.Array;
            this.Array = array;
        }

        public Value(JSON.Object obj)
        {
            if (obj == null)
            {
                this.Type = JSON.ValueType.Null;
            }
            else
            {
                this.Type = JSON.ValueType.Object;
                this.Obj = obj;
            }
        }

        public Value(Value value)
        {
            this.Type = value.Type;
            switch (this.Type)
            {
                case JSON.ValueType.String:
                    this.Str = value.Str;
                    break;

                case JSON.ValueType.Number:
                    this.Number = value.Number;
                    break;

                case JSON.ValueType.Object:
                    if (value.Obj != null)
                    {
                        this.Obj = new JSON.Object(value.Obj);
                    }
                    break;

                case JSON.ValueType.Array:
                    this.Array = new JSON.Array(value.Array);
                    break;

                case JSON.ValueType.Boolean:
                    this.Boolean = value.Boolean;
                    break;
            }
        }

        public Value(JSON.ValueType type)
        {
            this.Type = type;
        }

        public Value(bool boolean)
        {
            this.Type = JSON.ValueType.Boolean;
            this.Boolean = boolean;
        }

        public Value(double number)
        {
            this.Type = JSON.ValueType.Number;
            this.Number = number;
        }

        public Value(string str)
        {
            this.Type = JSON.ValueType.String;
            this.Str = str;
        }

        public static implicit operator Value(JSON.Array array)
        {
            return new Value(array);
        }

        public static implicit operator Value(JSON.Object obj)
        {
            return new Value(obj);
        }

        public static implicit operator Value(bool boolean)
        {
            return new Value(boolean);
        }

        public static implicit operator Value(double number)
        {
            return new Value(number);
        }

        public static implicit operator Value(string str)
        {
            return new Value(str);
        }

        public override string ToString()
        {
            switch (this.Type)
            {
                case JSON.ValueType.String:
                    return ("\"" + this.Str + "\"");

                case JSON.ValueType.Number:
                    return this.Number.ToString();

                case JSON.ValueType.Object:
                    return this.Obj.ToString();

                case JSON.ValueType.Array:
                    return this.Array.ToString();

                case JSON.ValueType.Boolean:
                    return (!this.Boolean ? "false" : "true");

                case JSON.ValueType.Null:
                    return "null";
            }
            return "null";
        }

        public JSON.Array Array { get; set; }

        public bool Boolean { get; set; }

        public double Number { get; set; }

        public JSON.Object Obj { get; set; }

        public Value Parent { get; set; }

        public string Str { get; set; }

        public JSON.ValueType Type { get; private set; }
    }
}

