using UnityEngine;

public class GameInput : MonoBehaviour
{
    private PlayerInputSystem playerInputSystem;
    private void Awake()
    {
        playerInputSystem = new PlayerInputSystem();
        playerInputSystem.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerInputSystem.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
