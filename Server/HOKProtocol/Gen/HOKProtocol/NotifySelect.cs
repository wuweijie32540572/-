//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.HOKProtocol
{

    public  sealed class NotifySelect :  Bright.Serialization.BeanBase 
    {
        public NotifySelect()
        {
        }

        public NotifySelect(Bright.Common.NotNullInitialization _) 
        {
            selectData = new HOKProtocol.SelectData();
        }

        public static void SerializeNotifySelect(ByteBuf _buf, NotifySelect x)
        {
            x.Serialize(_buf);
        }

        public static NotifySelect DeserializeNotifySelect(ByteBuf _buf)
        {
            var x = new HOKProtocol.NotifySelect();
            x.Deserialize(_buf);
            return x;
        }

         public HOKProtocol.SelectData selectData;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            HOKProtocol.SelectData.SerializeSelectData(_buf, selectData);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            selectData = HOKProtocol.SelectData.DeserializeSelectData(_buf);
        }

        public override string ToString()
        {
            return "HOKProtocol.NotifySelect{ "
            + "selectData:" + selectData + ","
            + "}";
        }
    }

}