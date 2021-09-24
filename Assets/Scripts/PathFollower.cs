using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollower : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float arrivalThreshold;

    private Path path;
    private Waypoint currentWaypoint;

    void Start()
    {
        SetupPath();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        float distanceToWaypoint = Vector3.Distance(transform.position, currentWaypoint.GetPosition());
        if (distanceToWaypoint <= arrivalThreshold)
        {
            print(distanceToWaypoint);
            if (currentWaypoint == path.GetPathEnd())
            {
                PathComplete();
            }
            else
            {
                currentWaypoint = path.GetNextWaypoint(currentWaypoint);
                transform.LookAt(currentWaypoint.GetPosition());
            }
        }
    }

    private void SetupPath()
    {
        path = FindObjectOfType<Path>();
        currentWaypoint = path.GetPathStart();
    }

    private void PathComplete()
    {
        Destroy (this.gameObject);
    }
}
