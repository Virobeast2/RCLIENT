namespace JSON
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Text;
    using UnityEngine;

    public class Object : IEnumerable, IEnumerable<KeyValuePair<string, Value>>
    {
        private readonly IDictionary<string, Value> values;

        public Object()
        {
            this.values = new Dictionary<string, Value>();
        }

        public Object(JSON.Object other)
        {
            this.values = new Dictionary<string, Value>();
            this.values = new Dictionary<string, Value>();
            if (other != null)
            {
                IEnumerator<KeyValuePair<string, Value>> enumerator = other.values.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        KeyValuePair<string, Value> current = enumerator.Current;
                        this.values[current.Key] = new Value(current.Value);
                    }
                }
                finally
                {
                    if (enumerator == null)
                    {
                    }
                    enumerator.Dispose();
                }
            }
        }

        public void Add(KeyValuePair<string, Value> pair)
        {
            this.values[pair.Key] = pair.Value;
        }

        public void Add(string key, Value value)
        {
            this.values[key] = value;
        }

        public void Clear()
        {
            this.values.Clear();
        }

        public bool ContainsKey(string key)
        {
            return this.values.ContainsKey(key);
        }

        private static JSON.Object Fail(char expected, int position)
        {
            return Fail(new string(expected, 1), position);
        }

        private static JSON.Object Fail(string expected, int position)
        {
            Debug.LogError(string.Concat(new object[] { "Invalid json string, expecting ", expected, " at ", position }));
            return null;
        }

        public JSON.Array GetArray(string key)
        {
            Value value2 = this.GetValue(key);
            if (value2 == null)
            {
                return new JSON.Array();
            }
            return value2.Array;
        }

        public bool GetBoolean(string key, bool bDefault = false)
        {
            Value value2 = this.GetValue(key);
            if (value2 != null)
            {
                if (value2.Type == JSON.ValueType.Boolean)
                {
                    return value2.Boolean;
                }
                if (value2.Type == JSON.ValueType.Number)
                {
                    return (value2.Number != 0.0);
                }
            }
            return bDefault;
        }

        public IEnumerator<KeyValuePair<string, Value>> GetEnumerator()
        {
            return this.values.GetEnumerator();
        }

        public float GetFloat(string key, float iDefault = 0)
        {
            return (float) this.GetNumber(key, (double) iDefault);
        }

        public int GetInt(string key, int iDefault = 0)
        {
            return (int) this.GetNumber(key, (double) iDefault);
        }

        public double GetNumber(string key, double iDefault = 0)
        {
            Value value2 = this.GetValue(key);
            if (value2 != null)
            {
                if (value2.Type == JSON.ValueType.Number)
                {
                    return value2.Number;
                }
                if (value2.Type == JSON.ValueType.String)
                {
                    double result = iDefault;
                    if (double.TryParse(value2.Str, out result))
                    {
                        return result;
                    }
                }
            }
            return iDefault;
        }

        public JSON.Object GetObject(string key)
        {
            Value value2 = this.GetValue(key);
            if (value2 == null)
            {
                return new JSON.Object();
            }
            return value2.Obj;
        }

        public string GetString(string key, string strDEFAULT = "")
        {
            Value value2 = this.GetValue(key);
            if (value2 == null)
            {
                return strDEFAULT;
            }
            return value2.Str.Replace(@"\/", "/");
        }

        public Value GetValue(string key)
        {
            Value value2;
            this.values.TryGetValue(key, out value2);
            return value2;
        }

        public static JSON.Object Parse(string jsonString)
        {
            if (!string.IsNullOrEmpty(jsonString))
            {
                Value value2 = null;
                List<string> list = new List<string>();
                ParsingState key = ParsingState.Object;
                for (int i = 0; i < jsonString.Length; i++)
                {
                    string str;
                    char ch;
                    string str2;
                    double num2;
                    Value value4;
                    char ch2;
                    i = SkipWhitespace(jsonString, i);
                    switch (key)
                    {
                        case ParsingState.Object:
                            if (jsonString[i] == '{')
                            {
                                break;
                            }
                            return Fail('{', i);

                        case ParsingState.Array:
                            if (jsonString[i] == '[')
                            {
                                goto Label_059A;
                            }
                            return Fail('[', i);

                        case ParsingState.EndObject:
                            if (jsonString[i] == '}')
                            {
                                goto Label_00B7;
                            }
                            return Fail('}', i);

                        case ParsingState.EndArray:
                            if (jsonString[i] == ']')
                            {
                                goto Label_05D5;
                            }
                            return Fail(']', i);

                        case ParsingState.Key:
                        {
                            if (jsonString[i] != '}')
                            {
                                goto Label_0169;
                            }
                            i--;
                            key = ParsingState.EndObject;
                            continue;
                        }
                        case ParsingState.Value:
                            ch = jsonString[i];
                            if (ch != '"')
                            {
                                goto Label_0235;
                            }
                            key = ParsingState.String;
                            goto Label_02E3;

                        case ParsingState.KeyValueSeparator:
                            if (jsonString[i] == ':')
                            {
                                goto Label_01AC;
                            }
                            return Fail(':', i);

                        case ParsingState.ValueSeparator:
                            ch2 = jsonString[i];
                            switch (ch2)
                            {
                                case ',':
                                    goto Label_01DC;

                                case ']':
                                    goto Label_0200;

                                case '}':
                                    goto Label_01F5;
                            }
                            return Fail(", } ]", i);

                        case ParsingState.String:
                            str2 = ParseString(jsonString, ref i);
                            if (str2 != null)
                            {
                                goto Label_0309;
                            }
                            return Fail("string value", i);

                        case ParsingState.Number:
                            num2 = ParseNumber(jsonString, ref i);
                            if (!double.IsNaN(num2))
                            {
                                goto Label_0394;
                            }
                            return Fail("valid number", i);

                        case ParsingState.Boolean:
                            if (jsonString[i] != 't')
                            {
                                goto Label_04BE;
                            }
                            if (((jsonString.Length >= (i + 4)) && (jsonString[i + 1] == 'r')) && ((jsonString[i + 2] == 'u') && (jsonString[i + 3] == 'e')))
                            {
                                goto Label_0455;
                            }
                            return Fail("true", i);

                        case ParsingState.Null:
                            if (jsonString[i] != 'n')
                            {
                                goto Label_072A;
                            }
                            if (((jsonString.Length >= (i + 4)) && (jsonString[i + 1] == 'u')) && ((jsonString[i + 2] == 'l') && (jsonString[i + 3] == 'l')))
                            {
                                goto Label_06C6;
                            }
                            return Fail("null", i);

                        default:
                        {
                            continue;
                        }
                    }
                    Value value3 = new JSON.Object();
                    if (value2 != null)
                    {
                        value3.Parent = value2;
                    }
                    value2 = value3;
                    key = ParsingState.Key;
                    continue;
                Label_00B7:
                    if (value2.Parent == null)
                    {
                        return value2.Obj;
                    }
                    JSON.ValueType type = value2.Parent.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type != JSON.ValueType.Array)
                        {
                            return Fail("valid object", i);
                        }
                    }
                    else
                    {
                        value2.Parent.Obj.values[list.Pop<string>()] = new Value(value2.Obj);
                        goto Label_0142;
                    }
                    value2.Parent.Array.Add(new Value(value2.Obj));
                Label_0142:
                    value2 = value2.Parent;
                    key = ParsingState.ValueSeparator;
                    continue;
                Label_0169:
                    str = ParseString(jsonString, ref i);
                    if (str == null)
                    {
                        return Fail("key string", i);
                    }
                    list.Add(str);
                    key = ParsingState.KeyValueSeparator;
                    continue;
                Label_01AC:
                    key = ParsingState.Value;
                    continue;
                Label_01DC:
                    key = (value2.Type != JSON.ValueType.Object) ? ParsingState.Value : ParsingState.Key;
                    continue;
                Label_01F5:
                    key = ParsingState.EndObject;
                    i--;
                    continue;
                Label_0200:
                    key = ParsingState.EndArray;
                    i--;
                    continue;
                Label_0235:
                    if (char.IsDigit(ch) || (ch == '-'))
                    {
                        key = ParsingState.Number;
                    }
                    else
                    {
                        ch2 = ch;
                        switch (ch2)
                        {
                            case '[':
                                key = ParsingState.Array;
                                goto Label_02E3;

                            case ']':
                                if (value2.Type != JSON.ValueType.Array)
                                {
                                    return Fail("valid array", i);
                                }
                                key = ParsingState.EndArray;
                                goto Label_02E3;
                        }
                        switch (ch2)
                        {
                            case 'f':
                            case 't':
                                key = ParsingState.Boolean;
                                break;

                            case 'n':
                                key = ParsingState.Null;
                                break;

                            default:
                                if (ch2 != '{')
                                {
                                    return Fail("beginning of value", i);
                                }
                                key = ParsingState.Object;
                                break;
                        }
                    }
                Label_02E3:
                    i--;
                    continue;
                Label_0309:
                    type = value2.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type == JSON.ValueType.Array)
                        {
                            goto Label_0348;
                        }
                        goto Label_035F;
                    }
                    value2.Obj.values[list.Pop<string>()] = new Value(str2);
                    goto Label_036B;
                Label_0348:
                    value2.Array.Add(str2);
                    goto Label_036B;
                Label_035F:
                    Debug.LogError("Fatal error, current JSON value not valid");
                    return null;
                Label_036B:
                    key = ParsingState.ValueSeparator;
                    continue;
                Label_0394:
                    type = value2.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type == JSON.ValueType.Array)
                        {
                            goto Label_03D3;
                        }
                        goto Label_03EA;
                    }
                    value2.Obj.values[list.Pop<string>()] = new Value(num2);
                    goto Label_03F6;
                Label_03D3:
                    value2.Array.Add(num2);
                    goto Label_03F6;
                Label_03EA:
                    Debug.LogError("Fatal error, current JSON value not valid");
                    return null;
                Label_03F6:
                    key = ParsingState.ValueSeparator;
                    continue;
                Label_0455:
                    type = value2.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type == JSON.ValueType.Array)
                        {
                            goto Label_0493;
                        }
                        goto Label_04A9;
                    }
                    value2.Obj.values[list.Pop<string>()] = new Value(true);
                    goto Label_04B5;
                Label_0493:
                    value2.Array.Add(new Value(true));
                    goto Label_04B5;
                Label_04A9:
                    Debug.LogError("Fatal error, current JSON value not valid");
                    return null;
                Label_04B5:
                    i += 3;
                    goto Label_057C;
                Label_04BE:
                    if (((jsonString.Length < (i + 5)) || (jsonString[i + 1] != 'a')) || (((jsonString[i + 2] != 'l') || (jsonString[i + 3] != 's')) || (jsonString[i + 4] != 'e')))
                    {
                        return Fail("false", i);
                    }
                    type = value2.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type == JSON.ValueType.Array)
                        {
                            goto Label_0556;
                        }
                        goto Label_056C;
                    }
                    value2.Obj.values[list.Pop<string>()] = new Value(false);
                    goto Label_0578;
                Label_0556:
                    value2.Array.Add(new Value(false));
                    goto Label_0578;
                Label_056C:
                    Debug.LogError("Fatal error, current JSON value not valid");
                    return null;
                Label_0578:
                    i += 4;
                Label_057C:
                    key = ParsingState.ValueSeparator;
                    continue;
                Label_059A:
                    value4 = new JSON.Array();
                    if (value2 != null)
                    {
                        value4.Parent = value2;
                    }
                    value2 = value4;
                    key = ParsingState.Value;
                    continue;
                Label_05D5:
                    if (value2.Parent == null)
                    {
                        return value2.Obj;
                    }
                    type = value2.Parent.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type != JSON.ValueType.Array)
                        {
                            return Fail("valid object", i);
                        }
                    }
                    else
                    {
                        value2.Parent.Obj.values[list.Pop<string>()] = new Value(value2.Array);
                        goto Label_0660;
                    }
                    value2.Parent.Array.Add(new Value(value2.Array));
                Label_0660:
                    value2 = value2.Parent;
                    key = ParsingState.ValueSeparator;
                    continue;
                Label_06C6:
                    type = value2.Type;
                    if (type != JSON.ValueType.Object)
                    {
                        if (type == JSON.ValueType.Array)
                        {
                            goto Label_0704;
                        }
                        goto Label_071A;
                    }
                    value2.Obj.values[list.Pop<string>()] = new Value(JSON.ValueType.Null);
                    goto Label_0726;
                Label_0704:
                    value2.Array.Add(new Value(JSON.ValueType.Null));
                    goto Label_0726;
                Label_071A:
                    Debug.LogError("Fatal error, current JSON value not valid");
                    return null;
                Label_0726:
                    i += 3;
                Label_072A:
                    key = ParsingState.ValueSeparator;
                }
                Debug.LogError("Unexpected end of string");
            }
            return null;
        }

        private static double ParseNumber(string str, ref int startPosition)
        {
            double num2;
            if ((startPosition >= str.Length) || (!char.IsDigit(str[startPosition]) && (str[startPosition] != '-')))
            {
                return double.NaN;
            }
            int num = startPosition + 1;
            while (((num < str.Length) && (str[num] != ',')) && ((str[num] != ']') && (str[num] != '}')))
            {
                num++;
            }
            if (!double.TryParse(str.Substring(startPosition, num - startPosition), NumberStyles.Float, CultureInfo.InvariantCulture, out num2))
            {
                return double.NaN;
            }
            startPosition = num - 1;
            return num2;
        }

        private static string ParseString(string str, ref int startPosition)
        {
            if ((str[startPosition] != '"') || ((startPosition + 1) >= str.Length))
            {
                Fail('"', startPosition);
                return null;
            }
            int index = str.IndexOf('"', startPosition + 1);
            if (index <= startPosition)
            {
                Fail('"', startPosition + 1);
                return null;
            }
            while (str[index - 1] == '\\')
            {
                index = str.IndexOf('"', index + 1);
                if (index <= startPosition)
                {
                    Fail('"', startPosition + 1);
                    return null;
                }
            }
            string str2 = string.Empty;
            if (index > (startPosition + 1))
            {
                str2 = str.Substring(startPosition + 1, (index - startPosition) - 1);
            }
            startPosition = index;
            return str2;
        }

        public void Remove(string key)
        {
            if (this.values.ContainsKey(key))
            {
                this.values.Remove(key);
            }
        }

        private static int SkipWhitespace(string str, int pos)
        {
            while ((pos < str.Length) && char.IsWhiteSpace(str[pos]))
            {
                pos++;
            }
            return pos;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.values.GetEnumerator();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('{');
            IEnumerator<KeyValuePair<string, Value>> enumerator = this.values.GetEnumerator();
            try
            {
                while (enumerator.MoveNext())
                {
                    KeyValuePair<string, Value> current = enumerator.Current;
                    builder.Append("\"" + current.Key + "\"");
                    builder.Append(':');
                    builder.Append(current.Value.ToString());
                    builder.Append(',');
                }
            }
            finally
            {
                if (enumerator == null)
                {
                }
                enumerator.Dispose();
            }
            if (this.values.Count > 0)
            {
                builder.Remove(builder.Length - 1, 1);
            }
            builder.Append('}');
            return builder.ToString();
        }

        public Value this[string key]
        {
            get
            {
                return this.GetValue(key);
            }
            set
            {
                this.values[key] = value;
            }
        }

        private enum ParsingState
        {
            Object,
            Array,
            EndObject,
            EndArray,
            Key,
            Value,
            KeyValueSeparator,
            ValueSeparator,
            String,
            Number,
            Boolean,
            Null
        }
    }
}

