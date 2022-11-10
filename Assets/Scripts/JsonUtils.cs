using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class JsonUtils
{

    public static void createFirstTimeData()
    {
        StatusData statusData = new StatusData(50,100,50);
        saveToJson(statusData);
    }

    //ToDo: Check if there´s previous data saved;
    public static bool isPathCreated() {
        string persitencePath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "data.json";
        return File.Exists(persitencePath) ? true : false;
    }
    public static void saveToJson(StatusData data)
    {
        string persitencePath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "data.json";
        string json = JsonUtility.ToJson(data);
        StreamWriter wr = new StreamWriter(persitencePath);
        wr.Write(json);
        Debug.Log("Saved to "+ persitencePath);
        wr.Close();
    }

    public static StatusData readData()
    {
        string persitencePath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "data.json";
        StreamReader r = new StreamReader(persitencePath);
        string json = r.ReadToEnd();
        r.Close();
        return JsonUtility.FromJson<StatusData>(json);
    }
}
