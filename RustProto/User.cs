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
    public sealed class User : GeneratedMessage<RustProto.User, RustProto.User.Builder>
    {
        private static readonly string[] _userFieldNames = new string[] { "displayname", "usergroup", "userid" };
        private static readonly uint[] _userFieldTags = new uint[] { 0x12, 0x18, 8 };
        private static readonly RustProto.User defaultInstance = new RustProto.User().MakeReadOnly();
        private string displayname_ = string.Empty;
        public const int DisplaynameFieldNumber = 2;
        private bool hasDisplayname;
        private bool hasUsergroup;
        private bool hasUserid;
        private int memoizedSerializedSize = -1;
        private Types.UserGroup usergroup_;
        public const int UsergroupFieldNumber = 3;
        private ulong userid_;
        public const int UseridFieldNumber = 1;

        static User()
        {
            object.ReferenceEquals(RustProto.Proto.User.Descriptor, null);
        }

        private User()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(RustProto.User prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        private RustProto.User MakeReadOnly()
        {
            return this;
        }

        public static RustProto.User ParseDelimitedFrom(Stream input)
        {
            return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
        }

        public static RustProto.User ParseDelimitedFrom(Stream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.User ParseFrom(ByteString data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.User ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public static RustProto.User ParseFrom(ICodedInputStream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.User ParseFrom(Stream input)
        {
            return CreateBuilder().MergeFrom(input).BuildParsed();
        }

        public static RustProto.User ParseFrom(ByteString data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.User ParseFrom(byte[] data, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(data, extensionRegistry).BuildParsed();
        }

        public static RustProto.User ParseFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
        {
            return CreateBuilder().MergeFrom(input, extensionRegistry).BuildParsed();
        }

        public static RustProto.User ParseFrom(Stream input, ExtensionRegistry extensionRegistry)
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
            string[] strArray = _userFieldNames;
            if (this.hasUserid)
            {
                output.WriteUInt64(1, strArray[2], this.Userid);
            }
            if (this.hasDisplayname)
            {
                output.WriteString(2, strArray[0], this.Displayname);
            }
            if (this.hasUsergroup)
            {
                output.WriteEnum(3, strArray[1], (int) this.Usergroup, this.Usergroup);
            }
            this.UnknownFields.WriteTo(output);
        }

        public static RustProto.User DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override RustProto.User DefaultInstanceForType
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
                return RustProto.Proto.User.internal__static_RustProto_User__Descriptor;
            }
        }

        public string Displayname
        {
            get
            {
                return this.displayname_;
            }
        }

        public bool HasDisplayname
        {
            get
            {
                return this.hasDisplayname;
            }
        }

        public bool HasUsergroup
        {
            get
            {
                return this.hasUsergroup;
            }
        }

        public bool HasUserid
        {
            get
            {
                return this.hasUserid;
            }
        }

        protected override FieldAccessorTable<RustProto.User, Builder> InternalFieldAccessors
        {
            get
            {
                return RustProto.Proto.User.internal__static_RustProto_User__FieldAccessorTable;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasUserid)
                {
                    return false;
                }
                if (!this.hasDisplayname)
                {
                    return false;
                }
                if (!this.hasUsergroup)
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
                    if (this.hasUserid)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt64Size(1, this.Userid);
                    }
                    if (this.hasDisplayname)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Displayname);
                    }
                    if (this.hasUsergroup)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeEnumSize(3, (int) this.Usergroup);
                    }
                    memoizedSerializedSize += this.UnknownFields.SerializedSize;
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override RustProto.User ThisMessage
        {
            get
            {
                return this;
            }
        }

        public Types.UserGroup Usergroup
        {
            get
            {
                return this.usergroup_;
            }
        }

        [CLSCompliant(false)]
        public ulong Userid
        {
            get
            {
                return this.userid_;
            }
        }

        [DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilder<RustProto.User, RustProto.User.Builder>
        {
            private RustProto.User result;
            private bool resultIsReadOnly;

            public Builder()
            {
                this.result = RustProto.User.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(RustProto.User cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override RustProto.User BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override RustProto.User.Builder Clear()
            {
                this.result = RustProto.User.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public RustProto.User.Builder ClearDisplayname()
            {
                this.PrepareBuilder();
                this.result.hasDisplayname = false;
                this.result.displayname_ = string.Empty;
                return this;
            }

            public RustProto.User.Builder ClearUsergroup()
            {
                this.PrepareBuilder();
                this.result.hasUsergroup = false;
                this.result.usergroup_ = RustProto.User.Types.UserGroup.REGULAR;
                return this;
            }

            public RustProto.User.Builder ClearUserid()
            {
                this.PrepareBuilder();
                this.result.hasUserid = false;
                this.result.userid_ = 0L;
                return this;
            }

            public override RustProto.User.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new RustProto.User.Builder(this.result);
                }
                return new RustProto.User.Builder().MergeFrom(this.result);
            }

            public override RustProto.User.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override RustProto.User.Builder MergeFrom(IMessage other)
            {
                if (other is RustProto.User)
                {
                    return this.MergeFrom((RustProto.User) other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override RustProto.User.Builder MergeFrom(RustProto.User other)
            {
                if (other != RustProto.User.DefaultInstance)
                {
                    this.PrepareBuilder();
                    if (other.HasUserid)
                    {
                        this.Userid = other.Userid;
                    }
                    if (other.HasDisplayname)
                    {
                        this.Displayname = other.Displayname;
                    }
                    if (other.HasUsergroup)
                    {
                        this.Usergroup = other.Usergroup;
                    }
                    this.MergeUnknownFields(other.UnknownFields);
                }
                return this;
            }

            public override RustProto.User.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                UnknownFieldSet.Builder unknownFields = null;
                while (input.ReadTag(out num, out str))
                {
                    object obj2;
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(RustProto.User._userFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = RustProto.User._userFieldTags[index];
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
                            this.result.hasUserid = input.ReadUInt64(ref this.result.userid_);
                            continue;
                        }
                        case 0x12:
                        {
                            this.result.hasDisplayname = input.ReadString(ref this.result.displayname_);
                            continue;
                        }
                        case 0x18:
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
                    if (input.ReadEnum<RustProto.User.Types.UserGroup>(ref this.result.usergroup_, out obj2))
                    {
                        this.result.hasUsergroup = true;
                    }
                    else
                    {
                        if (!(obj2 is int))
                        {
                            continue;
                        }
                        if (unknownFields == null)
                        {
                            unknownFields = UnknownFieldSet.CreateBuilder(this.UnknownFields);
                        }
                        unknownFields.MergeVarintField(3, (ulong) ((int) obj2));
                    }
                }
                if (unknownFields != null)
                {
                    this.UnknownFields = unknownFields.Build();
                }
                return this;
            }

            private RustProto.User PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    RustProto.User result = this.result;
                    this.result = new RustProto.User();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public RustProto.User.Builder SetDisplayname(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDisplayname = true;
                this.result.displayname_ = value;
                return this;
            }

            public RustProto.User.Builder SetUsergroup(RustProto.User.Types.UserGroup value)
            {
                this.PrepareBuilder();
                this.result.hasUsergroup = true;
                this.result.usergroup_ = value;
                return this;
            }

            [CLSCompliant(false)]
            public RustProto.User.Builder SetUserid(ulong value)
            {
                this.PrepareBuilder();
                this.result.hasUserid = true;
                this.result.userid_ = value;
                return this;
            }

            public override RustProto.User DefaultInstanceForType
            {
                get
                {
                    return RustProto.User.DefaultInstance;
                }
            }

            public override MessageDescriptor DescriptorForType
            {
                get
                {
                    return RustProto.User.Descriptor;
                }
            }

            public string Displayname
            {
                get
                {
                    return this.result.Displayname;
                }
                set
                {
                    this.SetDisplayname(value);
                }
            }

            public bool HasDisplayname
            {
                get
                {
                    return this.result.hasDisplayname;
                }
            }

            public bool HasUsergroup
            {
                get
                {
                    return this.result.hasUsergroup;
                }
            }

            public bool HasUserid
            {
                get
                {
                    return this.result.hasUserid;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override RustProto.User MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override RustProto.User.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public RustProto.User.Types.UserGroup Usergroup
            {
                get
                {
                    return this.result.Usergroup;
                }
                set
                {
                    this.SetUsergroup(value);
                }
            }

            [CLSCompliant(false)]
            public ulong Userid
            {
                get
                {
                    return this.result.Userid;
                }
                set
                {
                    this.SetUserid(value);
                }
            }
        }

        [DebuggerNonUserCode]
        public static class Types
        {
            public enum UserGroup
            {
                REGULAR,
                BANNED,
                ADMIN
            }
        }
    }
}

