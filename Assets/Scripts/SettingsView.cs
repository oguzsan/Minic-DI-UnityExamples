// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;
using UnityEngine;


public class SettingsView : MonoBehaviour
{
	//	MEMBERS
	[Inject]
	public ISettings settings;
	
	
    //  METHODS
    public void VolumeUp_OnClick()
    {
        settings.SetSoundVolume(Mathf.Min(settings.SoundVolume + 0.1f, 1.0f));
    }

    public void VolumeDown_OnClick()
    {
        settings.SetSoundVolume(Mathf.Max(settings.SoundVolume - 0.1f, 0.0f));
    }

    public void ToggleMusic_OnClick()
    {
        settings.ToggleMusic();
    }
}
