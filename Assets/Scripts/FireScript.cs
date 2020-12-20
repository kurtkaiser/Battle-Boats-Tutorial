using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject redFire;
    public GameObject yellowFire;
    public GameObject orangeFire;
    int count;

    List<Color> fireColors = new List<Color> { Color.red, Color.yellow, new Color(1.0f, 0.64f, 0) };

    void FixedUpdate()
    {
        if(count > 30)
        {
            fireColors.Add(Color.red);
            int rnd = Random.Range(0, fireColors.Count);
            redFire.GetComponent<Renderer>().material.SetColor("_Color", fireColors[rnd]);
            fireColors.RemoveAt(rnd);
            rnd = Random.Range(0, fireColors.Count);
            orangeFire.GetComponent<Renderer>().material.SetColor("_Color", fireColors[rnd]);
            fireColors.RemoveAt(rnd);
            yellowFire.GetComponent<Renderer>().material.SetColor("_Color", fireColors[0]);
            fireColors.Clear();
            fireColors = new List<Color> { Color.red, Color.yellow, new Color(1.0f, 0.64f, 0) };
            count = 0;
        }
        count++;
    }
}
