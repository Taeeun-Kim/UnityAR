using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 1. Variable
        Debug.Log("Hello Unity!");

        int level = 5;
        float strength = 15.5f;
        string playername = "Speedbrot";
        bool isFullLevel = false;

        Debug.Log("Hero's name?");
        Debug.Log(playername);

        Debug.Log("Hero's Level?");
        Debug.Log(level);

        Debug.Log("Hero's Strength?");
        Debug.Log(strength);

        Debug.Log("Is Hero's Lv99?");
        Debug.Log(isFullLevel);

        //2. Array Variable
        string[] monsters = {"Slime", "Snake", "Devil"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("Existing Monsters");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        Debug.Log("Existing Monsters's Level");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("Life Potion 30");
        items.Add("Mana Potion 30");

        Debug.Log("Items you have");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(1);
        Debug.Log(items[0]);
        // Debug.Log(items[1]); // Error out of Array
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
