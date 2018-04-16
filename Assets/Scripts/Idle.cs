using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : WorldState {

    private float hintTime = 10;
    private float hintCD = 5f;

    public override void Enter()
    {
        hintCD = hintTime;
    }
    public Idle(WorldStateMachine sm):base(sm)
    {

    }
    public override void Update()
    {
        ManageHint();

        ManageTabletClick();
    }


    private void ManageTabletClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit, 200f))
            {
                Tablet tablet = hit.collider.GetComponent<Tablet>();
                if(tablet != null)
                {
                    SM.Switch(WorldStateMachine.StateName.RollCall);
                    CheckList.TaskCompleted();
                }
            }
        }
    }

    private void ManageHint()
    {
        if (hintCD > 0)
            hintCD -= Time.deltaTime;
        if(hintCD <= 0)
        {
            //spawn hint
            MessageManager.SpawnMessage("Prof. Deve fare l'appello!");
            hintCD = hintTime;
        }
    }

    
}
