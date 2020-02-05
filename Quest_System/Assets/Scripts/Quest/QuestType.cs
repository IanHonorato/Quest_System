using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GoalType { 
    Kill,
    Gathering,
    Escort
}

[System.Serializable]
public class QuestType
{
    public GoalType goalType;

    public int requiredAmount;
    public int currentAmount;

    //rever o que seria esse current amount

    public bool isReached() {
        return (currentAmount >= requiredAmount);
    }

    public void enemyKilled() {
        if(goalType == GoalType.Kill)
            currentAmount++;
    }

    public void ItemCollected() {
        if (goalType == GoalType.Gathering)
            currentAmount++;
    }
}
