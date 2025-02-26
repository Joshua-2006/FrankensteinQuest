using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    private Vector3 startPosition;
    private float xChange = 0;
    private float yChange = 0;
    private float zChange = 0;

    [Header("X Movement")]
    public bool isXMoving;
    public bool isXUsingSine;
    public float xAmp;       //how far it moves
    public float Xperiod;    //how long it takes to repeat

    [Header("Y Movement")]
    public bool isYMoving;
    public bool isYUsingSine;
    public float yAmp;       //how far it moves
    public float Yperiod;    //how long it takes to repeat

    [Header("Z Movement")]
    public bool isZMoving;
    public bool isZUsingSine;
    public float zAmp;       //how far it moves
    public float Zperiod;    //how long it takes to repeat

    // Start is called before the first frame update
    void Start()
    {
        //find my starting position
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isXMoving)
        {
            xChange = WaveMove(xAmp, Xperiod, isXUsingSine);
        }
        if (isYMoving)
        {
            yChange = WaveMove(yAmp, Yperiod, isYUsingSine);
        }
        if (isZMoving)
        {
            zChange = WaveMove(zAmp, Zperiod, isZUsingSine);
        }
        //update my position
        transform.position = new Vector3(startPosition.x + xChange, startPosition.y + yChange, startPosition.z + zChange);
    }
    //Wave move Script
    public float WaveMove(float amp, float period, bool isUsingSine)
    {
        if (period != 0)
        {
            if (isUsingSine)
            {
                return amp * Mathf.Sin(Time.time * (6.28f / period));
            }
            else
            {
                return amp * Mathf.Cos(Time.time * (6.28f / period));
            }
        }
        else
        {
            return 0;

        }


    }
}
