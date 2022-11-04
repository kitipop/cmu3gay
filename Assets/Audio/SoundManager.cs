using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField] protected SoundSettings m_SoundSettings;

    public Slider m_SliderMasterVolume;
    public Slider m_SliderBGMVolume;    public Slider m_SliderSFXVolume;
    public Slider m_SliderUIVolume;


    // Start is called before the first frame update
    void Start()
    {
        InitialiseVolumes();
    }

    private void InitialiseVolumes()
    {
        SetMasterVolume(m_SoundSettings.Master);        SetBGMVolume(m_SoundSettings.BGM);        SetSFXVolume(m_SoundSettings.SFX);
        SetUIVolume(m_SoundSettings.UI);
    }

    public void SetMasterVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.MasterVolumeName, vol);
        m_SoundSettings.Master = vol;        m_SliderMasterVolume.value = m_SoundSettings.Master;
    }

    public void SetBGMVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.BGMVolumeName, vol);
        m_SoundSettings.BGM = vol;        m_SliderBGMVolume.value = m_SoundSettings.BGM;
    }
    public void SetSFXVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.SFXVolumeName, vol);
        m_SoundSettings.SFX = vol;        m_SliderSFXVolume.value = m_SoundSettings.SFX;
    }
    public void SetUIVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.UIVolumeName, vol);
        m_SoundSettings.UI = vol;        m_SliderUIVolume.value = m_SoundSettings.UI;
    }


}
