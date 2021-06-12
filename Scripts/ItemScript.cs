using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    [SerializeField] Item.Type itemType;

    [SerializeField]
    int ItemID;
    void Start()
    {
        //itemTypeに応じでItemを生成する
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //取得したら消す
    public void OnTouchObj()
    {
        //アイテムを取得済みにする
        //プレイヤーのステータス画面を再表示する

        this.gameObject.SetActive(false);
    }
}
