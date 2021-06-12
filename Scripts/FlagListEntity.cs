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
    public string ItemFlagName = "�A�C�e������t���O";

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


//�o������t���O�́A
//���i�s�t���O
//���G�|�������t���O
//���A�C�e������������t���O�ɕ�������