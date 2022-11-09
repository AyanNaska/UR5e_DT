using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerarotators : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            transform.Rotate(0, speed * Time.deltaTime, 0);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            transform.Rotate(0, -speed * Time.deltaTime, 0);
    }
}
