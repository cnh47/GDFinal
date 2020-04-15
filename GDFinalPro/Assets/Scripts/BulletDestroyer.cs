using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyer : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Debug.Log("Bullet Destroyed");
        Destroy(gameObject);
    }


}
