using System;

public abstract class InputService
{
    public float HorizontalInput { get; protected set; }
    //public float VerticalInput { get; protected set; }

    public Action OnJumpButtonPressedEvent;

    public abstract void GetHorizontalInput();
    //public abstract void GetVerticalInput();
    public abstract void GetJumpInput();
}
