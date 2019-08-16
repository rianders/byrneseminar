using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SaveGame(string[] list)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/game.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        foreach (string entry in list)
        {
            Debug.Log(entry);
        }

        formatter.Serialize(stream, list);
        stream.Close();

    }


    public static string[] LoadGame()
    {
        string path = Application.persistentDataPath + "/game.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            string[] LoadArray = formatter.Deserialize(stream) as string[];

            stream.Close();
            return LoadArray;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
