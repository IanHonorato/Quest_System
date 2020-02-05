using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGiver : MonoBehaviour
{
    public Quest quest;

    public Player player;

    /*public GameObject questWindow;
    public Text titleText;
    public Text descriptionText;
    public Text experienceText;
    public Text goldText;*/
    public void openQuestWindow() {
        /*
         * questWindow.SetActive(true);
         * titleText.text = quest.title;
         * descriptionText = quest.description;
         * experienceText = quest.experience.ToString();
         * goldText = quest.gold.ToString();
         */
        Debug.Log("Abrir Janela de Quest");
    }

    public void AcceptQuest() {
        //questWindow.setActive(false);
        quest.isActive = true;
        //em jogos maiores, o player poderá ter uma list de quest ativas atualmente
        player.quest = quest;
        Debug.Log("Quest Aceita");
    }
}
