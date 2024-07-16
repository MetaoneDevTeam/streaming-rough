using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class RumbleManager : MonoBehaviour
{
    public static RumbleManager instance;
    private Gamepad pad;
    private Coroutine stopRumbleAfterTimeCoroutine;

    private IEnumerator StopRumble(float duration, Gamepad pad)
    {
        float el = 0f;

        while (el < duration)
        {
            el += Time.deltaTime;
            yield return null;
        }

        pad.SetMotorSpeeds(0f, 0f);
    }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void RumblePulse(float lowFrequency, float highFrequency, float duration)
    {
        pad = Gamepad.current;

        if (pad != null)
        {
            // start rm
            pad.SetMotorSpeeds(lowFrequency, highFrequency);
            
            // stop rm
            stopRumbleAfterTimeCoroutine = StartCoroutine(StopRumble(duration, pad));
        }
    }
}
