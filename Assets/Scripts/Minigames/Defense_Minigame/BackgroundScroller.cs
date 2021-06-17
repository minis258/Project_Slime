using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    private Vector2 p_Offset;

    private Material p_Material;
    [SerializeField]
    private float p_VelocityX;
    [SerializeField]
    private float p_VelocityY;
    // Start is called before the first frame update
    private void Awake()
    {
        p_Material = GetComponent<Renderer>().material;
    }
    void Start()
    {
        p_Offset = new Vector2(p_VelocityX, p_VelocityY);
    }

    // Update is called once per frame
    void Update()
    {
        Scrolling();
    }

    private void Scrolling()
    {
        p_Material.mainTextureOffset += p_Offset * Time.deltaTime;   
    }
}
