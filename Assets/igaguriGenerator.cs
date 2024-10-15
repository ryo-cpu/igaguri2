using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class igaguriGenerator : MonoBehaviour
{
    public GameObject igaguriPrefab;
    // Start is called before the first frame update
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject igaguri=Instantiate(igaguriPrefab);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 wordDir = ray.direction;
            //    igaguri.GetComponent<igaguriController>().Shoot(wordDir.normalized * 2000);
        }
    }
}
