﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OnlineVideoLoader : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public string videoUrl;
    public LocalDatabase localDatabase;
    public string videoUrl1;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.url = videoUrl1+videoUrl;
        Debug.Log(videoPlayer.url);
        videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}