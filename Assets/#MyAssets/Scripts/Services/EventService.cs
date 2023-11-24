using System;
using UnityEngine;

public class EventService
{
    public event Action<PlayerController> OnPlayerSpawnedEvent;

    public void TriggerOnPlayerSpawnedEvent(PlayerController playerController)
    {
        OnPlayerSpawnedEvent?.Invoke(playerController);
    }
}
