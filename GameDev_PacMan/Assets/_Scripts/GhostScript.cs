using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GhostScript : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ghosts;
    public Transform jigglypuff;
    public Character character;
    public GameManager gm;
    public TMP_Text gameOver;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rotationSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if(ghosts.velocity.magnitude > 0)
        {
            Quaternion desiredRotation = Quaternion.LookRotation(ghosts.velocity.normalized);
            transform.rotation = Quaternion.Slerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
        }
        ghosts.SetDestination(jigglypuff.position);

        if (character.isPowered == true)
        {
            ghosts.speed = 0;
            Invoke("ghostsGo", 2f);
 
        }
    }

    void ghostsGo()
    {
        ghosts.speed = 3.5f;
        character.isPowered = false;
    }

    void OnTriggerEnter(Collider other)
    {
        gm.gameIsOver = true;
        

    }
}