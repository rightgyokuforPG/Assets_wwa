using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Item 
{
    // 列挙型：種類を列挙する
    public enum Type
    {
        One,    //最大HPの上限を上昇させるアイテム
        Two,    //HPを回復させるアイテム
        Three,  //ATKを増加させるアイテム
        Four,   //DEFを増加させるアイテム

    }

    public Type type;       //種類
    public Sprite sprite;   //Slotに表示する画像

    [SerializeField]
    int ItemID;

    /// <summary>
    /// アイテム生成しない方
    /// </summary>
    public Item()
    {

    }

    /// <summary>
    /// アイテム生成時必ずTypeとspriteを取得する
    /// </summary>
    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}









//★WeaponListEntity 武器の種類を管理する奴
//★PlayerListEntity プレイヤーが所持している物を管理する奴
//★EnemyListEntity  敵の情報を管理する奴（なんか種類を管理するだけでいる/いない管理出来なさそう）
//★FlagListEntity   シナリオ進行フラグやお邪魔NPCの出現フラグを管理する奴

//★EnemyExistFlagListEntity 敵の倒したかどうかを管理する奴
//  {どのステージか どの種類か どのIDか}
