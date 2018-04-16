using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionOptions : MonoBehaviour {

    private bool finalcd;
    private float time = 5f;

    // Use this for initialization
    void Start () {


    }

    // Update is called once per frame
    void Update () {

        if (!finalcd) return;

        if (time > 0)
            time -= Time.deltaTime;
        if(time <= 0)
        {
            SceneManager.LoadScene("End");
        }


	}

    public void First()
    {
        float r = Random.Range(0f, 1f);
        if(r <= .5f)
        {
            MessageManager.SpawnMessage("it means something to eat");
        }
        else
        {
            MessageManager.SpawnMessage("it means the final part of a leg");
        }
        finalcd = true;
    }
    public void Second()
    {
        float r = Random.Range(0f, 1f);
        if (r <= .5f)
        {
            MessageManager.SpawnMessage("la Groenlandia è l'isola più grande del mondo");
        }
        else
        {
            MessageManager.SpawnMessage("l'India");
        }
        finalcd = true;

    }
    public void Third()
    {
        float r = Random.Range(0f, 1f);
        if (r <= .5f)
        {
            MessageManager.SpawnMessage("l'america fù scoperta nel 1942");
        }
        else
        {
            MessageManager.SpawnMessage("l'america fù scoperta nel 1517");
        }
        finalcd = true;

    }
}
