using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    public UnityEngine.AI.NavMeshAgent ghosts;
    public Transform jigglypuff;
    public Character character;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ghosts.SetDestination(jigglypuff.position);
        if (character.isPowered == true)
        {
            ghosts.speed = 0;
            Invoke("ghostsGo", 3f);
 
        }
    }

    void ghostsGo()
    {
        ghosts.speed = 3.5f;
        character.isPowered = false;
    }
}
