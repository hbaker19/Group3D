using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveMyPostion : MonoBehaviour
{
    string savePath;
    SaveData data;
    // Start is called before the first frame update
    void Start()
    {
        savePath = Application.persistentDataPath + "/" + gameObject.name +
            "mySave.dat";
        Debug.Log(savePath);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Save();
        }

        if (Input.GetButtonDown("Load"))
        {
            Load();
        }
    }
    void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file;
        if (!File.Exists(savePath))
        {
            file = File.Create(savePath);
        }
        else
        {
            file = File.Open(savePath, FileMode.Open);
        }
        data = new SaveData(transform.position);
        bf.Serialize(file, data);
        file.Close();
        Debug.Log("Saved");
    }
    void Load()
    {
        if(File.Exists(savePath))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(savePath, FileMode.Open);
            data = (SaveData)bf.Deserialize(file);
            file.Close();
            transform.position = data.GetVector3();
            Debug.Log("Loaded");
        }
    }

    public void SaveGame()
    {
        Save();
    }

    public void LoadGame()
    {
        Load();
    }


}

[System.Serializable]

public class SaveData
{
    public float x;
    public float y;
    public float z;

    public SaveData(Vector3 position)
    {
        x = position.x;
        y = position.y;
        z = position.z;
    }

    public Vector3 GetVector3()
    {
        return new Vector3(x, y, z);
    }
}

