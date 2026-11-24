using System;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float speed = 10;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
            Debug.Log("계속 부딫히는 중");
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
            Debug.Log("나간다!!!!");
    }


    private void OnTriggerEnter(Collider other)
    {
        //// 플레이어 태그를 가지면 예외처리!!
        //if (other.gameObject.tag == "Player")
        //    return;

        //Debug.Log("Bullet이 " + other.gameObject.name + " 부딫혔다!!");

        //if (other.gameObject.tag == "Enemy")
        //{
        //    Debug.Log("적을 맞춤!!!");
        //    Destroy(other.gameObject);
        //}

        //Destroy(gameObject);

        if (other.gameObject.tag == "Enemy")
            Debug.Log("처음 부딫힘!!!");

    }

    private void OnCollisionEnter(Collision collision)
    {
        // 플레이어 태그를 가지면 예외처리!!
        if (collision.gameObject.tag == "Player")
            return;

        Debug.Log("Bullet이 " + collision.gameObject.name + " 부딫혔다!!");

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("적을 맞춤!!!");
            Destroy(collision.gameObject);
        }

        Destroy(gameObject);
    }

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
        //Debug.Log(gameObject.name + "비활성화!!");
    }


    private void OnDestroy()
    {
        //Debug.Log(gameObject.name + " 사라진다!!!");
    }

    public void Fire()
    {
        //Debug.Log("총알이 나가욧!!!");
    }

}
