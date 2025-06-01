using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class PowerupVFXTrigger : MonoBehaviour
{
    public VisualEffect powerupVFX;

    public void TriggerPowerupVFX()
    {
        if (powerupVFX != null)
        {
            powerupVFX.SendEvent("OnPlay"); // Make sure VFX listens for this
        }
    }
}
