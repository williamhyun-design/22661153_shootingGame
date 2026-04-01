using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutBullet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Bullet(Clone)")
        Destroy(other.gameObject);
    }
}
