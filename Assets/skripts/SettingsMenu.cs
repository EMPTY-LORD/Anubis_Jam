using UnityEngine;
using UnityEngine.Audio; // Audio ad alanını kullanmak için bu satırı ekleyin

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer mainMixer;

    public void SetVolume(float volume)
    {
        mainMixer.SetFloat("volume", volume);
    }
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }
}
