using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData 
{
    [SerializeField]
    string text = "���͂悤";

    //�A�C�e������t���O
    [SerializeField]
    public List<ItemFlag> itemFlagList;


    public SaveData()
    {
        itemFlagList = new List<ItemFlag>();
    }

}
