namespace StringTools
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_StringTools = new System.Windows.Forms.TabPage();
            this.splitContainer_FileLR = new System.Windows.Forms.SplitContainer();
            this.groupBox_Operate = new System.Windows.Forms.GroupBox();
            this.radioButton_StringTypeXML = new System.Windows.Forms.RadioButton();
            this.radioButton_StringTypeJson = new System.Windows.Forms.RadioButton();
            this.radioButton_StringTypeStrings = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer_FileUB = new System.Windows.Forms.SplitContainer();
            this.splitContainer_FileU = new System.Windows.Forms.SplitContainer();
            this.label_SourdeInfo3 = new System.Windows.Forms.Label();
            this.label_SourdeInfo2 = new System.Windows.Forms.Label();
            this.label_SourdeInfo1 = new System.Windows.Forms.Label();
            this.richTextBox_Source = new System.Windows.Forms.RichTextBox();
            this.splitContainer_FileB = new System.Windows.Forms.SplitContainer();
            this.label_Resultinfo3 = new System.Windows.Forms.Label();
            this.label_Resultinfo2 = new System.Windows.Forms.Label();
            this.label_Resultinfo1 = new System.Windows.Forms.Label();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.tabPage_SQLTools = new System.Windows.Forms.TabPage();
            this.tabPage_About = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_FileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator_File1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_FileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip_Main = new System.Windows.Forms.StatusStrip();
            this.openFileDialog_File = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog_File = new System.Windows.Forms.SaveFileDialog();
            this.fileSystemWatcher_File = new System.IO.FileSystemWatcher();
            this.checkBox_RTWordWWrap1 = new System.Windows.Forms.CheckBox();
            this.checkBox_RTWordWWrap2 = new System.Windows.Forms.CheckBox();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_StringTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileLR)).BeginInit();
            this.splitContainer_FileLR.Panel1.SuspendLayout();
            this.splitContainer_FileLR.Panel2.SuspendLayout();
            this.splitContainer_FileLR.SuspendLayout();
            this.groupBox_Operate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileUB)).BeginInit();
            this.splitContainer_FileUB.Panel1.SuspendLayout();
            this.splitContainer_FileUB.Panel2.SuspendLayout();
            this.splitContainer_FileUB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileU)).BeginInit();
            this.splitContainer_FileU.Panel1.SuspendLayout();
            this.splitContainer_FileU.Panel2.SuspendLayout();
            this.splitContainer_FileU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileB)).BeginInit();
            this.splitContainer_FileB.Panel1.SuspendLayout();
            this.splitContainer_FileB.Panel2.SuspendLayout();
            this.splitContainer_FileB.SuspendLayout();
            this.tabPage_About.SuspendLayout();
            this.menuStrip_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_File)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_StringTools);
            this.tabControl_Main.Controls.Add(this.tabPage_SQLTools);
            this.tabControl_Main.Controls.Add(this.tabPage_About);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 25);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(844, 454);
            this.tabControl_Main.TabIndex = 0;
            // 
            // tabPage_StringTools
            // 
            this.tabPage_StringTools.Controls.Add(this.splitContainer_FileLR);
            this.tabPage_StringTools.Location = new System.Drawing.Point(4, 22);
            this.tabPage_StringTools.Name = "tabPage_StringTools";
            this.tabPage_StringTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_StringTools.Size = new System.Drawing.Size(836, 428);
            this.tabPage_StringTools.TabIndex = 0;
            this.tabPage_StringTools.Text = "字符串处理";
            this.tabPage_StringTools.UseVisualStyleBackColor = true;
            this.tabPage_StringTools.SizeChanged += new System.EventHandler(this.tabPage1_SizeChanged);
            // 
            // splitContainer_FileLR
            // 
            this.splitContainer_FileLR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_FileLR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_FileLR.Location = new System.Drawing.Point(3, 3);
            this.splitContainer_FileLR.Name = "splitContainer_FileLR";
            // 
            // splitContainer_FileLR.Panel1
            // 
            this.splitContainer_FileLR.Panel1.AutoScroll = true;
            this.splitContainer_FileLR.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer_FileLR.Panel1.Controls.Add(this.groupBox_Operate);
            this.splitContainer_FileLR.Panel1MinSize = 130;
            // 
            // splitContainer_FileLR.Panel2
            // 
            this.splitContainer_FileLR.Panel2.Controls.Add(this.splitContainer_FileUB);
            this.splitContainer_FileLR.Panel2MinSize = 696;
            this.splitContainer_FileLR.Size = new System.Drawing.Size(830, 422);
            this.splitContainer_FileLR.SplitterDistance = 130;
            this.splitContainer_FileLR.TabIndex = 3;
            this.splitContainer_FileLR.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_FileLR_SplitterMoved);
            // 
            // groupBox_Operate
            // 
            this.groupBox_Operate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_Operate.Controls.Add(this.radioButton_StringTypeXML);
            this.groupBox_Operate.Controls.Add(this.radioButton_StringTypeJson);
            this.groupBox_Operate.Controls.Add(this.radioButton_StringTypeStrings);
            this.groupBox_Operate.Controls.Add(this.button4);
            this.groupBox_Operate.Controls.Add(this.button3);
            this.groupBox_Operate.Controls.Add(this.button2);
            this.groupBox_Operate.Controls.Add(this.button1);
            this.groupBox_Operate.Location = new System.Drawing.Point(5, 3);
            this.groupBox_Operate.Name = "groupBox_Operate";
            this.groupBox_Operate.Size = new System.Drawing.Size(120, 417);
            this.groupBox_Operate.TabIndex = 0;
            this.groupBox_Operate.TabStop = false;
            this.groupBox_Operate.Text = "操作";
            // 
            // radioButton_StringTypeXML
            // 
            this.radioButton_StringTypeXML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_StringTypeXML.AutoSize = true;
            this.radioButton_StringTypeXML.Location = new System.Drawing.Point(32, 64);
            this.radioButton_StringTypeXML.Name = "radioButton_StringTypeXML";
            this.radioButton_StringTypeXML.Size = new System.Drawing.Size(41, 16);
            this.radioButton_StringTypeXML.TabIndex = 6;
            this.radioButton_StringTypeXML.Text = "XML";
            this.radioButton_StringTypeXML.UseVisualStyleBackColor = true;
            // 
            // radioButton_StringTypeJson
            // 
            this.radioButton_StringTypeJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_StringTypeJson.AutoSize = true;
            this.radioButton_StringTypeJson.Location = new System.Drawing.Point(32, 42);
            this.radioButton_StringTypeJson.Name = "radioButton_StringTypeJson";
            this.radioButton_StringTypeJson.Size = new System.Drawing.Size(47, 16);
            this.radioButton_StringTypeJson.TabIndex = 5;
            this.radioButton_StringTypeJson.Text = "Json";
            this.radioButton_StringTypeJson.UseVisualStyleBackColor = true;
            // 
            // radioButton_StringTypeStrings
            // 
            this.radioButton_StringTypeStrings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_StringTypeStrings.AutoSize = true;
            this.radioButton_StringTypeStrings.Checked = true;
            this.radioButton_StringTypeStrings.Location = new System.Drawing.Point(32, 20);
            this.radioButton_StringTypeStrings.Name = "radioButton_StringTypeStrings";
            this.radioButton_StringTypeStrings.Size = new System.Drawing.Size(47, 16);
            this.radioButton_StringTypeStrings.TabIndex = 4;
            this.radioButton_StringTypeStrings.TabStop = true;
            this.radioButton_StringTypeStrings.Text = "文本";
            this.radioButton_StringTypeStrings.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer_FileUB
            // 
            this.splitContainer_FileUB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer_FileUB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_FileUB.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer_FileUB.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_FileUB.Name = "splitContainer_FileUB";
            this.splitContainer_FileUB.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_FileUB.Panel1
            // 
            this.splitContainer_FileUB.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer_FileUB.Panel1.Controls.Add(this.splitContainer_FileU);
            // 
            // splitContainer_FileUB.Panel2
            // 
            this.splitContainer_FileUB.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer_FileUB.Panel2.Controls.Add(this.splitContainer_FileB);
            this.splitContainer_FileUB.Panel2MinSize = 211;
            this.splitContainer_FileUB.Size = new System.Drawing.Size(696, 422);
            this.splitContainer_FileUB.SplitterDistance = 211;
            this.splitContainer_FileUB.TabIndex = 0;
            // 
            // splitContainer_FileU
            // 
            this.splitContainer_FileU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_FileU.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_FileU.Name = "splitContainer_FileU";
            this.splitContainer_FileU.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_FileU.Panel1
            // 
            this.splitContainer_FileU.Panel1.Controls.Add(this.checkBox_RTWordWWrap1);
            this.splitContainer_FileU.Panel1.Controls.Add(this.label_SourdeInfo3);
            this.splitContainer_FileU.Panel1.Controls.Add(this.label_SourdeInfo2);
            this.splitContainer_FileU.Panel1.Controls.Add(this.label_SourdeInfo1);
            // 
            // splitContainer_FileU.Panel2
            // 
            this.splitContainer_FileU.Panel2.Controls.Add(this.richTextBox_Source);
            this.splitContainer_FileU.Size = new System.Drawing.Size(694, 209);
            this.splitContainer_FileU.SplitterDistance = 25;
            this.splitContainer_FileU.TabIndex = 1;
            // 
            // label_SourdeInfo3
            // 
            this.label_SourdeInfo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SourdeInfo3.AutoSize = true;
            this.label_SourdeInfo3.Location = new System.Drawing.Point(262, 8);
            this.label_SourdeInfo3.Name = "label_SourdeInfo3";
            this.label_SourdeInfo3.Size = new System.Drawing.Size(11, 12);
            this.label_SourdeInfo3.TabIndex = 2;
            this.label_SourdeInfo3.Text = "-";
            // 
            // label_SourdeInfo2
            // 
            this.label_SourdeInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_SourdeInfo2.AutoSize = true;
            this.label_SourdeInfo2.Location = new System.Drawing.Point(191, 8);
            this.label_SourdeInfo2.Name = "label_SourdeInfo2";
            this.label_SourdeInfo2.Size = new System.Drawing.Size(65, 12);
            this.label_SourdeInfo2.TabIndex = 1;
            this.label_SourdeInfo2.Text = "文本信息：";
            // 
            // label_SourdeInfo1
            // 
            this.label_SourdeInfo1.AutoSize = true;
            this.label_SourdeInfo1.Location = new System.Drawing.Point(11, 8);
            this.label_SourdeInfo1.Name = "label_SourdeInfo1";
            this.label_SourdeInfo1.Size = new System.Drawing.Size(77, 12);
            this.label_SourdeInfo1.TabIndex = 0;
            this.label_SourdeInfo1.Text = "待处理文本：";
            // 
            // richTextBox_Source
            // 
            this.richTextBox_Source.DetectUrls = false;
            this.richTextBox_Source.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Source.EnableAutoDragDrop = true;
            this.richTextBox_Source.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Source.Name = "richTextBox_Source";
            this.richTextBox_Source.Size = new System.Drawing.Size(694, 180);
            this.richTextBox_Source.TabIndex = 0;
            this.richTextBox_Source.Text = "";
            this.richTextBox_Source.SelectionChanged += new System.EventHandler(this.richTextBox_Source_SelectionChanged);
            this.richTextBox_Source.BindingContextChanged += new System.EventHandler(this.richTextBox_Source_BindingContextChanged);
            this.richTextBox_Source.TextChanged += new System.EventHandler(this.richTextBox_Source_TextChanged);
            this.richTextBox_Source.Enter += new System.EventHandler(this.richTextBox_Source_Enter);
            this.richTextBox_Source.Validating += new System.ComponentModel.CancelEventHandler(this.richTextBox_Source_Validating);
            // 
            // splitContainer_FileB
            // 
            this.splitContainer_FileB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer_FileB.Location = new System.Drawing.Point(0, 0);
            this.splitContainer_FileB.Name = "splitContainer_FileB";
            this.splitContainer_FileB.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer_FileB.Panel1
            // 
            this.splitContainer_FileB.Panel1.Controls.Add(this.checkBox_RTWordWWrap2);
            this.splitContainer_FileB.Panel1.Controls.Add(this.label_Resultinfo3);
            this.splitContainer_FileB.Panel1.Controls.Add(this.label_Resultinfo2);
            this.splitContainer_FileB.Panel1.Controls.Add(this.label_Resultinfo1);
            // 
            // splitContainer_FileB.Panel2
            // 
            this.splitContainer_FileB.Panel2.Controls.Add(this.richTextBox_Result);
            this.splitContainer_FileB.Size = new System.Drawing.Size(694, 205);
            this.splitContainer_FileB.SplitterDistance = 25;
            this.splitContainer_FileB.TabIndex = 1;
            // 
            // label_Resultinfo3
            // 
            this.label_Resultinfo3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Resultinfo3.AutoSize = true;
            this.label_Resultinfo3.Location = new System.Drawing.Point(262, 8);
            this.label_Resultinfo3.Name = "label_Resultinfo3";
            this.label_Resultinfo3.Size = new System.Drawing.Size(11, 12);
            this.label_Resultinfo3.TabIndex = 5;
            this.label_Resultinfo3.Text = "-";
            // 
            // label_Resultinfo2
            // 
            this.label_Resultinfo2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Resultinfo2.AutoSize = true;
            this.label_Resultinfo2.Location = new System.Drawing.Point(191, 8);
            this.label_Resultinfo2.Name = "label_Resultinfo2";
            this.label_Resultinfo2.Size = new System.Drawing.Size(65, 12);
            this.label_Resultinfo2.TabIndex = 4;
            this.label_Resultinfo2.Text = "文本信息：";
            // 
            // label_Resultinfo1
            // 
            this.label_Resultinfo1.AutoSize = true;
            this.label_Resultinfo1.Location = new System.Drawing.Point(11, 8);
            this.label_Resultinfo1.Name = "label_Resultinfo1";
            this.label_Resultinfo1.Size = new System.Drawing.Size(77, 12);
            this.label_Resultinfo1.TabIndex = 3;
            this.label_Resultinfo1.Text = "已处理文本：";
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox_Result.Location = new System.Drawing.Point(0, 0);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(694, 176);
            this.richTextBox_Result.TabIndex = 0;
            this.richTextBox_Result.Text = "";
            // 
            // tabPage_SQLTools
            // 
            this.tabPage_SQLTools.Location = new System.Drawing.Point(4, 22);
            this.tabPage_SQLTools.Name = "tabPage_SQLTools";
            this.tabPage_SQLTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_SQLTools.Size = new System.Drawing.Size(836, 428);
            this.tabPage_SQLTools.TabIndex = 1;
            this.tabPage_SQLTools.Text = "SQL转换";
            this.tabPage_SQLTools.UseVisualStyleBackColor = true;
            // 
            // tabPage_About
            // 
            this.tabPage_About.Controls.Add(this.richTextBox1);
            this.tabPage_About.Location = new System.Drawing.Point(4, 22);
            this.tabPage_About.Name = "tabPage_About";
            this.tabPage_About.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_About.Size = new System.Drawing.Size(836, 428);
            this.tabPage_About.TabIndex = 2;
            this.tabPage_About.Text = "功能介绍";
            this.tabPage_About.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(820, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_File});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(844, 25);
            this.menuStrip_Main.TabIndex = 1;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // toolStripMenuItem_File
            // 
            this.toolStripMenuItem_File.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_FileOpen,
            this.toolStripSeparator_File1,
            this.toolStripMenuItem_FileClose});
            this.toolStripMenuItem_File.Name = "toolStripMenuItem_File";
            this.toolStripMenuItem_File.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItem_File.Text = "文件";
            // 
            // toolStripMenuItem_FileOpen
            // 
            this.toolStripMenuItem_FileOpen.Name = "toolStripMenuItem_FileOpen";
            this.toolStripMenuItem_FileOpen.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_FileOpen.Text = "打开";
            // 
            // toolStripSeparator_File1
            // 
            this.toolStripSeparator_File1.Name = "toolStripSeparator_File1";
            this.toolStripSeparator_File1.Size = new System.Drawing.Size(97, 6);
            // 
            // toolStripMenuItem_FileClose
            // 
            this.toolStripMenuItem_FileClose.Name = "toolStripMenuItem_FileClose";
            this.toolStripMenuItem_FileClose.Size = new System.Drawing.Size(100, 22);
            this.toolStripMenuItem_FileClose.Text = "退出";
            // 
            // statusStrip_Main
            // 
            this.statusStrip_Main.Location = new System.Drawing.Point(0, 479);
            this.statusStrip_Main.Name = "statusStrip_Main";
            this.statusStrip_Main.Size = new System.Drawing.Size(844, 22);
            this.statusStrip_Main.TabIndex = 2;
            this.statusStrip_Main.Text = "statusStrip1";
            // 
            // openFileDialog_File
            // 
            this.openFileDialog_File.FileName = "openFileDialog1";
            // 
            // fileSystemWatcher_File
            // 
            this.fileSystemWatcher_File.EnableRaisingEvents = true;
            this.fileSystemWatcher_File.SynchronizingObject = this;
            // 
            // checkBox_RTWordWWrap1
            // 
            this.checkBox_RTWordWWrap1.AutoSize = true;
            this.checkBox_RTWordWWrap1.Location = new System.Drawing.Point(348, 4);
            this.checkBox_RTWordWWrap1.Name = "checkBox_RTWordWWrap1";
            this.checkBox_RTWordWWrap1.Size = new System.Drawing.Size(72, 16);
            this.checkBox_RTWordWWrap1.TabIndex = 3;
            this.checkBox_RTWordWWrap1.Text = "自动换行";
            this.checkBox_RTWordWWrap1.UseVisualStyleBackColor = true;
            // 
            // checkBox_RTWordWWrap2
            // 
            this.checkBox_RTWordWWrap2.AutoSize = true;
            this.checkBox_RTWordWWrap2.Location = new System.Drawing.Point(348, 4);
            this.checkBox_RTWordWWrap2.Name = "checkBox_RTWordWWrap2";
            this.checkBox_RTWordWWrap2.Size = new System.Drawing.Size(72, 16);
            this.checkBox_RTWordWWrap2.TabIndex = 6;
            this.checkBox_RTWordWWrap2.Text = "自动换行";
            this.checkBox_RTWordWWrap2.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.statusStrip_Main);
            this.Controls.Add(this.menuStrip_Main);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "FormMain";
            this.Text = "StringTools v1.0.0";
            this.ResizeBegin += new System.EventHandler(this.FormMain_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.FormMain_ResizeEnd);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_StringTools.ResumeLayout(false);
            this.splitContainer_FileLR.Panel1.ResumeLayout(false);
            this.splitContainer_FileLR.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileLR)).EndInit();
            this.splitContainer_FileLR.ResumeLayout(false);
            this.groupBox_Operate.ResumeLayout(false);
            this.groupBox_Operate.PerformLayout();
            this.splitContainer_FileUB.Panel1.ResumeLayout(false);
            this.splitContainer_FileUB.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileUB)).EndInit();
            this.splitContainer_FileUB.ResumeLayout(false);
            this.splitContainer_FileU.Panel1.ResumeLayout(false);
            this.splitContainer_FileU.Panel1.PerformLayout();
            this.splitContainer_FileU.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileU)).EndInit();
            this.splitContainer_FileU.ResumeLayout(false);
            this.splitContainer_FileB.Panel1.ResumeLayout(false);
            this.splitContainer_FileB.Panel1.PerformLayout();
            this.splitContainer_FileB.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer_FileB)).EndInit();
            this.splitContainer_FileB.ResumeLayout(false);
            this.tabPage_About.ResumeLayout(false);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher_File)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_StringTools;
        private System.Windows.Forms.TabPage tabPage_SQLTools;
        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_File;
        private System.Windows.Forms.TabPage tabPage_About;
        private System.Windows.Forms.StatusStrip statusStrip_Main;
        private System.Windows.Forms.SplitContainer splitContainer_FileLR;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator_File1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FileClose;
        private System.Windows.Forms.SplitContainer splitContainer_FileUB;
        private System.Windows.Forms.GroupBox groupBox_Operate;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Source;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
        private System.Windows.Forms.SplitContainer splitContainer_FileU;
        private System.Windows.Forms.SplitContainer splitContainer_FileB;
        private System.Windows.Forms.Label label_SourdeInfo1;
        private System.Windows.Forms.Label label_SourdeInfo3;
        private System.Windows.Forms.Label label_SourdeInfo2;
        private System.Windows.Forms.Label label_Resultinfo3;
        private System.Windows.Forms.Label label_Resultinfo2;
        private System.Windows.Forms.Label label_Resultinfo1;
        private System.Windows.Forms.RadioButton radioButton_StringTypeXML;
        private System.Windows.Forms.RadioButton radioButton_StringTypeJson;
        private System.Windows.Forms.RadioButton radioButton_StringTypeStrings;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog_File;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_File;
        private System.IO.FileSystemWatcher fileSystemWatcher_File;
        private System.Windows.Forms.CheckBox checkBox_RTWordWWrap1;
        private System.Windows.Forms.CheckBox checkBox_RTWordWWrap2;
    }
}

