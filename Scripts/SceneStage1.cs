using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStage1 : MonoBehaviour
{

    void Awake()
    {
    }

    void Start()
    {
        //SceneTitleからシーン遷移する際、SaveManager内のsaveに上書きしているので
        //本当に取得出来ているか確認するコード
        //GameObject obj = GameObject.FindWithTag("GameManager");
        //SaveData save = obj.GetComponent<SaveManager>().GetSave();

        //if (save.itemFlagList[0].ItemID == 1)
        //{
        //    Debug.Log("データ遷移_確認OK");
        //    GameObject.Find("Item").SetActive(false);
        //}
        //Q:シーン間でデータ移せてるの？
        //A:Stage1側のAwakeでsaveを生成し、Title側のGameSceneLoadedでsaveに上書きしているから出来てる
    }

    void Update()
    {

    }
}
