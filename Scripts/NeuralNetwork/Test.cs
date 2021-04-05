using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        NeuralNetwork MainNetwork = new NeuralNetwork(new NeuralNetworkData(2, 5, 5, 3));
        print(Math.Warp(-1f));
        float[] inputs = new float[27];
        for (int i = 0; i < 27; i++)
        {
            inputs[i] = Math.random();
            print(inputs[i]);
        }
        BetterPrint.PrintArray(MainNetwork.Run(inputs));
    }

    
}
