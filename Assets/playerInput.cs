// GENERATED AUTOMATICALLY FROM 'Assets/playerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""playerInput"",
    ""maps"": [
        {
            ""name"": ""UiInputs"",
            ""id"": ""bd572ad2-3ae7-40dd-86e8-e49ced537a89"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""380fb2e7-408d-4062-b66e-b58b498e12d0"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""stop"",
                    ""type"": ""Value"",
                    ""id"": ""c0686c4b-6f93-4d9c-ab88-3621a13400ae"",
                    ""expectedControlType"": ""Touch"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""a794e14d-c889-44c8-bfc8-030613623acb"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5a1a8009-6b76-4fff-b39c-e32fc1fa06e9"",
                    ""path"": ""<Touchscreen>/primaryTouch"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""stop"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // UiInputs
        m_UiInputs = asset.FindActionMap("UiInputs", throwIfNotFound: true);
        m_UiInputs_Move = m_UiInputs.FindAction("Move", throwIfNotFound: true);
        m_UiInputs_stop = m_UiInputs.FindAction("stop", throwIfNotFound: true);
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

    // UiInputs
    private readonly InputActionMap m_UiInputs;
    private IUiInputsActions m_UiInputsActionsCallbackInterface;
    private readonly InputAction m_UiInputs_Move;
    private readonly InputAction m_UiInputs_stop;
    public struct UiInputsActions
    {
        private @PlayerInput m_Wrapper;
        public UiInputsActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_UiInputs_Move;
        public InputAction @stop => m_Wrapper.m_UiInputs_stop;
        public InputActionMap Get() { return m_Wrapper.m_UiInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UiInputsActions set) { return set.Get(); }
        public void SetCallbacks(IUiInputsActions instance)
        {
            if (m_Wrapper.m_UiInputsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnMove;
                @stop.started -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnStop;
                @stop.performed -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnStop;
                @stop.canceled -= m_Wrapper.m_UiInputsActionsCallbackInterface.OnStop;
            }
            m_Wrapper.m_UiInputsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @stop.started += instance.OnStop;
                @stop.performed += instance.OnStop;
                @stop.canceled += instance.OnStop;
            }
        }
    }
    public UiInputsActions @UiInputs => new UiInputsActions(this);
    public interface IUiInputsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnStop(InputAction.CallbackContext context);
    }
}
