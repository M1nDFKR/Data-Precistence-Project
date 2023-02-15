using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public int score;
    public string name;
    public string playerName;

    public static GameManager Instance;

    private void Awake(){
        if (Instance != null){
        Destroy (gameObject);
        return;
        }
        Instance=this;
        DontDestroyOnLoad(gameObject);

       
    }
     public class SaveData{

        public string playerName;
        public int score;
    }

    public void Ns(){

    SaveData data = new SaveData();
     data.playerName=name;
     data.score=score;
     string Json= JsonUtility.ToJson(data);
     File.WriteAllText(Application.persistentDataPath+"Savefile.Json", Json);
     }
    public void LoadNs(){
        string loadPath = Application.persistentDataPath+"Savefile.Json";
        if(File.Exists(loadPath)){
            string json = File.ReadAllText(loadPath);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerName=data.playerName;
            score=data.score;
    }
} 

}
