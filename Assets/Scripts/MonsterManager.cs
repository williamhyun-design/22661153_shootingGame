using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterManager : MonoBehaviour
{
    public GameObject prefabsMonster;
    float nowTime;
    public float createTime = 1f;

    private void Start()
    {
        
    }
    void Update()
    {
        nowTime = nowTime + Time.deltaTime;

        if (nowTime > createTime)
        {
            GameObject monster = Instantiate(prefabsMonster);
            monster.transform.position = transform.position;
            nowTime = 0;
        }
    }
}
