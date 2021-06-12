using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTitle : MonoBehaviour
{
    #region �q�G�����L�[�ݒ�
    public GameObject canvas_1;  //Press Z�̕�
    public GameObject canvas_2;  //���߂���̕�

    #endregion

    #region �B���ϐ�
    public bool firstPush = false; //Press Z -> ���߂��� �A���ŉ����Ȃ��p
    private bool isStart = false;    //���߂���I��
    private bool isLoad = false;    //��������I��

    public bool isMode1 = true;    //�uPress Z�v���\������Ă����
    public bool isMode2 = false;   //�u���߂���v���\������Ă����
    private bool flgCursor = true;  // �J�[�\�����]��

    [SerializeField]
    SaveData saveData;
    #endregion


    void Awake()
    {
        //SaveData����
        //saveData = new SaveData();
    }


    void Start()
    {
        SetCanvas();
    }


    void Update()
    {
        //�L�[�{�[�h���͎擾
        float VerticalKey = Input.GetAxis("Vertical");
        float SubmitKey = Input.GetAxis("Submit");
        float CancelKey = Input.GetAxis("Cancel");

        if(isMode2)
        {
            if (VerticalKey > 0)    //�����
            {
                if (!firstPush)
                {
                    Debug.Log("���������");
                    flgCursor = !flgCursor;
                    Canvas2_Cursor_Set();
                    firstPush = true;
                }
            }
            else if (VerticalKey < 0)   //������
            {
                if (!firstPush)
                {
                    Debug.Log("����������");
                    flgCursor = !flgCursor;
                    Canvas2_Cursor_Set();
                    firstPush = true;
                }
            }
            
        }

        if (SubmitKey > 0)    
        {
            if (!firstPush)
            {
                //Mode1��������Mode2��
                //Mode2��������V�[���J��
                if(isMode1)
                {
                    Debug.Log("Z����->Mode2�ɑJ��");
                    isMode1 = false;
                    isMode2 = true;
                    SetCanvas();
                }
                else if(isMode2)
                {
                    Debug.Log("Z����->�V�[���J��");
                    isMode1 = true;
                    isMode2 = false;
                    PressStart();
                }
                firstPush = true;
            }
        }
        else
        {
            //firstPush = false;
        }
        if(CancelKey > 0)
        {
            if (!firstPush)
            {
                Debug.Log("�L�����Z������");
                isMode1 = true;
                isMode2 = false;
                SetCanvas();
            }
            firstPush = true;
        }

        //���������Ă��Ȃ�������firstPush��false�ɂ���
        if (VerticalKey == 0 && SubmitKey == 0 && CancelKey == 0)
        {
            firstPush = false;
        }

    }
    public void PressStart()
    {
    
        Debug.Log("�V�[���J�ڂ��܂���");

        if(flgCursor)
        {
            isStart = true;
            //start��������load����������DataBase�ɕۑ�����
        }
        else
        {
            isLoad = true;
            //start��������load����������DataBase�ɕۑ�����
        }

        //�V�[���J�ڂ���
        SceneManager.LoadScene("stage1");
    }
    public void SetCanvas()
    {
        if(isMode1)
        {
            canvas_1.SetActive(true);
            canvas_2.SetActive(false);
        }
        else if(isMode2)
        {
            canvas_1.SetActive(false);
            canvas_2.SetActive(true);
            flgCursor = true;
            Canvas2_Cursor_Set();
        }
        else
        {
            Debug.Log("SceneTitle_SetCanvas_Error");
        }
    }

    /// <summary>
    /// Canvas2 �J�[�\���̈ʒu�𒲐�����
    /// </summary>
    public void Canvas2_Cursor_Set()
    {
        canvas_2.transform.Find("Sel_Start").gameObject.SetActive(flgCursor);
        canvas_2.transform.Find("Sel_Load").gameObject.SetActive(!flgCursor);
    }

}
