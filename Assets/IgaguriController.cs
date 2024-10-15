using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0;
    void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
        GetComponent<ParticleSystem>().Play(); 
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        Application.targetFrameRate = 60;
        Shoot(new Vector3(0, 200, 2000));
        count++;
        if(count>1000)
        {
            ///1000fで消去
            Destroy(this.gameObject);
            count = 0;
        }
    }
}
