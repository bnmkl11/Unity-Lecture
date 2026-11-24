using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject enemy = GameObject.FindGameObjectWithTag("Enemy");
        if (enemy == null)
        {
            Debug.Log("못찾았다!");
            return;
        }

        Debug.Log(enemy.name + " 찾았다!!!");

        Debug.Log(" ============================================== ");
        // Enemy 라는 태그를 가진 게임 오브젝트 여러개 찾아서 배열에 집어넣는중.
        GameObject[] gameObjectArr = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject go in gameObjectArr)
        {
            Debug.Log(go.name + " 이게있네!!!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 태그에 따라 조건을 따로 처리하는 것도 가능합니다!!
        if (gameObject.tag == "Enemy")
        {
            // 총알을 맞았다!! 처리가 가능하게 된다.
        }
    }
}
