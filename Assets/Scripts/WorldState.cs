using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldState : IWorldState {
    public WorldStateMachine SM
    {
        get; set;
    }

    public WorldState(WorldStateMachine sm)
    {
        this.SM = sm;
    }
    public virtual void Enter()
    {
    }

    public virtual void Exit()
    {

    }

   

    public virtual void Update()
    {
    }

   
}

public interface IWorldState
{
    WorldStateMachine SM { get; set; }

    void Enter();
    void Update();
    void Exit();
}
