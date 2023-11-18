using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : GenericSingleton<ServiceLocator>
{
    public InputService currentInputService { get; private set; }

    private void Awake()
    {
        currentInputService = new InputService_PC();
    }
}
