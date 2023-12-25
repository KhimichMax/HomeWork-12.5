using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using WildBoll.Inputs;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    private bool isOpen;
    private void Awake()
    {
       _anim = GetComponent<Animator>();
    }

    private void Start()
    {
        if (isOpen)
        {
            _anim.SetBool("open", true);
        }
    }

    private void OnCollisionStay(Collision _boxCollider)
    {
        if (_boxCollider.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown(GlobalStringVars.JUMP_AXES))
            {
                isOpen = !isOpen;
                Debug.Log(isOpen);
                if (isOpen)
                {
                    _anim.SetBool("open", true);
                }
                else
                {
                    _anim.SetBool("open", false);
                }
            }
        }
    }
}
