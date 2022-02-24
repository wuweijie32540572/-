//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace editor.cfg
{

public sealed partial class ExecuteDamageBuffCfg :  BuffCfg 
{
    public ExecuteDamageBuffCfg()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["damagePct"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  damagePct = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["damagePct"] = new JSONNumber(damagePct);
        }
    }

    public static ExecuteDamageBuffCfg LoadJsonExecuteDamageBuffCfg(SimpleJSON.JSONNode _json)
    {
        ExecuteDamageBuffCfg obj = new ExecuteDamageBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonExecuteDamageBuffCfg(ExecuteDamageBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 百分比生命伤害
    /// </summary>
    public int damagePct { get; set; }

}
}