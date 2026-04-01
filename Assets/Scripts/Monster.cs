using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    public float spd = 5.0f;
    public GameObject target;
    Vector3 direct = Vector3.down;

    public GameObject prefabsExplosion;

    private void Start()
    {
        int rndNUm = Random.Range(0, 10);
        if (rndNUm < 3)
        {
            GameObject target = GameObject.Find("Character");
            direct = target.transform.position - transform.position;
            direct.Normalize();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + direct * spd * Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        GameObject explosionObj = Instantiate(prefabsExplosion);
        explosionObj.transform.position = transform.position;

        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
