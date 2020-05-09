using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarObjeto : MonoBehaviour
{
    public TimeRecorder recorder;
    void OnTriggerEnter(Collider col)
    {
        if (!col.gameObject.name.Contains("Grab") && !col.gameObject.name.StartsWith("Mesa") && !col.gameObject.name.StartsWith("Ground"))
        {
            recorder.agarre(col.gameObject.name);
        }
    }
}
