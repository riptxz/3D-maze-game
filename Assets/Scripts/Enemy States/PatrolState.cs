using UnityEngine;
using UnityEngine.AI;

public class PatrolState : EnemyState
{
    public PatrolState(Enemy enemy, EnemyStateMachine sm) : base(enemy, sm)
    {
    }

    public override void Enter()
    {
        base.Enter();
        Debug.Log("Patrolling");
    }

    public override void Update()
    {
        if (!enemy.NavAgent.pathPending && enemy.NavAgent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }

       // if(Vector3.Distance(enemy.enemyPos, enemy.playerPos))
      //  {

       // }
    }

    public void GoToNextPoint()
    {
        if (enemy.points.Length == 0)
        {
            return;
        }
        enemy.NavAgent.destination = enemy.points[enemy.destPoint].position;
        enemy.destPoint = (enemy.destPoint + 1) % enemy.points.Length;
    }


    public override void Exit()
    {
        base.Exit();
    }
}
