using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasApple;
    bool hasOrange;
    bool hasCucamber;
    bool hasPckage;
    [SerializeField] Color32 hasAppleColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 hasOrangeColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 hasCucamberColor = new Color32 (1,1,1,1);
    [SerializeField] Color32 noProductColor = new Color32 (1,1,1,1);
    [SerializeField] float destroyDelay;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Apple" && !hasApple && !hasPckage)
        {
        spriteRenderer.color = hasAppleColor;
            hasPckage = true;
            hasApple = true;
          Destroy(other.gameObject, destroyDelay);  
        }
        if(other.tag == "appleLogo" && hasApple == true && hasPckage == true)
        {
            spriteRenderer.color = noProductColor;
            hasPckage = false;
            hasApple = false;
            Destroy(other.gameObject, destroyDelay);
            
        }
        if (other.tag == "Orange" && !hasOrange && !hasPckage)
        {
            spriteRenderer.color = hasOrangeColor;
            hasPckage = true;
            hasOrange = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "OrangeLogo" && hasOrange == true && hasPckage == true)
        {
            spriteRenderer.color = noProductColor;
            hasPckage = false;
            hasOrange = false;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "Cucamber" && !hasCucamber && !hasPckage)
        {
            spriteRenderer.color = hasCucamberColor;
            hasPckage = true;
            hasCucamber = true;
            Destroy(other.gameObject, destroyDelay);
        }
        if (other.tag == "CucamberLogo" && hasCucamber == true && hasPckage == true)
        {
            spriteRenderer.color = noProductColor;
            hasPckage = false;
            hasCucamber = false;
            Destroy(other.gameObject, destroyDelay);
        }
        
    }

    // Update is called once per frame

    void Update()
    {
        
    }
}
