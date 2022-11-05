using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundManager : MonoBehaviour
{
    [SerializeField] protected SoundSettings m_SoundSettings;

    public Slider m_SliderMasterVolume;
    public Slider m_SliderBGMVolume;
    public Slider m_SliderUIVolume;


    // Start is called before the first frame update
    void Start()
    {
        InitialiseVolumes();
    }

    private void InitialiseVolumes()
    {
        SetMasterVolume(m_SoundSettings.Master);
        SetUIVolume(m_SoundSettings.UI);
    }

    public void SetMasterVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.MasterVolumeName, vol);
        m_SoundSettings.Master = vol;
    }

    public void SetBGMVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.BGMVolumeName, vol);
        m_SoundSettings.BGM = vol;
    }
    public void SetSFXVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.SFXVolumeName, vol);
        m_SoundSettings.SFX = vol;
    }
    public void SetUIVolume(float vol)
    {
        m_SoundSettings.AudioMixer.SetFloat(m_SoundSettings.UIVolumeName, vol);
        m_SoundSettings.UI = vol;
    }


}