﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34011
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.5.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.AddOnlyCollection<int[]>> {
        
        private MsgPack.Serialization.MessagePackSerializer<object[]> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<object> _serializer1;
        
        private MsgPack.Serialization.MessagePackSerializer<object[][]> _serializer2;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[]> _serializer3;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Nullable<System.DateTime>> _serializer4;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime[][]> _serializer5;
        
        private MsgPack.Serialization.MessagePackSerializer<System.DateTime> _serializer6;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[]> _serializer7;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject[][]> _serializer8;
        
        private MsgPack.Serialization.MessagePackSerializer<MsgPack.MessagePackObject> _serializer9;
        
        private MsgPack.Serialization.MessagePackSerializer<int[]> _serializer10;
        
        private MsgPack.Serialization.MessagePackSerializer<int[][]> _serializer11;
        
        public MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer(MsgPack.Serialization.SerializationContext context) : 
                base(MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default).CompatibilityOptions.PackerCompatibilityOptions) {
            MsgPack.Serialization.SerializationContext safeContext = MsgPack_Serialization_AddOnlyCollection_1_System_Int32Array_Serializer.@__Conditional((context != null), context, MsgPack.Serialization.SerializationContext.Default);
            this._serializer0 = safeContext.GetSerializer<object[]>();
            this._serializer1 = safeContext.GetSerializer<object>();
            this._serializer2 = safeContext.GetSerializer<object[][]>();
            this._serializer3 = safeContext.GetSerializer<System.DateTime[]>();
            this._serializer4 = safeContext.GetSerializer<System.Nullable<System.DateTime>>();
            this._serializer5 = safeContext.GetSerializer<System.DateTime[][]>();
            this._serializer6 = safeContext.GetSerializer<System.DateTime>();
            this._serializer7 = safeContext.GetSerializer<MsgPack.MessagePackObject[]>();
            this._serializer8 = safeContext.GetSerializer<MsgPack.MessagePackObject[][]>();
            this._serializer9 = safeContext.GetSerializer<MsgPack.MessagePackObject>();
            this._serializer10 = safeContext.GetSerializer<int[]>();
            this._serializer11 = safeContext.GetSerializer<int[][]>();
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.AddOnlyCollection<int[]> objectTree) {
            this._serializer11.PackTo(packer, System.Linq.Enumerable.ToArray(objectTree));
        }
        
        protected internal override MsgPack.Serialization.AddOnlyCollection<int[]> UnpackFromCore(MsgPack.Unpacker unpacker) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            MsgPack.Serialization.AddOnlyCollection<int[]> collection = default(MsgPack.Serialization.AddOnlyCollection<int[]>);
            collection = new MsgPack.Serialization.AddOnlyCollection<int[]>();
            this.UnpackToCore(unpacker, collection);
            return collection;
        }
        
        protected internal override void UnpackToCore(MsgPack.Unpacker unpacker, MsgPack.Serialization.AddOnlyCollection<int[]> collection) {
            if ((unpacker.IsArrayHeader == false)) {
                throw MsgPack.Serialization.SerializationExceptions.NewIsNotArrayHeader();
            }
            int count = default(int);
            count = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
            for (int i = 0; (i < count); i = (i + 1)) {
                int[] nullable = default(int[]);
                if ((unpacker.Read() == false)) {
                    throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                }
                if (((unpacker.IsArrayHeader == false) 
                            && (unpacker.IsMapHeader == false))) {
                    nullable = this._serializer10.UnpackFrom(unpacker);
                }
                else {
                    MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                    disposable = unpacker.ReadSubtree();
                    try {
                        nullable = this._serializer10.UnpackFrom(disposable);
                    }
                    finally {
                        if (((disposable == null) 
                                    == false)) {
                            disposable.Dispose();
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    collection.Add(nullable);
                }
                else {
                    collection.Add(nullable);
                }
            }
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}