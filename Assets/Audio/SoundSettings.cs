using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "SoundSettingsPreset", fileName = "SoundSettingsPreset")]

public class SoundSettings : ScriptableObject
{
    public AudioMixer AudioMixer;

    [Header("MasterVolume")]
    public string MasterVolumeName = "Master";
    [Header("BGMVolume")]
    public string BGMVolumeName = "BGM";

    [Header("SFXVolume")]
    public string SFXVolumeName = "SFX";

    [Header("UIVolume")]
    public string UIVolumeName = "UI";
}