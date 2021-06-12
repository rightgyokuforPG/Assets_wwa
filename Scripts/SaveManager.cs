using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    string filePath;
    [SerializeField]
    private SaveData save;

    void start()
    {   
        filePath = Application.persistentDataPath + "/" + ".savedata.json";
        save = new SaveData();

        FlagListEntity flagListEntity = new FlagListEntity();
        //save.itemFlagList = flagListEntity.itemFlagList;  //これはダメだった
        //おそらく、参照型だから。で、参照型をどうやって渡す？
        //アドレス渡しても参照元消滅するので
        Debug.Log("itemFlagListのLength_" + flagListEntity.itemFlagList.Count);
        for (int i = 0; flagListEntity.itemFlagList.Count > i; i++)
        {
            Debug.Log("saveにitemflagのレコード追加している");
            save.itemFlagList.Add(flagListEntity.itemFlagList[i]);
        }
        Debug.Log("save_length_" + save.itemFlagList.Count);
    }
    public void Save()
    {
        string json = JsonUtility.ToJson(save);

        StreamWriter streamWriter = new StreamWriter(filePath);
        streamWriter.Write(json);
        streamWriter.Flush();
        streamWriter.Close();
    }

    public void Load()
    {
        if(File.Exists(filePath))
        {
            StreamReader streamReader;
            streamReader = new StreamReader(filePath);
            string data = streamReader.ReadToEnd();
            streamReader.Close();

            save = JsonUtility.FromJson<SaveData>(data);
        }
    }

    public SaveData GetSave()
    {
        return this.save;
    }
}
