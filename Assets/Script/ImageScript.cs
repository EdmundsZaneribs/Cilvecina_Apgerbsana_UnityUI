using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject menn;
    public GameObject women;
    public GameObject leftToggle;
    public GameObject rightToggle;
    public Sprite[] spriteArray;
    public GameObject imageHolder;
    public GameObject sizeSlider;
    public GameObject rotationSlider;

    public void showMenn(bool value)
    {
        if (menn != null)
        {
            menn.SetActive(value);
            Toggle leftToggleComponent = leftToggle.GetComponent<Toggle>();
            Toggle rightToggleComponent = rightToggle.GetComponent<Toggle>();

            if (leftToggleComponent != null) leftToggleComponent.interactable = value;
            if (rightToggleComponent != null) rightToggleComponent.interactable = value;
        }
    }

    public void showWomen(bool value)
    {
        if (women != null)
        {
            women.SetActive(value);
        }
    }

    public void toLeft()
    {
        if (menn != null)
        {
            menn.transform.localScale = new Vector2(1, 1);
        }
    }

    public void toRight()
    {
        if (menn != null)
        {
            menn.transform.localScale = new Vector2(-1, 1);
        }
    }

    public void changeImage(int index)
    {
        if (imageHolder != null && spriteArray != null && index >= 0 && index < spriteArray.Length)
        {
            imageHolder.GetComponent<Image>().sprite = spriteArray[index];
        }
    }

    public void changeSize()
    {
        if (sizeSlider != null && imageHolder != null)
        {
            float size = sizeSlider.GetComponent<Slider>().value;
            imageHolder.transform.localScale = new Vector2(1F * size, 1F * size);
        }
    }

    public void changeRotation()
    {
        if (rotationSlider != null && imageHolder != null)
        {
            float rotation = rotationSlider.GetComponent<Slider>().value;
            imageHolder.transform.localRotation = Quaternion.Euler(0, 0, rotation * 360);
        }
    }
}
