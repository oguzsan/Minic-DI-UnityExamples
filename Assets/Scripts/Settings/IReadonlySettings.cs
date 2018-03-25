// Copyright (c) 2018 Oğuz Sandıkçı
// This code is licensed under MIT license (see LICENSE.txt for details)

using System;


public interface IReadonlySettings
{
    //  MEMBERS
    float SoundVolume { get; }
    bool IsMusicPlaying{ get; }
}
