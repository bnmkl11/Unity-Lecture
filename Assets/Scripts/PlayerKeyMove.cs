using UnityEngine;

public class PlayerKeyMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    private float turnSpeed = 90f;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        // W 키를 계속 누르면 계속 앞으로 나아간다.
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

        // A키를 계속 누르면 왼쪽으로 계속 회전하겠죠.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -turnSpeed * Time.deltaTime, 0);
        }

        // D키를 계속 누르면 왼쪽으로 계속 회전하겠죠.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0 , turnSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
