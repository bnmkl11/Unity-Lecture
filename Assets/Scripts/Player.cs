using UnityEngine;

public class Player : MonoBehaviour
{
    int a = 0;
    float speed = 5;

    // 가장 먼저 실행되는 최초의 메소드입니다.
    // 오브젝트의 붙어있는 스크립트중에 가장먼저 실행되는 메소드.
    private void Awake()
    {
        string name = gameObject.name;
        a = 10;
        
        Debug.Log( name + " Awake 실행!!!!!!!!!!!!!!!!");
        // 데이터를 가져와서 오브젝트를 초기화하거나.
        // 모델리을 불러와서. 여러가지 초기화 작업 진행.
    }

    // 오브젝트를 활성화 할때 마다 실행되는 메소드에요.
    // 게임 시작시에도 한번 실행.
    private void OnEnable()
    {
        Debug.Log(gameObject.name +  " OnEnable2");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string name = gameObject.name;
        Debug.Log(name + " 플레이어의 스타트 메소드 실행!!!!");
    }

    // 매프레임마다 실행시키는 메소드.
    private void Update()
    {
        // 벡터에 직접 값을 더해서 이동시키는 기능.
        transform.position += Vector3.forward * speed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x += Time.deltaTime * speed;
        transform.position = pos;

        transform.localScale += Vector3.one * Time.deltaTime;

        transform.Rotate(0, 50 * Time.deltaTime, 0);
    }



}
