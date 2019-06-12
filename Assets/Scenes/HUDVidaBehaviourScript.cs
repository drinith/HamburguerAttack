using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUDVidaBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    public Rigidbody objetoRigi;
    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text="10";
    }

    // Update is called once per frame
    void Update()
    {
       
    }

}
