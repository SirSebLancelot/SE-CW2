using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door : MonoBehaviour
{
    //public bool suceess_state = false;
    public Animator ani;
    float currentTime;
    public Collider co;
    // Start is called before the first frame update
    void Start()
    {
        ani.SetBool("open", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("z")){
            ani.SetBool("open", true);
            co.enabled = false;
        }
    }
}
