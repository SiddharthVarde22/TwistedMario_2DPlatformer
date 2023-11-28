using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    PlayerController playerController;
    IWeapon weapon;

    [SerializeField]
    Rigidbody2D playerRigidbody;
    [SerializeField]
    LayerMask groundDetectionLayer;
    [SerializeField]
    float groundCheckRaycastDistance = 0.8f;
    [SerializeField]
    Transform gunHoldingPlace;
    [SerializeField]
    Vector3 gunPositionOffset;

    public void SetPlayerController(PlayerController playerController)
    {
        this.playerController = playerController;
    }

    public PlayerController GetPlayerController()
    {
        return playerController;
    }

    public void MovePlayerHorizontally(float horizontalInput, float movementSpeed)
    {
        RotatePlayer(horizontalInput);
        transform.position += horizontalInput * movementSpeed * Time.deltaTime * Vector3.right;
    }

    private void RotatePlayer(float horizontalInput)
    {
        if(horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if(horizontalInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    public void MakePlayerJump(float jumpStrength)
    {
        if (CheckIfIsGrounded())
        {
            playerRigidbody.AddForce(transform.up * jumpStrength, ForceMode2D.Impulse);
        }
    }

    public void MakePlayerShoot()
    {
        if(weapon != null)
        {
            weapon.OnWeaponFired(this);
        }
    }
    private bool CheckIfIsGrounded()
    {
        return Physics2D.Raycast(transform.position, -1 * transform.up, groundCheckRaycastDistance, groundDetectionLayer);
    }

    public void CollectTheWeapon(IWeapon weapon)
    {
        if(this.weapon == null)
        {
            this.weapon = weapon;

            ((Gun)this.weapon).gameObject.transform.parent = gunHoldingPlace;
            ((Gun)this.weapon).transform.SetLocalPositionAndRotation(Vector3.zero + gunPositionOffset, Quaternion.identity);
        }
    }

    public void OnCollidedWithObstacle()
    {
        ServiceLocator.Instance.sceneLoader.ReloadScene();
    }

    public void OnEnemyKilled()
    {
        Debug.Log("Enemy killed");
    }
}
