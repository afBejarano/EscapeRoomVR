using UnityEngine;

public class AgarrarObjeto : MonoBehaviour
{
    public TimeRecorder recorder;
    void OnTriggerEnter(Collider col)
    {
        if ((col.tag.Equals("mano")))
        {
            recorder.agarre(this.gameObject.name);
        }
    }
}