using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp = 5;

    public int Hp
    { 
        get
        {
            return hp;
        }
        set
        {
            hp = value;
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log($"{hp} 체력 만큼 남음");
            }
        }
    }


}
