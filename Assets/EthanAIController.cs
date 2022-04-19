using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EthanAIController : MonoBehaviour
{
    [SerializeField]
    private GameObject[] goalPoints;
    NavMeshAgent meshAgent;
    Vector3 lastPoint;
    // Start is called before the first frame update
    void Start()
    {
        goalPoints = GameObject.FindGameObjectsWithTag("GoalPoint");
        meshAgent = GetComponent<NavMeshAgent>();
        GotoLocation();
    }

    // Update is called once per frame
    void Update()
    {
        if(meshAgent.remainingDistance< 1.0f)
        {
            GotoLocation();
        }
    }
    private void GotoLocation()
    {
       // lastPoint = meshAgent.destination;

        meshAgent.SetDestination(goalPoints[Random.Range(0, goalPoints.Length)].transform.position);
       //cam.screenPointToRay() Method

    }
}
