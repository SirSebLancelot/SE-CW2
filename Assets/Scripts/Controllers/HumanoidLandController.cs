using System;
using UnityEngine;

public class HumanoidLandController : MonoBehaviour
{   
    public Transform CameraFollow;
    Rigidbody _rigidbody = null;
    // store capsule colider
    CapsuleCollider _capsulecollider = null;
    [SerializeField] HumanoidLandInput _input;

    Vector3 _playerMoveInput = Vector3.zero;

    Vector3 _playerLookInput = Vector3.zero;  
    Vector3 _previousPlayerLookInput = Vector3.zero;
    float _cameraPitch = 0.0f;
    [SerializeField] float _playerLookInputLerpTime = 0.35f;

    [Header("Movement")]
    [SerializeField] float _movementMultiplier = 30.0f;
    [SerializeField] float _rotationSpeedMultiplier = 180.0f;
    [SerializeField] float _pitchSpeedMultiplier = 180.0f;
    [SerializeField] float _runMultiplier = 2.0f;

    [Header("Ground check")]
    [SerializeField] bool _playerIsGrounded = true;
    [SerializeField] [Range(0.0f, 1.8f)] float _groundCheckRadiusMultiplier = 0.9f;
    [SerializeField] [Range(-0.95f, 1.05f)] float _groundCheckDistance = 0.05f;
    RaycastHit _groundCheckHit = new RaycastHit();

    [Header("Gravity")]
    [SerializeField] float _gravityFallCurrent = -100.0f;
    [SerializeField] float _gravityFallMin = -100.0f;
    [SerializeField] float _gravityFallMax = -500.0f;
    [SerializeField] [Range(-5.0f, -35.0f)] float _gravityFallIncrementAmount = -20.0f;
    [SerializeField] float _gravityFallIncrementTime = -0.05f;
    [SerializeField] float _playerFallTimer = 0.0f;
    [SerializeField] float _gravity = 0.0f;

    [Header("Jumping")]
    [SerializeField] float _initialJumpForce = 750.0f;
    [SerializeField] float _continualJumpForceMultiplier = 0.1f;
    [SerializeField] float _jumpTime = 0.175f;
    [SerializeField] float _jumpTimeCounter = 0.0f;
    [SerializeField] float _coyoteTime = 0.15f;
    [SerializeField] float _coyoteTimeCounter = 0.0f;
    [SerializeField] float _jumpBufferTime = 0.2f;
    [SerializeField] float _jumpBufferTimeCounter = 0.0f;
    [SerializeField] bool _playerIsJumping = false;
    [SerializeField] bool _jumpWasPressedLastFrame = false;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _capsulecollider = GetComponent<CapsuleCollider>();
    }
    


    // private void Awake()
    // {
    //     _rigidbody = GetComponent<Rigidbody>();
    // } 

    private void FixedUpdate()
    {
        _playerLookInput = GetLookInput();
        PlayerLook();
        PitchCamera();

        _playerMoveInput = GetMoveInput();
        _playerIsGrounded = PlayerGroundCheck();


        _playerMoveInput = PlayerRun();
        _playerMoveInput.y = PlayerGravity();
        _playerMoveInput.y = PlayerJump();
        
        _playerMoveInput = PlayerMove();
        

        _rigidbody.AddRelativeForce(_playerMoveInput, ForceMode.Force);
    }

    private Vector3 GetLookInput()
    {
        _previousPlayerLookInput = _playerLookInput;
        _playerLookInput = new Vector3(_input.LookInput.x, (_input.InvertMouseY ? - _input.LookInput.y : _input.LookInput.y), 0.0f);
        return Vector3.Lerp(_previousPlayerLookInput, _playerLookInput * Time.deltaTime, _playerLookInputLerpTime);   
    }

    private void PlayerLook()
    {
        _rigidbody.rotation = Quaternion.Euler(0.0f, _rigidbody.rotation.eulerAngles.y + (_playerLookInput.x * _rotationSpeedMultiplier), 0.0f);
    }

    private void PitchCamera()
    {
        // Vector3 rotationValues = CameraFollow.rotation.eulerAngles;
        _cameraPitch += _playerLookInput.y * _pitchSpeedMultiplier;
        _cameraPitch = Math.Clamp(_cameraPitch, -89.9f, 89.9f);

        CameraFollow.rotation = Quaternion.Euler(_cameraPitch, CameraFollow.rotation.eulerAngles.y, CameraFollow.rotation.eulerAngles.z);
    }

    private Vector3 GetMoveInput()
    {
        return new Vector3(_input.MoveInput.x, 0.0f, _input.MoveInput.y);
    }

    private bool PlayerGroundCheck()
    {
        float sphereCastRadius = _capsulecollider.radius * _groundCheckRadiusMultiplier;
        // take center of capsule collider and get height of y - sphereCastTravelDistance
        float sphereCastTravelDistance = _capsulecollider.bounds.extents.y - sphereCastRadius + _groundCheckDistance;
        // sphereCast - invisible sphere below feet
        return Physics.SphereCast(_rigidbody.position, sphereCastRadius, Vector3.down, out _groundCheckHit, sphereCastTravelDistance);
    }

    private float PlayerGravity()
    {
        if (_playerIsGrounded)
        {
            _gravity = 0.0f;
            _gravityFallCurrent = _gravityFallMin;
        }
        else 
        {
            _playerFallTimer -= Time.fixedDeltaTime;
            if (_playerFallTimer < 0.0f)
            {
                if (_gravityFallCurrent > _gravityFallMax)
                {
                    _gravityFallCurrent += _gravityFallIncrementAmount;
                }
                _playerFallTimer = _gravityFallIncrementTime;
                _gravity = _gravityFallCurrent;
            }
        }
        return _gravity;
    }

    private Vector3 PlayerRun()
    {
        Vector3 calculatedPlayerRunSpeed = _playerMoveInput;
        if (_input.RunIsPressed)
        {
            calculatedPlayerRunSpeed.x *= _runMultiplier;
            calculatedPlayerRunSpeed.z *= _runMultiplier;
        }
        return calculatedPlayerRunSpeed;
    }

    private Vector3 PlayerMove()
    {
        Vector3 calculatedPlayerMovement=  (new Vector3(_playerMoveInput.x * _movementMultiplier * _rigidbody.mass,
                                        _playerMoveInput.y * _rigidbody.mass,
                                        _playerMoveInput.z * _movementMultiplier * _rigidbody.mass));

        return calculatedPlayerMovement;  
    }

    private float PlayerJump()
    {
        float calculatedJumpInput = _playerMoveInput.y;

        SetJumpTimeCounter();
        SetCoyoteTimeCounter();
        SetJumpBufferTimeCounter();

        if (_jumpBufferTimeCounter > 0.0f && !_playerIsJumping && _coyoteTimeCounter > 0.0f)
        {
            // first intial jump
            calculatedJumpInput = _initialJumpForce;
            _playerIsJumping = true;
            _jumpBufferTimeCounter = 0.0f;
            _coyoteTimeCounter = 0.0f;
        }
        else if (_input.JumpIsPressed && _playerIsJumping && !_playerIsGrounded && _jumpTimeCounter > 0.0f)
        {
            // variable jump height
            calculatedJumpInput = _initialJumpForce * _continualJumpForceMultiplier;
        }
        else if (_playerIsJumping && _playerIsGrounded)
        {
            _playerIsJumping = false;
        }
        return calculatedJumpInput;
    }

    private void SetJumpTimeCounter()
    {
        if (_playerIsJumping && !_playerIsGrounded)
        {
            _jumpTimeCounter -= Time.fixedDeltaTime;
        }
        else
        {
            _jumpTimeCounter = _jumpTime;
        }
    }

    private void SetCoyoteTimeCounter()
    {
        if (_playerIsGrounded)
        {
            _coyoteTimeCounter = _coyoteTime;
        }
        else
        {
            _coyoteTimeCounter -= Time.fixedDeltaTime;
        }
    }

    private void SetJumpBufferTimeCounter()
    {
        if (!_jumpWasPressedLastFrame && _input.JumpIsPressed)
        {
            _jumpBufferTimeCounter = _jumpBufferTime;
        }
        else if (_jumpBufferTimeCounter > 0.0f)
        {
            _jumpBufferTimeCounter -= Time.fixedDeltaTime;
        }
        _jumpWasPressedLastFrame = _input.JumpIsPressed;
    }

}
