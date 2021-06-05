using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementControl : MonoBehaviour
{
    MeshRenderer meshRender;
    public float displacementAmout;
    //public ParticleSystem explosionParticles;
    


    // Start is called before the first frame update
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        displacementAmout = Mathf.Lerp(displacementAmout, 0, Time.deltaTime);
        meshRender.material.SetFloat("_Amount", displacementAmout);

        if (Input.GetButton("Jump"))
        {
            displacementAmout += 0.5f;
            //explosionParticles.Play();
        }


        
    }
}
