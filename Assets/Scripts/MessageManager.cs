using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour{


    static Text text;
    static Image img;

    static float cd;

    void Awake()
    {
        cd = 4f;
        text = GameObject.Find("Canvas").transform.FindChild("Image").GetComponentInChildren<Text>();
        img = GameObject.Find("Canvas").transform.FindChild("Image").GetComponent<Image>();
        img.gameObject.SetActive(false);
    }

    void Update()
    {
        if (cd > 0)
            cd -= Time.deltaTime;
        if(cd <= 0)
        {
            cd = 4;
            img.gameObject.SetActive(false);
            text.text = "";
        }
    }
    
    public static void SpawnMessage(string message)
    {
        img.gameObject.SetActive(true);
        text.text = message;
        cd = 4;
        PointsManager.points -= 0.5f;
    }
}
