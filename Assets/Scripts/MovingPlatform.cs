using UnityEngine;


// 특정한 위치에서 시작해서 -> 특정한 위치로 도착하고
// 그리고 왔다갔다 

public class MovingPlatform : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 startPos;
    private Vector3 offset;

    public float moveSpeed = 1;
    public float offsetDistance = 30;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        startPos = transform.position;
        rigidbody.isKinematic = true;

        offset = Vector3.forward * offsetDistance;
    }

    private void FixedUpdate()
    {
        float t = Mathf.PingPong(Time.time * moveSpeed, 1f);
        Vector3 target = startPos + offset * t;

        rigidbody.MovePosition(target);
    }

}
