using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 offset;

    // 카메라가 따라가야 하는 타깃.
    [SerializeField]
    private GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 게임 시작할때 현재 카메라의 위치랑 타깃의 위치를 빼서 오프셋값을 정한다.
        // 타깃에서 카메라를 향하는 벡터를 만들어서 오프셋에 저장합니다.
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.transform.position + offset;
    }
}
