using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, Controls.IRumbleActions
{
    public static InputManager instance;
    [HideInInspector] public Controls controls;
    
    public float lHorizontal;
    public float lVertical;
    public float rHorizontal;
    public float rVertical;

    public Vector2 lNormalized;
    public Vector2 rNormalized;

    public Vector2 lLerped;
    public Vector2 rLerped;

    [SerializeField]
    private float _lerpMultiplier;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        controls = new Controls();
        controls.Rumble.SetCallbacks(this);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        lVertical = InputManager.instance.controls.OnFoot.LSVertical.ReadValue<float>();
        lHorizontal = InputManager.instance.controls.OnFoot.LSHorizontal.ReadValue<float>();
        
        rVertical = InputManager.instance.controls.OnFoot.RSVertical.ReadValue<float>();
        rHorizontal = InputManager.instance.controls.OnFoot.RSHorizontal.ReadValue<float>();

        lNormalized.Set(lHorizontal, lVertical);
        lNormalized = Vector2.ClampMagnitude(lNormalized, 1f);
        
        rNormalized.Set(rHorizontal, rVertical);
        rNormalized = Vector2.ClampMagnitude(rNormalized, 1f);

        lLerped = Vector2.Lerp(lLerped, lNormalized, _lerpMultiplier * Time.deltaTime);
        rLerped = Vector2.Lerp(rLerped, rNormalized, _lerpMultiplier * Time.deltaTime);
    }

    public void OnRumbleAction(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }
}
