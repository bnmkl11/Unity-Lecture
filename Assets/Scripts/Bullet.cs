using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3초뒤에 나 게임오브젝트 삭제하겠다. 예약.
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log(gameObject.name + "비활성화!!");
    }


    private void OnDestroy()
    {
        Debug.Log(gameObject.name + " 사라진다!!!");
    }

}
