using System.Collections;
using UnityEngine;

public class cameremove : MonoBehaviour
{
    public GameObject Character;
    Transform At;
    Vector2 startPos;
        // Start is called before the first frame update
    void Start()
    {
        At = Character.transform;
        startPos = transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (At.transform.position.x > startPos.x && At.transform.position.x < 3.086001) 
        {
            transform.position = new Vector3(At.position.x, transform.position.y, At.position.z-10);

        }
    }
}
