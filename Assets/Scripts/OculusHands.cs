using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour
{
    public InputActionReference gripReference, triggerReference;
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        gripReference.action.started += GripPressed;
        gripReference.action.canceled += GripCanceled;
        triggerReference.action.started += TriggerPressed;
        triggerReference.action.canceled += TriggerCanceled;
    }

    private void OnDestroy()
    {
        gripReference.action.started -= GripPressed;
        gripReference.action.canceled -= GripCanceled;
        triggerReference.action.started -= TriggerPressed;
        triggerReference.action.canceled -= TriggerCanceled;
    }

    void GripPressed(InputAction.CallbackContext junk)
    {
        //Debug.Log("Grip pressed");
        anim.SetBool("GripPressed", true);
    }

    void GripCanceled(InputAction.CallbackContext junk)
    {
        //Debug.Log("Grip released");
        anim.SetBool("GripPressed", false);
    }

    void TriggerPressed(InputAction.CallbackContext junk)
    {
        //Debug.Log("Trigger pressed");
        anim.SetBool("TriggerPressed", true);
    }

    void TriggerCanceled(InputAction.CallbackContext junk)
    {
        //Debug.Log("Trigger released");
        anim.SetBool("TriggerPressed", false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
