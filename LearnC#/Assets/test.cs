using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
