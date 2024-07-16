//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.2
//     from Assets/TutorialInfo/InputActions/Controls.inputactions
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
using UnityEngine;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""Rumble"",
            ""id"": ""62666270-6abb-4b32-b35f-9089470a5aa0"",
            ""actions"": [
                {
                    ""name"": ""RumbleAction"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8097f957-8d0d-4f6b-91d8-63dedf381fe8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""452283ec-e2a4-4595-a939-8aeb1c54b627"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard"",
                    ""action"": ""RumbleAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea74fcf2-5242-453b-bc20-90f1646ad59d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RumbleAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""OnFoot"",
            ""id"": ""9196e626-68f2-499d-badc-b9fc6aa2e9a3"",
            ""actions"": [
                {
                    ""name"": ""LSVertical"",
                    ""type"": ""Value"",
                    ""id"": ""4b119781-f079-4578-9716-d1afe3eba3f2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""LSHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""4c593cec-a7a5-474b-847f-6b89c013460b"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RSHorizontal"",
                    ""type"": ""Value"",
                    ""id"": ""b31819c5-f9d9-44fc-b3c0-1a9474838d0c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""RSVertical"",
                    ""type"": ""Value"",
                    ""id"": ""6b83079b-160e-416d-818f-49df4ec865b2"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""VerticalInput"",
                    ""id"": ""c91e3c9a-150a-4a95-8f5f-7c8974ce20c0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LSVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""efdce40f-f992-4ba7-a144-e9a5d38d7183"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""LSVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""1949ce78-2026-409d-a443-0dcc7bcc8745"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""LSVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalInput"",
                    ""id"": ""2b3ad6ab-d644-40ca-8dca-0bc9eab2d2cd"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LSHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""11a8af98-5f49-4810-82f2-2ddcc9ffe9fe"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""LSHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""e7af538d-26c7-4031-aaa4-89a152e56dd8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""LSHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""HorizontalInput"",
                    ""id"": ""1787d3f3-fe29-4ef1-95da-7e15ca0401f1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RSHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""e37eaebb-70be-46da-b865-87991610a535"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RSHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""07ada4fb-41a2-4e2b-8fe2-841ffccf7d2a"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RSHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""VerticalInput"",
                    ""id"": ""cd3cf6c1-3044-43c5-913e-f459e03e2178"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RSVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""7a62f902-b3b4-423a-8a6c-27b7ffd356eb"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RSVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""236ec9f7-20cc-410e-8151-9c24bf93ff8e"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone"",
                    ""groups"": "";Gamepad"",
                    ""action"": ""RSVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // Rumble
        m_Rumble = asset.FindActionMap("Rumble", throwIfNotFound: true);
        m_Rumble_RumbleAction = m_Rumble.FindAction("RumbleAction", throwIfNotFound: true);
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_LSVertical = m_OnFoot.FindAction("LSVertical", throwIfNotFound: true);
        m_OnFoot_LSHorizontal = m_OnFoot.FindAction("LSHorizontal", throwIfNotFound: true);
        m_OnFoot_RSHorizontal = m_OnFoot.FindAction("RSHorizontal", throwIfNotFound: true);
        m_OnFoot_RSVertical = m_OnFoot.FindAction("RSVertical", throwIfNotFound: true);
    }

    ~@Controls()
    {
        Debug.Assert(!m_Rumble.enabled, "This will cause a leak and performance issues, Controls.Rumble.Disable() has not been called.");
        Debug.Assert(!m_OnFoot.enabled, "This will cause a leak and performance issues, Controls.OnFoot.Disable() has not been called.");
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

    // Rumble
    private readonly InputActionMap m_Rumble;
    private List<IRumbleActions> m_RumbleActionsCallbackInterfaces = new List<IRumbleActions>();
    private readonly InputAction m_Rumble_RumbleAction;
    public struct RumbleActions
    {
        private @Controls m_Wrapper;
        public RumbleActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @RumbleAction => m_Wrapper.m_Rumble_RumbleAction;
        public InputActionMap Get() { return m_Wrapper.m_Rumble; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(RumbleActions set) { return set.Get(); }
        public void AddCallbacks(IRumbleActions instance)
        {
            if (instance == null || m_Wrapper.m_RumbleActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_RumbleActionsCallbackInterfaces.Add(instance);
            @RumbleAction.started += instance.OnRumbleAction;
            @RumbleAction.performed += instance.OnRumbleAction;
            @RumbleAction.canceled += instance.OnRumbleAction;
        }

        private void UnregisterCallbacks(IRumbleActions instance)
        {
            @RumbleAction.started -= instance.OnRumbleAction;
            @RumbleAction.performed -= instance.OnRumbleAction;
            @RumbleAction.canceled -= instance.OnRumbleAction;
        }

        public void RemoveCallbacks(IRumbleActions instance)
        {
            if (m_Wrapper.m_RumbleActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IRumbleActions instance)
        {
            foreach (var item in m_Wrapper.m_RumbleActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_RumbleActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public RumbleActions @Rumble => new RumbleActions(this);

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private List<IOnFootActions> m_OnFootActionsCallbackInterfaces = new List<IOnFootActions>();
    private readonly InputAction m_OnFoot_LSVertical;
    private readonly InputAction m_OnFoot_LSHorizontal;
    private readonly InputAction m_OnFoot_RSHorizontal;
    private readonly InputAction m_OnFoot_RSVertical;
    public struct OnFootActions
    {
        private @Controls m_Wrapper;
        public OnFootActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @LSVertical => m_Wrapper.m_OnFoot_LSVertical;
        public InputAction @LSHorizontal => m_Wrapper.m_OnFoot_LSHorizontal;
        public InputAction @RSHorizontal => m_Wrapper.m_OnFoot_RSHorizontal;
        public InputAction @RSVertical => m_Wrapper.m_OnFoot_RSVertical;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void AddCallbacks(IOnFootActions instance)
        {
            if (instance == null || m_Wrapper.m_OnFootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Add(instance);
            @LSVertical.started += instance.OnLSVertical;
            @LSVertical.performed += instance.OnLSVertical;
            @LSVertical.canceled += instance.OnLSVertical;
            @LSHorizontal.started += instance.OnLSHorizontal;
            @LSHorizontal.performed += instance.OnLSHorizontal;
            @LSHorizontal.canceled += instance.OnLSHorizontal;
            @RSHorizontal.started += instance.OnRSHorizontal;
            @RSHorizontal.performed += instance.OnRSHorizontal;
            @RSHorizontal.canceled += instance.OnRSHorizontal;
            @RSVertical.started += instance.OnRSVertical;
            @RSVertical.performed += instance.OnRSVertical;
            @RSVertical.canceled += instance.OnRSVertical;
        }

        private void UnregisterCallbacks(IOnFootActions instance)
        {
            @LSVertical.started -= instance.OnLSVertical;
            @LSVertical.performed -= instance.OnLSVertical;
            @LSVertical.canceled -= instance.OnLSVertical;
            @LSHorizontal.started -= instance.OnLSHorizontal;
            @LSHorizontal.performed -= instance.OnLSHorizontal;
            @LSHorizontal.canceled -= instance.OnLSHorizontal;
            @RSHorizontal.started -= instance.OnRSHorizontal;
            @RSHorizontal.performed -= instance.OnRSHorizontal;
            @RSHorizontal.canceled -= instance.OnRSHorizontal;
            @RSVertical.started -= instance.OnRSVertical;
            @RSVertical.performed -= instance.OnRSVertical;
            @RSVertical.canceled -= instance.OnRSVertical;
        }

        public void RemoveCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnFootActions instance)
        {
            foreach (var item in m_Wrapper.m_OnFootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IRumbleActions
    {
        void OnRumbleAction(InputAction.CallbackContext context);
    }
    public interface IOnFootActions
    {
        void OnLSVertical(InputAction.CallbackContext context);
        void OnLSHorizontal(InputAction.CallbackContext context);
        void OnRSHorizontal(InputAction.CallbackContext context);
        void OnRSVertical(InputAction.CallbackContext context);
    }
}
