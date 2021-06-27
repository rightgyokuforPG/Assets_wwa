using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneStage1 : MonoBehaviour
{
    #region//�C���X�y�N�^�[�Őݒ肷��
    [Header("HP"),SerializeField] public Text statusHP;
    [Header("ATK")] public Text statusATK;
    [Header("DEF")] public Text statusDEF;
    [Header("MONEY")] public Text statusMONEY;

    //[Header("���߂��炩�ǂ���")] public bool isStart = false;
    #endregion



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

        //���Վ� title�ŏ��߂����I�����Ă����ꍇ�A�X�e�[�^�X�𒼓��͂���
        //if(isStart)
        //{
        //    Debug.Log("SceneStage1��isStart��true�ł���");
        //    GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().save.playerStatus.HP = 100;
        //    GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().save.playerStatus.ATK = 10;
        //    GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().save.playerStatus.HP = 5;
        //    GameObject.FindWithTag("GameManager").GetComponent<SaveManager>().save.playerStatus.HP = 0;
        //    isStart = false;
        //}

        //�����̃X�e�[�^�X�ɒl��ݒ肷��
        Reload();
    }

    void Update()
    {

    }

    /// <summary>
    /// �X�e�[�^�X���ĕ\������
    /// </summary>
    public void Reload()
    {
        Debug.Log("Reload�ɓ�����");
        statusHP.text = GameObject.FindWithTag("GameManager")
            .GetComponent<SaveManager>().save.playerStatus.HP.ToString();

        statusATK.text = GameObject.FindWithTag("GameManager")
            .GetComponent<SaveManager>().save.playerStatus.ATK.ToString();

        statusDEF.text = GameObject.FindWithTag("GameManager")
            .GetComponent<SaveManager>().save.playerStatus.DEF.ToString();

        statusMONEY.text = GameObject.FindWithTag("GameManager")
            .GetComponent<SaveManager>().save.playerStatus.MONEY.ToString();
    }
}
