using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Larpx.StringExx
{
    public class OperateJson : BaseAction, BaseInterface
    {
        private String _strJson;
        private String _strXML;
        private Dictionary<String, String> _oDic = new Dictionary<string, string>();

        public string strJson
        {
            get
            {
                return _strJson;
            }

            set
            {
                _strJson = value;
            }
        }

        public string strXML
        {
            get
            {
                return _strXML;
            }
        }

        public Dictionary<string, string> oDic
        {
            get
            {
                return _oDic;
            }

            set
            {
                _oDic = value;
            }
        }



        public new String ToString()
        {
            return _strJson;
        }

        #region 实现接口

        /// <summary>
        /// 格式化字符串
        /// </summary>
        /// <param name="str"></param>
        /// <returns>返回经过格式化的字符串</returns>
        public String Format()
        {
            if( String.IsNullOrEmpty( _strJson ) )
                return null;

            String tmp = String.Empty;
            try
            {
                JsonSerializer serialiaer = new JsonSerializer();
                TextReader tr = new StringReader( _strJson );
                JsonTextReader jtr = new JsonTextReader( tr );
                object obj = serialiaer.Deserialize( jtr );
                if( obj != null )
                {
                    StringWriter textwrite = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter( textwrite )
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serialiaer.Serialize( jsonWriter, obj );
                    tmp = textwrite.ToString();
                }
            }
            catch( Exception ex )
            {
                return ex.Message;
            }

            return tmp;
        }

        public String Compress()
        {
            throw new NotImplementedException();
        }

        public String Escape()
        {
            throw new NotImplementedException();
        }

        public bool Check()
        {

            return false;
        }

        /// <summary>
        /// 将对象转换为Json并且格式化
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public String Convert( object obj )
        {
            if( obj == null )
                return null;
            String tmp = String.Empty;
            try
            {
                _strJson = JsonConvert.SerializeObject( obj );
                tmp = this.Format();
            }
            catch( Exception ex )
            {
                return ex.Message;
            }
            return tmp;
        }

        public String ToXML()
        {
            throw new NotImplementedException();
        }

        public String ToJson()
        {
            throw new NotImplementedException();
        }

        public String ToURL()
        {
            throw new NotImplementedException();
        }

        #endregion
    }

}