﻿namespace RustProto.Proto
{
    using Google.ProtocolBuffers;
    using Google.ProtocolBuffers.Descriptors;
    using Google.ProtocolBuffers.FieldAccess;
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;

    [DebuggerNonUserCode]
    public static class Item
    {
        [CompilerGenerated]
        private static FileDescriptor.InternalDescriptorAssigner <>f__am$cache3;
        private static FileDescriptor descriptor;
        internal static MessageDescriptor internal__static_RustProto_Item__Descriptor;
        internal static FieldAccessorTable<Item, Item.Builder> internal__static_RustProto_Item__FieldAccessorTable;

        static Item()
        {
            byte[] descriptorData = Convert.FromBase64String("Cg9ydXN0L2l0ZW0ucHJvdG8SCVJ1c3RQcm90bxoTcnVzdC9pdGVtX21vZC5wcm90byKaAQoESXRlbRIKCgJpZBgBIAIoBRIMCgRuYW1lGAIgASgJEgwKBHNsb3QYAyABKAUSDQoFY291bnQYBCABKAUSEAoIc3Vic2xvdHMYBiABKAUSEQoJY29uZGl0aW9uGAcgASgCEhQKDG1heGNvbmRpdGlvbhgIIAEoAhIgCgdzdWJpdGVtGAUgAygLMg8uUnVzdFByb3RvLkl0ZW1CAkgB");
            if (<>f__am$cache3 == null)
            {
                <>f__am$cache3 = new FileDescriptor.InternalDescriptorAssigner(Item.<Item>m__8);
            }
            FileDescriptor.InternalDescriptorAssigner descriptorAssigner = <>f__am$cache3;
            FileDescriptor[] dependencies = new FileDescriptor[] { ItemMod.Descriptor };
            FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData, dependencies, descriptorAssigner);
        }

        [CompilerGenerated]
        private static ExtensionRegistry <Item>m__8(FileDescriptor root)
        {
            descriptor = root;
            internal__static_RustProto_Item__Descriptor = Descriptor.MessageTypes[0];
            string[] propertyNames = new string[] { "Id", "Name", "Slot", "Count", "Subslots", "Condition", "Maxcondition", "Subitem" };
            internal__static_RustProto_Item__FieldAccessorTable = new FieldAccessorTable<Item, Item.Builder>(internal__static_RustProto_Item__Descriptor, propertyNames);
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

