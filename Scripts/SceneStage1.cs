using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStage1 : MonoBehaviour
{
    //フラグリスト
    //[SerializeField]
    //FlagListEntity flagListEntity;
    //[SerializeField]
    //SaveData saveData;
    //[SerializeField]
    //SaveData saveData;

    void Awake()
    {
        //SaveData生成
        //saveData = new SaveData();

        //SaveData生成
        //saveData = new SaveData();
    }

    void Start()
    {
        //string path = $"Scripts/FlagListEntity";
        //flagListEntity = Resources.Load(path) as FlagListEntity;

        //Debug.Log("動作確認");
        //GameObject obj = GameObject.Find("Item");
        //if(flagListEntity.itemFlagList[0].isExist == false)
        //{
        //    obj.SetActive(false);
        //}
        //  Entity類はSceneStage1のSaveDataの中に入っている仕組みにした為、kc

        //やること  シーン遷移時にセーブデータからアイテム回収フラグを確認する
        //          で、回収済みだったらアイテムを非表示にする

        //SaveData save = GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().GetSave();
        //GameObject obj = GameObject.FindWithTag("GameManager");
        //SaveData save = obj.GetComponent<SaveManager>().GetSave();

        //Debug.Log("tests\t" + save);
        //Debug.Log("testsf\t" + save.flagListEntity);
        //Debug.Log("testsfi\t" + save.flagListEntity.itemFlagList);
        //Debug.Log("testsfi0\t" + save.flagListEntity.itemFlagList[0]);
        //Debug.Log("testsfi0i\t" + save.flagListEntity.itemFlagList[0].ItemID);

        //if (save.flagListEntity.itemFlagList[0].ItemID == 1)
        //{
        //    Debug.Log("if分ぬけた");
        //    GameObject.Find("Item").SetActive(false);
        //}

        //よく考えたらflagListEntity挟む必要なくね？

        GameObject obj = GameObject.FindWithTag("GameManager");
        SaveData save = obj.GetComponent<SaveManager>().GetSave();

        Debug.Log("tests\t" + save);
        Debug.Log("testsfi\t" + save.itemFlagList);

        Debug.Log("testsLength\t" + save.itemFlagList.Count);
        Debug.Log("testsfi0\t" + save.itemFlagList[0]);
        Debug.Log("testsfi0i\t" + save.itemFlagList[0].ItemID);

        if (save.itemFlagList[0].ItemID == 1)
        {
            Debug.Log("if分ぬけた");
            GameObject.Find("Item").SetActive(false);
        }
        else
        {
            Debug.Log("if分__0");
            Debug.Log("if分__0");
        }
    }

    void Update()
    {

    }
}
