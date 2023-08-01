using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    public MovementManager movementManager;

    public void Jump()
    {
        if (movementManager.isJumping == false)
        {
            movementManager.isJumping = true;
            
            movementManager.rb.velocity += Vector2.up * 15f;
        }
    }
}
