namespace RustProto.Proto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [DebuggerNonUserCode]
    public static class ItemMod
    {
        [CompilerGenerated]
        private static FileDescriptor.InternalDescriptorAssigner <>f__am$cache3;
        private static FileDescriptor descriptor;
        internal static MessageDescriptor internal__static_RustProto_ItemMod__Descriptor;
        internal static FieldAccessorTable<ItemMod, ItemMod.Builder> internal__static_RustProto_ItemMod__FieldAccessorTable;

        static ItemMod()
        {
            byte[] descriptorData = Convert.FromBase64String("ChNydXN0L2l0ZW1fbW9kLnByb3RvEglSdXN0UHJvdG8iIwoHSXRlbU1vZBIKCgJpZBgBIAIoBRIMCgRuYW1lGAIgASgJQgJIAQ==");
            if (<>f__am$cache3 == null)
            {
                <>f__am$cache3 = new FileDescriptor.InternalDescriptorAssigner(ItemMod.<ItemMod>m__9);
            }
            FileDescriptor.InternalDescriptorAssigner descriptorAssigner = <>f__am$cache3;
            FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData, new FileDescriptor[0], descriptorAssigner);
        }

        [CompilerGenerated]
        private static ExtensionRegistry <ItemMod>m__9(FileDescriptor root)
        {
            descriptor = root;
            internal__static_RustProto_ItemMod__Descriptor = Descriptor.MessageTypes[0];
            string[] propertyNames = new string[] { "Id", "Name" };
            internal__static_RustProto_ItemMod__FieldAccessorTable = new FieldAccessorTable<ItemMod, ItemMod.Builder>(internal__static_RustProto_ItemMod__Descriptor, propertyNames);
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

