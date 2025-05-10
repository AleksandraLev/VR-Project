using UnityEngine;
using UnityEngine.UI;

public class ImageSwiper : MonoBehaviour
{
    public Sprite[] images; // Массив картинок
    public Image displayImage; // Image-компонент, где отображается текущая картинка
    private int _currentIndex = 0; // Индекс текущей картинки
    
    public void ShowNext()// Для перелистывания вперёд
    {
        if (images.Length == 0) return;
        _currentIndex = (_currentIndex + 1) % images.Length;
        displayImage.sprite = images[_currentIndex];
    }

    public void ShowPrevious() // Для перелистывания назад
    {
        if (images.Length == 0) return;
        _currentIndex = (_currentIndex - 1 + images.Length) % images.Length;
        displayImage.sprite = images[_currentIndex];
    }

    private void Start()
    {
        if (images.Length > 0)
            displayImage.sprite = images[_currentIndex]; // Отображение первой картинки
    }

}