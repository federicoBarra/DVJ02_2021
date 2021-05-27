using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseEntity : MonoBehaviour
{
    public static event Action OnDestroy;

    public virtual void MeMori()
    {
        OnDestroy?.Invoke();
    }


}
