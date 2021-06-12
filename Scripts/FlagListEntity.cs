using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FlagListEntity : ScriptableObject
{
    public List<ItemFlag> itemFlagList = new List<ItemFlag>();
}


[System.Serializable]
public class ItemFlag : Flag
{
    public string ItemFlagName = "アイテム回収フラグ";

    [SerializeField]    
    public int ItemID;

    [SerializeField]
    public bool isExist;

    [SerializeField]
    string Bikou;
    public ItemFlag()
    {
        //this.isExist = true;
    }

}


//出来たらフラグは、
//★進行フラグ
//★敵倒したかフラグ
//★アイテム回収したかフラグに分けたい