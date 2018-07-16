namespace ConfuserExProtectionFinder
{
    partial class XtraForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.path = new DevExpress.XtraEditors.TextEdit();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.AT = new System.Windows.Forms.Label();
            this.Packer = new System.Windows.Forms.Label();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.Infos = new DevExpress.XtraEditors.LabelControl();
            this.ILDasm = new System.Windows.Forms.Label();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.Constants = new System.Windows.Forms.Label();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Protector = new DevExpress.XtraEditors.LabelControl();
            this.ADebug = new System.Windows.Forms.Label();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.ADump = new System.Windows.Forms.Label();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.RF = new System.Windows.Forms.Label();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.CFlow = new System.Windows.Forms.Label();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.Resource = new System.Windows.Forms.Label();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.ModeRF = new System.Windows.Forms.Label();
            this.EncodingRF = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.ModeConstants = new System.Windows.Forms.Label();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.Cfg = new System.Windows.Forms.Label();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.Predicate = new System.Windows.Forms.Label();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.PackerMode = new System.Windows.Forms.Label();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.ATMode = new System.Windows.Forms.Label();
            this.groupControl9 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.ResourceMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).BeginInit();
            this.groupControl9.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 38);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(202, 47);
            this.simpleButton1.StyleController = this.styleController1;
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Load and Detect !";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // path
            // 
            this.path.AllowDrop = true;
            this.path.Location = new System.Drawing.Point(12, 12);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(546, 20);
            this.path.TabIndex = 1;
            this.path.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox1DragDrop);
            this.path.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox1DragEnter);
            // 
            // styleController1
            // 
            this.styleController1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.styleController1.Appearance.Options.UseBackColor = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(68, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Anti Tamper : ";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 89);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(546, 23);
            this.separatorControl1.TabIndex = 3;
            // 
            // AT
            // 
            this.AT.AutoSize = true;
            this.AT.Location = new System.Drawing.Point(89, 38);
            this.AT.Name = "AT";
            this.AT.Size = new System.Drawing.Size(12, 13);
            this.AT.TabIndex = 4;
            this.AT.Text = "?";
            // 
            // Packer
            // 
            this.Packer.AutoSize = true;
            this.Packer.Location = new System.Drawing.Point(62, 34);
            this.Packer.Name = "Packer";
            this.Packer.Size = new System.Drawing.Size(12, 13);
            this.Packer.TabIndex = 6;
            this.Packer.Text = "?";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Packer : ";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(12, 436);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(546, 23);
            this.separatorControl2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Infos and Status : ";
            // 
            // Infos
            // 
            this.Infos.Location = new System.Drawing.Point(117, 459);
            this.Infos.Name = "Infos";
            this.Infos.Size = new System.Drawing.Size(4, 13);
            this.Infos.TabIndex = 9;
            this.Infos.Text = "/";
            // 
            // ILDasm
            // 
            this.ILDasm.AutoSize = true;
            this.ILDasm.Location = new System.Drawing.Point(86, 42);
            this.ILDasm.Name = "ILDasm";
            this.ILDasm.Size = new System.Drawing.Size(12, 13);
            this.ILDasm.TabIndex = 11;
            this.ILDasm.Text = "?";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 42);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Anti-ILDasm :";
            // 
            // Constants
            // 
            this.Constants.AutoSize = true;
            this.Constants.Location = new System.Drawing.Point(79, 30);
            this.Constants.Name = "Constants";
            this.Constants.Size = new System.Drawing.Size(12, 13);
            this.Constants.TabIndex = 13;
            this.Constants.Text = "?";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Constants : ";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(220, 51);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(131, 18);
            this.labelControl5.TabIndex = 14;
            this.labelControl5.Text = "Protector Name : ";
            // 
            // Protector
            // 
            this.Protector.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Protector.Appearance.Options.UseFont = true;
            this.Protector.Location = new System.Drawing.Point(357, 51);
            this.Protector.Name = "Protector";
            this.Protector.Size = new System.Drawing.Size(9, 18);
            this.Protector.TabIndex = 15;
            this.Protector.Text = "?";
            // 
            // ADebug
            // 
            this.ADebug.AutoSize = true;
            this.ADebug.Location = new System.Drawing.Point(79, 42);
            this.ADebug.Name = "ADebug";
            this.ADebug.Size = new System.Drawing.Size(12, 13);
            this.ADebug.TabIndex = 17;
            this.ADebug.Text = "?";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(14, 42);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(61, 13);
            this.labelControl6.TabIndex = 16;
            this.labelControl6.Text = "Anti-Debug :";
            // 
            // ADump
            // 
            this.ADump.AutoSize = true;
            this.ADump.Location = new System.Drawing.Point(77, 42);
            this.ADump.Name = "ADump";
            this.ADump.Size = new System.Drawing.Size(12, 13);
            this.ADump.TabIndex = 19;
            this.ADump.Text = "?";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 42);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Anti-Dump :";
            // 
            // RF
            // 
            this.RF.AutoSize = true;
            this.RF.Location = new System.Drawing.Point(79, 35);
            this.RF.Name = "RF";
            this.RF.Size = new System.Drawing.Size(12, 13);
            this.RF.TabIndex = 21;
            this.RF.Text = "?";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(14, 35);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 13);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Ref-Proxy : ";
            // 
            // CFlow
            // 
            this.CFlow.AutoSize = true;
            this.CFlow.Location = new System.Drawing.Point(88, 30);
            this.CFlow.Name = "CFlow";
            this.CFlow.Size = new System.Drawing.Size(12, 13);
            this.CFlow.TabIndex = 23;
            this.CFlow.Text = "?";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(14, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(71, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Control-Flow : ";
            // 
            // Resource
            // 
            this.Resource.AutoSize = true;
            this.Resource.Location = new System.Drawing.Point(79, 38);
            this.Resource.Name = "Resource";
            this.Resource.Size = new System.Drawing.Size(12, 13);
            this.Resource.TabIndex = 25;
            this.Resource.Text = "?";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(14, 38);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 13);
            this.labelControl10.TabIndex = 24;
            this.labelControl10.Text = "Resources : ";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(14, 64);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 13);
            this.labelControl11.TabIndex = 26;
            this.labelControl11.Text = "Mode : ";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(14, 100);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(53, 13);
            this.labelControl12.TabIndex = 27;
            this.labelControl12.Text = "Encoding : ";
            // 
            // ModeRF
            // 
            this.ModeRF.AutoSize = true;
            this.ModeRF.Location = new System.Drawing.Point(56, 64);
            this.ModeRF.Name = "ModeRF";
            this.ModeRF.Size = new System.Drawing.Size(11, 13);
            this.ModeRF.TabIndex = 28;
            this.ModeRF.Text = "/";
            // 
            // EncodingRF
            // 
            this.EncodingRF.AutoSize = true;
            this.EncodingRF.Location = new System.Drawing.Point(73, 100);
            this.EncodingRF.Name = "EncodingRF";
            this.EncodingRF.Size = new System.Drawing.Size(11, 13);
            this.EncodingRF.TabIndex = 29;
            this.EncodingRF.Text = "/";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl12);
            this.groupControl1.Controls.Add(this.EncodingRF);
            this.groupControl1.Controls.Add(this.RF);
            this.groupControl1.Controls.Add(this.ModeRF);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Location = new System.Drawing.Point(205, 223);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(157, 124);
            this.groupControl1.TabIndex = 30;
            this.groupControl1.Text = "RefProxy Settings";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Cfg);
            this.groupControl2.Controls.Add(this.labelControl13);
            this.groupControl2.Controls.Add(this.ModeConstants);
            this.groupControl2.Controls.Add(this.labelControl14);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.Constants);
            this.groupControl2.Location = new System.Drawing.Point(12, 223);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(148, 124);
            this.groupControl2.TabIndex = 31;
            this.groupControl2.Text = "Constants Settings";
            // 
            // ModeConstants
            // 
            this.ModeConstants.AutoSize = true;
            this.ModeConstants.Location = new System.Drawing.Point(56, 64);
            this.ModeConstants.Name = "ModeConstants";
            this.ModeConstants.Size = new System.Drawing.Size(11, 13);
            this.ModeConstants.TabIndex = 32;
            this.ModeConstants.Text = "/";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(14, 64);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(36, 13);
            this.labelControl14.TabIndex = 30;
            this.labelControl14.Text = "Mode : ";
            // 
            // Cfg
            // 
            this.Cfg.AutoSize = true;
            this.Cfg.Location = new System.Drawing.Point(50, 100);
            this.Cfg.Name = "Cfg";
            this.Cfg.Size = new System.Drawing.Size(11, 13);
            this.Cfg.TabIndex = 34;
            this.Cfg.Text = "/";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(14, 100);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(30, 13);
            this.labelControl13.TabIndex = 33;
            this.labelControl13.Text = "CFG : ";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.Predicate);
            this.groupControl3.Controls.Add(this.labelControl15);
            this.groupControl3.Controls.Add(this.labelControl9);
            this.groupControl3.Controls.Add(this.CFlow);
            this.groupControl3.Location = new System.Drawing.Point(401, 223);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(157, 124);
            this.groupControl3.TabIndex = 32;
            this.groupControl3.Text = "Cflow Settings";
            // 
            // Predicate
            // 
            this.Predicate.Location = new System.Drawing.Point(73, 64);
            this.Predicate.Name = "Predicate";
            this.Predicate.Size = new System.Drawing.Size(82, 27);
            this.Predicate.TabIndex = 30;
            this.Predicate.Text = "/";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(14, 64);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(55, 13);
            this.labelControl15.TabIndex = 29;
            this.labelControl15.Text = "Predicate : ";
            // 
            // PackerMode
            // 
            this.PackerMode.AutoSize = true;
            this.PackerMode.Location = new System.Drawing.Point(56, 64);
            this.PackerMode.Name = "PackerMode";
            this.PackerMode.Size = new System.Drawing.Size(11, 13);
            this.PackerMode.TabIndex = 36;
            this.PackerMode.Text = "/";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(14, 64);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(36, 13);
            this.labelControl16.TabIndex = 35;
            this.labelControl16.Text = "Mode : ";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.labelControl16);
            this.groupControl4.Controls.Add(this.PackerMode);
            this.groupControl4.Controls.Add(this.labelControl2);
            this.groupControl4.Controls.Add(this.Packer);
            this.groupControl4.Location = new System.Drawing.Point(12, 111);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(148, 95);
            this.groupControl4.TabIndex = 37;
            this.groupControl4.Text = "Packer Settings";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.ADump);
            this.groupControl5.Location = new System.Drawing.Point(12, 365);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(148, 74);
            this.groupControl5.TabIndex = 38;
            this.groupControl5.Text = "Anti-Dump Setting";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.labelControl6);
            this.groupControl6.Controls.Add(this.ADebug);
            this.groupControl6.Location = new System.Drawing.Point(205, 365);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(157, 74);
            this.groupControl6.TabIndex = 39;
            this.groupControl6.Text = "Anti-Debug Setting";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl3);
            this.groupControl7.Controls.Add(this.ILDasm);
            this.groupControl7.Location = new System.Drawing.Point(401, 365);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(157, 74);
            this.groupControl7.TabIndex = 40;
            this.groupControl7.Text = "Anti-ILDasm Setting";
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.labelControl17);
            this.groupControl8.Controls.Add(this.ATMode);
            this.groupControl8.Controls.Add(this.labelControl1);
            this.groupControl8.Controls.Add(this.AT);
            this.groupControl8.Location = new System.Drawing.Point(205, 111);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(161, 95);
            this.groupControl8.TabIndex = 41;
            this.groupControl8.Text = "AntiTamper Settings";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(14, 64);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(36, 13);
            this.labelControl17.TabIndex = 37;
            this.labelControl17.Text = "Mode : ";
            // 
            // ATMode
            // 
            this.ATMode.AutoSize = true;
            this.ATMode.Location = new System.Drawing.Point(56, 64);
            this.ATMode.Name = "ATMode";
            this.ATMode.Size = new System.Drawing.Size(11, 13);
            this.ATMode.TabIndex = 38;
            this.ATMode.Text = "/";
            // 
            // groupControl9
            // 
            this.groupControl9.Controls.Add(this.labelControl18);
            this.groupControl9.Controls.Add(this.ResourceMode);
            this.groupControl9.Controls.Add(this.labelControl10);
            this.groupControl9.Controls.Add(this.Resource);
            this.groupControl9.Location = new System.Drawing.Point(401, 111);
            this.groupControl9.Name = "groupControl9";
            this.groupControl9.Size = new System.Drawing.Size(157, 95);
            this.groupControl9.TabIndex = 42;
            this.groupControl9.Text = "Resources Settings";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(15, 64);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(36, 13);
            this.labelControl18.TabIndex = 39;
            this.labelControl18.Text = "Mode : ";
            // 
            // ResourceMode
            // 
            this.ResourceMode.AutoSize = true;
            this.ResourceMode.Location = new System.Drawing.Point(57, 64);
            this.ResourceMode.Name = "ResourceMode";
            this.ResourceMode.Size = new System.Drawing.Size(11, 13);
            this.ResourceMode.TabIndex = 40;
            this.ResourceMode.Text = "/";
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 483);
            this.Controls.Add(this.groupControl9);
            this.Controls.Add(this.groupControl8);
            this.Controls.Add(this.groupControl7);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.Protector);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.Infos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.path);
            this.Controls.Add(this.simpleButton1);
            this.Name = "XtraForm1";
            this.Text = "ConfuserEx Protection Detector  1.0 by MindSystem";
            ((System.ComponentModel.ISupportInitialize)(this.path.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            this.groupControl8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl9)).EndInit();
            this.groupControl9.ResumeLayout(false);
            this.groupControl9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit path;
        private DevExpress.XtraEditors.StyleController styleController1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label AT;
        private System.Windows.Forms.Label Packer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.Utils.ToolTipController toolTipController1;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LabelControl Infos;
        private System.Windows.Forms.Label ILDasm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label Constants;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl Protector;
        private System.Windows.Forms.Label ADebug;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label ADump;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.Label RF;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private System.Windows.Forms.Label CFlow;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.Label Resource;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private System.Windows.Forms.Label ModeRF;
        private System.Windows.Forms.Label EncodingRF;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label ModeConstants;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private System.Windows.Forms.Label Cfg;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private System.Windows.Forms.Label Predicate;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private System.Windows.Forms.Label PackerMode;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private System.Windows.Forms.Label ATMode;
        private DevExpress.XtraEditors.GroupControl groupControl9;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private System.Windows.Forms.Label ResourceMode;
    }
}