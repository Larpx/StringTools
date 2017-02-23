using System;

namespace Larpx.StringExx
{
    public interface BaseInterface
    {
        /// <summary>
        /// 格式化
        /// </summary>
        /// <returns></returns>
        String Format();

        /// <summary>
        /// 压缩
        /// </summary>
        /// <returns></returns>
        String Compress();

        /// <summary>
        /// 转义
        /// </summary>
        /// <returns></returns>
        String Escape();

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        bool Check();

        /// <summary>
        /// 转换
        /// </summary>
        /// <returns></returns>
        String Convert( object obj );

        /// <summary>
        /// 转为XML
        /// </summary>
        /// <returns></returns>
        String ToXML();

        /// <summary>
        /// 转为Json
        /// </summary>
        /// <returns></returns>
        String ToJson();

        /// <summary>
        /// 转为URL
        /// </summary>
        /// <returns></returns>
        String ToURL();

    }
}
