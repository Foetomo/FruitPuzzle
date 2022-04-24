using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Control : MonoBehaviour
{
    public GameObject parentPuzzle, penutup, panelGreat, buttonDone, buttonPlay, buttonRestart;
    public TextMeshProUGUI textLevel, textFruit;
    string level, fruit;
    int order = 0; // order merupakan urutan per level

    // Script untuk
    void active(int a)
    {
        
        order += a;
        if (order < 0)
        {
            order = parentPuzzle.transform.childCount - 1;
        }
        else if (order > parentPuzzle.transform.childCount - 1)
        {
            order = 0;
        }

        for (int i = 0; i < parentPuzzle.transform.childCount; i++)
        {
            parentPuzzle.transform.GetChild(i).gameObject.SetActive(false);
            penutup.gameObject.SetActive(false);
            panelGreat.gameObject.SetActive(false);
            
            if (order == 0)
            {
                level = "Level 1";
                fruit = "Apple";
                textLevel.text = level;
                textFruit.text = fruit;
                
            }
            else if (order == 1)
            {
                level = "Level 2";
                fruit = "Banana";
                textLevel.text = level;
                textFruit.text = fruit;
            }
            else if (order == 2)
            {
                level = "Level 3";
                fruit = "Cherry";
                textLevel.text = level;
                textFruit.text = fruit;
            }
            else if (order == 3)
            {
                level = "Level 4";
                fruit = "Dragon Fruit";
                textLevel.text = level;
                textFruit.text = fruit;
            }
            else if (order == 4)
            {
                level = "Level 5";
                fruit = "Grapes";
                textLevel.text = level;
                textFruit.text = fruit;
            }
            else if (order == 5)
            {
                level = "Done";
                fruit = "Done";
                textLevel.text = level;
                textFruit.text = fruit;
                penutup.gameObject.SetActive(true);
                panelGreat.gameObject.SetActive(true);
                buttonPlay.gameObject.SetActive(false);
                buttonDone.gameObject.SetActive(true);
                buttonRestart.gameObject.SetActive(true);
            }
        }
        parentPuzzle.transform.GetChild(order).gameObject.SetActive(true);
    }

    public void Click()
    {
        active(1);
    }
}
