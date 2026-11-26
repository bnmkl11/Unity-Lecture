using UnityEngine;

public class PlayerKeyMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    [SerializeField]
    private float turnSpeed = 90f;

    public GameObject bulletPrefab;

    // 코인 먹기용 점수 스코어.
    private int score;

    /// <summary>
    ///  점수를 증가시켜주는 메소드.
    /// </summary>
    /// <param name="score"></param>
    public void AddScore(int score)
    {
        this.score += score;
    }

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
            GameObject copiedBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Bullet bullet = copiedBullet.GetComponent<Bullet>();
            // GetComponent 메소드를 통해서 해당 컴포넌트가 존재하지 않으면 
            // null을 반환합니다.
            // 이미 존재하는 컴포넌트면 해당 컴포넌트를 찾아서 반환을 해줍니다.
            if (bullet == null)
                return;

            //SphereCollider collider = copiedBullet.GetComponent<SphereCollider>();
            //collider.radius = 100;

            MeshRenderer meshRenderer = copiedBullet.GetComponent<MeshRenderer>();
            meshRenderer.material.color = Color.red;

            // bullet.Fire();

            BulletTest bulletTest = bullet.gameObject.AddComponent<BulletTest>();
        }
    }
}
