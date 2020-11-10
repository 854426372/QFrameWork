using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace QFrameWork
{
    public static class SpriteExtension
    {
        /// <summary>
        /// 传入一个sprite 和 图片上Image的XY点，返回一个在canvas上图片点位置的坐标(Transform = 在当前图片左下角位置的一个物体；inputX = X轴 ；InputY = Y轴 )
        /// </summary>
        /// <param name="sprite"></param>
        /// <param name="Parent"></param>
        /// <param name="inputX"></param>
        /// <param name="InputY"></param>
        /// <returns></returns>
        public static Vector2 GetPointPos(this SpriteRenderer sprite,Transform Parent, float inputX, float InputY)
        {
            #region  待整理上博客的简单版
            //需要注意的地方：
            //1、建立一个父物体在spriteRenderer的左下角，确定当前图片左下角的位置
            //2、spriteRenderer的transform scale属性必须所有都是1（未被强制放大缩小过，后面其实是可以放大缩小，但是不能去改变它的scale）
            //3、spriteRenderer的 Draw mode设置为Sliced
            //4、spriteRenderer的size设置为与原图片的大小一致（这个时候就可以不改变scale的大小下去改变 图片的显示大小，因为scale如果被改变，无法去计算图片本身大小与3D世界下大小的比例）

            //float RealityW = sprite.sprite.texture.width; ;
            //float RealityH = sprite.sprite.texture.height;
            //Debug.Log("图片实际宽度" + RealityW);
            //Debug.Log("图片实际高度" + RealityH);
            //Vector2 spriteSize = sprite.size;
            //Debug.Log("当前图片在世界中的大小是" + spriteSize);
            //Debug.Log("当前sprite父级在世界中的位置" + Parent.transform.position);
            //float RatioW = RealityW / spriteSize.x;
            //float RatioH = RealityH / spriteSize.y;
            //Debug.Log("宽度比例大小:" + RatioW + ";高度比例大小:" + RatioH);
            //float IamgeW = inputX / RatioW;
            //float IamgeY = InputY / RatioH;
            //Debug.Log("换算到世界中的图片的位置" + IamgeW + "asdasd" + IamgeY);
            //Debug.Log("换算到世界中的位置" + (IamgeW + Parent.position.x) + "asdasd" + (IamgeY + Parent.position.z));
            //return new Vector2(IamgeW + Parent.position.x, IamgeY + Parent.position.z);
            #endregion
            float IamgeW = inputX / (sprite.sprite.texture.width / sprite.size.x);
            float IamgeY = InputY / (sprite.sprite.texture.height / sprite.size.y);
            return new Vector2(IamgeW + Parent.position.x, IamgeY + Parent.position.z);
        }
    }
}