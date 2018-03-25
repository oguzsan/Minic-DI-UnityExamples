// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;
using UnityEngine;
using UnityEngine.UI;


public class SoundPlayerView : MonoBehaviour
{
	//	MEMBERS
	[Inject]
	public IReadonlySettings settings;
    public Text SoundVolumeText;
    public Text MusicStateText;


    //  METHODS
    private void Update ()
	{
        SoundVolumeText.text = "Sound Volume:" + settings.SoundVolume.ToString("0.0");
        MusicStateText.text = "Music playing:" + settings.IsMusicPlaying;
    }
}
