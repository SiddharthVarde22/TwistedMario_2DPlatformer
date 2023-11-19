using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : GenericSingleton<ServiceLocator>
{
    [SerializeField]
    public PlayerSpawnService playerSpawnerPrefab;

    public InputService currentInputService { get; private set; }
    public PlayerSpawnService playerSpawnerService { get; private set; }

    private void Awake()
    {
        currentInputService = new InputService_PC();
        playerSpawnerService = Instantiate<PlayerSpawnService>(playerSpawnerPrefab);
        playerSpawnerService.SetInputService(currentInputService);
        playerSpawnerService.CreatePlayer(currentInputService);
    }
}
