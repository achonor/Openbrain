﻿using System;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Google.Protobuf;
using System.Collections;
using System.Collections.Generic;

public class Function{
    //1970
    private static DateTime time1970 = new DateTime(1970, 1, 1, 0, 0, 0, 0);
    //服务器和本地时间差
    private static double offsetTime;

    //获取本地时间戳
    public static double GetLocaLTime()
    {
        return Convert.ToDouble((DateTime.UtcNow - time1970).TotalSeconds);
    }
    public static double GetServerTime()
    {
        return GetLocaLTime() + offsetTime;
    }
    public static void SetServerTime(long serverTime)
    {
        TimeSpan ts = DateTime.UtcNow - time1970;
        offsetTime = serverTime - GetLocaLTime();
    }

    public static byte[] Serialization(byte[] data)
    {
        //数据长度
        int protoLen = data.Length;
        byte[] head = new byte[4];
        IntToByte4(head, protoLen);
        //拼接
        return MergeArray<byte>(head, data);
    }

    public static int Byte4ToInt(byte[] data) {
        int ret = 0;
        for (int i = 0; i < 4; i++)
        {
            int tmpInt = data[i];
            if (tmpInt < 0)
            {
                tmpInt = tmpInt + 256;
            }
            ret = (ret << 8) | tmpInt;
        }
        return ret;
    }

    public static void IntToByte4(byte[] data, int num)
    {
        for (int i = 3; i >= 0; i--)
        {
            int tmpInt = ((255 << (8 * i))) & num;
            data[3 - i] = (byte)tmpInt;
        }
    }

    public static T[] MergeArray<T>(T[] first, T[] second)
    {
        T[] result = new T[first.Length + second.Length];
        first.CopyTo(result, 0);
        second.CopyTo(result, first.Length);
        return result;
    }
    /// <summary>
    /// 随机范围内不重复的多个数字
    /// </summary>
    /// <param name="min">最小值</param>
    /// <param name="max">最大值</param>
    /// <param name="size">随机个数</param>
    /// <returns></returns>
    public static int[] RandInRange(int min, int max, int size)
    {
        int[] result = new int[size];
        if ((max - min + 1) < size)
        {
            Debug.LogError("Function.RandInRange Range less size!");
            return result;
        } else if (max - min + 1 == size) {
            for (int i =  min; i <= max; i++)
            {
                result[i - min] = i;
            }
            return result;
        } else if (max - min + 1 < (size << 1))
        {
            int tmpSize = max - min + 1 - size;
            Dictionary<int, bool> isSelect = new Dictionary<int, bool>();
            int[] tmpRet = RandInRange(min, max, tmpSize);
            for (int i = 0; i < tmpSize; i++)
            {
                isSelect[tmpRet[i]] = true;
            }
            int tmpIndex = 0;
            for (int i = min; i <= max; i++)
            {
                if (isSelect.ContainsKey(i) && true == isSelect[i])
                {
                    continue;
                }
                result[tmpIndex++] = i;
            }
            return result;
        }
        Dictionary<int, bool> selectDict = new Dictionary<int, bool>();
        for (int i = 0; i < size; i++)
        {
            int maxCount = 99;
            while (0 < (maxCount--))
            {
                int number = UnityEngine.Random.Range(min, max);
                if (!selectDict.ContainsKey(number))
                {
                    selectDict.Add(number, true);
                    result[i] = number;
                    break;
                }
            }
            if (0 == maxCount)
            {
                Debug.LogError("Function.RandInRange 0 == maxCount");
            }
        }
        return result;
    }
    /// <summary>
    /// 随机数组内不重复的size个对象
    /// </summary>
    /// <typeparam name="T">object</typeparam>
    /// <param name="range">随机数组</param>
    /// <param name="size">随机个数</param>
    /// <returns></returns>
    public static T[] RandInRange<T>(T[] range, int size)
    {
        T[] result = new T[size];
        int[] intResule = RandInRange(0, range.Length - 1, size);
        for (int i = 0; i < size; i++)
        {
            result[i] = range[intResule[i]];
        }
        return result;
    }

    public static void UpsetArray<T>(T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int idx = UnityEngine.Random.Range(0, array.Length - 1);
            T tmpValue = array[i];
            array[i] = array[idx];
            array[idx] = tmpValue;
        }
    }

    //加载url图
    public static IEnumerator DownloadImage(Image image, string url, System.Action<Sprite> callback = null)
    {
        WWW www = new WWW(url);
        yield return www;
        if (!string.IsNullOrEmpty(www.error))
        {
            Debug.Log(www.error);
        }else
        {
            Texture2D tex = www.texture;
            Sprite temp = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0, 0));
            image.sprite = temp;
            if (null != callback)
            {
                callback(temp);
            }
        }
    }

    public static void SetImageSprite(Image image, string iconPath)
    {
        Sprite sprite = Resources.Load(iconPath, typeof(Sprite)) as Sprite;
        if (null == sprite)
        {
            Debug.LogError("SetImageSprite Error: " + iconPath);
            return;
        }
        image.sprite = sprite;
    }

    //通过枚举获取等级文字
    public static string LevelToString(enum_player_level level)
    {
        switch (level)
        {
            case enum_player_level.Copper:
                return Language.GetTextByKey(10001);
            case enum_player_level.Silver:
                return Language.GetTextByKey(10002);
            case enum_player_level.Gold:
                return Language.GetTextByKey(10003);
            case enum_player_level.Platinum:
                return Language.GetTextByKey(10004);
            case enum_player_level.Diamond:
                return Language.GetTextByKey(10005);
            default:
                return "NULL";
        }
    }

    //通过枚举获取熟练度文字
    public static string ProficiencyToString(enum_player_proficiency proficiency)
    {
        switch (proficiency)
        {
            case enum_player_proficiency.Toe:
                return Language.GetTextByKey(10101);
            case enum_player_proficiency.Calf:
                return Language.GetTextByKey(10102);
            case enum_player_proficiency.Knee:
                return Language.GetTextByKey(10103);
            case enum_player_proficiency.Thigh:
                return Language.GetTextByKey(10104);
            case enum_player_proficiency.Butt:
                return Language.GetTextByKey(10105);
            case enum_player_proficiency.Belly:
                return Language.GetTextByKey(10106);
            case enum_player_proficiency.Chest:
                return Language.GetTextByKey(10107);
            case enum_player_proficiency.Neck:
                return Language.GetTextByKey(10108);
            case enum_player_proficiency.Brain:
                return Language.GetTextByKey(10109);
            default:
                return "NULL";
        }
    }

    /// <summary>
    /// 目录覆盖
    /// </summary>
    /// <param name="sourceDir"></param>
    /// <param name="destDir"></param>
    public static void OverDirectory(DirectoryInfo sourceDir, string destDir)
    {
        if (!Directory.Exists(destDir))
        {
            Directory.CreateDirectory(destDir);
        }
        foreach (var nextFile in sourceDir.GetFiles())
        {
            File.Copy(nextFile.FullName, destDir + "/" + nextFile.Name, true);
        }
        foreach (DirectoryInfo nextFolder in sourceDir.GetDirectories())
        {
            OverDirectory(nextFolder, destDir + "/" + nextFolder.Name);
        }
    }
    /// <summary>
    /// 获取目录下所有文件
    /// </summary>
    /// <param name="sourceDir">目录</param>
    /// <param name="outList">返回的文件列表</param>
    public static void GetDirectoryAllFile(DirectoryInfo sourceDir, List<FileInfo> outList)
    {
        foreach (var nextFile in sourceDir.GetFiles())
        {
            outList.Add(nextFile);
        }
        foreach (DirectoryInfo nextFolder in sourceDir.GetDirectories())
        {
            GetDirectoryAllFile(nextFolder, outList);
        }
    }

    /// <summary>
    /// 写入数据到文件
    /// </summary>
    /// <param name="content"></param>
    /// <param name="filePath"></param>
    public static void WriteFile(byte[] content, string filePath)
    {
        //判断路径是否存在
        FileInfo fileInfo = new FileInfo(filePath);
        if (!fileInfo.Directory.Exists)
        {
            //不能存在要先创建目录
            fileInfo.Directory.Create();
        }
        //文件已存在，先删除
        if (File.Exists(filePath))
        {
            File.Delete(filePath);
        }
        FileStream fileStream = File.Create(filePath);
        fileStream.Write(content, 0, content.Length);
        //保存
        fileStream.Flush();
        fileStream.Close();
    }
    /// <summary>
    /// 获取文件MD5
    /// </summary>
    /// <param name="fileName"></param>
    /// <returns></returns>
    public static string GetMD5HashFromFile(string fileName)
    {
        try
        {
            FileStream file = new FileStream(fileName, FileMode.Open);
            System.Security.Cryptography.MD5 md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }
            return sb.ToString();
        }
        catch (Exception ex)
        {
            throw new Exception("GetMD5HashFromFile() fail,error:" + ex.Message);
        }
    }
}
