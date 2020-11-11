using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{
    public void explode() {

        GetComponent<Animator>().Play("npcExpo");
        StartCoroutine(wait());
    }


     IEnumerator wait() {

        yield return new WaitForSeconds(1.5f);
        GameObject.Destroy(this.gameObject);
    }
}
