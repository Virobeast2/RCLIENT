namespace RustProto.Proto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [DebuggerNonUserCode]
    public static class Blueprint
    {
        [CompilerGenerated]
        private static FileDescriptor.InternalDescriptorAssigner <>f__am$cache3;
        private static FileDescriptor descriptor;
        internal static MessageDescriptor internal__static_RustProto_Blueprint__Descriptor;
        internal static FieldAccessorTable<Blueprint, Blueprint.Builder> internal__static_RustProto_Blueprint__FieldAccessorTable;

        static Blueprint()
        {
            byte[] descriptorData = Convert.FromBase64String("ChRydXN0L2JsdWVwcmludC5wcm90bxIJUnVzdFByb3RvIhcKCUJsdWVwcmludBIKCgJpZBgBIAIoBUICSAE=");
            if (<>f__am$cache3 == null)
            {
                <>f__am$cache3 = new FileDescriptor.InternalDescriptorAssigner(Blueprint.<Blueprint>m__5);
            }
            FileDescriptor.InternalDescriptorAssigner descriptorAssigner = <>f__am$cache3;
            FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData, new FileDescriptor[0], descriptorAssigner);
        }

        [CompilerGenerated]
        private static ExtensionRegistry <Blueprint>m__5(FileDescriptor root)
        {
            descriptor = root;
            internal__static_RustProto_Blueprint__Descriptor = Descriptor.MessageTypes[0];
            string[] propertyNames = new string[] { "Id" };
            internal__static_RustProto_Blueprint__FieldAccessorTable = new FieldAccessorTable<Blueprint, Blueprint.Builder>(internal__static_RustProto_Blueprint__Descriptor, propertyNames);
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

