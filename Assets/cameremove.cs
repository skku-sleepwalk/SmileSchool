using System.Collections;
using UnityEngine;

public class cameremove : MonoBehaviour
{
    public GameObject Character;
    Transform At;
        // Start is called before the first frame update
    void Start()
    {
        At = Character.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(At.position.x, At.position.y, At.position.z-10);
    }
}
