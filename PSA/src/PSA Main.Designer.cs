namespace SmashAttacks
{
    partial class FormMain
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.opnDlg = new System.Windows.Forms.OpenFileDialog();
			this.saveDlg = new System.Windows.Forms.SaveFileDialog();
			this.tbpgAttributes = new System.Windows.Forms.TabPage();
			this.dtgrdAttributes = new System.Windows.Forms.DataGridView();
			this.AttributeContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.showAsFloatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showAsIntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lblAttributeDescription = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.tbpgActions = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lstEventsTxt = new System.Windows.Forms.RichTextBox();
			this.lstEvents = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lblEventListOffset = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnCopyText = new System.Windows.Forms.Button();
			this.btnUp = new System.Windows.Forms.Button();
			this.btnNOP = new System.Windows.Forms.Button();
			this.btnDown = new System.Windows.Forms.Button();
			this.btnCopyEvent = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnPasteEvent = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblEventDescription = new System.Windows.Forms.Label();
			this.tbctrlActionEvents = new System.Windows.Forms.TabControl();
			this.tbpgSpecials = new System.Windows.Forms.TabPage();
			this.cboAction = new System.Windows.Forms.ComboBox();
			this.lblName5 = new System.Windows.Forms.Label();
			this.tbpgSubActionEvents = new System.Windows.Forms.TabPage();
			this.btnAnimationFlags = new System.Windows.Forms.Button();
			this.cboEventList = new System.Windows.Forms.ComboBox();
			this.lblName1 = new System.Windows.Forms.Label();
			this.cboSubAction = new System.Windows.Forms.ComboBox();
			this.lblName2 = new System.Windows.Forms.Label();
			this.lblName3 = new System.Windows.Forms.Label();
			this.txtAnimationName = new System.Windows.Forms.TextBox();
			this.txtAnimDropdown = new System.Windows.Forms.ComboBox();
			this.tbSubRoutines = new System.Windows.Forms.TabPage();
			this.btnCreateSubRoutine = new System.Windows.Forms.Button();
			this.btnGo = new System.Windows.Forms.Button();
			this.txtOffset = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.mnuStatusMenu = new System.Windows.Forms.StatusStrip();
			this.mnuStatusMenuLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.mnuStatusMenuLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tbctrlMain = new System.Windows.Forms.TabControl();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.hexViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuOpen = new System.Windows.Forms.MenuItem();
			this.mnuSep = new System.Windows.Forms.MenuItem();
			this.mnuSave = new System.Windows.Forms.MenuItem();
			this.mnuSaveAs = new System.Windows.Forms.MenuItem();
			this.mnuSep2 = new System.Windows.Forms.MenuItem();
			this.mnuExit = new System.Windows.Forms.MenuItem();
			this.mnuOption = new System.Windows.Forms.MenuItem();
			this.mnuOptionHxToInt = new System.Windows.Forms.MenuItem();
			this.mnuOptionHxToIntSw = new System.Windows.Forms.MenuItem();
			this.mnuOptionHxToIntBth = new System.Windows.Forms.MenuItem();
			this.mnuOptionLstBxTxt = new System.Windows.Forms.MenuItem();
			this.mnuOptionSep1 = new System.Windows.Forms.MenuItem();
			this.mnuOptionAdd = new System.Windows.Forms.MenuItem();
			this.mnuOptionModify = new System.Windows.Forms.MenuItem();
			this.mnuOptionRemove = new System.Windows.Forms.MenuItem();
			this.mnuOptionNpSel = new System.Windows.Forms.MenuItem();
			this.mnuOptionSep2 = new System.Windows.Forms.MenuItem();
			this.mnuOptionMvUp = new System.Windows.Forms.MenuItem();
			this.mnuOptionMvDwn = new System.Windows.Forms.MenuItem();
			this.mnuOptionSep3 = new System.Windows.Forms.MenuItem();
			this.mnuOptionCopy = new System.Windows.Forms.MenuItem();
			this.mnuOptionPaste = new System.Windows.Forms.MenuItem();
			this.mnuOptionCpyTxt = new System.Windows.Forms.MenuItem();
			this.mnuOption2Sep = new System.Windows.Forms.MenuItem();
			this.mnuOptionExtras = new System.Windows.Forms.MenuItem();
			this.mnuOptionExtrasCU = new System.Windows.Forms.MenuItem();
			this.mnuOptionExtrasCD = new System.Windows.Forms.MenuItem();
			this.mnuOptionExtrasAName = new System.Windows.Forms.MenuItem();
			this.mnuHelp = new System.Windows.Forms.MenuItem();
			this.mnuAbout = new System.Windows.Forms.MenuItem();
			this.mnuStatusMenuLabel2Tmr = new System.Windows.Forms.Timer(this.components);
			this.mnuFilePathObtained = new System.Windows.Forms.Button();
			this.mnuOption2 = new System.Windows.Forms.MenuItem();
			this.tbpgAttributes.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtgrdAttributes)).BeginInit();
			this.AttributeContextMenu.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.tbpgActions.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tbctrlActionEvents.SuspendLayout();
			this.tbpgSpecials.SuspendLayout();
			this.tbpgSubActionEvents.SuspendLayout();
			this.tbSubRoutines.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.mnuStatusMenu.SuspendLayout();
			this.tbctrlMain.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// opnDlg
			// 
			this.opnDlg.Filter = "Pac Files|*.pac|All files|*.*";
			// 
			// saveDlg
			// 
			this.saveDlg.DefaultExt = "pac";
			this.saveDlg.Filter = "Pac Files|*.pac|All files|*.*";
			// 
			// tbpgAttributes
			// 
			this.tbpgAttributes.Controls.Add(this.dtgrdAttributes);
			this.tbpgAttributes.Controls.Add(this.lblAttributeDescription);
			this.tbpgAttributes.Controls.Add(this.groupBox2);
			this.tbpgAttributes.Location = new System.Drawing.Point(4, 22);
			this.tbpgAttributes.Name = "tbpgAttributes";
			this.tbpgAttributes.Padding = new System.Windows.Forms.Padding(3);
			this.tbpgAttributes.Size = new System.Drawing.Size(420, 463);
			this.tbpgAttributes.TabIndex = 1;
			this.tbpgAttributes.Text = "Attributes";
			this.tbpgAttributes.UseVisualStyleBackColor = true;
			// 
			// dtgrdAttributes
			// 
			this.dtgrdAttributes.AllowUserToAddRows = false;
			this.dtgrdAttributes.AllowUserToDeleteRows = false;
			this.dtgrdAttributes.AllowUserToResizeRows = false;
			this.dtgrdAttributes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dtgrdAttributes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dtgrdAttributes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgrdAttributes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dtgrdAttributes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgrdAttributes.ColumnHeadersVisible = false;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle8.Format = "N4";
			dataGridViewCellStyle8.NullValue = null;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgrdAttributes.DefaultCellStyle = dataGridViewCellStyle8;
			this.dtgrdAttributes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtgrdAttributes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
			this.dtgrdAttributes.EnableHeadersVisualStyles = false;
			this.dtgrdAttributes.GridColor = System.Drawing.SystemColors.ControlLight;
			this.dtgrdAttributes.Location = new System.Drawing.Point(3, 43);
			this.dtgrdAttributes.MultiSelect = false;
			this.dtgrdAttributes.Name = "dtgrdAttributes";
			this.dtgrdAttributes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgrdAttributes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dtgrdAttributes.RowHeadersWidth = 8;
			this.dtgrdAttributes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dtgrdAttributes.RowTemplate.ContextMenuStrip = this.AttributeContextMenu;
			this.dtgrdAttributes.RowTemplate.Height = 16;
			this.dtgrdAttributes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgrdAttributes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgrdAttributes.Size = new System.Drawing.Size(414, 375);
			this.dtgrdAttributes.TabIndex = 4;
			this.dtgrdAttributes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrdAttributes_CellEndEdit);
			this.dtgrdAttributes.CurrentCellChanged += new System.EventHandler(this.dtgrdAttributes_CurrentCellChanged);
			// 
			// AttributeContextMenu
			// 
			this.AttributeContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAsFloatToolStripMenuItem,
            this.showAsIntToolStripMenuItem});
			this.AttributeContextMenu.Name = "AttributeContextMenu";
			this.AttributeContextMenu.Size = new System.Drawing.Size(145, 48);
			// 
			// showAsFloatToolStripMenuItem
			// 
			this.showAsFloatToolStripMenuItem.Name = "showAsFloatToolStripMenuItem";
			this.showAsFloatToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.showAsFloatToolStripMenuItem.Text = "Show as float";
			this.showAsFloatToolStripMenuItem.Click += new System.EventHandler(this.showAsFloatToolStripMenuItem_Click);
			// 
			// showAsIntToolStripMenuItem
			// 
			this.showAsIntToolStripMenuItem.Name = "showAsIntToolStripMenuItem";
			this.showAsIntToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.showAsIntToolStripMenuItem.Text = "Show as int";
			this.showAsIntToolStripMenuItem.Click += new System.EventHandler(this.showAsIntToolStripMenuItem_Click);
			// 
			// lblAttributeDescription
			// 
			this.lblAttributeDescription.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblAttributeDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblAttributeDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblAttributeDescription.Location = new System.Drawing.Point(3, 418);
			this.lblAttributeDescription.Name = "lblAttributeDescription";
			this.lblAttributeDescription.Size = new System.Drawing.Size(414, 42);
			this.lblAttributeDescription.TabIndex = 3;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(414, 40);
			this.groupBox2.TabIndex = 6;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Value List";
			// 
			// comboBox2
			// 
			this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(3, 16);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(408, 21);
			this.comboBox2.TabIndex = 0;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// tbpgActions
			// 
			this.tbpgActions.Controls.Add(this.panel1);
			this.tbpgActions.Controls.Add(this.tbctrlActionEvents);
			this.tbpgActions.Controls.Add(this.groupBox1);
			this.tbpgActions.Location = new System.Drawing.Point(4, 22);
			this.tbpgActions.Name = "tbpgActions";
			this.tbpgActions.Size = new System.Drawing.Size(420, 463);
			this.tbpgActions.TabIndex = 2;
			this.tbpgActions.Text = "Action Events";
			this.tbpgActions.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lstEventsTxt);
			this.panel1.Controls.Add(this.lstEvents);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.lblEventDescription);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 127);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(3);
			this.panel1.Size = new System.Drawing.Size(420, 336);
			this.panel1.TabIndex = 21;
			// 
			// lstEventsTxt
			// 
			this.lstEventsTxt.Location = new System.Drawing.Point(162, 80);
			this.lstEventsTxt.Name = "lstEventsTxt";
			this.lstEventsTxt.Size = new System.Drawing.Size(100, 96);
			this.lstEventsTxt.TabIndex = 23;
			this.lstEventsTxt.Text = "";
			this.lstEventsTxt.Visible = false;
			// 
			// lstEvents
			// 
			this.lstEvents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lstEvents.FormattingEnabled = true;
			this.lstEvents.HorizontalScrollbar = true;
			this.lstEvents.Location = new System.Drawing.Point(3, 22);
			this.lstEvents.Name = "lstEvents";
			this.lstEvents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstEvents.Size = new System.Drawing.Size(414, 213);
			this.lstEvents.TabIndex = 5;
			this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
			this.lstEvents.DoubleClick += new System.EventHandler(this.lstEvents_DoubleClick);
			this.lstEvents.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstEvents_KeyUp);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lblEventListOffset);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(414, 19);
			this.panel3.TabIndex = 22;
			// 
			// lblEventListOffset
			// 
			this.lblEventListOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblEventListOffset.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblEventListOffset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEventListOffset.Location = new System.Drawing.Point(67, 0);
			this.lblEventListOffset.Name = "lblEventListOffset";
			this.lblEventListOffset.Size = new System.Drawing.Size(347, 18);
			this.lblEventListOffset.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 18);
			this.label1.TabIndex = 10;
			this.label1.Text = "Offset";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.btnCopyText);
			this.panel2.Controls.Add(this.btnUp);
			this.panel2.Controls.Add(this.btnNOP);
			this.panel2.Controls.Add(this.btnDown);
			this.panel2.Controls.Add(this.btnCopyEvent);
			this.panel2.Controls.Add(this.btnModify);
			this.panel2.Controls.Add(this.btnPasteEvent);
			this.panel2.Controls.Add(this.btnRemove);
			this.panel2.Controls.Add(this.btnAdd);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(3, 235);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(414, 44);
			this.panel2.TabIndex = 21;
			// 
			// btnCopyText
			// 
			this.btnCopyText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyText.Enabled = false;
			this.btnCopyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopyText.Location = new System.Drawing.Point(291, 3);
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(72, 38);
			this.btnCopyText.TabIndex = 20;
			this.btnCopyText.Text = "Copy Text";
			this.btnCopyText.UseVisualStyleBackColor = true;
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyEventText_Click);
			// 
			// btnUp
			// 
			this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnUp.Enabled = false;
			this.btnUp.Location = new System.Drawing.Point(247, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(40, 18);
			this.btnUp.TabIndex = 15;
			this.btnUp.Text = "▲";
			this.btnUp.UseVisualStyleBackColor = true;
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnNOP
			// 
			this.btnNOP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNOP.Enabled = false;
			this.btnNOP.Location = new System.Drawing.Point(186, 3);
			this.btnNOP.Name = "btnNOP";
			this.btnNOP.Size = new System.Drawing.Size(58, 36);
			this.btnNOP.TabIndex = 14;
			this.btnNOP.Text = "Nop Selected";
			this.btnNOP.UseVisualStyleBackColor = true;
			this.btnNOP.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// btnDown
			// 
			this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDown.Enabled = false;
			this.btnDown.Location = new System.Drawing.Point(247, 21);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(40, 18);
			this.btnDown.TabIndex = 16;
			this.btnDown.Text = "▼";
			this.btnDown.UseVisualStyleBackColor = true;
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnCopyEvent
			// 
			this.btnCopyEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopyEvent.Enabled = false;
			this.btnCopyEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopyEvent.Location = new System.Drawing.Point(366, 3);
			this.btnCopyEvent.Name = "btnCopyEvent";
			this.btnCopyEvent.Size = new System.Drawing.Size(46, 19);
			this.btnCopyEvent.TabIndex = 19;
			this.btnCopyEvent.Text = "Copy";
			this.btnCopyEvent.UseVisualStyleBackColor = true;
			this.btnCopyEvent.Click += new System.EventHandler(this.btnCopyEvent_Click);
			// 
			// btnModify
			// 
			this.btnModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnModify.Enabled = false;
			this.btnModify.Location = new System.Drawing.Point(64, 3);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(58, 36);
			this.btnModify.TabIndex = 17;
			this.btnModify.Text = "Modify";
			this.btnModify.UseVisualStyleBackColor = true;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnPasteEvent
			// 
			this.btnPasteEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPasteEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPasteEvent.Location = new System.Drawing.Point(366, 22);
			this.btnPasteEvent.Name = "btnPasteEvent";
			this.btnPasteEvent.Size = new System.Drawing.Size(46, 19);
			this.btnPasteEvent.TabIndex = 18;
			this.btnPasteEvent.Text = "Paste";
			this.btnPasteEvent.UseVisualStyleBackColor = true;
			this.btnPasteEvent.Click += new System.EventHandler(this.btnPasteEvent_Click);
			// 
			// btnRemove
			// 
			this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnRemove.Enabled = false;
			this.btnRemove.Location = new System.Drawing.Point(125, 3);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(58, 36);
			this.btnRemove.TabIndex = 21;
			this.btnRemove.Text = "Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(58, 36);
			this.btnAdd.TabIndex = 13;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// lblEventDescription
			// 
			this.lblEventDescription.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblEventDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblEventDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lblEventDescription.Location = new System.Drawing.Point(3, 279);
			this.lblEventDescription.Name = "lblEventDescription";
			this.lblEventDescription.Size = new System.Drawing.Size(414, 54);
			this.lblEventDescription.TabIndex = 4;
			// 
			// tbctrlActionEvents
			// 
			this.tbctrlActionEvents.Controls.Add(this.tbpgSpecials);
			this.tbctrlActionEvents.Controls.Add(this.tbpgSubActionEvents);
			this.tbctrlActionEvents.Controls.Add(this.tbSubRoutines);
			this.tbctrlActionEvents.Dock = System.Windows.Forms.DockStyle.Top;
			this.tbctrlActionEvents.Location = new System.Drawing.Point(0, 41);
			this.tbctrlActionEvents.Name = "tbctrlActionEvents";
			this.tbctrlActionEvents.SelectedIndex = 0;
			this.tbctrlActionEvents.Size = new System.Drawing.Size(420, 86);
			this.tbctrlActionEvents.TabIndex = 12;
			this.tbctrlActionEvents.SelectedIndexChanged += new System.EventHandler(this.tbctrlActionEvents_SelectedIndexChanged);
			// 
			// tbpgSpecials
			// 
			this.tbpgSpecials.Controls.Add(this.cboAction);
			this.tbpgSpecials.Controls.Add(this.lblName5);
			this.tbpgSpecials.Location = new System.Drawing.Point(4, 22);
			this.tbpgSpecials.Name = "tbpgSpecials";
			this.tbpgSpecials.Padding = new System.Windows.Forms.Padding(3);
			this.tbpgSpecials.Size = new System.Drawing.Size(412, 60);
			this.tbpgSpecials.TabIndex = 1;
			this.tbpgSpecials.Text = "Specials";
			this.tbpgSpecials.UseVisualStyleBackColor = true;
			// 
			// cboAction
			// 
			this.cboAction.FormattingEnabled = true;
			this.cboAction.Location = new System.Drawing.Point(8, 30);
			this.cboAction.Name = "cboAction";
			this.cboAction.Size = new System.Drawing.Size(152, 21);
			this.cboAction.TabIndex = 12;
			this.cboAction.SelectedIndexChanged += new System.EventHandler(this.cboAction_SelectedIndexChanged);
			// 
			// lblName5
			// 
			this.lblName5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblName5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblName5.Location = new System.Drawing.Point(8, 8);
			this.lblName5.Name = "lblName5";
			this.lblName5.Size = new System.Drawing.Size(152, 21);
			this.lblName5.TabIndex = 11;
			this.lblName5.Text = "Action";
			// 
			// tbpgSubActionEvents
			// 
			this.tbpgSubActionEvents.Controls.Add(this.btnAnimationFlags);
			this.tbpgSubActionEvents.Controls.Add(this.cboEventList);
			this.tbpgSubActionEvents.Controls.Add(this.lblName1);
			this.tbpgSubActionEvents.Controls.Add(this.cboSubAction);
			this.tbpgSubActionEvents.Controls.Add(this.lblName2);
			this.tbpgSubActionEvents.Controls.Add(this.lblName3);
			this.tbpgSubActionEvents.Controls.Add(this.txtAnimationName);
			this.tbpgSubActionEvents.Controls.Add(this.txtAnimDropdown);
			this.tbpgSubActionEvents.Location = new System.Drawing.Point(4, 22);
			this.tbpgSubActionEvents.Name = "tbpgSubActionEvents";
			this.tbpgSubActionEvents.Padding = new System.Windows.Forms.Padding(3);
			this.tbpgSubActionEvents.Size = new System.Drawing.Size(412, 60);
			this.tbpgSubActionEvents.TabIndex = 0;
			this.tbpgSubActionEvents.Text = "Sub Actions";
			this.tbpgSubActionEvents.UseVisualStyleBackColor = true;
			// 
			// btnAnimationFlags
			// 
			this.btnAnimationFlags.Location = new System.Drawing.Point(128, 32);
			this.btnAnimationFlags.Name = "btnAnimationFlags";
			this.btnAnimationFlags.Size = new System.Drawing.Size(176, 22);
			this.btnAnimationFlags.TabIndex = 16;
			this.btnAnimationFlags.Text = "Animation Flags";
			this.btnAnimationFlags.UseVisualStyleBackColor = true;
			this.btnAnimationFlags.Click += new System.EventHandler(this.btnAnimationFlags_Click);
			// 
			// cboEventList
			// 
			this.cboEventList.FormattingEnabled = true;
			this.cboEventList.Items.AddRange(new object[] {
            "Main",
            "GFX",
            "SFX",
            "Other"});
			this.cboEventList.Location = new System.Drawing.Point(72, 32);
			this.cboEventList.Name = "cboEventList";
			this.cboEventList.Size = new System.Drawing.Size(48, 21);
			this.cboEventList.TabIndex = 13;
			this.cboEventList.SelectedIndexChanged += new System.EventHandler(this.cboSubAction_SelectedIndexChanged);
			// 
			// lblName1
			// 
			this.lblName1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblName1.Location = new System.Drawing.Point(8, 32);
			this.lblName1.Name = "lblName1";
			this.lblName1.Size = new System.Drawing.Size(64, 21);
			this.lblName1.TabIndex = 12;
			this.lblName1.Text = "Event List";
			this.lblName1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cboSubAction
			// 
			this.cboSubAction.FormattingEnabled = true;
			this.cboSubAction.Location = new System.Drawing.Point(72, 8);
			this.cboSubAction.Name = "cboSubAction";
			this.cboSubAction.Size = new System.Drawing.Size(48, 21);
			this.cboSubAction.TabIndex = 11;
			this.cboSubAction.SelectedIndexChanged += new System.EventHandler(this.cboSubAction_SelectedIndexChanged);
			// 
			// lblName2
			// 
			this.lblName2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblName2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblName2.Location = new System.Drawing.Point(8, 8);
			this.lblName2.Name = "lblName2";
			this.lblName2.Size = new System.Drawing.Size(64, 21);
			this.lblName2.TabIndex = 10;
			this.lblName2.Text = "Sub Action";
			this.lblName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblName3
			// 
			this.lblName3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.lblName3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lblName3.Location = new System.Drawing.Point(128, 8);
			this.lblName3.Name = "lblName3";
			this.lblName3.Size = new System.Drawing.Size(64, 20);
			this.lblName3.TabIndex = 15;
			this.lblName3.Text = "Animation";
			this.lblName3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// txtAnimationName
			// 
			this.txtAnimationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAnimationName.Location = new System.Drawing.Point(192, 8);
			this.txtAnimationName.MaxLength = 64;
			this.txtAnimationName.Name = "txtAnimationName";
			this.txtAnimationName.Size = new System.Drawing.Size(214, 20);
			this.txtAnimationName.TabIndex = 14;
			this.txtAnimationName.TextChanged += new System.EventHandler(this.txtAnimationName_TextChanged);
			// 
			// txtAnimDropdown
			// 
			this.txtAnimDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAnimDropdown.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAnimDropdown.FormattingEnabled = true;
			this.txtAnimDropdown.Location = new System.Drawing.Point(128, 7);
			this.txtAnimDropdown.Name = "txtAnimDropdown";
			this.txtAnimDropdown.Size = new System.Drawing.Size(278, 22);
			this.txtAnimDropdown.TabIndex = 17;
			this.txtAnimDropdown.Visible = false;
			this.txtAnimDropdown.SelectedIndexChanged += new System.EventHandler(this.txtAnimDropdown_SelectedIndexChanged);
			// 
			// tbSubRoutines
			// 
			this.tbSubRoutines.Controls.Add(this.btnCreateSubRoutine);
			this.tbSubRoutines.Controls.Add(this.btnGo);
			this.tbSubRoutines.Controls.Add(this.txtOffset);
			this.tbSubRoutines.Controls.Add(this.label2);
			this.tbSubRoutines.Location = new System.Drawing.Point(4, 22);
			this.tbSubRoutines.Name = "tbSubRoutines";
			this.tbSubRoutines.Size = new System.Drawing.Size(412, 60);
			this.tbSubRoutines.TabIndex = 2;
			this.tbSubRoutines.Text = "Sub Routines";
			this.tbSubRoutines.UseVisualStyleBackColor = true;
			// 
			// btnCreateSubRoutine
			// 
			this.btnCreateSubRoutine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreateSubRoutine.Location = new System.Drawing.Point(557, 8);
			this.btnCreateSubRoutine.Name = "btnCreateSubRoutine";
			this.btnCreateSubRoutine.Size = new System.Drawing.Size(72, 24);
			this.btnCreateSubRoutine.TabIndex = 17;
			this.btnCreateSubRoutine.Text = "Create New";
			this.btnCreateSubRoutine.UseVisualStyleBackColor = true;
			this.btnCreateSubRoutine.Click += new System.EventHandler(this.btnCreateSubRoutine_Click);
			// 
			// btnGo
			// 
			this.btnGo.Location = new System.Drawing.Point(112, 8);
			this.btnGo.Name = "btnGo";
			this.btnGo.Size = new System.Drawing.Size(48, 22);
			this.btnGo.TabIndex = 16;
			this.btnGo.Text = "Go";
			this.btnGo.UseVisualStyleBackColor = true;
			this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
			// 
			// txtOffset
			// 
			this.txtOffset.Location = new System.Drawing.Point(48, 8);
			this.txtOffset.MaxLength = 64;
			this.txtOffset.Name = "txtOffset";
			this.txtOffset.Size = new System.Drawing.Size(64, 20);
			this.txtOffset.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Offset";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(420, 41);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Current Object";
			// 
			// comboBox1
			// 
			this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Enabled = false;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(3, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(414, 21);
			this.comboBox1.TabIndex = 22;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// mnuStatusMenu
			// 
			this.mnuStatusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStatusMenuLabel2,
            this.mnuStatusMenuLabel});
			this.mnuStatusMenu.Location = new System.Drawing.Point(0, 489);
			this.mnuStatusMenu.Name = "mnuStatusMenu";
			this.mnuStatusMenu.Size = new System.Drawing.Size(428, 22);
			this.mnuStatusMenu.TabIndex = 23;
			this.mnuStatusMenu.Text = "statusStrip1";
			// 
			// mnuStatusMenuLabel2
			// 
			this.mnuStatusMenuLabel2.Name = "mnuStatusMenuLabel2";
			this.mnuStatusMenuLabel2.Size = new System.Drawing.Size(0, 17);
			this.mnuStatusMenuLabel2.Visible = false;
			// 
			// mnuStatusMenuLabel
			// 
			this.mnuStatusMenuLabel.Name = "mnuStatusMenuLabel";
			this.mnuStatusMenuLabel.Size = new System.Drawing.Size(0, 17);
			this.mnuStatusMenuLabel.Visible = false;
			// 
			// tbctrlMain
			// 
			this.tbctrlMain.Controls.Add(this.tbpgActions);
			this.tbctrlMain.Controls.Add(this.tbpgAttributes);
			this.tbctrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbctrlMain.Enabled = false;
			this.tbctrlMain.Location = new System.Drawing.Point(0, 0);
			this.tbctrlMain.Name = "tbctrlMain";
			this.tbctrlMain.SelectedIndex = 0;
			this.tbctrlMain.Size = new System.Drawing.Size(428, 489);
			this.tbctrlMain.TabIndex = 1;
			this.tbctrlMain.SelectedIndexChanged += new System.EventHandler(this.tbctrlMain_SelectedIndexChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexViewToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
			// 
			// hexViewToolStripMenuItem
			// 
			this.hexViewToolStripMenuItem.Name = "hexViewToolStripMenuItem";
			this.hexViewToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Project Smash Attacks";
			this.notifyIcon1.Visible = true;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFile,
            this.mnuOption,
            this.mnuOption2,
            this.mnuHelp});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOpen,
            this.mnuSep,
            this.mnuSave,
            this.mnuSaveAs,
            this.mnuSep2,
            this.mnuExit});
			this.mnuFile.Text = "File";
			// 
			// mnuOpen
			// 
			this.mnuOpen.Index = 0;
			this.mnuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
			this.mnuOpen.Text = "Open";
			this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click_1);
			// 
			// mnuSep
			// 
			this.mnuSep.Index = 1;
			this.mnuSep.Text = "-";
			// 
			// mnuSave
			// 
			this.mnuSave.Index = 2;
			this.mnuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
			this.mnuSave.Text = "Save";
			this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click_1);
			// 
			// mnuSaveAs
			// 
			this.mnuSaveAs.Index = 3;
			this.mnuSaveAs.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS;
			this.mnuSaveAs.Text = "Save As";
			this.mnuSaveAs.Click += new System.EventHandler(this.mnuSaveAs_Click_1);
			// 
			// mnuSep2
			// 
			this.mnuSep2.Index = 4;
			this.mnuSep2.Text = "-";
			// 
			// mnuExit
			// 
			this.mnuExit.Index = 5;
			this.mnuExit.Text = "Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click_1);
			// 
			// mnuOption
			// 
			this.mnuOption.Index = 1;
			this.mnuOption.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOptionAdd,
            this.mnuOptionModify,
            this.mnuOptionRemove,
            this.mnuOptionNpSel,
            this.mnuOptionSep1,
            this.mnuOptionMvUp,
            this.mnuOptionMvDwn,
            this.mnuOptionSep2,
            this.mnuOptionCopy,
            this.mnuOptionPaste,
            this.mnuOptionCpyTxt,
            this.mnuOptionSep3,
            this.mnuOptionExtras});
			this.mnuOption.Text = "Option";
			// 
			// mnuOptionHxToInt
			// 
			this.mnuOptionHxToInt.Index = 0;
			this.mnuOptionHxToInt.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOptionHxToIntSw,
            this.mnuOptionHxToIntBth});
			this.mnuOptionHxToInt.Text = "Switch Hex to Int Options";
			this.mnuOptionHxToInt.Click += new System.EventHandler(this.mnuOptionHxToInt_Click);
			// 
			// mnuOptionHxToIntSw
			// 
			this.mnuOptionHxToIntSw.Index = 0;
			this.mnuOptionHxToIntSw.Text = "Switch Hex to Int";
			this.mnuOptionHxToIntSw.Click += new System.EventHandler(this.mnuOptionHxToIntSw_Click);
			// 
			// mnuOptionHxToIntBth
			// 
			this.mnuOptionHxToIntBth.Index = 1;
			this.mnuOptionHxToIntBth.Text = "Include both Hex and Int";
			this.mnuOptionHxToIntBth.Click += new System.EventHandler(this.mnuOptionHxToIntBth_Click);
			// 
			// mnuOptionLstBxTxt
			// 
			this.mnuOptionLstBxTxt.Index = 1;
			this.mnuOptionLstBxTxt.Text = "Switch from ListBox to Text";
			this.mnuOptionLstBxTxt.Visible = false;
			this.mnuOptionLstBxTxt.Click += new System.EventHandler(this.mnuOptionLstBxTxt_Click);
			this.mnuOptionLstBxTxt.Select += new System.EventHandler(this.mnuOptionLstBxTxt_Select);
			// 
			// mnuOptionSep1
			// 
			this.mnuOptionSep1.Index = 4;
			this.mnuOptionSep1.Text = "-";
			// 
			// mnuOptionAdd
			// 
			this.mnuOptionAdd.Index = 0;
			this.mnuOptionAdd.Shortcut = System.Windows.Forms.Shortcut.CtrlN;
			this.mnuOptionAdd.Text = "Add";
			this.mnuOptionAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// mnuOptionModify
			// 
			this.mnuOptionModify.Enabled = false;
			this.mnuOptionModify.Index = 1;
			this.mnuOptionModify.Shortcut = System.Windows.Forms.Shortcut.CtrlB;
			this.mnuOptionModify.Text = "Modify";
			this.mnuOptionModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// mnuOptionRemove
			// 
			this.mnuOptionRemove.Enabled = false;
			this.mnuOptionRemove.Index = 2;
			this.mnuOptionRemove.Shortcut = System.Windows.Forms.Shortcut.CtrlDel;
			this.mnuOptionRemove.Text = "Remove";
			this.mnuOptionRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
			// 
			// mnuOptionNpSel
			// 
			this.mnuOptionNpSel.Enabled = false;
			this.mnuOptionNpSel.Index = 3;
			this.mnuOptionNpSel.Shortcut = System.Windows.Forms.Shortcut.Del;
			this.mnuOptionNpSel.Text = "Nop Selected";
			this.mnuOptionNpSel.Click += new System.EventHandler(this.btnRemove_Click);
			// 
			// mnuOptionSep2
			// 
			this.mnuOptionSep2.Index = 7;
			this.mnuOptionSep2.Text = "-";
			// 
			// mnuOptionMvUp
			// 
			this.mnuOptionMvUp.Enabled = false;
			this.mnuOptionMvUp.Index = 5;
			this.mnuOptionMvUp.Shortcut = System.Windows.Forms.Shortcut.AltUpArrow;
			this.mnuOptionMvUp.Text = "Move ▲";
			this.mnuOptionMvUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// mnuOptionMvDwn
			// 
			this.mnuOptionMvDwn.Enabled = false;
			this.mnuOptionMvDwn.Index = 6;
			this.mnuOptionMvDwn.Shortcut = System.Windows.Forms.Shortcut.AltDownArrow;
			this.mnuOptionMvDwn.Text = "Move ▼";
			this.mnuOptionMvDwn.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// mnuOptionSep3
			// 
			this.mnuOptionSep3.Index = 11;
			this.mnuOptionSep3.Text = "-";
			// 
			// mnuOptionCopy
			// 
			this.mnuOptionCopy.Enabled = false;
			this.mnuOptionCopy.Index = 8;
			this.mnuOptionCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
			this.mnuOptionCopy.Text = "Copy";
			this.mnuOptionCopy.Click += new System.EventHandler(this.btnCopyEvent_Click);
			// 
			// mnuOptionPaste
			// 
			this.mnuOptionPaste.Index = 9;
			this.mnuOptionPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
			this.mnuOptionPaste.Text = "Paste";
			this.mnuOptionPaste.Click += new System.EventHandler(this.btnPasteEvent_Click);
			// 
			// mnuOptionCpyTxt
			// 
			this.mnuOptionCpyTxt.Enabled = false;
			this.mnuOptionCpyTxt.Index = 10;
			this.mnuOptionCpyTxt.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftC;
			this.mnuOptionCpyTxt.Text = "Copy Text";
			this.mnuOptionCpyTxt.Click += new System.EventHandler(this.btnCopyEventText_Click);
			// 
			// mnuOption2Sep
			// 
			this.mnuOption2Sep.Index = 2;
			this.mnuOption2Sep.Text = "-";
			// 
			// mnuOptionExtras
			// 
			this.mnuOptionExtras.Index = 12;
			this.mnuOptionExtras.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOptionExtrasCU,
            this.mnuOptionExtrasCD});
			this.mnuOptionExtras.Text = "Extra Option";
			// 
			// mnuOptionExtrasCU
			// 
			this.mnuOptionExtrasCU.Enabled = false;
			this.mnuOptionExtrasCU.Index = 0;
			this.mnuOptionExtrasCU.Shortcut = System.Windows.Forms.Shortcut.AltLeftArrow;
			this.mnuOptionExtrasCU.Text = "Change Sub-Action ▲";
			this.mnuOptionExtrasCU.Click += new System.EventHandler(this.mnuOptionExtrasCU_Click);
			// 
			// mnuOptionExtrasCD
			// 
			this.mnuOptionExtrasCD.Enabled = false;
			this.mnuOptionExtrasCD.Index = 1;
			this.mnuOptionExtrasCD.Shortcut = System.Windows.Forms.Shortcut.AltRightArrow;
			this.mnuOptionExtrasCD.Text = "Change Sub-Action ▼";
			this.mnuOptionExtrasCD.Click += new System.EventHandler(this.mnuOptionExtrasCD_Click);
			// 
			// mnuOptionExtrasAName
			// 
			this.mnuOptionExtrasAName.Index = 3;
			this.mnuOptionExtrasAName.Text = "Replace Anim Name with Sub-Actions";
			this.mnuOptionExtrasAName.Click += new System.EventHandler(this.mnuOptionExtrasAName_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.Index = 3;
			this.mnuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuAbout});
			this.mnuHelp.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Index = 0;
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click_1);
			// 
			// mnuStatusMenuLabel2Tmr
			// 
			this.mnuStatusMenuLabel2Tmr.Interval = 1;
			this.mnuStatusMenuLabel2Tmr.Tick += new System.EventHandler(this.mnuStatusMenuLabel2Tmr_Tick);
			// 
			// mnuFilePathObtained
			// 
			this.mnuFilePathObtained.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mnuFilePathObtained.Location = new System.Drawing.Point(342, 0);
			this.mnuFilePathObtained.Name = "mnuFilePathObtained";
			this.mnuFilePathObtained.Size = new System.Drawing.Size(85, 22);
			this.mnuFilePathObtained.TabIndex = 24;
			this.mnuFilePathObtained.Text = "File Info";
			this.mnuFilePathObtained.UseVisualStyleBackColor = true;
			this.mnuFilePathObtained.Click += new System.EventHandler(this.button1_Click);
			// 
			// mnuOption2
			// 
			this.mnuOption2.Index = 2;
			this.mnuOption2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuOptionHxToInt,
            this.mnuOptionLstBxTxt,
            this.mnuOption2Sep,
            this.mnuOptionExtrasAName});
			this.mnuOption2.Text = "Option 2";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 511);
			this.Controls.Add(this.mnuFilePathObtained);
			this.Controls.Add(this.tbctrlMain);
			this.Controls.Add(this.mnuStatusMenu);
			this.Menu = this.mainMenu1;
			this.MinimumSize = new System.Drawing.Size(385, 538);
			this.Name = "FormMain";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Smash Attacks!";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.tbpgAttributes.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtgrdAttributes)).EndInit();
			this.AttributeContextMenu.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.tbpgActions.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tbctrlActionEvents.ResumeLayout(false);
			this.tbpgSpecials.ResumeLayout(false);
			this.tbpgSubActionEvents.ResumeLayout(false);
			this.tbpgSubActionEvents.PerformLayout();
			this.tbSubRoutines.ResumeLayout(false);
			this.tbSubRoutines.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.mnuStatusMenu.ResumeLayout(false);
			this.mnuStatusMenu.PerformLayout();
			this.tbctrlMain.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog opnDlg;
        private System.Windows.Forms.SaveFileDialog saveDlg;
        private System.Windows.Forms.TabPage tbpgAttributes;
        private System.Windows.Forms.DataGridView dtgrdAttributes;
        private System.Windows.Forms.Label lblAttributeDescription;
        private System.Windows.Forms.TabPage tbpgActions;
        private System.Windows.Forms.Button btnCopyEvent;
        private System.Windows.Forms.Button btnPasteEvent;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnNOP;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabControl tbctrlActionEvents;
        private System.Windows.Forms.TabPage tbpgSpecials;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.Label lblName5;
        private System.Windows.Forms.TabPage tbpgSubActionEvents;
        private System.Windows.Forms.Button btnAnimationFlags;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.TextBox txtAnimationName;
        private System.Windows.Forms.ComboBox cboEventList;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.ComboBox cboSubAction;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TabPage tbSubRoutines;
        private System.Windows.Forms.Button btnCreateSubRoutine;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.TabControl tbctrlMain;
        private System.Windows.Forms.ContextMenuStrip AttributeContextMenu;
        private System.Windows.Forms.ToolStripMenuItem showAsFloatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAsIntToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hexViewToolStripMenuItem;
        private System.Windows.Forms.Button btnCopyText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblEventListOffset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem mnuFile;
        private System.Windows.Forms.MenuItem mnuOpen;
        private System.Windows.Forms.MenuItem mnuSep;
        private System.Windows.Forms.MenuItem mnuSave;
        private System.Windows.Forms.MenuItem mnuSaveAs;
        private System.Windows.Forms.MenuItem mnuSep2;
        private System.Windows.Forms.MenuItem mnuExit;
        private System.Windows.Forms.MenuItem mnuHelp;
        private System.Windows.Forms.MenuItem mnuAbout;
        private System.Windows.Forms.MenuItem mnuOption;
        private System.Windows.Forms.MenuItem mnuOptionHxToInt;
        private System.Windows.Forms.StatusStrip mnuStatusMenu;
        private System.Windows.Forms.ToolStripStatusLabel mnuStatusMenuLabel;
        private System.Windows.Forms.Timer mnuStatusMenuLabel2Tmr;
        private System.Windows.Forms.ToolStripStatusLabel mnuStatusMenuLabel2;
        private System.Windows.Forms.Button mnuFilePathObtained;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.MenuItem mnuOptionSep1;
        private System.Windows.Forms.MenuItem mnuOptionAdd;
        private System.Windows.Forms.MenuItem mnuOptionModify;
        private System.Windows.Forms.MenuItem mnuOptionRemove;
        private System.Windows.Forms.MenuItem mnuOptionNpSel;
        private System.Windows.Forms.MenuItem mnuOptionSep2;
        private System.Windows.Forms.MenuItem mnuOptionMvUp;
        private System.Windows.Forms.MenuItem mnuOptionMvDwn;
        private System.Windows.Forms.MenuItem mnuOptionSep3;
        private System.Windows.Forms.MenuItem mnuOptionCopy;
        private System.Windows.Forms.MenuItem mnuOptionPaste;
        private System.Windows.Forms.MenuItem mnuOptionCpyTxt;
        private System.Windows.Forms.MenuItem mnuOption2Sep;
        private System.Windows.Forms.MenuItem mnuOptionExtras;
        private System.Windows.Forms.MenuItem mnuOptionExtrasCU;
        private System.Windows.Forms.MenuItem mnuOptionExtrasCD;
        private System.Windows.Forms.MenuItem mnuOptionLstBxTxt;
        private System.Windows.Forms.RichTextBox lstEventsTxt;
        private System.Windows.Forms.MenuItem mnuOptionHxToIntSw;
        private System.Windows.Forms.MenuItem mnuOptionHxToIntBth;
        private System.Windows.Forms.MenuItem mnuOptionExtrasAName;
        private System.Windows.Forms.ComboBox txtAnimDropdown;
		private System.Windows.Forms.MenuItem mnuOption2;
	}
}

