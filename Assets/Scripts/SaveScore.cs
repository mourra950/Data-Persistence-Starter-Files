using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
[System.Serializable]
public class SaveScore
{
    public int HighScore;
    public string Playername;
    public void initdata()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveScore data = JsonUtility.FromJson<SaveScore>(json);
            HighScore = data.HighScore;
            Playername = data.Playername;
        }
    }

    public void saveData(string name, int score)
    {
        SaveScore data = new SaveScore();
        data.HighScore = score;
        data.Playername = name;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

}
