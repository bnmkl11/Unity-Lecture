using UnityEngine;

public class PlayerRigidbodyMove : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody;
    private Vector3 dir;

    public float speed = 10;

    public float jumpPower = 10f;

    // 점프인지 아닌지 알 수 있는 불값 변수.
    private bool isJump = false;

    // 땅에 있는지 아닌지 변수.
    private bool isGround = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Debug.Log($"수평 : {h}, 수직 : {v}");

        dir = new Vector3(h, 0, v);

        // 땅에 붙어있고 스페이스 키를 누른 경우에만 작동.
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isJump = true;
        }
    }

    private void FixedUpdate()
    {
        // 매직넘버.
        Vector3 velocity = dir * speed;
        // y에 적용되고 속도를 유지하고 싶어서 y를 집어넣음.
        velocity.y = rigidbody.linearVelocity.y;
        rigidbody.linearVelocity = velocity;

        if (isJump)
        {
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
            isJump = false;
        }
    }
}
