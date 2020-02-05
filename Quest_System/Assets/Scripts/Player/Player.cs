using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int experience = 40;
    public int gold = 1000;

    public Quest quest;

    //metódo provisório
    public void goBattle() {
        health -= 1;
        experience += 2;
        gold += 5;

        if (quest.isActive) {
            quest.questType.enemyKilled();
            if (quest.questType.isReached()) {
                experience += quest.experienceReward;
                gold += quest.goldReward;
                quest.complete();
            }
        }

        Debug.Log("Batalhou");
    }
}
