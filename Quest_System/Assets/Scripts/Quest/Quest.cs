using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Quest
{
    public bool isActive;
    
    public string Title;
    public string Description;
    public int experienceReward;
    public int goldReward;

    public QuestType questType;

    public void complete() {
        isActive = false;
        Debug.Log(Title + "was completed!");
    }
}
