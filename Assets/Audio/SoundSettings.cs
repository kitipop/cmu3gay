using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "SoundSettingsPreset", fileName = "SoundSettingsPreset")]

public class SoundSettings : ScriptableObject
{
    public AudioMixer AudioMixer;

    [Header("MasterVolume")]
    public string MasterVolumeName = "Master";    [Range(-80, 20)]    public float Master;
    [Header("BGMVolume")]
    public string BGMVolumeName = "BGM";    [Range(-80, 20)]    public float BGM;

    [Header("SFXVolume")]
    public string SFXVolumeName = "SFX";    [Range(-80, 20)]    public float SFX;

    [Header("UIVolume")]
    public string UIVolumeName = "UI";    [Range(-80, 20)]    public float UI;
}
