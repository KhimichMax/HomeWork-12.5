using System;
using UnityEngine;
using WildBoll.Inputs;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator _anim;
    public GameObject _obj;
    
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

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _obj.GetComponent<CanvasGroup>().alpha += Time.deltaTime / 2;
            
            if (Input.GetButtonDown(GlobalStringVars.JUMP_AXES))
            {
                isOpen = !isOpen;
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

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            _obj.GetComponent<CanvasGroup>().alpha = 0;
        }
    }
    
}
