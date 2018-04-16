using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPoints : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Text>().text = "Il tuo punteggio è: " + PointsManager.points + "/3.5";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
