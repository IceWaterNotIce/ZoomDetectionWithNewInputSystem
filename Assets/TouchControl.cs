//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/TouchControl.inputactions
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

public partial class @TouchControl: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @TouchControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""TouchControl"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""02d75f0f-5560-49e5-ba5f-fd2bfc8b55b0"",
            ""actions"": [
                {
                    ""name"": ""PrimaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""4de165dd-1102-4144-99ef-d7d2fa9f4201"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryFingerPosition"",
                    ""type"": ""Value"",
                    ""id"": ""e0b3a9ef-091d-4231-973c-19a497478694"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""SecondaryTouchContact"",
                    ""type"": ""Button"",
                    ""id"": ""d4e621eb-e149-42f7-b8c2-806bf904c1b1"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press"",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8feae3a5-ef13-4386-b676-de7876b130ff"",
                    ""path"": ""<Touchscreen>/touch0/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrimaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b223975d-7c0e-4189-b42a-cbcb19b7ecea"",
                    ""path"": ""<Touchscreen>/touch1/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryFingerPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2391a90b-453c-4e5a-b6f4-39177cc6f2fd"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SecondaryTouchContact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_PrimaryFingerPosition = m_Touch.FindAction("PrimaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryFingerPosition = m_Touch.FindAction("SecondaryFingerPosition", throwIfNotFound: true);
        m_Touch_SecondaryTouchContact = m_Touch.FindAction("SecondaryTouchContact", throwIfNotFound: true);
    }

    ~@TouchControl()
    {
        UnityEngine.Debug.Assert(!m_Touch.enabled, "This will cause a leak and performance issues, TouchControl.Touch.Disable() has not been called.");
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

    // Touch
    private readonly InputActionMap m_Touch;
    private List<ITouchActions> m_TouchActionsCallbackInterfaces = new List<ITouchActions>();
    private readonly InputAction m_Touch_PrimaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryFingerPosition;
    private readonly InputAction m_Touch_SecondaryTouchContact;
    public struct TouchActions
    {
        private @TouchControl m_Wrapper;
        public TouchActions(@TouchControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @PrimaryFingerPosition => m_Wrapper.m_Touch_PrimaryFingerPosition;
        public InputAction @SecondaryFingerPosition => m_Wrapper.m_Touch_SecondaryFingerPosition;
        public InputAction @SecondaryTouchContact => m_Wrapper.m_Touch_SecondaryTouchContact;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void AddCallbacks(ITouchActions instance)
        {
            if (instance == null || m_Wrapper.m_TouchActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TouchActionsCallbackInterfaces.Add(instance);
            @PrimaryFingerPosition.started += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed += instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled += instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed += instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled += instance.OnSecondaryFingerPosition;
            @SecondaryTouchContact.started += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed += instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled += instance.OnSecondaryTouchContact;
        }

        private void UnregisterCallbacks(ITouchActions instance)
        {
            @PrimaryFingerPosition.started -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.performed -= instance.OnPrimaryFingerPosition;
            @PrimaryFingerPosition.canceled -= instance.OnPrimaryFingerPosition;
            @SecondaryFingerPosition.started -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.performed -= instance.OnSecondaryFingerPosition;
            @SecondaryFingerPosition.canceled -= instance.OnSecondaryFingerPosition;
            @SecondaryTouchContact.started -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.performed -= instance.OnSecondaryTouchContact;
            @SecondaryTouchContact.canceled -= instance.OnSecondaryTouchContact;
        }

        public void RemoveCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITouchActions instance)
        {
            foreach (var item in m_Wrapper.m_TouchActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TouchActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnPrimaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryFingerPosition(InputAction.CallbackContext context);
        void OnSecondaryTouchContact(InputAction.CallbackContext context);
    }
}