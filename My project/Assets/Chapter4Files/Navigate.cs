using UnityEngine;
using UnityEngine.AI;

public class Navigate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    NavMeshAgent agent;
    public Transform WalkTarget;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(agent.transform.position != WalkTarget.position)
            agent.SetDestination(WalkTarget.position);
    }
}
