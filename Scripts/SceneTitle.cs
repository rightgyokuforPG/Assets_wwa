using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneTitle : MonoBehaviour
{
    #region ヒエラルキー設定
    public GameObject canvas_1;  //Press Zの方
    public GameObject canvas_2;  //初めからの方

    #endregion

    #region 隠し変数
    public bool firstPush = false; //Press Z -> 初めから 連続で押さない用
    private bool isStart = false;    //初めから選択
    private bool isLoad = false;    //続きから選択

    public bool isMode1 = true;    //「Press Z」が表示されている方
    public bool isMode2 = false;   //「初めから」が表示されている方
    private bool flgCursor = true;  // カーソル反転式

    [SerializeField]
    SaveData saveData;
    #endregion


    void Awake()
    {
        //SaveData生成
        //saveData = new SaveData();
    }


    void Start()
    {
        SetCanvas();
    }


    void Update()
    {
        //キーボード入力取得
        float VerticalKey = Input.GetAxis("Vertical");
        float SubmitKey = Input.GetAxis("Submit");
        float CancelKey = Input.GetAxis("Cancel");

        if(isMode2)
        {
            if (VerticalKey > 0)    //上方向
            {
                if (!firstPush)
                {
                    Debug.Log("上方向押下");
                    flgCursor = !flgCursor;
                    Canvas2_Cursor_Set();
                    firstPush = true;
                }
            }
            else if (VerticalKey < 0)   //下方向
            {
                if (!firstPush)
                {
                    Debug.Log("下方向押下");
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
                //Mode1だったらMode2に
                //Mode2だったらシーン遷移
                if(isMode1)
                {
                    Debug.Log("Z押下->Mode2に遷移");
                    isMode1 = false;
                    isMode2 = true;
                    SetCanvas();
                }
                else if(isMode2)
                {
                    Debug.Log("Z押下->シーン遷移");
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
                Debug.Log("キャンセル押下");
                isMode1 = true;
                isMode2 = false;
                SetCanvas();
            }
            firstPush = true;
        }

        //何も押していない時だけfirstPushをfalseにする
        if (VerticalKey == 0 && SubmitKey == 0 && CancelKey == 0)
        {
            firstPush = false;
        }

    }
    public void PressStart()
    {
    
        Debug.Log("シーン遷移しました");

        if(flgCursor)
        {
            isStart = true;
            //startだったかloadだったかをDataBaseに保存する
        }
        else
        {
            isLoad = true;
            //startだったかloadだったかをDataBaseに保存する
        }

        //シーン遷移する
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
    /// Canvas2 カーソルの位置を調整する
    /// </summary>
    public void Canvas2_Cursor_Set()
    {
        canvas_2.transform.Find("Sel_Start").gameObject.SetActive(flgCursor);
        canvas_2.transform.Find("Sel_Load").gameObject.SetActive(!flgCursor);
    }

}
