#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace QFrameWork
{
    public class ImagetextExample : MonoBehaviour
    {
        GameObject prefab;
        public SpriteRenderer sprite;
        public Transform spriteParent;  //当前图片父物体的位置
        public Image image;
        public Canvas canvas;
        public Vector2 v2;
        public InputField XInput;
        public InputField YInput;
        public Button ConfirmBut;
        public static bool IsSpriteRenderer = false;
        [UnityEditor.MenuItem("QFramework/Example/21 Image API简化", false, 21)]
        private static void MenuItem()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            GameObject prefab = Instantiate(Resources.Load<GameObject>("image/SpritePrefab"));
            prefab.AddComponent<ImagetextExample>();
            IsSpriteRenderer = false;
        }
        // Start is called before the first frame update
        void Start()
        {
            prefab = this.gameObject;
            canvas = prefab.transform.Find("Canvas").GetComponent<Canvas>();
            XInput = canvas.transform.Find("XInput").GetComponent<InputField>();
            YInput = canvas.transform.Find("YInput").GetComponent<InputField>();
            ConfirmBut = canvas.transform.Find("Confirm").GetComponent<Button>();
            spriteParent = prefab.transform.Find("SpriteParent");
            sprite = spriteParent.transform.Find("Sprite").GetComponent<SpriteRenderer>();
            image = prefab.transform.Find("Canvas/Image").GetComponent<Image>();
            Debug.Log("显示Canvas内的图片");
            spriteParent.Hide();
            image.Show();
            ConfirmBut.onClick.AddListener(OnSpritesClick);


        }
        /// <summary>
        /// canvas按钮点击事件
        /// </summary>
        private void OnSpritesClick()
        {
            float X = float.Parse(XInput.text);
            float Y = float.Parse(YInput.text);
            Vector2 v2 = image.GetPointPos(X, Y);
            GameObject Area = Instantiate(Resources.Load<GameObject>("image/ImagePoint"));
            Area.transform.SetParent(canvas.transform);
            Area.transform.position = new Vector3(v2.x, v2.y);
        }


    }
}
#endif