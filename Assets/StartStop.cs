using UnityEngine;
using UnityEngine.Video;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class StartStop : MonoBehaviour
{
    private VideoPlayer player;
    public Button button;
    public Sprite playsprite;
    public Sprite pausesprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
        public void ChangeStartStop() 
    { 
        if (player.isPlaying == false)
        {
            player.Play();
            button.image.sprite = pausesprite;
        }
        else
        {
            player.Pause();
            button.image.sprite = playsprite;
        }
    
        
    }
}
