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

    //[SerializeField]
    //public FlagListEntity flagListEntity;

    //public static SaveData instance;

    //�������炭�Ainstance������K�v�Ȃ�
    //private void Awake()
    //{
    //    if(instance == null)
    //    {
    //        instance = this;
    //    }
    //}

    //�G�|�������|���ĂȂ����t���O
    //[SerializeField]
    //FlagListEntity enemyFlagList;

    //�i�s�t���O
    //[SerializeField]
    //FlagListEntity progressFlagList;

    //�v���C���[�f�[�^



    //�悭������FlagListEntity���ĂȂ��Ă邩��
    //���񒆂ɑS�t���O�͂����ĂĂ����������Ȃ���
    public SaveData()
    {
        //flagListEntity = new FlagListEntity();
        itemFlagList = new List<ItemFlag>();
    }

    //public Flag Spawn(Flag.Type type)
    //{
    //    //flagList�̒�����type�ƈ�v����flag�𐶐����ēn��
    //    foreach(Flag flag in flagListEntity.itemFlagList)
    //    {
    //        if(flag.type == type)
    //        {
    //            return new Flag();//item.type�n����
    //        }
    //    }
    //    return null;
    //}
}
