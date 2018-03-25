using System;


public interface ISettings : IReadonlySettings
{
	//  METHODS
	void SetSoundVolume(float value);
	void ToggleMusic();
}
