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
