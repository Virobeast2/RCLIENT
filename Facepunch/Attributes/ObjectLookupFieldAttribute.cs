namespace Facepunch.Attributes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine;

    public abstract class ObjectLookupFieldAttribute : FieldAttribute
    {
        private readonly System.Type attributeMinimumType = typeof(UnityEngine.Object);
        public readonly PrefabLookupKinds Kinds;
        private System.Type minType;
        public readonly System.Type[] RequiredInterfaces;
        private Facepunch.Attributes.SearchMode searchMode;
        private readonly Facepunch.Attributes.SearchMode searchModeDefault = Facepunch.Attributes.SearchMode.MainAsset;

        protected ObjectLookupFieldAttribute(PrefabLookupKinds kinds, System.Type minimumType, Facepunch.Attributes.SearchMode searchModeDefault, System.Type[] interfaceTypes)
        {
            this.Kinds = kinds;
            this.MinimumType = minimumType;
            if (searchModeDefault != Facepunch.Attributes.SearchMode.Default)
            {
                this.searchModeDefault = searchModeDefault;
            }
            if (interfaceTypes == null)
            {
            }
            this.RequiredInterfaces = Empty.TypeArray;
        }

        protected virtual bool CompliantMinimumType(System.Type type)
        {
            return true;
        }

        public CustomLookupResult Confirm(UnityEngine.Object obj)
        {
            bool flag;
            CustomLookupResult failConfirmException;
            if (!this.AllowNull)
            {
                if (obj == null)
                {
                    return CustomLookupResult.FailNull;
                }
                flag = false;
            }
            else
            {
                flag = obj == 0;
            }
            if (!flag)
            {
                System.Type type;
                try
                {
                    type = obj.GetType();
                }
                catch (Exception exception)
                {
                    Debug.LogException(exception, obj);
                    return CustomLookupResult.FailNull;
                }
                try
                {
                    failConfirmException = this.CustomConfirm(obj, false, type);
                }
                catch (Exception exception2)
                {
                    Debug.LogException(exception2, obj);
                    failConfirmException = CustomLookupResult.FailConfirmException;
                }
            }
            else
            {
                try
                {
                    failConfirmException = this.CustomConfirm(null, true, null);
                }
                catch (Exception exception3)
                {
                    Debug.LogException(exception3);
                    failConfirmException = CustomLookupResult.FailConfirmException;
                }
            }
            if (failConfirmException == CustomLookupResult.Fallback)
            {
                return CustomLookupResult.AcceptConfirmed;
            }
            return failConfirmException;
        }

        protected virtual CustomLookupResult CustomConfirm(UnityEngine.Object obj, bool isNull, System.Type type)
        {
            return CustomLookupResult.Fallback;
        }

        protected virtual CustomLookupResult CustomLookup(object value, System.Type type, ref UnityEngine.Object find)
        {
            return CustomLookupResult.Fallback;
        }

        public CustomLookupResult Lookup(object value, out UnityEngine.Object find)
        {
            return this.Lookup(value, this.MinimumType, out find);
        }

        public CustomLookupResult Lookup<TObj>(object value, out TObj find) where TObj: UnityEngine.Object
        {
            return this.Lookup<TObj>(value, typeof(TObj), out find);
        }

        public CustomLookupResult Lookup(object value, System.Type type, out UnityEngine.Object find)
        {
            CustomLookupResult accept;
            find = null;
            if (!this.MinimumType.IsAssignableFrom(type))
            {
                return CustomLookupResult.FailCast;
            }
            foreach (System.Type type2 in this.RequiredInterfaces)
            {
                if (!type2.IsAssignableFrom(type))
                {
                    return CustomLookupResult.FailInterface;
                }
            }
            try
            {
                accept = this.CustomLookup(value, type, ref find);
            }
            catch (Exception exception)
            {
                Debug.LogException(exception, find);
                return CustomLookupResult.FailCustomException;
            }
            switch (accept)
            {
                case CustomLookupResult.Fallback:
                    accept = CustomLookupResult.Accept;
                    break;

                case CustomLookupResult.Accept:
                    try
                    {
                        accept = this.Confirm(find);
                    }
                    catch (Exception exception2)
                    {
                        Debug.LogException(exception2, find);
                        return CustomLookupResult.FailConfirmException;
                    }
                    break;
            }
            return accept;
        }

        public CustomLookupResult Lookup<TObj>(object value, System.Type type, out TObj find) where TObj: UnityEngine.Object
        {
            UnityEngine.Object obj2;
            CustomLookupResult result;
            if (!typeof(TObj).IsAssignableFrom(type))
            {
                throw new ArgumentOutOfRangeException("type", type, "type is not assignable to the generic " + typeof(TObj));
            }
            try
            {
                result = this.Lookup(value, typeof(TObj), out obj2);
            }
            catch (Exception exception)
            {
                Debug.LogException(exception);
                find = null;
                return CustomLookupResult.FailCustomException;
            }
            if (result > CustomLookupResult.Fallback)
            {
                try
                {
                    find = (TObj) obj2;
                }
                catch (Exception exception2)
                {
                    Debug.LogException(exception2, obj2);
                    find = null;
                    return CustomLookupResult.FailCast;
                }
                return result;
            }
            try
            {
                find = (TObj) obj2;
            }
            catch
            {
                find = null;
            }
            return result;
        }

        public bool AllowNull { get; set; }

        public System.Type MinimumType
        {
            get
            {
                if (this.minType == null)
                {
                }
                return this.attributeMinimumType;
            }
            set
            {
                if (((value != null) && !this.attributeMinimumType.IsAssignableFrom(value)) && !this.CompliantMinimumType(value))
                {
                    throw new ArgumentOutOfRangeException("value", value, "The type is not assignable given restrictions");
                }
                this.minType = value;
            }
        }

        public Facepunch.Attributes.SearchMode SearchMode
        {
            get
            {
                return ((this.searchMode != Facepunch.Attributes.SearchMode.Default) ? this.searchMode : this.searchModeDefault);
            }
            protected set
            {
                this.searchMode = value;
            }
        }

        private static class Empty
        {
            public static readonly System.Type[] TypeArray = new System.Type[0];
        }
    }
}

