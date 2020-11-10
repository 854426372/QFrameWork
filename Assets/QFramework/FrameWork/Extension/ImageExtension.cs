using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace QFrameWork
{
    public static class ImageExtension
    {
        /// <summary>
        /// 传入一个image 和 图片上Image的XY点，返回一个在canvas上图片点位置的坐标
        /// </summary>
        /// <param name="image"></param>
        /// <param name="inputX"></param>
        /// <param name="InputY"></param>
        /// <returns></returns>
        public static Vector2 GetPointPos(this Image image,float inputX,float InputY)
        {
            Vector3[] v3 =new Vector3[4];
            image.gameObject.GetComponent<RectTransform>().GetWorldCorners(v3);
            float ScreneX = (inputX / (image.sprite.texture.width / Mathf.Abs(v3[0].x - v3[3].x))) + v3[0].x;
            float ScreneY = (InputY / (image.sprite.texture.height / Mathf.Abs(v3[0].y - v3[1].y))) + v3[0].y;
            return new Vector2(ScreneX, ScreneY);
        }
    }
}