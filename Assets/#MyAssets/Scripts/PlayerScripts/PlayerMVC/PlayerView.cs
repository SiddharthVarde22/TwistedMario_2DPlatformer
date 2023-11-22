using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    PlayerController playerController;

    [SerializeField]
    Rigidbody2D playerRigidbody;
    [SerializeField]
    LayerMask groundDetectionLayer;
    [SerializeField]
    float groundCheckRaycastDistance = 0.8f;

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
        transform.position += horizontalInput * movementSpeed * Time.deltaTime * transform.right;
    }

    public void MakePlayerJump(float jumpStrength)
    {
        if (CheckIfIsGrounded())
        {
            playerRigidbody.AddForce(transform.up * jumpStrength, ForceMode2D.Impulse);
        }
    }

    private bool CheckIfIsGrounded()
    {
        return Physics2D.Raycast(transform.position, -1 * transform.up, groundCheckRaycastDistance, groundDetectionLayer);
    }
}
