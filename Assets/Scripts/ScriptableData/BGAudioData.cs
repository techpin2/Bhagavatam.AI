using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/BGAudioData", order = 1)]
public class BGAudioData : ScriptableObject
{
    public List<Data> datas;

}

[Serializable]
public class Data
{
    public Sprite BackgroundImage;
    public Color BackgroundColor;
    public AudioClip FluitAudio;
}
