using System;

namespace StringExx
{
    public interface BaseInterface
    {
        //转换为字符串
        object ToString();

        //格式化
        object Format();

        //压缩
        object Compress();

        //转义
        object Escape();

        //校验
        object Check();

        //转换
        object Convert();

        String ToXML();

        String ToJson();

        String ToURL();

    }
}
