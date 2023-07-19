using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class AudioSlider : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;

    private void Start()
    {
        mixer.GetFloat("Volume", out value);
        volumeSlider.value = value;
    }

    public void SetVolume()
    {
        mixer.SetFloat("Volume", volumeSlider.value);
    }
}
