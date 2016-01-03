namespace RustProto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Collections;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using RustProto.Helpers;
    using RustProto.Proto;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;

    [DebuggerNonUserCode]
    public sealed class Item : GeneratedMessage<RustProto.Item, RustProto.Item.Builder>
    {
        private static readonly string[] _itemFieldNames = new string[] { "condition", "count", "id", "maxcondition", "name", "slot", "subitem", "subslots" };
        private static readonly uint[] _itemFieldTags = new uint[] { 0x3d, 0x20, 8, 0x45, 0x12, 0x18, 0x2a, 0x30 };
        private float condition_;
        public const int ConditionFieldNumber = 7;
        private int count_;
        public const int CountFieldNumber = 4;
        private static readonly RustProto.Item defaultInstance = new RustProto.Item().MakeReadOnly();
        private bool hasCondition;
        private bool hasCount;
        private bool hasId;
        private bool hasMaxcondition;
        private bool hasName;
        private bool hasSlot;
        private bool hasSubslots;
        private int id_;
        public const int IdFieldNumber = 1;
        private float maxcondition_;
        public const int MaxconditionFieldNumber = 8;
        private int memoizedSerializedSize = -1;
        private string name_ = string.Empty;
        public const int NameFieldNumber = 2;
        private int slot_;
        public const int SlotFieldNumber = 3;
        private PopsicleList<RustProto.Item> subitem_ = new PopsicleList<RustProto.Item>();
        public const int SubitemFieldNumber = 5;
        private int subslots_;
        public const int SubslotsFieldNumber = 6;

        static Item()
        {
            object.ReferenceEquals(RustProto.Proto.Item.Descriptor, null);
        }

        private Item()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RustProto.Item prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public RustProto.Item GetSubitem(int index)
        {
            return this.subitem_[index];
        }

        private RustProto.Item MakeReadOnly()
        {
            this.subitem_.MakeReadOnly();
            return this;
        }

        public static RustProto.Item ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static RustProto.Item ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Item ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Item ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Item ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Item ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Item ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Item ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Item ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Item ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Recycler<RustProto.Item, Builder> Recycler()
        {
            return Recycler<RustProto.Item, Builder>.Manufacture();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _itemFieldNames;
            if (this.hasId)
            {
                output.WriteInt32(1, strArray[2], this.Id);
            }
            if (this.hasName)
            {
                output.WriteString(2, strArray[4], this.Name);
            }
            if (this.hasSlot)
            {
                output.WriteInt32(3, strArray[5], this.Slot);
            }
            if (this.hasCount)
            {
                output.WriteInt32(4, strArray[1], this.Count);
            }
            if (this.subitem_.Count > 0)
            {
                output.WriteMessageArray<RustProto.Item>(5, strArray[6], this.subitem_);
            }
            if (this.hasSubslots)
            {
                output.WriteInt32(6, strArray[7], this.Subslots);
            }
            if (this.hasCondition)
            {
                output.WriteFloat(7, strArray[0], this.Condition);
            }
            if (this.hasMaxcondition)
            {
                output.WriteFloat(8, strArray[3], this.Maxcondition);
            }
            this.UnknownFields.WriteTo(output);
        }

        public float Condition
        {
            get
            {
                return this.condition_;
            }
        }

        public int Count
        {
            get
            {
                return this.count_;
            }
        }

        public static RustProto.Item DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RustProto.Item DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public static MessageDescriptor Descriptor
        {
            get
            {
                return RustProto.Proto.Item.internal__static_RustProto_Item__Descriptor;
            }
        }

        public bool HasCondition
        {
            get
            {
                return this.hasCondition;
            }
        }

        public bool HasCount
        {
            get
            {
                return this.hasCount;
            }
        }

        public bool HasId
        {
            get
            {
                return this.hasId;
            }
        }

        public bool HasMaxcondition
        {
            get
            {
                return this.hasMaxcondition;
            }
        }

        public bool HasName
        {
            get
            {
                return this.hasName;
            }
        }

        public bool HasSlot
        {
            get
            {
                return this.hasSlot;
            }
        }

        public bool HasSubslots
        {
            get
            {
                return this.hasSubslots;
            }
        }

        public int Id
        {
            get
            {
                return this.id_;
            }
        }

        protected override FieldAccessorTable<RustProto.Item, Builder> InternalFieldAccessors
        {
            get
            {
                return RustProto.Proto.Item.internal__static_RustProto_Item__FieldAccessorTable;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasId)
                {
                    return false;
                }
                IEnumerator<RustProto.Item> enumerator = this.SubitemList.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        RustProto.Item current = enumerator.Current;
                        if (!current.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                finally
                {
                    if (enumerator == null)
                    {
                    }
                    enumerator.Dispose();
                }
                return true;
            }
        }

        public float Maxcondition
        {
            get
            {
                return this.maxcondition_;
            }
        }

        public string Name
        {
            get
            {
                return this.name_;
            }
        }

        public override int SerializedSize
        {
            get
            {
                int memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize == -1)
                {
                    memoizedSerializedSize = 0;
                    if (this.hasId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(1, this.Id);
                    }
                    if (this.hasName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Name);
                    }
                    if (this.hasSlot)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(3, this.Slot);
                    }
                    if (this.hasCount)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(4, this.Count);
                    }
                    if (this.hasSubslots)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeInt32Size(6, this.Subslots);
                    }
                    if (this.hasCondition)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeFloatSize(7, this.Condition);
                    }
                    if (this.hasMaxcondition)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeFloatSize(8, this.Maxcondition);
                    }
                    IEnumerator<RustProto.Item> enumerator = this.SubitemList.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            RustProto.Item current = enumerator.Current;
                            memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, current);
                        }
                    }
                    finally
                    {
                        if (enumerator == null)
                        {
                        }
                        enumerator.Dispose();
                    }
                    memoizedSerializedSize += this.UnknownFields.SerializedSize;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public int Slot
        {
            get
            {
                return this.slot_;
            }
        }

        public int SubitemCount
        {
            get
            {
                return this.subitem_.Count;
            }
        }

        public IList<RustProto.Item> SubitemList
        {
            get
            {
                return this.subitem_;
            }
        }

        public int Subslots
        {
            get
            {
                return this.subslots_;
            }
        }

        protected override RustProto.Item ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<RustProto.Item, RustProto.Item.Builder>
        {
            private RustProto.Item result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RustProto.Item.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RustProto.Item cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public RustProto.Item.Builder AddRangeSubitem(IEnumerable<RustProto.Item> values)
            {
                this.PrepareBuilder();
                this.result.subitem_.Add(values);
                return this;
            }

            public RustProto.Item.Builder AddSubitem(RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.subitem_.Add(value);
                return this;
            }

            public RustProto.Item.Builder AddSubitem(RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.subitem_.Add(builderForValue.Build());
                return this;
            }

            public override RustProto.Item BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RustProto.Item.Builder Clear()
            {
                this.result = RustProto.Item.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RustProto.Item.Builder ClearCondition()
            {
                this.PrepareBuilder();
                this.result.hasCondition = false;
                this.result.condition_ = 0f;
                return this;
            }

            public RustProto.Item.Builder ClearCount()
            {
                this.PrepareBuilder();
                this.result.hasCount = false;
                this.result.count_ = 0;
                return this;
            }

            public RustProto.Item.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0;
                return this;
            }

            public RustProto.Item.Builder ClearMaxcondition()
            {
                this.PrepareBuilder();
                this.result.hasMaxcondition = false;
                this.result.maxcondition_ = 0f;
                return this;
            }

            public RustProto.Item.Builder ClearName()
            {
                this.PrepareBuilder();
                this.result.hasName = false;
                this.result.name_ = string.Empty;
                return this;
            }

            public RustProto.Item.Builder ClearSlot()
            {
                this.PrepareBuilder();
                this.result.hasSlot = false;
                this.result.slot_ = 0;
                return this;
            }

            public RustProto.Item.Builder ClearSubitem()
            {
                this.PrepareBuilder();
                this.result.subitem_.Clear();
                return this;
            }

            public RustProto.Item.Builder ClearSubslots()
            {
                this.PrepareBuilder();
                this.result.hasSubslots = false;
                this.result.subslots_ = 0;
                return this;
            }

            public override RustProto.Item.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RustProto.Item.Builder(this.result);
                }
                return new RustProto.Item.Builder().MergeFrom(this.result);
            }

            public RustProto.Item GetSubitem(int index)
            {
                return this.result.GetSubitem(index);
            }

            public override RustProto.Item.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RustProto.Item.Builder MergeFrom(IMessage other)
            {
                if (other is RustProto.Item)
                {
                    return this.MergeFrom((RustProto.Item) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RustProto.Item.Builder MergeFrom(RustProto.Item other)
            {
                if (other != RustProto.Item.DefaultInstance)
                {
                    this.PrepareBuilder();
                    if (other.HasId)
                    {
                        this.Id = other.Id;
                    }
                    if (other.HasName)
                    {
                        this.Name = other.Name;
                    }
                    if (other.HasSlot)
                    {
                        this.Slot = other.Slot;
                    }
                    if (other.HasCount)
                    {
                        this.Count = other.Count;
                    }
                    if (other.HasSubslots)
                    {
                        this.Subslots = other.Subslots;
                    }
                    if (other.HasCondition)
                    {
                        this.Condition = other.Condition;
                    }
                    if (other.HasMaxcondition)
                    {
                        this.Maxcondition = other.Maxcondition;
                    }
                    if (other.subitem_.Count != 0)
                    {
                        this.result.subitem_.Add(other.subitem_);
                    }
                    this.MergeUnknownFields(other.UnknownFields);
                }
                return this;
            }

            public override RustProto.Item.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RustProto.Item._itemFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RustProto.Item._itemFieldTags[index];
                        }
                        else
                        {
                            if (unknownFields == null)
                            {
                                unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, unknownFields, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                        {
                            this.result.hasId = input.ReadInt32(ref this.result.id_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasName = input.ReadString(ref this.result.name_);
                            continue;
                        }
                        case 0x18:
                        {
                            this.result.hasSlot = input.ReadInt32(ref this.result.slot_);
                            continue;
                        }
                        case 0x20:
                        {
                            this.result.hasCount = input.ReadInt32(ref this.result.count_);
                            continue;
                        }
                        case 0x2a:
                        {
                            input.ReadMessageArray<RustProto.Item>(num, str, this.result.subitem_, RustProto.Item.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x30:
                        {
                            this.result.hasSubslots = input.ReadInt32(ref this.result.subslots_);
                            continue;
                        }
                        case 0x3d:
                        {
                            this.result.hasCondition = input.ReadFloat(ref this.result.condition_);
                            continue;
                        }
                        case 0x45:
                            break;

                        default:
                        {
                            if (WireFormat.IsEndGroupTag(num))
                            {
                                if (unknownFields != null)
                                {
                                    this.UnknownFields = unknownFields.Build();
                                }
                                return this;
                            }
                            if (unknownFields == null)
                            {
                                unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                            }
                            this.ParseUnknownField(input, unknownFields, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    this.result.hasMaxcondition = input.ReadFloat(ref this.result.maxcondition_);
                }
                if (unknownFields != null)
                {
                    this.UnknownFields = unknownFields.Build();
                }
                return this;
            }

            private RustProto.Item PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RustProto.Item result = this.result;
                    this.result = new RustProto.Item();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RustProto.Item.Builder SetCondition(float value)
            {
                this.PrepareBuilder();
                this.result.hasCondition = true;
                this.result.condition_ = value;
                return this;
            }

            public RustProto.Item.Builder SetCount(int value)
            {
                this.PrepareBuilder();
                this.result.hasCount = true;
                this.result.count_ = value;
                return this;
            }

            public RustProto.Item.Builder SetId(int value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public RustProto.Item.Builder SetMaxcondition(float value)
            {
                this.PrepareBuilder();
                this.result.hasMaxcondition = true;
                this.result.maxcondition_ = value;
                return this;
            }

            public RustProto.Item.Builder SetName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasName = true;
                this.result.name_ = value;
                return this;
            }

            public RustProto.Item.Builder SetSlot(int value)
            {
                this.PrepareBuilder();
                this.result.hasSlot = true;
                this.result.slot_ = value;
                return this;
            }

            public RustProto.Item.Builder SetSubitem(int index, RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.subitem_[index] = value;
                return this;
            }

            public RustProto.Item.Builder SetSubitem(int index, RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.subitem_[index] = builderForValue.Build();
                return this;
            }

            public RustProto.Item.Builder SetSubslots(int value)
            {
                this.PrepareBuilder();
                this.result.hasSubslots = true;
                this.result.subslots_ = value;
                return this;
            }

            public float Condition
            {
                get
                {
                    return this.result.Condition;
                }
                set
                {
                    this.SetCondition(value);
                }
            }

            public int Count
            {
                get
                {
                    return this.result.Count;
                }
                set
                {
                    this.SetCount(value);
                }
            }

            public override RustProto.Item DefaultInstanceForType
            {
                get
                {
                    return RustProto.Item.DefaultInstance;
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return RustProto.Item.Descriptor;
                }
            }

            public bool HasCondition
            {
                get
                {
                    return this.result.hasCondition;
                }
            }

            public bool HasCount
            {
                get
                {
                    return this.result.hasCount;
                }
            }

            public bool HasId
            {
                get
                {
                    return this.result.hasId;
                }
            }

            public bool HasMaxcondition
            {
                get
                {
                    return this.result.hasMaxcondition;
                }
            }

            public bool HasName
            {
                get
                {
                    return this.result.hasName;
                }
            }

            public bool HasSlot
            {
                get
                {
                    return this.result.hasSlot;
                }
            }

            public bool HasSubslots
            {
                get
                {
                    return this.result.hasSubslots;
                }
            }

            public int Id
            {
                get
                {
                    return this.result.Id;
                }
                set
                {
                    this.SetId(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public float Maxcondition
            {
                get
                {
                    return this.result.Maxcondition;
                }
                set
                {
                    this.SetMaxcondition(value);
                }
            }

            protected override RustProto.Item MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Name
            {
                get
                {
                    return this.result.Name;
                }
                set
                {
                    this.SetName(value);
                }
            }

            public int Slot
            {
                get
                {
                    return this.result.Slot;
                }
                set
                {
                    this.SetSlot(value);
                }
            }

            public int SubitemCount
            {
                get
                {
                    return this.result.SubitemCount;
                }
            }

            public IPopsicleList<RustProto.Item> SubitemList
            {
                get
                {
                    return this.PrepareBuilder().subitem_;
                }
            }

            public int Subslots
            {
                get
                {
                    return this.result.Subslots;
                }
                set
                {
                    this.SetSubslots(value);
                }
            }

            protected override RustProto.Item.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

