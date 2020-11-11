using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitController : MonoBehaviour
{
    [SerializeField] float range;
    [SerializeField] GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) < range)
        {

            GetComponent<Animator>().Play("backhit");
        }
        else {


            GetComponent<Animator>().Play("idle");
        }
    }
}
