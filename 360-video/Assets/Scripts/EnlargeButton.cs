using UnityEngine;

public class EnlargeButton : MonoBehaviour
{
    private Vector3 originalSize;
    public float factor = 1.1f;
    // Start is called before the first frame update
    void Start()
    {
        originalSize = transform.parent.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseEnter()
    {
        Debug.Log("Enter");
        transform.parent.localScale *= factor;
    }

    public void OnMouseExit()
    {
        Debug.Log("Exit");
        transform.parent.localScale = originalSize;
    }
}
