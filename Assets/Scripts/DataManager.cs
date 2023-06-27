using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    
    [Serializable]
    public class SaveData
    {
        public HighScorePlayerName name;
        public HighScore score;
    }
    public class HighScorePlayerName
    {
        public string first;
        public string second;
        public string third;
    }
    public class HighScore
    {
        public string firstScore;
        public string secondScore;
        public string thirdScore;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
