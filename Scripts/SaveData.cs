using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    [SerializeField]
    string text = "おはよう";

    //アイテム回収フラグ
    [SerializeField]
    public List<ItemFlag> itemFlagList;


    public SaveData()
    {
        itemFlagList = new List<ItemFlag>();
    }

}
