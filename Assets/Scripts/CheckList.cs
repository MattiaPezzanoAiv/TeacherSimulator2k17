using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckList : MonoBehaviour {

    public static List<Sprite> checkSprites;
    public static int currentTask;

    private static List<GameObject> tasks;
    private static bool started;


    void Awake()
    {
        
    }

	// Use this for initialization
	void Start () {

        checkSprites = new List<Sprite>();
        checkSprites.Add( Resources.Load<Sprite>("checkfals"));
        checkSprites.Add( Resources.Load<Sprite>("check"));

        tasks = new List<GameObject>();
        currentTask = 0;
        tasks = new List<GameObject>();
        for (int i = 0; i < transform.childCount; i++)
        {
            tasks.Add(transform.FindChild("obj" + i).gameObject);
        }

        foreach (var t in tasks)
        {
            t.GetComponentInChildren<Image>().sprite = checkSprites[0];
        }

        transform.parent.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static void TaskCompleted()
    {
        tasks[currentTask++].GetComponentInChildren<Image>().sprite = checkSprites[1];
        PointsManager.points++;
    }
}
