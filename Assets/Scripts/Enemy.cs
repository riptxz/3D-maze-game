using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    EnemyStateMachine sm;

    public Transform[] points;
    public Vector3 playerPos;
    public Vector3 enemyPos;

    public NavMeshAgent NavAgent;

    public int destPoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sm = new EnemyStateMachine(this);
        sm.Init(sm.patrolState); // Start in the patrol state
    }

    // Update is called once per frame
    void Update()
    {
        sm.Update();
    }

    private void FixedUpdate()
    {
        sm.FixedUpdate();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        sm.currentState.OnCollisionEnter2D(collision);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        sm.currentState.OnTriggerEnter2D(collision);
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        sm.currentState.OnTriggerExit2D(collision);
    }
}
