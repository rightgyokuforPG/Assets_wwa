using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveManager : MonoBehaviour
{
    string filePath;
    [SerializeField]
    private SaveData save;

    void Awake()
    {
        save = new SaveData();
    }

    void start()
    {   
        filePath = Application.persistentDataPath + "/" + ".savedata.json";
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
