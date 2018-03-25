// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;


public class Settings : ISettings
{
    //  MEMBERS
    public float SoundVolume { get; private set; }
    public bool IsMusicPlaying { get; private set; }
    
    
    //  CONSTRUCTOR
    public Settings()
    {
        SoundVolume = 1;
        IsMusicPlaying = true;
    }
    
    
    // METHODS
    public void SetSoundVolume(float value)
    {
        SoundVolume = value;
    }
    
    public void ToggleMusic()
    {
        IsMusicPlaying = !IsMusicPlaying;
    }
}
