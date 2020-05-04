using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgarrarObjeto : MonoBehaviour
{
    public TimeRecorder recorder;
    void OnTriggerEnter(Collider col)
    {
        recorder.agarre(col.gameObject.name);
    }
}
