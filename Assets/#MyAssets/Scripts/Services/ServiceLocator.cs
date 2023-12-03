using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : GenericSingleton<ServiceLocator>
{
    [SerializeField]
    public PlayerSpawnService playerSpawnerPrefab;
    [SerializeField]
    int gameWinBuildIndex, gameLoseBuildIndex, mainMenuBuildIndex;

    public InputService currentInputService { get; private set; }
    public PlayerSpawnService playerSpawnerService { get; private set; }
    public EventService eventService { get; private set; }
    public BulletSpawnService bulletSpawnService { get; private set; }
    public SceneLoadingService sceneLoader { get; private set; }

    protected override void Awake()
    {
        base.Awake();
        currentInputService = new InputService_PC();
        eventService = new EventService();
        bulletSpawnService = new BulletSpawnService();
        sceneLoader = new SceneLoadingService(gameWinBuildIndex, gameLoseBuildIndex, mainMenuBuildIndex);

        playerSpawnerService = Instantiate<PlayerSpawnService>(playerSpawnerPrefab);
        playerSpawnerService.SetInputService(currentInputService);
        playerSpawnerService.SetEventService(eventService);
    }

    //private void Start()
    //{
    //    playerSpawnerService.CreatePlayer(currentInputService);
    //}

    public void SpawnThePlayer()
    {
        playerSpawnerService.CreatePlayer(currentInputService);
    }
}
