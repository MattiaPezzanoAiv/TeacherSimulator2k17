using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegisterDone : MonoBehaviour
{

    public Alumns alumns;
    public WorldStateMachine sm;

    private Dictionary<string,bool> classMap;

    void Awake()
    {
        classMap = new Dictionary<string, bool>();
        classMap.Add("Sergio Rossi", true);
        classMap.Add("Mattia Rossi", true);
        classMap.Add("Luca Rossi", true);
        classMap.Add("Elena Rossi", true);
        classMap.Add("Samuel Rossi", true);
        classMap.Add("Claudio Rossi", true);
        classMap.Add("Mario Rossi", false);
        classMap.Add("Paolo Rossi", false);
        classMap.Add("Chiara Rossi", false);


    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Close()
    {
        sm.Switch(WorldStateMachine.StateName.Selection);
    }
    public void Done()
    {
        foreach (var data in alumns.GetData())
        {
            if(data.Value.present != classMap[data.Value.name])
            {
                MessageManager.SpawnMessage("Prof. non ha segnato tutti i presenti!");
                return;
            }
        }

        sm.Switch(WorldStateMachine.StateName.Selection);
        CheckList.TaskCompleted();
        Debug.Log("interroga");
    }
}
