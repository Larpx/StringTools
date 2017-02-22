using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public object ToString( string str )
        {
            return _strJson;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public object Format( string str )
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
                throw ex;
            }
            return tmp;
        }

        public object Compress( string str )
        {
            throw new NotImplementedException();
        }

        public object Escape( string str )
        {
            throw new NotImplementedException();
        }

        public bool Check( string str )
        {
            throw new NotImplementedException();
        }

        public object Convert( string str )
        {
            throw new NotImplementedException();
        }

        public string ToXML( string str )
        {
            throw new NotImplementedException();
        }

        public string ToJson( string str )
        {
            throw new NotImplementedException();
        }

        public string ToURL( string str )
        {
            throw new NotImplementedException();
        }
    }
}
