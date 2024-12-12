//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/Input Actions/PlayerControls.inputactions
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

public partial class @PlayerControls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c7464962-f783-401f-bbc5-402adea5ff8b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""c877051b-b2bb-4ced-a93b-bcff3be625fd"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""098c10e3-6f61-430a-a590-ba1daba48eb7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""98aa7b11-9f6a-487c-b99e-dc98e33b0c33"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""01c6868a-08d8-40b2-b046-097c8ecf6d3d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""0218a9ea-1e15-4ab3-a080-5ea1e87961d4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Equip"",
                    ""type"": ""Button"",
                    ""id"": ""2a919392-c549-4937-88f6-8749a36948e7"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""OpenAndCloseFlashLight"",
                    ""type"": ""Button"",
                    ""id"": ""3eee5f0c-ca18-4af6-a978-5cdfbd359f3c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""92546c94-1c05-440b-87c4-622093626b00"",
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
                    ""id"": ""0007520e-9f97-4bd4-b454-44478be89e96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4fe610a1-806d-4f21-ad0c-386918df5fac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""66040642-1cc0-44a6-abdc-00a28d6fdf10"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""41800081-666d-480e-85c8-3819caaabc53"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c9752473-f207-4804-a0ef-08ff7eda7b62"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b4dea9a-9368-4d6f-8d7b-c0d3775c1db4"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""53df6420-4ba5-4255-984b-a74309dc6b4e"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e86f9fb2-2a8e-426a-a691-e1bae375b99c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5a79c50-d5e4-4ed4-82b2-a561151901df"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""Equip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""857de291-ecda-44bc-9fb1-7bad876d1c93"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard/Mouse"",
                    ""action"": ""OpenAndCloseFlashLight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UIControls"",
            ""id"": ""977a80fa-9201-432e-a699-2f06a738b981"",
            ""actions"": [
                {
                    ""name"": ""Pause Game"",
                    ""type"": ""Button"",
                    ""id"": ""3eb0a772-7789-4d1b-8bc8-0a7c0b682a5b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Tasks Panel"",
                    ""type"": ""Button"",
                    ""id"": ""fbb4015e-ca0f-4ae9-92fc-f1b0c04177c8"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Open Inventory Panel"",
                    ""type"": ""Button"",
                    ""id"": ""c7a17311-0e6c-495c-a51e-290f3faeb741"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4b60f826-1cbd-44e8-be8b-245e06eca3e6"",
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
                    ""id"": ""3b61f242-54f3-4cbf-b750-5989c820b505"",
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
                    ""id"": ""aab548a5-1311-4b28-a940-5e5fd22f884c"",
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
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        m_Player_Look = m_Player.FindAction("Look", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Run = m_Player.FindAction("Run", throwIfNotFound: true);
        m_Player_Interact = m_Player.FindAction("Interact", throwIfNotFound: true);
        m_Player_Equip = m_Player.FindAction("Equip", throwIfNotFound: true);
        m_Player_OpenAndCloseFlashLight = m_Player.FindAction("OpenAndCloseFlashLight", throwIfNotFound: true);
        // UIControls
        m_UIControls = asset.FindActionMap("UIControls", throwIfNotFound: true);
        m_UIControls_PauseGame = m_UIControls.FindAction("Pause Game", throwIfNotFound: true);
        m_UIControls_OpenTasksPanel = m_UIControls.FindAction("Open Tasks Panel", throwIfNotFound: true);
        m_UIControls_OpenInventoryPanel = m_UIControls.FindAction("Open Inventory Panel", throwIfNotFound: true);
    }

    ~@PlayerControls()
    {
        UnityEngine.Debug.Assert(!m_Player.enabled, "This will cause a leak and performance issues, PlayerControls.Player.Disable() has not been called.");
        UnityEngine.Debug.Assert(!m_UIControls.enabled, "This will cause a leak and performance issues, PlayerControls.UIControls.Disable() has not been called.");
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Move;
    private readonly InputAction m_Player_Look;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Run;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_Equip;
    private readonly InputAction m_Player_OpenAndCloseFlashLight;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputAction @Look => m_Wrapper.m_Player_Look;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Run => m_Wrapper.m_Player_Run;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @Equip => m_Wrapper.m_Player_Equip;
        public InputAction @OpenAndCloseFlashLight => m_Wrapper.m_Player_OpenAndCloseFlashLight;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
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
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Equip.started += instance.OnEquip;
            @Equip.performed += instance.OnEquip;
            @Equip.canceled += instance.OnEquip;
            @OpenAndCloseFlashLight.started += instance.OnOpenAndCloseFlashLight;
            @OpenAndCloseFlashLight.performed += instance.OnOpenAndCloseFlashLight;
            @OpenAndCloseFlashLight.canceled += instance.OnOpenAndCloseFlashLight;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Run.started -= instance.OnRun;
            @Run.performed -= instance.OnRun;
            @Run.canceled -= instance.OnRun;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Equip.started -= instance.OnEquip;
            @Equip.performed -= instance.OnEquip;
            @Equip.canceled -= instance.OnEquip;
            @OpenAndCloseFlashLight.started -= instance.OnOpenAndCloseFlashLight;
            @OpenAndCloseFlashLight.performed -= instance.OnOpenAndCloseFlashLight;
            @OpenAndCloseFlashLight.canceled -= instance.OnOpenAndCloseFlashLight;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // UIControls
    private readonly InputActionMap m_UIControls;
    private List<IUIControlsActions> m_UIControlsActionsCallbackInterfaces = new List<IUIControlsActions>();
    private readonly InputAction m_UIControls_PauseGame;
    private readonly InputAction m_UIControls_OpenTasksPanel;
    private readonly InputAction m_UIControls_OpenInventoryPanel;
    public struct UIControlsActions
    {
        private @PlayerControls m_Wrapper;
        public UIControlsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseGame => m_Wrapper.m_UIControls_PauseGame;
        public InputAction @OpenTasksPanel => m_Wrapper.m_UIControls_OpenTasksPanel;
        public InputAction @OpenInventoryPanel => m_Wrapper.m_UIControls_OpenInventoryPanel;
        public InputActionMap Get() { return m_Wrapper.m_UIControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIControlsActions set) { return set.Get(); }
        public void AddCallbacks(IUIControlsActions instance)
        {
            if (instance == null || m_Wrapper.m_UIControlsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIControlsActionsCallbackInterfaces.Add(instance);
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

        private void UnregisterCallbacks(IUIControlsActions instance)
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

        public void RemoveCallbacks(IUIControlsActions instance)
        {
            if (m_Wrapper.m_UIControlsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIControlsActions instance)
        {
            foreach (var item in m_Wrapper.m_UIControlsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIControlsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIControlsActions @UIControls => new UIControlsActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard/Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnEquip(InputAction.CallbackContext context);
        void OnOpenAndCloseFlashLight(InputAction.CallbackContext context);
    }
    public interface IUIControlsActions
    {
        void OnPauseGame(InputAction.CallbackContext context);
        void OnOpenTasksPanel(InputAction.CallbackContext context);
        void OnOpenInventoryPanel(InputAction.CallbackContext context);
    }
}
