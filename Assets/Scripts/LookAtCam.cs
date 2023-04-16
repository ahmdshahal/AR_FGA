using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCam : MonoBehaviour
{
    [SerializeField] private Transform target;

    private void OnEnable()
    {
        transform.LookAt(target);
    }
}
