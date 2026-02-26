using UnityEngine;
using UnityEngine.AI;

public class FlyingEnemy : MonoBehaviour
{
    public float detectionRange = 6;
    public float updateRate = 0.2f;

    private Transform player;
    private NavMeshAgent agent;
    private float nextUpdateTime;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;

        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(distance <= detectionRange)
        {
            if(Time.time >= nextUpdateTime)
            {
                agent.SetDestination(player.position);
                nextUpdateTime = Time.time + updateRate;
            }
        }
        else
        {
            agent.ResetPath();
        }
    }
}