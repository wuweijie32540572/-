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

    public  sealed class BattleHeroData :  Bright.Serialization.BeanBase 
    {
        public BattleHeroData()
        {
        }

        public BattleHeroData(Bright.Common.NotNullInitialization _) 
        {
            userName = "";
        }

        public static void SerializeBattleHeroData(ByteBuf _buf, BattleHeroData x)
        {
            x.Serialize(_buf);
        }

        public static BattleHeroData DeserializeBattleHeroData(ByteBuf _buf)
        {
            var x = new HOKProtocol.BattleHeroData();
            x.Deserialize(_buf);
            return x;
        }

         public string userName;

         public int heroId;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            _buf.WriteString(userName);
            _buf.WriteInt(heroId);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            userName = _buf.ReadString();
            heroId = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.BattleHeroData{ "
            + "userName:" + userName + ","
            + "heroId:" + heroId + ","
            + "}";
        }
    }

}