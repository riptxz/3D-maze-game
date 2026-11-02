using UnityEngine;

public class ChaseState : EnemyState
{
    public ChaseState(Enemy enemy, EnemyStateMachine sm) : base(enemy, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Chasing");
    }

    public override void Update()
    {
        if(Vector3.Distance(enemy.NavAgent.destination, enemy.playerPos.position) < 30f)
        {
            enemy.NavAgent.destination = enemy.playerPos.position;
        }


        //if(Vector3.Distance(enemy.NavAgent.destination, enemy.playerPos.position) >= 31f)
        //{
        //    sm.ChangeState(sm.patrolState);
        //}

        if(Input.GetKey("e"))
        {
            sm.ChangeState(sm.patrolState);
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
