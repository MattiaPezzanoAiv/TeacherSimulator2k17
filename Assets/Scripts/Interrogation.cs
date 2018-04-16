using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selection : WorldState {

    public Selection(WorldStateMachine sm) : base(sm)
    {
        tablet = GameObject.Find("Canvas").transform.FindChild("Tablet").gameObject;
        lookTablet = Camera.main.transform.forward;
        lookBlackboard = GameObject.Find("Aula_props").transform.FindChild("LIM").FindChild("LOOKAT");
    }

    private GameObject tablet;
    private Vector3 lookTablet;
    private Transform lookBlackboard;

    public override void Enter()
    {
        tablet.SetActive(false);
        tablet.transform.FindChild("Done").gameObject.SetActive(false);
        tablet.transform.FindChild("Close").gameObject.SetActive(true);

        Alumns alumns = tablet.GetComponentInChildren<Alumns>();
        alumns.present.interactable = false;

    }

    public override void Update()
    {
        ManageTabletClick();

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            //look lavagna
            Vector3 newFor = (lookBlackboard.position - Camera.main.transform.position ).normalized;
            Camera.main.transform.forward = Vector3.Lerp(Camera.main.transform.forward, newFor, Time.deltaTime * 2f);
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            //look tablet
            Camera.main.transform.forward = Vector3.Lerp(Camera.main.transform.forward, lookTablet, Time.deltaTime * 2f);
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 200f))
            {
                Right right = hit.collider.GetComponent<Right>();
                if (right != null)
                {
                    SM.Switch(WorldStateMachine.StateName.Temp);
                    CheckList.TaskCompleted();
                    Debug.Log("right");
                    return;
                }
                BlackBoardError error = hit.collider.GetComponent<BlackBoardError>();
                if(error != null)
                {
                    MessageManager.SpawnMessage("Prof. quello non è Power Point!");
                }
            }
        }
    }

    private void ManageTabletClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 200f))
            {
                Tablet tablet = hit.collider.GetComponent<Tablet>();
                if (tablet != null)
                {
                    SM.Switch(WorldStateMachine.StateName.RollCall);
                    Debug.Log("tablet");
                }
            }
        }
    }
}
