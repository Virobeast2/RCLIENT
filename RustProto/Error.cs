namespace RustProto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using RustProto.Proto;
    using System;
    using System.Diagnostics;
    using System.IO;

    [DebuggerNonUserCode]
    public sealed class Error : GeneratedMessage<RustProto.Error, RustProto.Error.Builder>
    {
        private static readonly string[] _errorFieldNames = new string[] { "message", "status" };
        private static readonly uint[] _errorFieldTags = new uint[] { 0x12, 10 };
        private static readonly RustProto.Error defaultInstance = new RustProto.Error().MakeReadOnly();
        private bool hasMessage;
        private bool hasStatus;
        private int memoizedSerializedSize = -1;
        private string message_ = string.Empty;
        public const int MessageFieldNumber = 2;
        private string status_ = string.Empty;
        public const int StatusFieldNumber = 1;

        static Error()
        {
            object.ReferenceEquals(RustProto.Proto.Error.Descriptor, null);
        }

        private Error()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RustProto.Error prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        private RustProto.Error MakeReadOnly()
        {
            return this;
        }

        public static RustProto.Error ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static RustProto.Error ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Error ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Error ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.Error ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Error ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.Error ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Error ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.Error ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.Error ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _errorFieldNames;
            if (this.hasStatus)
            {
                output.WriteString(1, strArray[1], this.Status);
            }
            if (this.hasMessage)
            {
                output.WriteString(2, strArray[0], this.Message);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static RustProto.Error DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RustProto.Error DefaultInstanceForType
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
                return RustProto.Proto.Error.internal__static_RustProto_Error__Descriptor;
            }
        }

        public bool HasMessage
        {
            get
            {
                return this.hasMessage;
            }
        }

        public bool HasStatus
        {
            get
            {
                return this.hasStatus;
            }
        }

        protected override FieldAccessorTable<RustProto.Error, Builder> InternalFieldAccessors
        {
            get
            {
                return RustProto.Proto.Error.internal__static_RustProto_Error__FieldAccessorTable;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasStatus)
                {
                    return false;
                }
                if (!this.hasMessage)
                {
                    return false;
                }
                return true;
            }
        }

        public string Message
        {
            get
            {
                return this.message_;
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
                    if (this.hasStatus)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Status);
                    }
                    if (this.hasMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Message);
                    }
                    memoizedSerializedSize += this.UnknownFields.SerializedSize;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string Status
        {
            get
            {
                return this.status_;
            }
        }

        protected override RustProto.Error ThisMessage
        {
            get
            {
                return this;
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<RustProto.Error, RustProto.Error.Builder>
        {
            private RustProto.Error result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RustProto.Error.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RustProto.Error cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RustProto.Error BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RustProto.Error.Builder Clear()
            {
                this.result = RustProto.Error.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RustProto.Error.Builder ClearMessage()
            {
                this.PrepareBuilder();
                this.result.hasMessage = false;
                this.result.message_ = string.Empty;
                return this;
            }

            public RustProto.Error.Builder ClearStatus()
            {
                this.PrepareBuilder();
                this.result.hasStatus = false;
                this.result.status_ = string.Empty;
                return this;
            }

            public override RustProto.Error.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RustProto.Error.Builder(this.result);
                }
                return new RustProto.Error.Builder().MergeFrom(this.result);
            }

            public override RustProto.Error.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RustProto.Error.Builder MergeFrom(IMessage other)
            {
                if (other is RustProto.Error)
                {
                    return this.MergeFrom((RustProto.Error) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RustProto.Error.Builder MergeFrom(RustProto.Error other)
            {
                if (other != RustProto.Error.DefaultInstance)
                {
                    this.PrepareBuilder();
                    if (other.HasStatus)
                    {
                        this.Status = other.Status;
                    }
                    if (other.HasMessage)
                    {
                        this.Message = other.Message;
                    }
                    this.MergeUnknownFields(other.UnknownFields);
                }
                return this;
            }

            public override RustProto.Error.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RustProto.Error._errorFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RustProto.Error._errorFieldTags[index];
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
                            this.result.hasStatus = input.ReadString(ref this.result.status_);
                            continue;
                        }
                        case 0x12:
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
                    this.result.hasMessage = input.ReadString(ref this.result.message_);
                }
                if (unknownFields != null)
                {
                    this.UnknownFields = unknownFields.Build();
                }
                return this;
            }

            private RustProto.Error PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RustProto.Error result = this.result;
                    this.result = new RustProto.Error();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RustProto.Error.Builder SetMessage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMessage = true;
                this.result.message_ = value;
                return this;
            }

            public RustProto.Error.Builder SetStatus(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasStatus = true;
                this.result.status_ = value;
                return this;
            }

            public override RustProto.Error DefaultInstanceForType
            {
                get
                {
                    return RustProto.Error.DefaultInstance;
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return RustProto.Error.Descriptor;
                }
            }

            public bool HasMessage
            {
                get
                {
                    return this.result.hasMessage;
                }
            }

            public bool HasStatus
            {
                get
                {
                    return this.result.hasStatus;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            public string Message
            {
                get
                {
                    return this.result.Message;
                }
                set
                {
                    this.SetMessage(value);
                }
            }

            protected override RustProto.Error MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Status
            {
                get
                {
                    return this.result.Status;
                }
                set
                {
                    this.SetStatus(value);
                }
            }

            protected override RustProto.Error.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}

