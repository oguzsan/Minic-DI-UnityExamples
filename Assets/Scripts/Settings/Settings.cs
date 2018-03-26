// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;


public class Settings : ISettings
{
    //  MEMBERS
    public float SoundVolume { get; protected set; }
    public bool IsMusicPlaying { get; protected set; }
    
    
    //  CONSTRUCTOR
    public Settings()
    {
        SoundVolume = 1;
        IsMusicPlaying = true;
    }
    
    
    // METHODS
    public virtual void SetSoundVolume(float value)
    {
        SoundVolume = value;
    }
    
    public virtual void ToggleMusic()
    {
        IsMusicPlaying = !IsMusicPlaying;
    }

}
