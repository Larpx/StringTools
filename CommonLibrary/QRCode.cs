using System;
using System.Drawing;
using System.Text;
using ThoughtWorks.QRCode.Codec;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;

namespace Larpx.CommonLibrary
{
    public class QRCode
    {
        public static Bitmap GetCode( string str,
          ENCODE_MODE em = ENCODE_MODE.BYTE,
           ERROR_CORRECTION ec = ERROR_CORRECTION.MIDDLE,
            int Version = 0,
            int Scale = 4
            )
        {
            try
            {
                if( String.IsNullOrEmpty( str ) )
                    throw new Exception( "字符串为空" );
                //初始化二维码生成工具
                QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
                qrCodeEncoder.QRCodeEncodeMode = (QRCodeEncoder.ENCODE_MODE)em;
                qrCodeEncoder.QRCodeErrorCorrect = (QRCodeEncoder.ERROR_CORRECTION)ec;
                qrCodeEncoder.QRCodeVersion = Version;
                qrCodeEncoder.QRCodeScale = Scale;

                //将字符串生成二维码图片
                Bitmap image = qrCodeEncoder.Encode( str, Encoding.UTF8 );
                return image;
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        public static Bitmap GetCode( string str,
           ErrorCorrectionLevel ec = ErrorCorrectionLevel.MIDDLE,
           BarcodeFormat bfType = BarcodeFormat.QR_CODE,
          int nWidth = 150,
          int nHeight = 150,
          int nMargin = 0
           )
        {
            try
            {
                if( String.IsNullOrEmpty( str ) )
                    throw new Exception( "字符串为空" );

                ZXing.QrCode.QrCodeEncodingOptions qrEncodeOption = new ZXing.QrCode.QrCodeEncodingOptions();
                qrEncodeOption.CharacterSet = "UTF-8";
                qrEncodeOption.DisableECI = true; // Extended Channel Interpretation (ECI) 主要用于特殊的字符集。并不是所有的扫描器都支持这种编码。
                qrEncodeOption.Height = nHeight;
                qrEncodeOption.Width = nWidth;
                qrEncodeOption.Margin = nMargin;
                switch( ec )
                {
                case ErrorCorrectionLevel.HIGH:
                    qrEncodeOption.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.H; // 纠错级别
                    break;
                case ErrorCorrectionLevel.LOW:
                    qrEncodeOption.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.L; // 纠错级别
                    break;
                case ErrorCorrectionLevel.MIDDLE:
                    qrEncodeOption.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.M; // 纠错级别
                    break;
                case ErrorCorrectionLevel.QUE:
                    qrEncodeOption.ErrorCorrection = ZXing.QrCode.Internal.ErrorCorrectionLevel.Q; // 纠错级别
                    break;
                }

                BarcodeWriter writer = new BarcodeWriter();
                writer.Format = (ZXing.BarcodeFormat)bfType;
                writer.Options = qrEncodeOption;

                // Write 具备生成、写入两个功能
                Bitmap bmp = writer.Write( str );

                using( MemoryStream ms = new MemoryStream() )
                    bmp.Save( ms, ImageFormat.Png );
                return bmp;
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        #region 枚举类型

        public enum ENCODE_MODE
        {
            ALPHA_NUMERIC = 0,
            NUMERIC = 1,
            BYTE = 2
        }

        public enum ERROR_CORRECTION
        {
            LOW = 0,
            MIDDLE = 1,
            QUE = 2,
            HIGH = 3
        }

        public enum BarcodeFormat
        {
            //
            // 摘要:
            //     Aztec 2D barcode format.
            AZTEC = 1,
            //
            // 摘要:
            //     CODABAR 1D format.
            CODABAR = 2,
            //
            // 摘要:
            //     Code 39 1D format.
            CODE_39 = 4,
            //
            // 摘要:
            //     Code 93 1D format.
            CODE_93 = 8,
            //
            // 摘要:
            //     Code 128 1D format.
            CODE_128 = 16,
            //
            // 摘要:
            //     Data Matrix 2D barcode format.
            DATA_MATRIX = 32,
            //
            // 摘要:
            //     EAN-8 1D format.
            EAN_8 = 64,
            //
            // 摘要:
            //     EAN-13 1D format.
            EAN_13 = 128,
            //
            // 摘要:
            //     ITF (Interleaved Two of Five) 1D format.
            ITF = 256,
            //
            // 摘要:
            //     MaxiCode 2D barcode format.
            MAXICODE = 512,
            //
            // 摘要:
            //     PDF417 format.
            PDF_417 = 1024,
            //
            // 摘要:
            //     QR Code 2D barcode format.
            QR_CODE = 2048,
            //
            // 摘要:
            //     RSS 14
            RSS_14 = 4096,
            //
            // 摘要:
            //     RSS EXPANDED
            RSS_EXPANDED = 8192,
            //
            // 摘要:
            //     UPC-A 1D format.
            UPC_A = 16384,
            //
            // 摘要:
            //     UPC-E 1D format.
            UPC_E = 32768,
            //
            // 摘要:
            //     UPC_A | UPC_E | EAN_13 | EAN_8 | CODABAR | CODE_39 | CODE_93 | CODE_128 | ITF
            //     | RSS_14 | RSS_EXPANDED without MSI (to many false-positives)
            All_1D = 61918,
            //
            // 摘要:
            //     UPC/EAN extension format. Not a stand-alone format.
            UPC_EAN_EXTENSION = 65536,
            //
            // 摘要:
            //     MSI
            MSI = 131072,
            //
            // 摘要:
            //     Plessey
            PLESSEY = 262144
        }

        public enum ErrorCorrectionLevel
        {
            //L = ~7% correction
            LOW = 0,
            //M = ~15% correction
            MIDDLE = 1,
            //Q = ~25% correction
            QUE = 2,
            //H = ~30% correction
            HIGH = 3
        }

        #endregion

    }
}