//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Scripts/Input/InputActions.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""HumanoidLand"",
            ""id"": ""f1f0461a-cfa5-46db-81ef-2baa027b5e35"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""b85d3542-e1fc-414c-836d-5a1425c104a7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""2910f3fd-49b7-447e-9be9-51ae8e033cb8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""12077d10-69bf-4e2d-bfdc-50ca51063612"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Value"",
                    ""id"": ""046bf842-9663-47f0-a961-91ce0c745321"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4190820c-b6b3-40d6-9e67-586e7c52d5ac"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""55e31fae-66f5-431e-9bdf-497000d2955e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a6c7bffe-aa14-49c6-80da-c06257fc6e88"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d66ed98f-d088-4a3f-908e-91cf2a4f03c0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9297e17c-e729-482a-bd50-78574f1c9ec8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4ecba802-90f8-4371-8d1f-ca809dc98e96"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c91235f0-56b9-454d-b8a1-44577464a206"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""06abce0a-db07-445f-ad0b-58f5bd527b06"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.03,y=0.03)"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""16f0f770-7529-4a80-b7c3-a3dbd27e9aff"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cb4bba0a-5720-4f0b-88d0-78070bcef22a"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1455266b-94e4-40eb-b088-10bd9e16d5f8"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b767dabb-eea7-4fff-ba88-0cd2eb02e250"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HumanoidLand
        m_HumanoidLand = asset.FindActionMap("HumanoidLand", throwIfNotFound: true);
        m_HumanoidLand_Move = m_HumanoidLand.FindAction("Move", throwIfNotFound: true);
        m_HumanoidLand_Look = m_HumanoidLand.FindAction("Look", throwIfNotFound: true);
        m_HumanoidLand_Jump = m_HumanoidLand.FindAction("Jump", throwIfNotFound: true);
        m_HumanoidLand_Run = m_HumanoidLand.FindAction("Run", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // HumanoidLand
    private readonly InputActionMap m_HumanoidLand;
    private IHumanoidLandActions m_HumanoidLandActionsCallbackInterface;
    private readonly InputAction m_HumanoidLand_Move;
    private readonly InputAction m_HumanoidLand_Look;
    private readonly InputAction m_HumanoidLand_Jump;
    private readonly InputAction m_HumanoidLand_Run;
    public struct HumanoidLandActions
    {
        private @InputActions m_Wrapper;
        public HumanoidLandActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_HumanoidLand_Move;
        public InputAction @Look => m_Wrapper.m_HumanoidLand_Look;
        public InputAction @Jump => m_Wrapper.m_HumanoidLand_Jump;
        public InputAction @Run => m_Wrapper.m_HumanoidLand_Run;
        public InputActionMap Get() { return m_Wrapper.m_HumanoidLand; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HumanoidLandActions set) { return set.Get(); }
        public void SetCallbacks(IHumanoidLandActions instance)
        {
            if (m_Wrapper.m_HumanoidLandActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnLook;
                @Jump.started -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnJump;
                @Run.started -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_HumanoidLandActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_HumanoidLandActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public HumanoidLandActions @HumanoidLand => new HumanoidLandActions(this);
    public interface IHumanoidLandActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
