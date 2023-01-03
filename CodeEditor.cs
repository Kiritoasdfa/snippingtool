using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
//图片剪裁
public class CodeEditor : MonoBehaviour
{
    /// <summary>
    /// 取图片的中心区域
    /// </summary>
    [MenuItem("图片工具/获取中心区域")]
    private static void ChangeDrawTexture()
    {
        var Texture =
            AssetDatabase.LoadAssetAtPath<Texture2D>("Assets/Editor/Texture/timg.jpg");

        Debug.Log(Texture);

        var ShowImage = GameObject.Find("Image").GetComponent<Image>();

        ShowImage.sprite = BornSprite(Texture);

    }

    private static Sprite BornSprite(Texture2D Texture, int Width = 500, int Height = 600)
    {
        //因为是以左下的00为起点，所以Pos 需要按照原图一半的比例再剪去需要截取大小的一半
        Sprite sp = Sprite.Create(Texture,
            new Rect(new Vector2(Texture.width / 2 - Width / 2, Texture.height / 2 - Height / 2),
                new Vector2(Width, Height)), new Vector2(0.5f, 0.5f));

        return sp;
    }
}
