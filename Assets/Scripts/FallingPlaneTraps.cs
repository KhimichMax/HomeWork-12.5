using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlaneTraps : MonoBehaviour
{
    private Animation anim;
    private void Awake()
    {
        anim = GetComponent<Animation>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.Play("FallingPlaneAnimation");
        }
    }
}
