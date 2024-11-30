//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input Actions/UIControls.inputactions
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

public partial class @UIControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @UIControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""UIControls"",
    ""maps"": [
        {
            ""name"": ""UI"",
            ""id"": ""be60368a-53af-4b89-bbfa-30aa7e272925"",
            ""actions"": [
                {
                    ""name"": ""Pause Game"",
                    ""type"": ""Button"",
                    ""id"": ""b47b700d-d5a7-4846-8954-fb0f64e20adb"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Tasks Panel"",
                    ""type"": ""Button"",
                    ""id"": ""e6c509f6-0988-40ea-99a8-fdffc189bb0c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Inventory Panel"",
                    ""type"": ""Button"",
                    ""id"": ""a6b06439-c6e6-4e7d-820d-c49167733177"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c82e9728-cb20-4435-8006-37d1c1aa6af2"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Pause Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6c6482ee-6559-4935-bd06-10e83dfa302c"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Open Tasks Panel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e21c76e-10a7-4146-95d6-f4260f948915"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Open Inventory Panel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard/Mouse"",
            ""bindingGroup"": ""Keyboard/Mouse"",
            ""devices"": []
        }
    ]
}");
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_PauseGame = m_UI.FindAction("Pause Game", throwIfNotFound: true);
        m_UI_OpenTasksPanel = m_UI.FindAction("Open Tasks Panel", throwIfNotFound: true);
        m_UI_OpenInventoryPanel = m_UI.FindAction("Open Inventory Panel", throwIfNotFound: true);
    }

    ~@UIControls()
    {
        UnityEngine.Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, UIControls.UI.Disable() has not been called.");
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

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_PauseGame;
    private readonly InputAction m_UI_OpenTasksPanel;
    private readonly InputAction m_UI_OpenInventoryPanel;
    public struct UIActions
    {
        private @UIControls m_Wrapper;
        public UIActions(@UIControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseGame => m_Wrapper.m_UI_PauseGame;
        public InputAction @OpenTasksPanel => m_Wrapper.m_UI_OpenTasksPanel;
        public InputAction @OpenInventoryPanel => m_Wrapper.m_UI_OpenInventoryPanel;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @PauseGame.started += instance.OnPauseGame;
            @PauseGame.performed += instance.OnPauseGame;
            @PauseGame.canceled += instance.OnPauseGame;
            @OpenTasksPanel.started += instance.OnOpenTasksPanel;
            @OpenTasksPanel.performed += instance.OnOpenTasksPanel;
            @OpenTasksPanel.canceled += instance.OnOpenTasksPanel;
            @OpenInventoryPanel.started += instance.OnOpenInventoryPanel;
            @OpenInventoryPanel.performed += instance.OnOpenInventoryPanel;
            @OpenInventoryPanel.canceled += instance.OnOpenInventoryPanel;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @PauseGame.started -= instance.OnPauseGame;
            @PauseGame.performed -= instance.OnPauseGame;
            @PauseGame.canceled -= instance.OnPauseGame;
            @OpenTasksPanel.started -= instance.OnOpenTasksPanel;
            @OpenTasksPanel.performed -= instance.OnOpenTasksPanel;
            @OpenTasksPanel.canceled -= instance.OnOpenTasksPanel;
            @OpenInventoryPanel.started -= instance.OnOpenInventoryPanel;
            @OpenInventoryPanel.performed -= instance.OnOpenInventoryPanel;
            @OpenInventoryPanel.canceled -= instance.OnOpenInventoryPanel;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IUIActions
    {
        void OnPauseGame(InputAction.CallbackContext context);
        void OnOpenTasksPanel(InputAction.CallbackContext context);
        void OnOpenInventoryPanel(InputAction.CallbackContext context);
    }
}
