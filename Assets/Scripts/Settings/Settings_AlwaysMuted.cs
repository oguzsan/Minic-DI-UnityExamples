using System;


public class Settings_AlwaysMuted : Settings
{
    //  CONSTRUCTOR
    public Settings_AlwaysMuted()
    {
        SoundVolume = 0;
        IsMusicPlaying = false;
    }


    //  METHODS
    public override void SetSoundVolume(float value)
    {}

    public override void ToggleMusic()
    {}
}
