using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : GenericSingleton<ServiceLocator>
{
    [SerializeField]
    public PlayerSpawnService playerSpawnerPrefab;

    public InputService currentInputService { get; private set; }
    public PlayerSpawnService playerSpawnerService { get; private set; }

    public EventService eventService { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        currentInputService = new InputService_PC();
        eventService = new EventService();
        playerSpawnerService = Instantiate<PlayerSpawnService>(playerSpawnerPrefab);
        playerSpawnerService.SetInputService(currentInputService);
        playerSpawnerService.SetEventService(eventService);
    }

    private void Start()
    {
        playerSpawnerService.CreatePlayer(currentInputService);
    }
}
