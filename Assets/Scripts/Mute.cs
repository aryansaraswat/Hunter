using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public AudioSource _as;
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
    void Start()
    {
        _as = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
        _as.mute = !_as.mute;
    }
}
