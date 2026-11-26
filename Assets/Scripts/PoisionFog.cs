using UnityEngine;

public class PoisionFog : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("독안개 입장!!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("독안개 안에 있음.");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("독안개 빠져나옴.");
    }
}
