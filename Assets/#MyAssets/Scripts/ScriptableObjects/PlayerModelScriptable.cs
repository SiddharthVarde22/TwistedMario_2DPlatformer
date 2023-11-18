using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerModelScriptable", menuName = "ScriptableObject/PlayerModel")]
public class PlayerModelScriptable : ScriptableObject
{
    public float playerSpeed = 10;
    public float playerJumpStrength = 10;
}
