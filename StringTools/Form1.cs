using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Larpx.CommonLibrary;

namespace Larpx.StringTools
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void tabPage1_SizeChanged( object sender, EventArgs e )
        {

        }

        private void FormMain_ResizeBegin( object sender, EventArgs e )
        {
            try
            {
                Size oDefaultSzie = new Size( 860, 540 );
                if( this.Size.Width < oDefaultSzie.Width || this.Size.Height < oDefaultSzie.Height )
                    return;
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        private void FormMain_ResizeEnd( object sender, EventArgs e )
        {
            try
            {
                Size oDefaultSzie = new Size( 860, 540 );
                if( this.Size.Width < oDefaultSzie.Width || this.Size.Height < oDefaultSzie.Height )
                {
                    this.Size = oDefaultSzie;
                }
                else
                {
                    //控件位置改变

                }
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        private void splitContainer_FileLR_SplitterMoved( object sender, SplitterEventArgs e )
        {
            try
            {
                int nDefaultSplit = this.splitContainer_FileLR.Size.Width / 7;
                if( splitContainer_FileLR.SplitterDistance < nDefaultSplit )
                    splitContainer_FileLR.SplitterDistance = nDefaultSplit;
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        public string UrlEncode( string str )
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes( str ); //默认是System.Text.Encoding.Default.GetBytes(str)
            for( int i = 0; i < byStr.Length; i++ )
            {
                sb.Append( @"%" + Convert.ToString( byStr[i], 16 ) );
            }

            return ( sb.ToString() );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            try
            {


                richTextBox_Result.Text = this.UrlEncode( richTextBox_Source.Text );
            }
            catch( Exception ex )
            {
                throw ex;
            }
        }

        private void richTextBox_Source_SelectionChanged( object sender, EventArgs e )
        {

        }

        private void richTextBox_Source_Enter( object sender, EventArgs e )
        {

        }

        private void richTextBox_Source_Validating( object sender, CancelEventArgs e )
        {

        }

        private void richTextBox_Source_BindingContextChanged( object sender, EventArgs e )
        {

        }

        private void richTextBox_Source_TextChanged( object sender, EventArgs e )
        {

        }

        /// <summary>
        /// 切换tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl_Main_Selected( object sender, TabControlEventArgs e )
        {
            switch( e.TabPageIndex )
            {
            case (int)CommClass.MainTabIndex.StringTool:

                break;
            case (int)CommClass.MainTabIndex.SQLTools:

                break;
            case (int)CommClass.MainTabIndex.QRCodeTools:

                break;
            case (int)CommClass.MainTabIndex.AboutInfo:

                break;
            }
        }

        private void QRCode_Done_Click( object sender, EventArgs e )
        {
            try
            {
                Bitmap bp;
                label7.Text = "";
                if( !String.IsNullOrEmpty( QR_textBox_Memo.Text ) )
                {
                    //bp = QRCode.GetCode( QR_textBox_Memo.Text, QRCode.ENCODE_MODE.BYTE, QRCode.ERROR_CORRECTION.HIGH, 0, 4 );

                   bp = QRCode.GetCode( QR_textBox_Memo.Text, QRCode.ErrorCorrectionLevel.HIGH, QRCode.BarcodeFormat.QR_CODE,300,300 );
                    QR_pictureBox_QRCode.Image = bp;
                }
            }
            catch( Exception ex )
            {
                label7.Text = ex.Message;
            }
        }
    }
}
