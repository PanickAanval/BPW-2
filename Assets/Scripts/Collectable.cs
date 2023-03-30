using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Collectable : MonoBehaviour
{
    public UnityEvent changeWorld;
    public int amount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (amount==5)
        {
            changeWorld.Invoke();
        }
    }

    public void IncreaseCounter()
    {
        amount++;
    }
}
