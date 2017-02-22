using System;

namespace Larpx.StringExx
{
    public interface BaseInterface
    {             
        /// <summary>
        /// 转换为字符串
        /// </summary>
        /// <returns></returns>
        object ToString( String str );

        /// <summary>
        /// 格式化
        /// </summary>
        /// <returns></returns>
        object Format( String str );

        /// <summary>
        /// 压缩
        /// </summary>
        /// <returns></returns>
        object Compress( String str );

        /// <summary>
        /// 转义
        /// </summary>
        /// <returns></returns>
        object Escape( String str );

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        bool Check( String str );

        /// <summary>
        /// 转换
        /// </summary>
        /// <returns></returns>
        object Convert( String str );

        /// <summary>
        /// 转为XML
        /// </summary>
        /// <returns></returns>
        String ToXML( String str );

        /// <summary>
        /// 转为Json
        /// </summary>
        /// <returns></returns>
        String ToJson( String str );

        /// <summary>
        /// 转为URL
        /// </summary>
        /// <returns></returns>
        String ToURL( String str );

    }
}
