using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BgPositions : MonoBehaviour
{

    public PageSwiper pageSwiper;
    public GameObject redPos;
    public GameObject bluePos;
    public GameObject greenPos;
    private Vector3 vectorChange = new Vector3(Screen.width * 3, 0f, 0f);

    public void RepositionBackGrounds()
    {
        //yeşil arka plan
        if (pageSwiper.bg % 3 == 1)
        {
            if (pageSwiper.swipingRight)
            {
                bluePos.transform.position += vectorChange;
            }
            else if (pageSwiper.swipingLeft)
            {
                redPos.transform.position -= vectorChange;
            }
        }
        //kırmızı arka plan
        else if (pageSwiper.bg % 3 == 2)
        {
            if (pageSwiper.swipingRight) {
                greenPos.transform.position += vectorChange;
            }else if (pageSwiper.swipingLeft) 
            {
                bluePos.transform.position -= vectorChange;
            }
        }
        //mavi arka plan
        else if (pageSwiper.bg % 3 == 0)
        {
            if (pageSwiper.swipingRight)
            {
                redPos.transform.position += vectorChange;
            }
            else if (pageSwiper.swipingLeft)
            {
                greenPos.transform.position -= vectorChange;
            }
        }
    }
}
