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

    //[SerializeField]
    //public FlagListEntity flagListEntity;

    //public static SaveData instance;

    //※おそらく、instance化する必要なし
    //private void Awake()
    //{
    //    if(instance == null)
    //    {
    //        instance = this;
    //    }
    //}

    //敵倒したか倒してないかフラグ
    //[SerializeField]
    //FlagListEntity enemyFlagList;

    //進行フラグ
    //[SerializeField]
    //FlagListEntity progressFlagList;

    //プレイヤーデータ



    //よく見たらFlagListEntityってなってるから
    //そん中に全フラグはいっててもおかしくないな
    public SaveData()
    {
        //flagListEntity = new FlagListEntity();
        itemFlagList = new List<ItemFlag>();
    }

    //public Flag Spawn(Flag.Type type)
    //{
    //    //flagListの中からtypeと一致するflagを生成して渡す
    //    foreach(Flag flag in flagListEntity.itemFlagList)
    //    {
    //        if(flag.type == type)
    //        {
    //            return new Flag();//item.type渡せる
    //        }
    //    }
    //    return null;
    //}
}
