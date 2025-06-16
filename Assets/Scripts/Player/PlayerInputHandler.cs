using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerMover))]
public class PlayerInputHandler : MonoBehaviour
{
    private PlayerInputActions inputActions;
    private PlayerMover mover;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        mover = GetComponent<PlayerMover>();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    void Update()
    {
        Vector2 moveInput = inputActions.Player.Move.ReadValue<Vector2>();
        mover.Move(moveInput);
    }
}