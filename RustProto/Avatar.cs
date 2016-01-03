﻿namespace RustProto
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
    public sealed class Avatar : GeneratedMessage<RustProto.Avatar, RustProto.Avatar.Builder>
    {
        private static readonly string[] _avatarFieldNames = new string[] { "ang", "awayEvent", "belt", "blueprints", "inventory", "pos", "vitals", "wearable" };
        private static readonly uint[] _avatarFieldTags = new uint[] { 0x12, 0x42, 0x3a, 0x22, 0x2a, 10, 0x1a, 50 };
        private Quaternion ang_;
        public const int AngFieldNumber = 2;
        private RustProto.AwayEvent awayEvent_;
        public const int AwayEventFieldNumber = 8;
        private PopsicleList<RustProto.Item> belt_ = new PopsicleList<RustProto.Item>();
        public const int BeltFieldNumber = 7;
        private PopsicleList<RustProto.Blueprint> blueprints_ = new PopsicleList<RustProto.Blueprint>();
        public const int BlueprintsFieldNumber = 4;
        private static readonly RustProto.Avatar defaultInstance = new RustProto.Avatar().MakeReadOnly();
        private bool hasAng;
        private bool hasAwayEvent;
        private bool hasPos;
        private bool hasVitals;
        private PopsicleList<RustProto.Item> inventory_ = new PopsicleList<RustProto.Item>();
        public const int InventoryFieldNumber = 5;
        private int memoizedSerializedSize = -1;
        private Vector pos_;
        public const int PosFieldNumber = 1;
        private RustProto.Vitals vitals_;
        public const int VitalsFieldNumber = 3;
        private PopsicleList<RustProto.Item> wearable_ = new PopsicleList<RustProto.Item>();
        public const int WearableFieldNumber = 6;

        static Avatar()
        {
            object.ReferenceEquals(RustProto.Proto.Avatar.Descriptor, null);
        }

        private Avatar()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RustProto.Avatar prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public RustProto.Item GetBelt(int index)
        {
            return this.belt_[index];
        }

        public RustProto.Blueprint GetBlueprints(int index)
        {
            return this.blueprints_[index];
        }

        public RustProto.Item GetInventory(int index)
        {
            return this.inventory_[index];
        }

        public RustProto.Item GetWearable(int index)
        {
            return this.wearable_[index];
        }

        private RustProto.Avatar MakeReadOnly()
        {
            this.blueprints_.MakeReadOnly();
            this.inventory_.MakeReadOnly();
            this.wearable_.MakeReadOnly();
            this.belt_.MakeReadOnly();
            return this;
        }

        public static RustProto.Avatar ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static RustProto.Avatar ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Avatar ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Recycler<RustProto.Avatar, Builder> Recycler()
        {
            return Recycler<RustProto.Avatar, Builder>.Manufacture();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _avatarFieldNames;
            if (this.hasPos)
            {
                output.WriteMessage(1, strArray[5], this.Pos);
            }
            if (this.hasAng)
            {
                output.WriteMessage(2, strArray[0], this.Ang);
            }
            if (this.hasVitals)
            {
                output.WriteMessage(3, strArray[6], this.Vitals);
            }
            if (this.blueprints_.Count > 0)
            {
                output.WriteMessageArray<RustProto.Blueprint>(4, strArray[3], this.blueprints_);
            }
            if (this.inventory_.Count > 0)
            {
                output.WriteMessageArray<RustProto.Item>(5, strArray[4], this.inventory_);
            }
            if (this.wearable_.Count > 0)
            {
                output.WriteMessageArray<RustProto.Item>(6, strArray[7], this.wearable_);
            }
            if (this.belt_.Count > 0)
            {
                output.WriteMessageArray<RustProto.Item>(7, strArray[2], this.belt_);
            }
            if (this.hasAwayEvent)
            {
                output.WriteMessage(8, strArray[1], this.AwayEvent);
            }
            this.UnknownFields.WriteTo(output);
        }

        public Quaternion Ang
        {
            get
            {
                if (this.ang_ == null)
                {
                }
                return Quaternion.DefaultInstance;
            }
        }

        public RustProto.AwayEvent AwayEvent
        {
            get
            {
                if (this.awayEvent_ == null)
                {
                }
                return RustProto.AwayEvent.DefaultInstance;
            }
        }

        public int BeltCount
        {
            get
            {
                return this.belt_.Count;
            }
        }

        public IList<RustProto.Item> BeltList
        {
            get
            {
                return this.belt_;
            }
        }

        public int BlueprintsCount
        {
            get
            {
                return this.blueprints_.Count;
            }
        }

        public IList<RustProto.Blueprint> BlueprintsList
        {
            get
            {
                return this.blueprints_;
            }
        }

        public static RustProto.Avatar DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RustProto.Avatar DefaultInstanceForType
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
                return RustProto.Proto.Avatar.internal__static_RustProto_Avatar__Descriptor;
            }
        }

        public bool HasAng
        {
            get
            {
                return this.hasAng;
            }
        }

        public bool HasAwayEvent
        {
            get
            {
                return this.hasAwayEvent;
            }
        }

        public bool HasPos
        {
            get
            {
                return this.hasPos;
            }
        }

        public bool HasVitals
        {
            get
            {
                return this.hasVitals;
            }
        }

        protected override FieldAccessorTable<RustProto.Avatar, Builder> InternalFieldAccessors
        {
            get
            {
                return RustProto.Proto.Avatar.internal__static_RustProto_Avatar__FieldAccessorTable;
            }
        }

        public int InventoryCount
        {
            get
            {
                return this.inventory_.Count;
            }
        }

        public IList<RustProto.Item> InventoryList
        {
            get
            {
                return this.inventory_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                IEnumerator<RustProto.Blueprint> enumerator = this.BlueprintsList.GetEnumerator();
                try
                {
                    while (enumerator.MoveNext())
                    {
                        RustProto.Blueprint current = enumerator.Current;
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
                IEnumerator<RustProto.Item> enumerator2 = this.InventoryList.GetEnumerator();
                try
                {
                    while (enumerator2.MoveNext())
                    {
                        RustProto.Item item = enumerator2.Current;
                        if (!item.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                finally
                {
                    if (enumerator2 == null)
                    {
                    }
                    enumerator2.Dispose();
                }
                IEnumerator<RustProto.Item> enumerator3 = this.WearableList.GetEnumerator();
                try
                {
                    while (enumerator3.MoveNext())
                    {
                        RustProto.Item item2 = enumerator3.Current;
                        if (!item2.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                finally
                {
                    if (enumerator3 == null)
                    {
                    }
                    enumerator3.Dispose();
                }
                IEnumerator<RustProto.Item> enumerator4 = this.BeltList.GetEnumerator();
                try
                {
                    while (enumerator4.MoveNext())
                    {
                        RustProto.Item item3 = enumerator4.Current;
                        if (!item3.IsInitialized)
                        {
                            return false;
                        }
                    }
                }
                finally
                {
                    if (enumerator4 == null)
                    {
                    }
                    enumerator4.Dispose();
                }
                if (this.HasAwayEvent && !this.AwayEvent.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public Vector Pos
        {
            get
            {
                if (this.pos_ == null)
                {
                }
                return Vector.DefaultInstance;
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
                    if (this.hasPos)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.Pos);
                    }
                    if (this.hasAng)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Ang);
                    }
                    if (this.hasVitals)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.Vitals);
                    }
                    IEnumerator<RustProto.Blueprint> enumerator = this.BlueprintsList.GetEnumerator();
                    try
                    {
                        while (enumerator.MoveNext())
                        {
                            RustProto.Blueprint current = enumerator.Current;
                            memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(4, current);
                        }
                    }
                    finally
                    {
                        if (enumerator == null)
                        {
                        }
                        enumerator.Dispose();
                    }
                    IEnumerator<RustProto.Item> enumerator2 = this.InventoryList.GetEnumerator();
                    try
                    {
                        while (enumerator2.MoveNext())
                        {
                            RustProto.Item item = enumerator2.Current;
                            memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, item);
                        }
                    }
                    finally
                    {
                        if (enumerator2 == null)
                        {
                        }
                        enumerator2.Dispose();
                    }
                    IEnumerator<RustProto.Item> enumerator3 = this.WearableList.GetEnumerator();
                    try
                    {
                        while (enumerator3.MoveNext())
                        {
                            RustProto.Item item2 = enumerator3.Current;
                            memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, item2);
                        }
                    }
                    finally
                    {
                        if (enumerator3 == null)
                        {
                        }
                        enumerator3.Dispose();
                    }
                    IEnumerator<RustProto.Item> enumerator4 = this.BeltList.GetEnumerator();
                    try
                    {
                        while (enumerator4.MoveNext())
                        {
                            RustProto.Item item3 = enumerator4.Current;
                            memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, item3);
                        }
                    }
                    finally
                    {
                        if (enumerator4 == null)
                        {
                        }
                        enumerator4.Dispose();
                    }
                    if (this.hasAwayEvent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.AwayEvent);
                    }
                    memoizedSerializedSize += this.UnknownFields.SerializedSize;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override RustProto.Avatar ThisMessage
        {
            get
            {
                return this;
            }
        }

        public RustProto.Vitals Vitals
        {
            get
            {
                if (this.vitals_ == null)
                {
                }
                return RustProto.Vitals.DefaultInstance;
            }
        }

        public int WearableCount
        {
            get
            {
                return this.wearable_.Count;
            }
        }

        public IList<RustProto.Item> WearableList
        {
            get
            {
                return this.wearable_;
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<RustProto.Avatar, RustProto.Avatar.Builder>
        {
            private RustProto.Avatar result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RustProto.Avatar.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RustProto.Avatar cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public RustProto.Avatar.Builder AddBelt(RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.belt_.Add(value);
                return this;
            }

            public RustProto.Avatar.Builder AddBelt(RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.belt_.Add(builderForValue.Build());
                return this;
            }

            public RustProto.Avatar.Builder AddBlueprints(RustProto.Blueprint value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blueprints_.Add(value);
                return this;
            }

            public RustProto.Avatar.Builder AddBlueprints(RustProto.Blueprint.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blueprints_.Add(builderForValue.Build());
                return this;
            }

            public RustProto.Avatar.Builder AddInventory(RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.inventory_.Add(value);
                return this;
            }

            public RustProto.Avatar.Builder AddInventory(RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.inventory_.Add(builderForValue.Build());
                return this;
            }

            public RustProto.Avatar.Builder AddRangeBelt(IEnumerable<RustProto.Item> values)
            {
                this.PrepareBuilder();
                this.result.belt_.Add(values);
                return this;
            }

            public RustProto.Avatar.Builder AddRangeBlueprints(IEnumerable<RustProto.Blueprint> values)
            {
                this.PrepareBuilder();
                this.result.blueprints_.Add(values);
                return this;
            }

            public RustProto.Avatar.Builder AddRangeInventory(IEnumerable<RustProto.Item> values)
            {
                this.PrepareBuilder();
                this.result.inventory_.Add(values);
                return this;
            }

            public RustProto.Avatar.Builder AddRangeWearable(IEnumerable<RustProto.Item> values)
            {
                this.PrepareBuilder();
                this.result.wearable_.Add(values);
                return this;
            }

            public RustProto.Avatar.Builder AddWearable(RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.wearable_.Add(value);
                return this;
            }

            public RustProto.Avatar.Builder AddWearable(RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.wearable_.Add(builderForValue.Build());
                return this;
            }

            public override RustProto.Avatar BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RustProto.Avatar.Builder Clear()
            {
                this.result = RustProto.Avatar.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RustProto.Avatar.Builder ClearAng()
            {
                this.PrepareBuilder();
                this.result.hasAng = false;
                this.result.ang_ = null;
                return this;
            }

            public RustProto.Avatar.Builder ClearAwayEvent()
            {
                this.PrepareBuilder();
                this.result.hasAwayEvent = false;
                this.result.awayEvent_ = null;
                return this;
            }

            public RustProto.Avatar.Builder ClearBelt()
            {
                this.PrepareBuilder();
                this.result.belt_.Clear();
                return this;
            }

            public RustProto.Avatar.Builder ClearBlueprints()
            {
                this.PrepareBuilder();
                this.result.blueprints_.Clear();
                return this;
            }

            public RustProto.Avatar.Builder ClearInventory()
            {
                this.PrepareBuilder();
                this.result.inventory_.Clear();
                return this;
            }

            public RustProto.Avatar.Builder ClearPos()
            {
                this.PrepareBuilder();
                this.result.hasPos = false;
                this.result.pos_ = null;
                return this;
            }

            public RustProto.Avatar.Builder ClearVitals()
            {
                this.PrepareBuilder();
                this.result.hasVitals = false;
                this.result.vitals_ = null;
                return this;
            }

            public RustProto.Avatar.Builder ClearWearable()
            {
                this.PrepareBuilder();
                this.result.wearable_.Clear();
                return this;
            }

            public override RustProto.Avatar.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RustProto.Avatar.Builder(this.result);
                }
                return new RustProto.Avatar.Builder().MergeFrom(this.result);
            }

            public RustProto.Item GetBelt(int index)
            {
                return this.result.GetBelt(index);
            }

            public RustProto.Blueprint GetBlueprints(int index)
            {
                return this.result.GetBlueprints(index);
            }

            public RustProto.Item GetInventory(int index)
            {
                return this.result.GetInventory(index);
            }

            public RustProto.Item GetWearable(int index)
            {
                return this.result.GetWearable(index);
            }

            public RustProto.Avatar.Builder MergeAng(Quaternion value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAng && (this.result.ang_ != Quaternion.DefaultInstance))
                {
                    this.result.ang_ = Quaternion.CreateBuilder(this.result.ang_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.ang_ = value;
                }
                this.result.hasAng = true;
                return this;
            }

            public RustProto.Avatar.Builder MergeAwayEvent(RustProto.AwayEvent value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAwayEvent && (this.result.awayEvent_ != RustProto.AwayEvent.DefaultInstance))
                {
                    this.result.awayEvent_ = RustProto.AwayEvent.CreateBuilder(this.result.awayEvent_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.awayEvent_ = value;
                }
                this.result.hasAwayEvent = true;
                return this;
            }

            public override RustProto.Avatar.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RustProto.Avatar.Builder MergeFrom(IMessage other)
            {
                if (other is RustProto.Avatar)
                {
                    return this.MergeFrom((RustProto.Avatar) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RustProto.Avatar.Builder MergeFrom(RustProto.Avatar other)
            {
                if (other != RustProto.Avatar.DefaultInstance)
                {
                    this.PrepareBuilder();
                    if (other.HasPos)
                    {
                        this.MergePos(other.Pos);
                    }
                    if (other.HasAng)
                    {
                        this.MergeAng(other.Ang);
                    }
                    if (other.HasVitals)
                    {
                        this.MergeVitals(other.Vitals);
                    }
                    if (other.blueprints_.Count != 0)
                    {
                        this.result.blueprints_.Add(other.blueprints_);
                    }
                    if (other.inventory_.Count != 0)
                    {
                        this.result.inventory_.Add(other.inventory_);
                    }
                    if (other.wearable_.Count != 0)
                    {
                        this.result.wearable_.Add(other.wearable_);
                    }
                    if (other.belt_.Count != 0)
                    {
                        this.result.belt_.Add(other.belt_);
                    }
                    if (other.HasAwayEvent)
                    {
                        this.MergeAwayEvent(other.AwayEvent);
                    }
                    this.MergeUnknownFields(other.UnknownFields);
                }
                return this;
            }

            public override RustProto.Avatar.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RustProto.Avatar._avatarFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RustProto.Avatar._avatarFieldTags[index];
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

                        case 10:
                        {
                            Vector.Builder builder = Vector.CreateBuilder();
                            if (this.result.hasPos)
                            {
                                builder.MergeFrom(this.Pos);
                            }
                            input.ReadMessage(builder, extensionRegistry);
                            this.Pos = builder.BuildPartial();
                            continue;
                        }
                        case 0x12:
                        {
                            Quaternion.Builder builder3 = Quaternion.CreateBuilder();
                            if (this.result.hasAng)
                            {
                                builder3.MergeFrom(this.Ang);
                            }
                            input.ReadMessage(builder3, extensionRegistry);
                            this.Ang = builder3.BuildPartial();
                            continue;
                        }
                        case 0x1a:
                        {
                            RustProto.Vitals.Builder builder4 = RustProto.Vitals.CreateBuilder();
                            if (this.result.hasVitals)
                            {
                                builder4.MergeFrom(this.Vitals);
                            }
                            input.ReadMessage(builder4, extensionRegistry);
                            this.Vitals = builder4.BuildPartial();
                            continue;
                        }
                        case 0x22:
                        {
                            input.ReadMessageArray<RustProto.Blueprint>(num, str, this.result.blueprints_, RustProto.Blueprint.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x2a:
                        {
                            input.ReadMessageArray<RustProto.Item>(num, str, this.result.inventory_, RustProto.Item.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 50:
                        {
                            input.ReadMessageArray<RustProto.Item>(num, str, this.result.wearable_, RustProto.Item.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x3a:
                        {
                            input.ReadMessageArray<RustProto.Item>(num, str, this.result.belt_, RustProto.Item.DefaultInstance, extensionRegistry);
                            continue;
                        }
                        case 0x42:
                        {
                            RustProto.AwayEvent.Builder builder5 = RustProto.AwayEvent.CreateBuilder();
                            if (this.result.hasAwayEvent)
                            {
                                builder5.MergeFrom(this.AwayEvent);
                            }
                            input.ReadMessage(builder5, extensionRegistry);
                            this.AwayEvent = builder5.BuildPartial();
                            continue;
                        }
                    }
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
                }
                if (unknownFields != null)
                {
                    this.UnknownFields = unknownFields.Build();
                }
                return this;
            }

            public RustProto.Avatar.Builder MergePos(Vector value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPos && (this.result.pos_ != Vector.DefaultInstance))
                {
                    this.result.pos_ = Vector.CreateBuilder(this.result.pos_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.pos_ = value;
                }
                this.result.hasPos = true;
                return this;
            }

            public RustProto.Avatar.Builder MergeVitals(RustProto.Vitals value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasVitals && (this.result.vitals_ != RustProto.Vitals.DefaultInstance))
                {
                    this.result.vitals_ = RustProto.Vitals.CreateBuilder(this.result.vitals_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.vitals_ = value;
                }
                this.result.hasVitals = true;
                return this;
            }

            private RustProto.Avatar PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RustProto.Avatar result = this.result;
                    this.result = new RustProto.Avatar();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RustProto.Avatar.Builder SetAng(Quaternion value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAng = true;
                this.result.ang_ = value;
                return this;
            }

            public RustProto.Avatar.Builder SetAng(Quaternion.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAng = true;
                this.result.ang_ = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetAwayEvent(RustProto.AwayEvent value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAwayEvent = true;
                this.result.awayEvent_ = value;
                return this;
            }

            public RustProto.Avatar.Builder SetAwayEvent(RustProto.AwayEvent.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAwayEvent = true;
                this.result.awayEvent_ = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetBelt(int index, RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.belt_[index] = value;
                return this;
            }

            public RustProto.Avatar.Builder SetBelt(int index, RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.belt_[index] = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetBlueprints(int index, RustProto.Blueprint value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.blueprints_[index] = value;
                return this;
            }

            public RustProto.Avatar.Builder SetBlueprints(int index, RustProto.Blueprint.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.blueprints_[index] = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetInventory(int index, RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.inventory_[index] = value;
                return this;
            }

            public RustProto.Avatar.Builder SetInventory(int index, RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.inventory_[index] = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetPos(Vector value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPos = true;
                this.result.pos_ = value;
                return this;
            }

            public RustProto.Avatar.Builder SetPos(Vector.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPos = true;
                this.result.pos_ = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetVitals(RustProto.Vitals value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVitals = true;
                this.result.vitals_ = value;
                return this;
            }

            public RustProto.Avatar.Builder SetVitals(RustProto.Vitals.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasVitals = true;
                this.result.vitals_ = builderForValue.Build();
                return this;
            }

            public RustProto.Avatar.Builder SetWearable(int index, RustProto.Item value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.wearable_[index] = value;
                return this;
            }

            public RustProto.Avatar.Builder SetWearable(int index, RustProto.Item.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.wearable_[index] = builderForValue.Build();
                return this;
            }

            public Quaternion Ang
            {
                get
                {
                    return this.result.Ang;
                }
                set
                {
                    this.SetAng(value);
                }
            }

            public RustProto.AwayEvent AwayEvent
            {
                get
                {
                    return this.result.AwayEvent;
                }
                set
                {
                    this.SetAwayEvent(value);
                }
            }

            public int BeltCount
            {
                get
                {
                    return this.result.BeltCount;
                }
            }

            public IPopsicleList<RustProto.Item> BeltList
            {
                get
                {
                    return this.PrepareBuilder().belt_;
                }
            }

            public int BlueprintsCount
            {
                get
                {
                    return this.result.BlueprintsCount;
                }
            }

            public IPopsicleList<RustProto.Blueprint> BlueprintsList
            {
                get
                {
                    return this.PrepareBuilder().blueprints_;
                }
            }

            public override RustProto.Avatar DefaultInstanceForType
            {
                get
                {
                    return RustProto.Avatar.DefaultInstance;
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return RustProto.Avatar.Descriptor;
                }
            }

            public bool HasAng
            {
                get
                {
                    return this.result.hasAng;
                }
            }

            public bool HasAwayEvent
            {
                get
                {
                    return this.result.hasAwayEvent;
                }
            }

            public bool HasPos
            {
                get
                {
                    return this.result.hasPos;
                }
            }

            public bool HasVitals
            {
                get
                {
                    return this.result.hasVitals;
                }
            }

            public int InventoryCount
            {
                get
                {
                    return this.result.InventoryCount;
                }
            }

            public IPopsicleList<RustProto.Item> InventoryList
            {
                get
                {
                    return this.PrepareBuilder().inventory_;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override RustProto.Avatar MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public Vector Pos
            {
                get
                {
                    return this.result.Pos;
                }
                set
                {
                    this.SetPos(value);
                }
            }

            protected override RustProto.Avatar.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public RustProto.Vitals Vitals
            {
                get
                {
                    return this.result.Vitals;
                }
                set
                {
                    this.SetVitals(value);
                }
            }

            public int WearableCount
            {
                get
                {
                    return this.result.WearableCount;
                }
            }

            public IPopsicleList<RustProto.Item> WearableList
            {
                get
                {
                    return this.PrepareBuilder().wearable_;
                }
            }
        }
    }
}

