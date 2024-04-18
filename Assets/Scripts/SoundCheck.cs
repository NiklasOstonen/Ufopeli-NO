using UnityEngine;

public class SoundCheck : MonoBehaviour
{
    public AudioListener audio;
    // Start is called before the first frame update
    void Start()
    {
        //Reference to the AudioListener component on the object
        audio = GetComponent<AudioListener>();

    }

    // Update is called once per frame
    void Update()
    {
        //Toggles sound on/off by pressing 'M'
        if (Input.GetKey(KeyCode.M) && audio.enabled == true)
        {
            audio.enabled = false;
        }
        if (Input.GetKey(KeyCode.M) && audio.enabled == false)
        {
            audio.enabled = true;
        }

    }
}