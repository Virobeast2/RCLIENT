namespace RustProto.Proto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [DebuggerNonUserCode]
    public static class User
    {
        [CompilerGenerated]
        private static FileDescriptor.InternalDescriptorAssigner <>f__am$cache3;
        private static FileDescriptor descriptor;
        internal static MessageDescriptor internal__static_RustProto_User__Descriptor;
        internal static FieldAccessorTable<User, User.Builder> internal__static_RustProto_User__FieldAccessorTable;

        static User()
        {
            byte[] descriptorData = Convert.FromBase64String("Cg9ydXN0L3VzZXIucHJvdG8SCVJ1c3RQcm90byKKAQoEVXNlchIOCgZ1c2VyaWQYASACKAQSEwoLZGlzcGxheW5hbWUYAiACKAkSLAoJdXNlcmdyb3VwGAMgAigOMhkuUnVzdFByb3RvLlVzZXIuVXNlckdyb3VwIi8KCVVzZXJHcm91cBILCgdSRUdVTEFSEAASCgoGQkFOTkVEEAESCQoFQURNSU4QAkICSAE=");
            if (<>f__am$cache3 == null)
            {
                <>f__am$cache3 = new FileDescriptor.InternalDescriptorAssigner(User.<User>m__A);
            }
            FileDescriptor.InternalDescriptorAssigner descriptorAssigner = <>f__am$cache3;
            FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData, new FileDescriptor[0], descriptorAssigner);
        }

        [CompilerGenerated]
        private static ExtensionRegistry <User>m__A(FileDescriptor root)
        {
            descriptor = root;
            internal__static_RustProto_User__Descriptor = Descriptor.MessageTypes[0];
            string[] propertyNames = new string[] { "Userid", "Displayname", "Usergroup" };
            internal__static_RustProto_User__FieldAccessorTable = new FieldAccessorTable<User, User.Builder>(internal__static_RustProto_User__Descriptor, propertyNames);
            return null;
        }

        public static void RegisterAllExtensions(ExtensionRegistry registry)
        {
        }

        public static FileDescriptor Descriptor
        {
            get
            {
                return descriptor;
            }
        }
    }
}

