using UnityEngine;

public class AudioTest : MonoBehaviour
{
    public AudioSource cauldron;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void playAudio()
    {
        cauldron.Play(3);
    }

}
