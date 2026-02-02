using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;


public class MonsterMove : MonoBehaviour
{
    float x = 0;
    float y = 0;
    public float speed = 3.0f; // 몬스터 이동 속도
    public IObjectPool<GameObject> Pool { get; set; }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
        if (transform.position.x < -18) { 
       
        Destroy(gameObject);
        }
    }
    

}
