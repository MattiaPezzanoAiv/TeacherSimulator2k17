using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Final : WorldState {

    private GameObject question;

    public Final(WorldStateMachine sm) : base(sm)
    {
        question = GameObject.Find("Canvas").transform.FindChild("Question").gameObject;
        question.SetActive(false);
    }

    public override void Enter()
    {
        question.SetActive(true);
        CheckList.TaskCompleted();
    }

    public override void Update()
    {

    }
}
