using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetTrigger : MonoBehaviour
{
    private Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        if (main.isMagnet == true)
        {
            if (Vector3.Distance(transform.position, Player.position) < 2)
                transform.position = Vector3.MoveTowards(transform.position, Player.position, 0.1f);
            //Debug.Log(Vector3.Distance(transform.position, Player.position));
            StartCoroutine(disableMagnet());
        }
    }

    IEnumerator disableMagnet()
    {
        yield return new WaitForSeconds(10.0f);
        main.isMagnet = false;
        //Debug.Log("Disable Magnet");
    }
}
