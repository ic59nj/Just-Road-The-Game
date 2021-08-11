using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameHandler : MonoBehaviour
{
    //init variables
    public Text cpT;
    public int checkpointCount;
    // Start is called before the first frame update
    void Start()
    {
        checkpointCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cpT.text = checkpointCount.ToString();
    }
}