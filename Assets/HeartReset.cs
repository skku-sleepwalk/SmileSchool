using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartReset : MonoBehaviour
{
    public HeartSystem heartSystem;
    public void Reset()
    {
        heartSystem.RegenHeart(5);
    }
}
