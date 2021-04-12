using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayerManager : GuaranaMedia
{
    [SerializeField] private VideoPlayer player;

    [SerializeField] private VideoClip clipSource;

    protected override bool IsPrepared => this.player.isPrepared;
    protected override void Prepare() => this.player.Prepare();

    protected override void Show(){
       this.player.gameObject.SetActive(true);
       this.player.Play();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

}
