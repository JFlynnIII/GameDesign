using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoller : MonoBehaviour
{

    public int result;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Roll()
    {
        result = Random.Range(1, 5);
        GameObject.Find("ResultDisplay").GetComponent<TMPro.TextMeshProUGUI>().text = result.ToString();
    }
}
