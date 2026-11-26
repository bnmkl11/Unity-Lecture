using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    private int score = 10;

    // 동전의 회전하는 스피드.
    public float turnSpeed = 90;

    private void Update()
    {
        transform.Rotate (Vector3.up * turnSpeed * Time.deltaTime, Space.World);
    }

    // 코인이 플레이어랑 닿으면 플레이어의 점수를 증가시켜준다.
    private void OnTriggerEnter(Collider other)
    {
        // 태그가 플레이어인 경우에만 통과시켜준다!!
        if (other.gameObject.CompareTag("Player") == false)
            return;

        PlayerKeyMove player = other.gameObject.GetComponent<PlayerKeyMove>();
        //  플레이어 컴포넌트가 없는 경우. 즉 null인 경우.
        if (player == null)
            return;

        // 플레이어의 점수를 증가시켜주는 기능을 만들어야 한다.
        player.AddScore(score);
        Destroy(gameObject);
    }

}
