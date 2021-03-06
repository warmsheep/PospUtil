﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PospUtil.util
{
    public abstract class AbsMac
    {
        /// <summary>
        /// 转换8倍长数据
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] getEightMultiplesData(byte[] data)
        {
            try
            {
                byte[] result = (byte[])null;
                int length = data.Length;
                int k = length % 8;

                if (k == 0)
                {
                    int len = length;
                    result = data;
                }
                else
                {
                    int len = (length / 8 + 1) * 8;
                    result = new byte[len];
                    for (int i = length; i < len; i++)
                    {
                        result[i] = 0;
                    }
                    Array.Copy(data, 0, result, 0, length);

                }
                data = (byte[])null;
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("获取8倍长数据失败,data = " + e.Message);
            }
            throw new Exception("获取8倍长数据失败,data = " + data);
        }

    }
}
