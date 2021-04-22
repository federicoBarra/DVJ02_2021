using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public Transform target;

    public Transform baseTranform;
    public Transform cannonTranform;

    public float baseRotationSpeed = 10;
    public float cannonRotationSpeed = 5;

    // Update is called once per frame
    void Update()
    {
        //base rotation
        Vector3 aDondeEstoyMirando = target.position;
        aDondeEstoyMirando.y = 0;
        Quaternion q01 = Quaternion.identity;

        Vector3 posicionDesdeDondeMiro = baseTranform.position;

        q01.SetLookRotation(aDondeEstoyMirando - posicionDesdeDondeMiro, Vector3.up); // similar to Quaternion.LookRotation
        baseTranform.rotation = Quaternion.Slerp(baseTranform.rotation, q01, Time.deltaTime * baseRotationSpeed);

        //cannon rotation
        Quaternion q02 = Quaternion.identity;
        posicionDesdeDondeMiro = cannonTranform.position;
        
        q02.SetLookRotation(posicionDesdeDondeMiro - posicionDesdeDondeMiro, Vector3.up); // similar to Quaternion.LookRotation

        Vector3 newEulers = q02.eulerAngles;
        newEulers.y = 0;
        newEulers.z = 0;
        q02 = Quaternion.Euler(newEulers);
        
        cannonTranform.localRotation = Quaternion.Slerp(cannonTranform.localRotation, q02, Time.deltaTime * cannonRotationSpeed);
    }
}
