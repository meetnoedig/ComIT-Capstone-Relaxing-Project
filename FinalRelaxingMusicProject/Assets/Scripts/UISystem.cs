using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISystem : MonoBehaviour
{
    //Gideon, define these two inside the class but outside the method
    UIPage PreviousPage;
    UIPage CurrentPage;
    
    
    // Start is called before the first frame update
    void Start()
    {
        UIPage[] pages = GetComponentsInChildren<UIPage>(true); //Gideon, adding true gives us access to all the pages
        pages[0].gameObject.SetActive(true);
        for (int i = 1; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }

        CurrentPage = pages[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SwitchPage(UIPage nextPage)
    {
        // TODO: Disable the current page then enable the next page which is  'page' above.
        PreviousPage = CurrentPage;
        CurrentPage.gameObject.SetActive(false); //Disable the gameObject that has the UIPage component.
        nextPage.gameObject.SetActive(true);
        CurrentPage = nextPage;
    }

    public void GoToPreviousPage()
    {
        SwitchPage(PreviousPage);
    }
}
