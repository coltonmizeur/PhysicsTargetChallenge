using UnityEngine;

public class MovingTarget : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float moveRange = 3f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.PingPong(Time.time * moveSpeed, moveRange * 2f) - moveRange;
        transform.position = startPosition + new Vector3(offset, 0f, 0f);
    }
}