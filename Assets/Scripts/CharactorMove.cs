using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{
    public float spd = 5;
    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float targetY = 0f;

        if (h >= 0.1f) targetY = -40f;
        else if (h <= -0.1f) targetY = 40f;

        Quaternion targetRot = Quaternion.Euler(0, targetY, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime * 5f);

        Vector3 direct = new Vector3(h, v, 0);
        transform.position = transform.position + direct * spd * Time.deltaTime;
    }
}
