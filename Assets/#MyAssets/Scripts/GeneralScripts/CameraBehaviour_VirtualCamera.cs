using UnityEngine;
using Cinemachine;

public class CameraBehaviour_VirtualCamera : MonoBehaviour
{
    [SerializeField]
    CinemachineVirtualCamera virtualCamera;

    private void Awake()
    {
        ServiceLocator.Instance.eventService.OnPlayerSpawnedEvent += OnPlayerSpawnedEventTriggered;
    }

    public void OnPlayerSpawnedEventTriggered(PlayerController playerController)
    {
        virtualCamera.Follow = playerController.GetPlayerView().transform;
    }

    private void OnDestroy()
    {
        ServiceLocator.Instance.eventService.OnPlayerSpawnedEvent -= OnPlayerSpawnedEventTriggered;
    }
}
