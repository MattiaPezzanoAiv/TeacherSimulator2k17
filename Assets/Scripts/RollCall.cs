using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollCall : WorldState {

    private GameObject uiTablet;

    public RollCall(WorldStateMachine sm) : base(sm)
    {
        uiTablet = GameObject.Find("Canvas").transform.FindChild("Tablet").gameObject;
    }

    public override void Enter()
    {
        //showTablet
        uiTablet.SetActive(true);
    }
    public override void Update()
    {

    }
}
