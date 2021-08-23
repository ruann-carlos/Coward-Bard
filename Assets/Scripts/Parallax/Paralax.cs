using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralax : MonoBehaviour
{
    [SerializeField] private GameObject background;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        ParalaxEffect();
    }

    // Update is called once per frame
    void Update()
    {
        ParalaxEffect();
    }

    private void ParalaxEffect()
    {
        if(background.transform.position.x <= -24.8)
        {
            background.transform.position = new Vector3(25, 1);
        }
        background.transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }

}
