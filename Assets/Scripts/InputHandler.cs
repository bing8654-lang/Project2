using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    public Vector2 MoveInput {  get; private set; }
    public bool JumpInput { get; private set; }

    void OnMove(InputValue Value)
    {
        MoveInput = Value.Get<Vector2>();
    }

    void OnJump(InputValue Value)
    {
        JumpInput = Value.isPressed;
    }
}
