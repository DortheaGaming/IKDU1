using UnityEngine;

public class menucontrol : MonoBehaviour
{
    public GameObject videopanal;
    public GameObject mathpanal;
    public GameObject foodpanal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeThat(string NameOfPanel) 
    {
        videopanal.SetActive(NameOfPanel == "video");
        mathpanal.SetActive(NameOfPanel == "math");
        foodpanal.SetActive(NameOfPanel == "food");
    }
}
