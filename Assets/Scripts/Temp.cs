using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : WorldState
{

    public Temp(WorldStateMachine sm) : base(sm)
    {
        lookTablet = Camera.main.transform.forward;
    }
    private Vector3 lookTablet;

    public override void Update()
    {
        BackInToPose();
        ManageInterrogation();

    }
    public override void Enter()
    {
        GameObject go = GameObject.Find("Canvas").transform.FindChild("Tablet").FindChild("Prefab_CheckList").gameObject;
        go.transform.parent = GameObject.Find("Canvas").transform;
        go.SetActive(true);
        go.GetComponent<RectTransform>().anchoredPosition = new Vector2(-200, -50);
    }

    private void BackInToPose()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //look tablet
            Camera.main.transform.forward = Vector3.Lerp(Camera.main.transform.forward, lookTablet, Time.deltaTime * 2f);
        }
    }
    private void ManageInterrogation()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 200f))
            {
                Student student = hit.collider.GetComponent<Student>();
                if (student != null)
                {
                    SM.Switch(WorldStateMachine.StateName.Final);
                    Debug.Log("final");
                    return;
                }
            }
        }
    }
}
