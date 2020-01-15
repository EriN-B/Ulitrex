using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class BAckground_loop : MonoBehaviour
{
    public float speed = 0.1f;

    private Material mat;
    private Vector2 offset = Vector2.zero;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update()
    {
        offset.x = offset.x + speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }
}
