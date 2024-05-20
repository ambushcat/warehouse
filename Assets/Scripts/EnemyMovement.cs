using TMPro;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;

    void Start()
    {
        targetPoint = 0;
    }

    void Update()
    {
        Vector3 targetPosition = patrolPoints[targetPoint].position;
        Vector3 direction = targetPosition - transform.position;

        if (transform.position == targetPosition)
        {
            increaseTargetInt();
        }
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(direction);
    }

    void increaseTargetInt()
    {
        targetPoint++;
        if(targetPoint >= patrolPoints.Length)
        {
            targetPoint = 0;
        }
    }
}
