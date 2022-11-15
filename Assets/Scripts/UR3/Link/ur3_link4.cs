using System;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ur3_link4 : MonoBehaviour
{
    void FixedUpdate()
    {
        try
        {
            transform.localEulerAngles = new Vector3(0.0f, 0.0f, 90.0f + (float)(ur_data_processing.UR_Stream_Data.J_Orientation[3] * (180.0 / Math.PI)));
        }
        catch (Exception e)
        {
            Debug.Log("Exception:" + e);
        }
    }
    void OnApplicationQuit()
    {
        Destroy(this);
    }
}
