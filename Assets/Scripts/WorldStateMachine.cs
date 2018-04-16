using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldStateMachine : MonoBehaviour {

    public enum StateName { Idle, RollCall, Selection, Temp, Final}

    private Dictionary<StateName, IWorldState> worldStates;
    private IWorldState current;

    void Awake()
    {
        worldStates = new Dictionary<StateName, IWorldState>();
        // fill dictionary
        worldStates.Add(StateName.Idle, new Idle(this));
        worldStates.Add(StateName.RollCall, new RollCall(this));
        worldStates.Add(StateName.Selection, new Selection(this));
        worldStates.Add(StateName.Temp, new Temp(this));
        worldStates.Add(StateName.Final, new Final(this));
        current = worldStates[StateName.Idle];
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        current.Update();
	}


    public void Switch(StateName stateName)
    {
        current.Exit();
        current = worldStates[stateName];
        current.Enter();
    }
}
