using System;

public abstract class InputService
{
    public float HorizontalInput { get; protected set; }

    public Action OnJumpButtonPressedEvent;
    public Action OnFireButtonPressedEvent;

    public abstract void GetHorizontalInput();
    public abstract void GetJumpInput();
    public abstract void GetFireInput();
}
