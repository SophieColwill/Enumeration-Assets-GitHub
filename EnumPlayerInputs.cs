//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/Managers/EnumPlayerInputs.inputactions
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

public partial class @EnumPlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @EnumPlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""EnumPlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Main"",
            ""id"": ""59b54556-8473-4fbc-8d1b-b9aef5cf3c04"",
            ""actions"": [
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""3f977d98-d154-47b0-8489-18ba03619f4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fd2b924f-4f63-4536-baff-f8d9b5d496ac"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Remove Enum Action"",
                    ""type"": ""Button"",
                    ""id"": ""5baedf55-fcae-486d-9630-2c7cd94f1294"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Move Enum Action"",
                    ""type"": ""Button"",
                    ""id"": ""867b13c6-ac58-4c26-aba1-2b82c4494c0f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Taller Enum Action"",
                    ""type"": ""Button"",
                    ""id"": ""54e92ec1-5fce-4d23-88ac-ea16e8a09b46"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shorter Enum Action"",
                    ""type"": ""Button"",
                    ""id"": ""730120f7-f551-44ee-b6eb-58baddfba1d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Color Change Input Action"",
                    ""type"": ""Button"",
                    ""id"": ""6e1398d3-2ebf-49d2-b23a-7c7787957782"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""13543bbb-29d3-4605-a3e1-0d1204fa49b8"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""3D Vector"",
                    ""id"": ""869de5b2-a25c-4f95-a241-74e8a1642fa9"",
                    ""path"": ""3DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0272a13a-702e-4aa4-95f8-3b4261302d5e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7e06a891-3324-468e-97df-c07a623da227"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6a31731f-7a7c-4f38-93b5-4eeeae6de7f4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""19fd9610-9224-4061-bc0b-40c2757b97bb"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""forward"",
                    ""id"": ""30ccff23-a408-4009-935d-feea259edb0d"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""backward"",
                    ""id"": ""e53a54a3-1b25-45e3-8025-f8e4c88c8b9b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""82c17424-8953-4790-b0ce-f74ab2b200c2"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Remove Enum Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5eecce0e-2f82-45be-b501-f03cef9a3f37"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move Enum Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce2ac17f-2082-41e5-bea6-57c0bd1d6663"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Taller Enum Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0933fc15-4732-4a1d-886e-d2a959b208a3"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shorter Enum Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f715245-64b9-4421-b8e7-bbd17ef0c549"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Color Change Input Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Main
        m_Main = asset.FindActionMap("Main", throwIfNotFound: true);
        m_Main_Action = m_Main.FindAction("Action", throwIfNotFound: true);
        m_Main_Movement = m_Main.FindAction("Movement", throwIfNotFound: true);
        m_Main_RemoveEnumAction = m_Main.FindAction("Remove Enum Action", throwIfNotFound: true);
        m_Main_MoveEnumAction = m_Main.FindAction("Move Enum Action", throwIfNotFound: true);
        m_Main_TallerEnumAction = m_Main.FindAction("Taller Enum Action", throwIfNotFound: true);
        m_Main_ShorterEnumAction = m_Main.FindAction("Shorter Enum Action", throwIfNotFound: true);
        m_Main_ColorChangeInputAction = m_Main.FindAction("Color Change Input Action", throwIfNotFound: true);
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

    // Main
    private readonly InputActionMap m_Main;
    private List<IMainActions> m_MainActionsCallbackInterfaces = new List<IMainActions>();
    private readonly InputAction m_Main_Action;
    private readonly InputAction m_Main_Movement;
    private readonly InputAction m_Main_RemoveEnumAction;
    private readonly InputAction m_Main_MoveEnumAction;
    private readonly InputAction m_Main_TallerEnumAction;
    private readonly InputAction m_Main_ShorterEnumAction;
    private readonly InputAction m_Main_ColorChangeInputAction;
    public struct MainActions
    {
        private @EnumPlayerInputs m_Wrapper;
        public MainActions(@EnumPlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Action => m_Wrapper.m_Main_Action;
        public InputAction @Movement => m_Wrapper.m_Main_Movement;
        public InputAction @RemoveEnumAction => m_Wrapper.m_Main_RemoveEnumAction;
        public InputAction @MoveEnumAction => m_Wrapper.m_Main_MoveEnumAction;
        public InputAction @TallerEnumAction => m_Wrapper.m_Main_TallerEnumAction;
        public InputAction @ShorterEnumAction => m_Wrapper.m_Main_ShorterEnumAction;
        public InputAction @ColorChangeInputAction => m_Wrapper.m_Main_ColorChangeInputAction;
        public InputActionMap Get() { return m_Wrapper.m_Main; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MainActions set) { return set.Get(); }
        public void AddCallbacks(IMainActions instance)
        {
            if (instance == null || m_Wrapper.m_MainActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MainActionsCallbackInterfaces.Add(instance);
            @Action.started += instance.OnAction;
            @Action.performed += instance.OnAction;
            @Action.canceled += instance.OnAction;
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @RemoveEnumAction.started += instance.OnRemoveEnumAction;
            @RemoveEnumAction.performed += instance.OnRemoveEnumAction;
            @RemoveEnumAction.canceled += instance.OnRemoveEnumAction;
            @MoveEnumAction.started += instance.OnMoveEnumAction;
            @MoveEnumAction.performed += instance.OnMoveEnumAction;
            @MoveEnumAction.canceled += instance.OnMoveEnumAction;
            @TallerEnumAction.started += instance.OnTallerEnumAction;
            @TallerEnumAction.performed += instance.OnTallerEnumAction;
            @TallerEnumAction.canceled += instance.OnTallerEnumAction;
            @ShorterEnumAction.started += instance.OnShorterEnumAction;
            @ShorterEnumAction.performed += instance.OnShorterEnumAction;
            @ShorterEnumAction.canceled += instance.OnShorterEnumAction;
            @ColorChangeInputAction.started += instance.OnColorChangeInputAction;
            @ColorChangeInputAction.performed += instance.OnColorChangeInputAction;
            @ColorChangeInputAction.canceled += instance.OnColorChangeInputAction;
        }

        private void UnregisterCallbacks(IMainActions instance)
        {
            @Action.started -= instance.OnAction;
            @Action.performed -= instance.OnAction;
            @Action.canceled -= instance.OnAction;
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @RemoveEnumAction.started -= instance.OnRemoveEnumAction;
            @RemoveEnumAction.performed -= instance.OnRemoveEnumAction;
            @RemoveEnumAction.canceled -= instance.OnRemoveEnumAction;
            @MoveEnumAction.started -= instance.OnMoveEnumAction;
            @MoveEnumAction.performed -= instance.OnMoveEnumAction;
            @MoveEnumAction.canceled -= instance.OnMoveEnumAction;
            @TallerEnumAction.started -= instance.OnTallerEnumAction;
            @TallerEnumAction.performed -= instance.OnTallerEnumAction;
            @TallerEnumAction.canceled -= instance.OnTallerEnumAction;
            @ShorterEnumAction.started -= instance.OnShorterEnumAction;
            @ShorterEnumAction.performed -= instance.OnShorterEnumAction;
            @ShorterEnumAction.canceled -= instance.OnShorterEnumAction;
            @ColorChangeInputAction.started -= instance.OnColorChangeInputAction;
            @ColorChangeInputAction.performed -= instance.OnColorChangeInputAction;
            @ColorChangeInputAction.canceled -= instance.OnColorChangeInputAction;
        }

        public void RemoveCallbacks(IMainActions instance)
        {
            if (m_Wrapper.m_MainActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMainActions instance)
        {
            foreach (var item in m_Wrapper.m_MainActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MainActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MainActions @Main => new MainActions(this);
    public interface IMainActions
    {
        void OnAction(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
        void OnRemoveEnumAction(InputAction.CallbackContext context);
        void OnMoveEnumAction(InputAction.CallbackContext context);
        void OnTallerEnumAction(InputAction.CallbackContext context);
        void OnShorterEnumAction(InputAction.CallbackContext context);
        void OnColorChangeInputAction(InputAction.CallbackContext context);
    }
}
