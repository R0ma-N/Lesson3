
using UnityEngine;
using UnityEngine.AI;

public class AgentNav : MonoBehaviour
{
    public Transform Cell;
    
    void Start()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = Cell.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
