using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QFrameWork
{
    public class SpritesExample:MonoBehaviour
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
        [UnityEditor.MenuItem("QFramework/Example/22 SpriteRenderer API简化", false, 22)]
        private static void SpriteMenuItem()
        {
            UnityEditor.EditorApplication.isPlaying = true;
            GameObject prefab = Instantiate(Resources.Load<GameObject>("image/SpritePrefab"));
            prefab.AddComponent<SpritesExample>();
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
            spriteParent.Show();
            image.Hide();
            ConfirmBut.onClick.AddListener(OnSpriteRendererClick);
        }
        /// <summary>
        /// SpriteRenderer按钮点击事件
        /// </summary>
        private void OnSpriteRendererClick()
        {
            float X = float.Parse(XInput.text);
            float Y = float.Parse(YInput.text);
            Vector2 v2 = sprite.GetPointPos(spriteParent,X, Y);
            GameObject Area = Instantiate(Resources.Load<GameObject>("image/SprintPoint"));
            Area.transform.position = new Vector3(v2.x, spriteParent.position.y, v2.y);
        }
        private void OnDestroy()
        {
            Debug.Log("销毁自身");
            Destroy(this.gameObject);

        }
    }
}