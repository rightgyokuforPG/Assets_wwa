using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneStage1 : MonoBehaviour
{
    //�t���O���X�g
    //[SerializeField]
    //FlagListEntity flagListEntity;
    //[SerializeField]
    //SaveData saveData;
    //[SerializeField]
    //SaveData saveData;

    void Awake()
    {
        //SaveData����
        //saveData = new SaveData();

        //SaveData����
        //saveData = new SaveData();
    }

    void Start()
    {
        //string path = $"Scripts/FlagListEntity";
        //flagListEntity = Resources.Load(path) as FlagListEntity;

        //Debug.Log("����m�F");
        //GameObject obj = GameObject.Find("Item");
        //if(flagListEntity.itemFlagList[0].isExist == false)
        //{
        //    obj.SetActive(false);
        //}
        //  Entity�ނ�SceneStage1��SaveData�̒��ɓ����Ă���d�g�݂ɂ����ׁAkc

        //��邱��  �V�[���J�ڎ��ɃZ�[�u�f�[�^����A�C�e������t���O���m�F����
        //          �ŁA����ς݂�������A�C�e�����\���ɂ���

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
        //    Debug.Log("if���ʂ���");
        //    GameObject.Find("Item").SetActive(false);
        //}

        //�悭�l������flagListEntity���ޕK�v�Ȃ��ˁH

        GameObject obj = GameObject.FindWithTag("GameManager");
        SaveData save = obj.GetComponent<SaveManager>().GetSave();

        Debug.Log("tests\t" + save);
        Debug.Log("testsfi\t" + save.itemFlagList);

        Debug.Log("testsLength\t" + save.itemFlagList.Count);
        Debug.Log("testsfi0\t" + save.itemFlagList[0]);
        Debug.Log("testsfi0i\t" + save.itemFlagList[0].ItemID);

        if (save.itemFlagList[0].ItemID == 1)
        {
            Debug.Log("if���ʂ���");
            GameObject.Find("Item").SetActive(false);
        }
        else
        {
            Debug.Log("if��__0");
            Debug.Log("if��__0");
        }
    }

    void Update()
    {

    }
}
