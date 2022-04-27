using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PageSwiper : MonoBehaviour, IDragHandler, IEndDragHandler
{
    private Vector3 panelLocation;
    public float percentThreshold = 0.2f;
    public float easing = 0.5f;
    public int bg;
    internal bool swipingRight = false;
    internal bool swipingLeft = false;
    public BgPositions bgPositions;
    public bool rainbow;
    internal bool rainbowActive;
    public float timeStart;
    private float timeReal;

    public Timer timerScript;
    private bool swipeFast;
    private bool swipeSlow = true;
    private float swipingSpeed = 1f;

    public RectTransform panelY;

    // Start is called before the first frame update
    void Start()
    {
        panelLocation = transform.position;
        bg = 2;
    }

    void Update()
    {
        if (timerScript.iced && !swipeFast)
        {
            swipingSpeed = 20f;
            swipeFast = true;
            swipeSlow = false;
        }

        if (!timerScript.iced && !swipeSlow)
        {
            swipingSpeed = 1f;
            swipeSlow = true;
            swipeFast = false;
        }

        if (rainbow && !rainbowActive)
        {
            timeReal = timeStart;
            Vector3 rbLocation = panelLocation;
            rbLocation -= new Vector3(0, panelY.rect.height + 10000f, 0);
            StartCoroutine(SmoothMove(transform.position, rbLocation, easing));
            panelLocation = rbLocation;
            rainbow = false;      
            rainbowActive = true;
        }

        if (rainbowActive)
        {
            timeReal -= Time.deltaTime;
            if (timeReal <= 0)
            {
                Vector3 rbLocation = panelLocation;
                rbLocation += new Vector3(0, panelY.rect.height + 10000f, 0);
                StartCoroutine(SmoothMove(transform.position, rbLocation, easing));
                panelLocation = rbLocation;
                rainbowActive = false;
            }
        }
}
   
    
    public void OnDrag(PointerEventData data)
    {
        float difference = data.pressPosition.x - data.position.x;
        transform.position = panelLocation - new Vector3(difference, 0, 0);    
    }

    public void OnEndDrag(PointerEventData data)
    {
        float percentage = (data.pressPosition.x - data.position.x) / Screen.width;

        if (Mathf.Abs(percentage) >= percentThreshold){
            Vector3 newLocation = panelLocation;
            //sağa kaydırma
            if (percentage > 0)
            {
                newLocation += new Vector3(-Screen.width, 0, 0);
                swipingRight = true;
                bgPositions.RepositionBackGrounds();
                bg += 1;
                if(bg > 3)
                {
                    bg -= 3;
                }
            }
            //sola kaydırma
            else if (percentage < 0)
            {
                newLocation += new Vector3(Screen.width, 0, 0);
                swipingLeft = true;
                bgPositions.RepositionBackGrounds();
                bg -= 1;
                if(bg < 1)
                {
                    bg += 3;
                }
            }
            StartCoroutine(SmoothMove(transform.position, newLocation, easing));
            panelLocation = newLocation;
            
            swipingRight = false;
            swipingLeft = false;
        }
        else
        {
            StartCoroutine(SmoothMove(transform.position, panelLocation, easing));
        }
    }


    IEnumerator SmoothMove(Vector3 startpos, Vector3 endpos, float seconds)
    {
        float t = 0f;
        while (t <= 1.0) {
            t += Time.deltaTime * swipingSpeed / seconds;
            transform.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0f, 1f, t));
            yield return null;
        }
    }
}
