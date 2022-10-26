/***
 * Author: Stu Dent
 * Create: 10/18/22
 * Modified:
 * Description: triggers the witch animation and sound cackle
 ***/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Witch : MonoBehaviour
{
    public string animtionParamater;
    Animator anim;
    AudioSource asrc;
    AudioClip clip;



    private void Start()
    {
        anim = GetComponent<Animator>();
        asrc = GetComponent<AudioSource>();
        clip = asrc.clip;
    }

private void OnTriggerEnter(Collider other)
    {
      if(other.tag == "Player")
        {
            anim.SetTrigger(animtionParamater);
        }
    }

/*private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            anim.SetBool(animtionParamater, false);
        }
    }*/


    void playCackle()
    {
        asrc.PlayOneShot(clip);
    }


}
