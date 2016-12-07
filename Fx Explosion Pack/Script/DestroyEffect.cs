using UnityEngine;
using System.Collections;

public class DestroyEffect : MonoBehaviour {

    //void Update ()
    //{

    //	if(Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.C))
    //	   Destroy(transform.gameObject);

    //}

    private ParticleSystem[] particleSystems;

    void Start()
    {
        particleSystems = GetComponentsInChildren<ParticleSystem>();
    }

    void Update()
    {
        bool allStopped = true;

        foreach (ParticleSystem ps in particleSystems)
        {
            if (!ps.isStopped)
            {
                allStopped = false;
            }
        }

        if (allStopped)
            GameObject.Destroy(gameObject);
    }
}
