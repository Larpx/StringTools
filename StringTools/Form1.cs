using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTools
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
    }
}
