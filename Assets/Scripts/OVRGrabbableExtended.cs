using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OVRGrabbableExtended : OVRGrabbable
{
    [HideInInspector] public UnityEngine.Events.UnityEvent OnGrabBegin;
    [HideInInspector] public UnityEngine.Events.UnityEvent OnGrabEnd;
    public TimeRecorder grabador;

    public override void GrabBegin(OVRGrabber hand, Collider grabPoint)
    {
        OnGrabBegin.Invoke();
        grabador.agarraObjeto(grabPoint.gameObject.name);
    }

    public override void GrabEnd(Vector3 linearVelocity, Vector3 angularVelocity)
    {
        OnGrabEnd.Invoke();
        grabador.sueltaObjeto();
    }
}