namespace RustProto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using RustProto.Helpers;
    using RustProto.Proto;
    using System;
    using System.Diagnostics;
    using System.IO;

    [DebuggerNonUserCode]
    public sealed class Blueprint : GeneratedMessage<RustProto.Blueprint, RustProto.Blueprint.Builder>
    {
        private static readonly string[] _blueprintFieldNames = new string[] { "id" };
        private static readonly uint[] _blueprintFieldTags = new uint[] { 8 };
        private static readonly RustProto.Blueprint defaultInstance = new RustProto.Blueprint().MakeReadOnly();
        private bool hasId;
        private int id_;
        public const int IdFieldNumber = 1;
        private int memoizedSerializedSize = -1;

        static Blueprint()
        {
            object.ReferenceEquals(RustProto.Proto.Blueprint.Descriptor, null);
        }

        private Blueprint()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RustProto.Blueprint prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        private RustProto.Blueprint MakeReadOnly()
        {
            return this;
        }

        public static RustProto.Blueprint ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static RustProto.Blueprint ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Blueprint ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static Recycler<RustProto.Blueprint, Builder> Recycler()
        {
            return Recycler<RustProto.Blueprint, Builder>.Manufacture();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _blueprintFieldNames;
            if (this.hasId)
            {
                output.WriteInt32(1, strArray[0], this.Id);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static RustProto.Blueprint DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RustProto.Blueprint DefaultInstanceForType
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
                return RustProto.Proto.Blueprint.internal__static_RustProto_Blueprint__Descriptor;
            }
        }

        public bool HasId
        {
            get
            {
                return this.hasId;
            }
        }

        public int Id
        {
            get
            {
                return this.id_;
            }
        }

        protected override FieldAccessorTable<RustProto.Blueprint, Builder> InternalFieldAccessors
        {
            get
            {
                return RustProto.Proto.Blueprint.internal__static_RustProto_Blueprint__FieldAccessorTable;
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
                return true;
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
                    memoizedSerializedSize += this.UnknownFields.SerializedSize;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override RustProto.Blueprint ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<RustProto.Blueprint, RustProto.Blueprint.Builder>
        {
            private RustProto.Blueprint result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RustProto.Blueprint.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RustProto.Blueprint cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RustProto.Blueprint BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RustProto.Blueprint.Builder Clear()
            {
                this.result = RustProto.Blueprint.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RustProto.Blueprint.Builder ClearId()
            {
                this.PrepareBuilder();
                this.result.hasId = false;
                this.result.id_ = 0;
                return this;
            }

            public override RustProto.Blueprint.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RustProto.Blueprint.Builder(this.result);
                }
                return new RustProto.Blueprint.Builder().MergeFrom(this.result);
            }

            public override RustProto.Blueprint.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RustProto.Blueprint.Builder MergeFrom(IMessage other)
            {
                if (other is RustProto.Blueprint)
                {
                    return this.MergeFrom((RustProto.Blueprint) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RustProto.Blueprint.Builder MergeFrom(RustProto.Blueprint other)
            {
                if (other != RustProto.Blueprint.DefaultInstance)
                {
                    this.PrepareBuilder();
                    if (other.HasId)
                    {
                        this.Id = other.Id;
                    }
                    this.MergeUnknownFields(other.UnknownFields);
                }
                return this;
            }

            public override RustProto.Blueprint.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RustProto.Blueprint._blueprintFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RustProto.Blueprint._blueprintFieldTags[index];
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
                    this.result.hasId = input.ReadInt32(ref this.result.id_);
                }
                if (unknownFields != null)
                {
                    this.UnknownFields = unknownFields.Build();
                }
                return this;
            }

            private RustProto.Blueprint PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RustProto.Blueprint result = this.result;
                    this.result = new RustProto.Blueprint();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RustProto.Blueprint.Builder SetId(int value)
            {
                this.PrepareBuilder();
                this.result.hasId = true;
                this.result.id_ = value;
                return this;
            }

            public override RustProto.Blueprint DefaultInstanceForType
            {
                get
                {
                    return RustProto.Blueprint.DefaultInstance;
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return RustProto.Blueprint.Descriptor;
                }
            }

            public bool HasId
            {
                get
                {
                    return this.result.hasId;
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

            protected override RustProto.Blueprint MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override RustProto.Blueprint.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

