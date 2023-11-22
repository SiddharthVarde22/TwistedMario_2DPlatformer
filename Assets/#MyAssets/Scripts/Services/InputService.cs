using System;

public abstract class InputService
{
    public float HorizontalInput { get; protected set; }

    public Action OnJumpButtonPressedEvent;

    public abstract void GetHorizontalInput();
    public abstract void GetJumpInput();
}
