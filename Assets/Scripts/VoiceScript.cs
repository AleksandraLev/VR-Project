using UnityEngine;
using Oculus.Voice;

public class VoiceScript : MonoBehaviour
{
    public AppVoiceExperience voiceExperience;
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.One))
        {
            voiceExperience.Activate();
        }
    }
}