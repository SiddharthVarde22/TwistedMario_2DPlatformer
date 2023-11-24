using System;
using UnityEngine;

public class InputService_PC : InputService
{
    public override void GetHorizontalInput()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
    }

    public override void GetJumpInput()
    {
        if(Input.GetButtonDown("Jump"))
        {
            OnJumpButtonPressedEvent?.Invoke();
        }
    }

    public override void GetFireInput()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            OnFireButtonPressedEvent?.Invoke();
        }
    }
}
