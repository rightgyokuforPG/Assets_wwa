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
        //SceneTitle����V�[���J�ڂ���ہASaveManager����save�ɏ㏑�����Ă���̂�
        //�{���Ɏ擾�o���Ă��邩�m�F����R�[�h
        //GameObject obj = GameObject.FindWithTag("GameManager");
        //SaveData save = obj.GetComponent<SaveManager>().GetSave();

        //if (save.itemFlagList[0].ItemID == 1)
        //{
        //    Debug.Log("�f�[�^�J��_�m�FOK");
        //    GameObject.Find("Item").SetActive(false);
        //}
        //Q:�V�[���ԂŃf�[�^�ڂ��Ă�́H
        //A:Stage1����Awake��save�𐶐����ATitle����GameSceneLoaded��save�ɏ㏑�����Ă��邩��o���Ă�
    }

    void Update()
    {

    }
}
