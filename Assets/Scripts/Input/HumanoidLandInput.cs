using UnityEngine;
using UnityEngine.InputSystem;

public class HumanoidLandInput : MonoBehaviour
{
    public Vector2 MoveInput {get; private set; } = Vector2.zero;
    public bool MoveIsPressed = false;
    public Vector2 LookInput {get; private set; } = Vector2.zero;
    public bool InvertMouseY {get; private set; } = true;
    public bool RunIsPressed {get; private set; } = false;
    public bool JumpIsPressed {get; private set; } = false;

    InputActions _input = null;

    private void OnEnable()
    {
        _input = new InputActions();
        _input.HumanoidLand.Enable();  // enable action map

        _input.HumanoidLand.Move.performed += SetMove;
        _input.HumanoidLand.Move.canceled += SetMove;

        _input.HumanoidLand.Look.performed += SetLook;
        _input.HumanoidLand.Look.canceled += SetLook;

        _input.HumanoidLand.Run.started += SetRun;
        _input.HumanoidLand.Run.canceled += SetRun;

        _input.HumanoidLand.Jump.started += SetJump;
        _input.HumanoidLand.Jump.canceled += SetJump;
    }

    private void OnDisable()
    {
        _input.HumanoidLand.Move.performed -= SetMove;
        _input.HumanoidLand.Move.canceled -= SetMove;

        _input.HumanoidLand.Look.performed -= SetLook;
        _input.HumanoidLand.Look.canceled -= SetLook;

        _input.HumanoidLand.Jump.started -= SetRun;
        _input.HumanoidLand.Jump.canceled -= SetRun;

        _input.HumanoidLand.Jump.started -= SetJump;
        _input.HumanoidLand.Jump.canceled -= SetJump;

        _input.HumanoidLand.Disable();
    }


    private void SetMove(InputAction.CallbackContext ctx)
    {
        MoveInput = ctx.ReadValue<Vector2>();
        MoveIsPressed = !(MoveInput == Vector2.zero);
    }

    private void SetJump(InputAction.CallbackContext ctx)
    {
        JumpIsPressed = ctx.started;
    }


    private void SetLook(InputAction.CallbackContext ctx)
    {
        LookInput = ctx.ReadValue<Vector2>();
    }

    private void SetRun(InputAction.CallbackContext ctx)
    {
        RunIsPressed = ctx.started;
    }
}
