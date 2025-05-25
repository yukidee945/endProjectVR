using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   
    void Start()
    {
        InvokeRepeating("RestartGame", 60f, 60f); // Запускаем каждые 60 секунд
    }

   
    void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}


//по нажатию на кнопку

//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class Restart : MonoBehaviour
//{
//   
//    public void RestartGame()
//    {
//        // Загружает текущую сцену заново по её индексу
//        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
//    }
//}
