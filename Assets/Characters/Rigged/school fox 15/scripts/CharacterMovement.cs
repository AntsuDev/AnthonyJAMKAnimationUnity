using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Animator _animator;
    public bool _release = false;
    public bool _ubiubi = false;
        
    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = _animator.GetBool("isWalking");
        bool forwardPressed = Input.GetKey("w");
        

        if (Input.GetKeyDown(KeyCode.R)) 
        { 
            _release = !_release;
            _animator.SetBool("release", _release);
            
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            _ubiubi = !_ubiubi;
            _animator.SetBool("ubiubi", _ubiubi);            
        }
        if (!_ubiubi)
        {
            _ubiubi = false;
        }
        if (!isWalking && forwardPressed)
        {
            _animator.SetBool("isWalking", true);
        }
        if (isWalking && !forwardPressed)
        {
            _animator.SetBool("isWalking", false);
        }

    }
}
