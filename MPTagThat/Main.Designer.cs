using System.Windows.Forms;

namespace MPTagThat
{
  partial class Main
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
      Elegant.Ui.ThemeSelector themeSelector;
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.panelBottom = new System.Windows.Forms.Panel();
      this.playerPanel = new MPTagThat.Core.WinControls.MPTPanel();
      this.panelMiddle = new MPTagThat.Core.WinControls.MPTPanel();
      this.panelMiddleTop = new MPTagThat.Core.WinControls.MPTPanel();
      this.panelFileList = new MPTagThat.Core.WinControls.MPTPanel();
      this.splitterTop = new NJFLib.Controls.CollapsibleSplitter();
      this.panelMiddleDBSearch = new MPTagThat.Core.WinControls.MPTPanel();
      this.splitterLeft = new MPTagThat.Core.WinControls.MPTCollapsibleSplitter();
      this.panelLeft = new MPTagThat.Core.WinControls.MPTPanel();
      this.panelLeftTop = new MPTagThat.Core.WinControls.MPTPanel();
      this.splitterRight = new MPTagThat.Core.WinControls.MPTCollapsibleSplitter();
      this.panelRight = new MPTagThat.Core.WinControls.MPTPanel();
      this.splitterBottom = new MPTagThat.Core.WinControls.MPTCollapsibleSplitter();
      this.panelMiddleBottom = new MPTagThat.Core.WinControls.MPTPanel();
      this.splitterPlayer = new NJFLib.Controls.CollapsibleSplitter();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.formFrameSkinner = new Elegant.Ui.FormFrameSkinner();
      this.statusBar = new Elegant.Ui.StatusBar();
      this.statusBarNotificationsArea1 = new Elegant.Ui.StatusBarNotificationsArea();
      this.statusBarPane2 = new Elegant.Ui.StatusBarPane();
      this.toolStripStatusLabelFiles = new Elegant.Ui.Label();
      this.toolStripStatusLabelFilter = new Elegant.Ui.Label();
      this.statusBarPane3 = new Elegant.Ui.StatusBarPane();
      this.toolStripStatusLabelFolder = new Elegant.Ui.Label();
      this.statusBarControlsArea1 = new Elegant.Ui.StatusBarControlsArea();
      this.statusBarPane4 = new Elegant.Ui.StatusBarPane();
      this.toolStripStatusLabelScanProgress = new Elegant.Ui.Label();
      this.statusBarPane1 = new Elegant.Ui.StatusBarPane();
      this.progressBar1 = new Elegant.Ui.ProgressBar();
      this.buttonProgressCancel = new Elegant.Ui.Button();
      this.ribbon = new Elegant.Ui.Ribbon();
      this.startMenuSave = new Elegant.Ui.Button();
      this.startMenuRefresh = new Elegant.Ui.Button();
      this.backstageView = new Elegant.Ui.BackstageView();
      this.backstageViewPageOptions = new Elegant.Ui.BackstageViewPage();
      this.panel2 = new Elegant.Ui.Panel();
      this.backstageViewPanel1 = new Elegant.Ui.BackstageViewPanel();
      this.backstageViewButtonSave = new Elegant.Ui.BackstageViewButton();
      this.backstageViewButtonRefresh = new Elegant.Ui.BackstageViewButton();
      this.backstageViewPageRecentFolders = new Elegant.Ui.BackstageViewPage();
      this.panel1 = new Elegant.Ui.Panel();
      this.separatorRecentFolders = new Elegant.Ui.Separator();
      this.pinListRecentFolders = new Elegant.Ui.PinList();
      this.backstageViewSeparator1 = new Elegant.Ui.BackstageViewSeparator();
      this.backstageViewButtonChangeColumns = new Elegant.Ui.BackstageViewButton();
      this.backstageViewSeparator2 = new Elegant.Ui.BackstageViewSeparator();
      this.backstageViewButtonExit = new Elegant.Ui.BackstageViewButton();
      this.ribbonTabPageTag = new Elegant.Ui.RibbonTabPage();
      this.ribbonGroupTagsRetrieve = new Elegant.Ui.RibbonGroup();
      this.buttonTagFromFile = new Elegant.Ui.Button();
      this.buttonTagIdentifyFiles = new Elegant.Ui.Button();
      this.buttonTagFromInternet = new Elegant.Ui.Button();
      this.ribbonGroupTagsEdit = new Elegant.Ui.RibbonGroup();
      this.buttonCaseConversion = new Elegant.Ui.SplitButton();
      this.popupMenu3 = new Elegant.Ui.PopupMenu(this.components);
      this.buttonCaseConversionOptions = new Elegant.Ui.Button();
      this.separator2 = new Elegant.Ui.Separator();
      this.buttonDeleteTag = new Elegant.Ui.SplitButton();
      this.popupMenu2 = new Elegant.Ui.PopupMenu(this.components);
      this.buttonDeleteAllTags = new Elegant.Ui.Button();
      this.buttonDeleteID3v1 = new Elegant.Ui.Button();
      this.buttonDeleteID3v2 = new Elegant.Ui.Button();
      this.buttonGetLyrics = new Elegant.Ui.Button();
      this.buttonRemoveComment = new Elegant.Ui.Button();
      this.separator3 = new Elegant.Ui.Separator();
      this.buttonGroup1 = new Elegant.Ui.ButtonGroup();
      this.comboBoxScripts = new Elegant.Ui.ComboBox();
      this.buttonScriptExecute = new Elegant.Ui.Button();
      this.buttonGroup3 = new Elegant.Ui.ButtonGroup();
      this.buttonNumberOnClick = new Elegant.Ui.ToggleButton();
      this.buttonAutoNumber = new Elegant.Ui.Button();
      this.textBoxNumber = new Elegant.Ui.TextBox();
      this.ribbonGroupPicture = new Elegant.Ui.RibbonGroup();
      this.galleryPicture = new Elegant.Ui.Gallery();
      this.buttonGetCoverArt = new Elegant.Ui.Button();
      this.buttonRemoveCoverArt = new Elegant.Ui.Button();
      this.buttonSaveAsThumb = new Elegant.Ui.Button();
      this.ribbonGroupOrganise = new Elegant.Ui.RibbonGroup();
      this.buttonRenameFiles = new Elegant.Ui.SplitButton();
      this.popupMenu1 = new Elegant.Ui.PopupMenu(this.components);
      this.buttonRenameFilesOptions = new Elegant.Ui.Button();
      this.buttonOrganiseFiles = new Elegant.Ui.Button();
      this.ribbonGroupOther = new Elegant.Ui.RibbonGroup();
      this.buttonAddToBurner = new Elegant.Ui.Button();
      this.buttonAddToConversion = new Elegant.Ui.Button();
      this.buttonAddToPlaylist = new Elegant.Ui.Button();
      this.ribbonTabPageRip = new Elegant.Ui.RibbonTabPage();
      this.ribbonGroupRip = new Elegant.Ui.RibbonGroup();
      this.buttonRipStart = new Elegant.Ui.Button();
      this.buttonRipCancel = new Elegant.Ui.Button();
      this.ribbonGroupRipOptions = new Elegant.Ui.RibbonGroup();
      this.textBoxRipOutputFolder = new Elegant.Ui.TextBox();
      this.comboBoxRipEncoder = new Elegant.Ui.ComboBox();
      this.buttonRipFolderSelect = new Elegant.Ui.Button();
      this.ribbonTabPageConvert = new Elegant.Ui.RibbonTabPage();
      this.ribbonGroupConvert = new Elegant.Ui.RibbonGroup();
      this.buttonConvertStart = new Elegant.Ui.Button();
      this.buttonConvertCancel = new Elegant.Ui.Button();
      this.ribbonGroupConvertOptions = new Elegant.Ui.RibbonGroup();
      this.textBoxConvertOutputFolder = new Elegant.Ui.TextBox();
      this.comboBoxConvertEncoder = new Elegant.Ui.ComboBox();
      this.buttonConvertFolderSelect = new Elegant.Ui.Button();
      this.ribbonTabPageBurn = new Elegant.Ui.RibbonTabPage();
      this.ribbonGroupBurn = new Elegant.Ui.RibbonGroup();
      this.buttonBurnStart = new Elegant.Ui.Button();
      this.buttonBurnCancel = new Elegant.Ui.Button();
      this.ribbonGroupBurnOptions = new Elegant.Ui.RibbonGroup();
      this.comboBoxBurner = new Elegant.Ui.ComboBox();
      this.comboBoxBurnerSpeed = new Elegant.Ui.ComboBox();
      themeSelector = new Elegant.Ui.ThemeSelector(this.components);
      this.panelBottom.SuspendLayout();
      this.panelMiddle.SuspendLayout();
      this.panelMiddleTop.SuspendLayout();
      this.panelLeft.SuspendLayout();
      this.statusBar.SuspendLayout();
      this.statusBarNotificationsArea1.SuspendLayout();
      this.statusBarPane2.SuspendLayout();
      this.statusBarPane3.SuspendLayout();
      this.statusBarControlsArea1.SuspendLayout();
      this.statusBarPane4.SuspendLayout();
      this.statusBarPane1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstageView)).BeginInit();
      this.backstageViewPageOptions.SuspendLayout();
      this.backstageViewPageRecentFolders.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pinListRecentFolders)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageTag)).BeginInit();
      this.ribbonTabPageTag.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupTagsRetrieve)).BeginInit();
      this.ribbonGroupTagsRetrieve.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupTagsEdit)).BeginInit();
      this.ribbonGroupTagsEdit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).BeginInit();
      this.buttonGroup1.SuspendLayout();
      this.buttonGroup3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupPicture)).BeginInit();
      this.ribbonGroupPicture.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.galleryPicture)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupOrganise)).BeginInit();
      this.ribbonGroupOrganise.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupOther)).BeginInit();
      this.ribbonGroupOther.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageRip)).BeginInit();
      this.ribbonTabPageRip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupRip)).BeginInit();
      this.ribbonGroupRip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupRipOptions)).BeginInit();
      this.ribbonGroupRipOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageConvert)).BeginInit();
      this.ribbonTabPageConvert.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupConvert)).BeginInit();
      this.ribbonGroupConvert.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupConvertOptions)).BeginInit();
      this.ribbonGroupConvertOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageBurn)).BeginInit();
      this.ribbonTabPageBurn.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupBurn)).BeginInit();
      this.ribbonGroupBurn.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupBurnOptions)).BeginInit();
      this.ribbonGroupBurnOptions.SuspendLayout();
      this.SuspendLayout();
      // 
      // panelBottom
      // 
      this.panelBottom.Controls.Add(this.playerPanel);
      this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelBottom.Location = new System.Drawing.Point(0, 999);
      this.panelBottom.Name = "panelBottom";
      this.panelBottom.Size = new System.Drawing.Size(1008, 90);
      this.panelBottom.TabIndex = 12;
      // 
      // playerPanel
      // 
      this.playerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.playerPanel.Location = new System.Drawing.Point(0, 0);
      this.playerPanel.Name = "playerPanel";
      this.playerPanel.Size = new System.Drawing.Size(1008, 90);
      this.playerPanel.TabIndex = 11;
      // 
      // panelMiddle
      // 
      this.panelMiddle.Controls.Add(this.panelMiddleTop);
      this.panelMiddle.Controls.Add(this.splitterLeft);
      this.panelMiddle.Controls.Add(this.splitterRight);
      this.panelMiddle.Controls.Add(this.splitterBottom);
      this.panelMiddle.Controls.Add(this.panelMiddleBottom);
      this.panelMiddle.Controls.Add(this.panelLeft);
      this.panelMiddle.Controls.Add(this.panelRight);
      this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMiddle.Location = new System.Drawing.Point(0, 153);
      this.panelMiddle.Name = "panelMiddle";
      this.panelMiddle.Size = new System.Drawing.Size(1008, 843);
      this.panelMiddle.TabIndex = 10;
      // 
      // panelMiddleTop
      // 
      this.panelMiddleTop.Controls.Add(this.panelFileList);
      this.panelMiddleTop.Controls.Add(this.splitterTop);
      this.panelMiddleTop.Controls.Add(this.panelMiddleDBSearch);
      this.panelMiddleTop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelMiddleTop.Location = new System.Drawing.Point(158, 0);
      this.panelMiddleTop.Name = "panelMiddleTop";
      this.panelMiddleTop.Size = new System.Drawing.Size(676, 571);
      this.panelMiddleTop.TabIndex = 11;
      // 
      // panelFileList
      // 
      this.panelFileList.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelFileList.Location = new System.Drawing.Point(0, 88);
      this.panelFileList.Name = "panelFileList";
      this.panelFileList.Size = new System.Drawing.Size(676, 483);
      this.panelFileList.TabIndex = 9;
      // 
      // splitterTop
      // 
      this.splitterTop.AnimationDelay = 20;
      this.splitterTop.AnimationStep = 20;
      this.splitterTop.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
      this.splitterTop.ControlToHide = this.panelMiddleDBSearch;
      this.splitterTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.splitterTop.ExpandParentForm = false;
      this.splitterTop.Location = new System.Drawing.Point(0, 80);
      this.splitterTop.Name = "splitterTop";
      this.splitterTop.TabIndex = 11;
      this.splitterTop.TabStop = false;
      this.splitterTop.UseAnimations = true;
      this.splitterTop.VisualStyle = NJFLib.Controls.VisualStyles.XP;
      // 
      // panelMiddleDBSearch
      // 
      this.panelMiddleDBSearch.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelMiddleDBSearch.Location = new System.Drawing.Point(0, 0);
      this.panelMiddleDBSearch.Name = "panelMiddleDBSearch";
      this.panelMiddleDBSearch.Size = new System.Drawing.Size(676, 80);
      this.panelMiddleDBSearch.TabIndex = 10;
      // 
      // splitterLeft
      // 
      this.splitterLeft.AnimationDelay = 20;
      this.splitterLeft.AnimationStep = 20;
      this.splitterLeft.BackColor = System.Drawing.SystemColors.Control;
      this.splitterLeft.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
      this.splitterLeft.ControlToHide = this.panelLeft;
      this.splitterLeft.ExpandParentForm = false;
      this.splitterLeft.Localisation = "splitterLeft";
      this.splitterLeft.LocalisationContext = "Main";
      this.splitterLeft.Location = new System.Drawing.Point(150, 0);
      this.splitterLeft.Name = "splitterLeft";
      this.splitterLeft.TabIndex = 2;
      this.splitterLeft.TabStop = false;
      this.splitterLeft.UseAnimations = false;
      this.splitterLeft.VisualStyle = NJFLib.Controls.VisualStyles.XP;
      // 
      // panelLeft
      // 
      this.panelLeft.Controls.Add(this.panelLeftTop);
      this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.panelLeft.Location = new System.Drawing.Point(0, 0);
      this.panelLeft.Name = "panelLeft";
      this.panelLeft.Size = new System.Drawing.Size(150, 843);
      this.panelLeft.TabIndex = 1;
      // 
      // panelLeftTop
      // 
      this.panelLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelLeftTop.Location = new System.Drawing.Point(0, 0);
      this.panelLeftTop.Name = "panelLeftTop";
      this.panelLeftTop.Size = new System.Drawing.Size(150, 843);
      this.panelLeftTop.TabIndex = 4;
      // 
      // splitterRight
      // 
      this.splitterRight.AnimationDelay = 20;
      this.splitterRight.AnimationStep = 20;
      this.splitterRight.BackColor = System.Drawing.SystemColors.Control;
      this.splitterRight.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
      this.splitterRight.ControlToHide = this.panelRight;
      this.splitterRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.splitterRight.ExpandParentForm = false;
      this.splitterRight.Localisation = "splitterRight";
      this.splitterRight.LocalisationContext = "Main";
      this.splitterRight.Location = new System.Drawing.Point(834, 0);
      this.splitterRight.Name = "splitterRight";
      this.splitterRight.TabIndex = 4;
      this.splitterRight.TabStop = false;
      this.splitterRight.UseAnimations = false;
      this.splitterRight.VisualStyle = NJFLib.Controls.VisualStyles.XP;
      this.splitterRight.Click += new System.EventHandler(this.splitterRight_Click);
      // 
      // panelRight
      // 
      this.panelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.panelRight.BackColor = System.Drawing.SystemColors.Control;
      this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.panelRight.Location = new System.Drawing.Point(842, 0);
      this.panelRight.Name = "panelRight";
      this.panelRight.Size = new System.Drawing.Size(166, 843);
      this.panelRight.TabIndex = 3;
      // 
      // splitterBottom
      // 
      this.splitterBottom.AnimationDelay = 20;
      this.splitterBottom.AnimationStep = 20;
      this.splitterBottom.BorderStyle3D = System.Windows.Forms.Border3DStyle.Flat;
      this.splitterBottom.ControlToHide = this.panelMiddleBottom;
      this.splitterBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitterBottom.ExpandParentForm = false;
      this.splitterBottom.Localisation = "collapsibleSplitter1";
      this.splitterBottom.LocalisationContext = "Main";
      this.splitterBottom.Location = new System.Drawing.Point(150, 571);
      this.splitterBottom.Name = "collapsibleSplitter1";
      this.splitterBottom.TabIndex = 6;
      this.splitterBottom.TabStop = false;
      this.splitterBottom.UseAnimations = false;
      this.splitterBottom.VisualStyle = NJFLib.Controls.VisualStyles.XP;
      this.splitterBottom.Click += new System.EventHandler(this.splitterBottom_Click);
      // 
      // panelMiddleBottom
      // 
      this.panelMiddleBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panelMiddleBottom.Location = new System.Drawing.Point(150, 579);
      this.panelMiddleBottom.Name = "panelMiddleBottom";
      this.panelMiddleBottom.Size = new System.Drawing.Size(692, 264);
      this.panelMiddleBottom.TabIndex = 12;
      // 
      // splitterPlayer
      // 
      this.splitterPlayer.AnimationDelay = 1;
      this.splitterPlayer.AnimationStep = 50;
      this.splitterPlayer.BorderStyle3D = System.Windows.Forms.Border3DStyle.RaisedOuter;
      this.splitterPlayer.ControlToHide = this.panelBottom;
      this.splitterPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.splitterPlayer.ExpandParentForm = false;
      this.splitterPlayer.Location = new System.Drawing.Point(0, 996);
      this.splitterPlayer.Name = "splitterPlayer";
      this.splitterPlayer.TabIndex = 13;
      this.splitterPlayer.TabStop = false;
      this.splitterPlayer.UseAnimations = true;
      this.splitterPlayer.VisualStyle = NJFLib.Controls.VisualStyles.XP;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.HeaderText = "File";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.Width = 300;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.HeaderText = "Message";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // formFrameSkinner
      // 
      this.formFrameSkinner.Form = this;
      this.formFrameSkinner.TitleFont = new System.Drawing.Font("Tahoma", 9F);
      // 
      // statusBar
      // 
      this.statusBar.Controls.Add(this.statusBarNotificationsArea1);
      this.statusBar.Controls.Add(this.statusBarControlsArea1);
      this.statusBar.ControlsArea = this.statusBarControlsArea1;
      this.statusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.statusBar.Location = new System.Drawing.Point(0, 1089);
      this.statusBar.Name = "statusBar";
      this.statusBar.NotificationsArea = this.statusBarNotificationsArea1;
      this.statusBar.Size = new System.Drawing.Size(1008, 22);
      this.statusBar.TabIndex = 16;
      this.statusBar.Text = "statusBar1";
      // 
      // statusBarNotificationsArea1
      // 
      this.statusBarNotificationsArea1.Controls.Add(this.statusBarPane2);
      this.statusBarNotificationsArea1.Controls.Add(this.statusBarPane3);
      this.statusBarNotificationsArea1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.statusBarNotificationsArea1.Location = new System.Drawing.Point(0, 0);
      this.statusBarNotificationsArea1.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarNotificationsArea1.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarNotificationsArea1.Name = "statusBarNotificationsArea1";
      this.statusBarNotificationsArea1.Size = new System.Drawing.Size(689, 22);
      this.statusBarNotificationsArea1.TabIndex = 1;
      // 
      // statusBarPane2
      // 
      this.statusBarPane2.Controls.Add(this.toolStripStatusLabelFiles);
      this.statusBarPane2.Controls.Add(this.toolStripStatusLabelFilter);
      this.statusBarPane2.Location = new System.Drawing.Point(0, 0);
      this.statusBarPane2.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane2.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane2.Name = "statusBarPane2";
      this.statusBarPane2.Size = new System.Drawing.Size(149, 22);
      this.statusBarPane2.TabIndex = 0;
      // 
      // toolStripStatusLabelFiles
      // 
      this.toolStripStatusLabelFiles.Location = new System.Drawing.Point(5, 5);
      this.toolStripStatusLabelFiles.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.toolStripStatusLabelFiles.Name = "toolStripStatusLabelFiles";
      this.toolStripStatusLabelFiles.Size = new System.Drawing.Size(57, 13);
      this.toolStripStatusLabelFiles.TabIndex = 0;
      this.toolStripStatusLabelFiles.Text = "                   ";
      // 
      // toolStripStatusLabelFilter
      // 
      this.toolStripStatusLabelFilter.Location = new System.Drawing.Point(68, 5);
      this.toolStripStatusLabelFilter.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.toolStripStatusLabelFilter.Name = "toolStripStatusLabelFilter";
      this.toolStripStatusLabelFilter.Size = new System.Drawing.Size(48, 13);
      this.toolStripStatusLabelFilter.TabIndex = 1;
      this.toolStripStatusLabelFilter.Text = "                ";
      // 
      // statusBarPane3
      // 
      this.statusBarPane3.Controls.Add(this.toolStripStatusLabelFolder);
      this.statusBarPane3.Location = new System.Drawing.Point(149, 0);
      this.statusBarPane3.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane3.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane3.Name = "statusBarPane3";
      this.statusBarPane3.Padding = new System.Windows.Forms.Padding(10, 2, 2, 1);
      this.statusBarPane3.Size = new System.Drawing.Size(117, 22);
      this.statusBarPane3.TabIndex = 1;
      // 
      // toolStripStatusLabelFolder
      // 
      this.toolStripStatusLabelFolder.Location = new System.Drawing.Point(13, 5);
      this.toolStripStatusLabelFolder.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.toolStripStatusLabelFolder.Name = "toolStripStatusLabelFolder";
      this.toolStripStatusLabelFolder.Size = new System.Drawing.Size(63, 13);
      this.toolStripStatusLabelFolder.TabIndex = 0;
      this.toolStripStatusLabelFolder.Text = "                     ";
      // 
      // statusBarControlsArea1
      // 
      this.statusBarControlsArea1.Controls.Add(this.statusBarPane4);
      this.statusBarControlsArea1.Controls.Add(this.statusBarPane1);
      this.statusBarControlsArea1.Dock = System.Windows.Forms.DockStyle.Right;
      this.statusBarControlsArea1.Location = new System.Drawing.Point(689, 0);
      this.statusBarControlsArea1.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarControlsArea1.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarControlsArea1.Name = "statusBarControlsArea1";
      this.statusBarControlsArea1.Size = new System.Drawing.Size(319, 22);
      this.statusBarControlsArea1.TabIndex = 0;
      // 
      // statusBarPane4
      // 
      this.statusBarPane4.Controls.Add(this.toolStripStatusLabelScanProgress);
      this.statusBarPane4.Dock = System.Windows.Forms.DockStyle.Right;
      this.statusBarPane4.Location = new System.Drawing.Point(0, 0);
      this.statusBarPane4.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane4.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane4.Name = "statusBarPane4";
      this.statusBarPane4.Size = new System.Drawing.Size(34, 22);
      this.statusBarPane4.TabIndex = 2;
      // 
      // toolStripStatusLabelScanProgress
      // 
      this.toolStripStatusLabelScanProgress.Location = new System.Drawing.Point(5, 11);
      this.toolStripStatusLabelScanProgress.Name = "toolStripStatusLabelScanProgress";
      this.toolStripStatusLabelScanProgress.Size = new System.Drawing.Size(0, 0);
      this.toolStripStatusLabelScanProgress.TabIndex = 0;
      // 
      // statusBarPane1
      // 
      this.statusBarPane1.Controls.Add(this.progressBar1);
      this.statusBarPane1.Controls.Add(this.buttonProgressCancel);
      this.statusBarPane1.Location = new System.Drawing.Point(34, 0);
      this.statusBarPane1.MaximumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane1.MinimumSize = new System.Drawing.Size(0, 22);
      this.statusBarPane1.Name = "statusBarPane1";
      this.statusBarPane1.Size = new System.Drawing.Size(233, 22);
      this.statusBarPane1.TabIndex = 0;
      // 
      // progressBar1
      // 
      this.progressBar1.DesiredWidth = 175;
      this.progressBar1.Id = "a3fc702d-0b4f-4160-9fff-0baba8d7430e";
      this.progressBar1.Location = new System.Drawing.Point(3, 5);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(175, 12);
      this.progressBar1.TabIndex = 0;
      this.progressBar1.Text = "progressBar1";
      // 
      // buttonProgressCancel
      // 
      this.buttonProgressCancel.AutoSize = true;
      this.buttonProgressCancel.CommandName = "ProgressCancel";
      this.buttonProgressCancel.Id = "72fee6d7-03bc-42a8-8e13-35309ec722ad";
      this.buttonProgressCancel.Location = new System.Drawing.Point(180, 2);
      this.buttonProgressCancel.Name = "buttonProgressCancel";
      this.buttonProgressCancel.Size = new System.Drawing.Size(26, 19);
      this.buttonProgressCancel.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonProgressCancel.SmallImages.Images"))))});
      this.buttonProgressCancel.TabIndex = 1;
      this.buttonProgressCancel.MouseEnter += new System.EventHandler(this.buttonProgressCancel_MouseEnter);
      this.buttonProgressCancel.MouseLeave += new System.EventHandler(this.buttonProgressCancel_MouseLeave);
      // 
      // ribbon
      // 
      this.ribbon.ApplicationButtonImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("ribbon.ApplicationButtonImages.Images"))))});
      this.ribbon.ApplicationButtonStyle = Elegant.Ui.RibbonApplicationButtonStyle.Default;
      this.ribbon.BackstageView = this.backstageView;
      this.ribbon.CurrentTabPage = this.ribbonTabPageTag;
      this.ribbon.CustomTitleBarEnabled = false;
      this.ribbon.Dock = System.Windows.Forms.DockStyle.Top;
      this.ribbon.HelpButtonCommandName = "Help";
      this.ribbon.HelpButtonImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::MPTagThat.Properties.Resources.ribbon_help)});
      this.ribbon.HelpButtonVisible = true;
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.Name = "ribbon";
      this.ribbon.QuickAccessToolbarControls.AddRange(new Elegant.Ui.Control[] {
            this.startMenuSave,
            this.startMenuRefresh});
      this.ribbon.QuickAccessToolbarCustomizationDialogEnabled = false;
      this.ribbon.QuickAccessToolbarCustomizationEnabled = false;
      this.ribbon.QuickAccessToolbarPlacementMode = Elegant.Ui.QuickAccessToolbarPlacementMode.AboveRibbon;
      this.ribbon.Size = new System.Drawing.Size(1008, 153);
      this.ribbon.TabIndex = 15;
      this.ribbon.TabPages.AddRange(new Elegant.Ui.RibbonTabPage[] {
            this.ribbonTabPageTag,
            this.ribbonTabPageRip,
            this.ribbonTabPageConvert,
            this.ribbonTabPageBurn});
      this.ribbon.Text = "ribbon1";
      this.ribbon.CurrentTabPageChanged += new System.EventHandler(this.ribbon_CurrentTabPageChanged);
      // 
      // startMenuSave
      // 
      this.startMenuSave.CommandName = "Save";
      this.startMenuSave.Id = "38bad7fd-3fad-4393-8d19-7cad0ef3854b";
      this.startMenuSave.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("startMenuSave.LargeImages.Images"))))});
      this.startMenuSave.Location = new System.Drawing.Point(0, 0);
      this.startMenuSave.Name = "startMenuSave";
      this.startMenuSave.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("startMenuSave.ScreenTip.Image")));
      this.startMenuSave.Size = new System.Drawing.Size(195, 23);
      this.startMenuSave.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("startMenuSave.SmallImages.Images"))))});
      this.startMenuSave.TabIndex = 2;
      this.startMenuSave.Text = "Save";
      // 
      // startMenuRefresh
      // 
      this.startMenuRefresh.CommandName = "Refresh";
      this.startMenuRefresh.Id = "870d4a3f-624a-4d16-93e4-0a91f196bc2b";
      this.startMenuRefresh.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("startMenuRefresh.LargeImages.Images")))),
            new Elegant.Ui.ControlImage("Default", null)});
      this.startMenuRefresh.Location = new System.Drawing.Point(0, 23);
      this.startMenuRefresh.Name = "startMenuRefresh";
      this.startMenuRefresh.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("startMenuRefresh.ScreenTip.Image")));
      this.startMenuRefresh.Size = new System.Drawing.Size(195, 23);
      this.startMenuRefresh.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("startMenuRefresh.SmallImages.Images"))))});
      this.startMenuRefresh.TabIndex = 4;
      this.startMenuRefresh.Text = "Refresh";
      // 
      // backstageView
      // 
      this.backstageView.CurrentPage = this.backstageViewPageOptions;
      this.backstageView.Id = "7072530e-3b26-4337-af20-69a8f1207f12";
      this.backstageView.Items.AddRange(new System.Windows.Forms.Control[] {
            this.backstageViewButtonSave,
            this.backstageViewButtonRefresh,
            this.backstageViewPageRecentFolders,
            this.backstageViewPageOptions,
            this.backstageViewSeparator1,
            this.backstageViewButtonChangeColumns,
            this.backstageViewSeparator2,
            this.backstageViewButtonExit});
      this.backstageView.Location = new System.Drawing.Point(0, 52);
      this.backstageView.Name = "backstageView";
      this.backstageView.Size = new System.Drawing.Size(1008, 1030);
      this.backstageView.TabIndex = 17;
      // 
      // backstageViewPageOptions
      // 
      this.backstageViewPageOptions.Controls.Add(this.panel2);
      this.backstageViewPageOptions.Controls.Add(this.backstageViewPanel1);
      this.backstageViewPageOptions.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::MPTagThat.Properties.Resources.QuickAccessMenuOptions)});
      this.backstageViewPageOptions.Location = new System.Drawing.Point(0, 5);
      this.backstageViewPageOptions.Name = "backstageViewPageOptions";
      this.backstageViewPageOptions.Padding = new System.Windows.Forms.Padding(12);
      this.backstageViewPageOptions.Size = new System.Drawing.Size(910, 1020);
      this.backstageViewPageOptions.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", global::MPTagThat.Properties.Resources.QuickAccessMenuOptions)});
      this.backstageViewPageOptions.TabIndex = 0;
      this.backstageViewPageOptions.Text = "Options";
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(222, 12);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(676, 996);
      this.panel2.TabIndex = 1;
      this.panel2.Text = "panel2";
      // 
      // backstageViewPanel1
      // 
      this.backstageViewPanel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.backstageViewPanel1.Location = new System.Drawing.Point(12, 12);
      this.backstageViewPanel1.Name = "backstageViewPanel1";
      this.backstageViewPanel1.Size = new System.Drawing.Size(210, 996);
      this.backstageViewPanel1.TabIndex = 0;
      // 
      // backstageViewButtonSave
      // 
      this.backstageViewButtonSave.CommandName = "Save";
      this.backstageViewButtonSave.Id = "32efd3ca-28d1-4652-86df-5fc3b5ec04e5";
      this.backstageViewButtonSave.ImageToTextSpace = 5;
      this.backstageViewButtonSave.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Default", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonSave.LargeImages.Images")))),
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonSave.LargeImages.Images1"))))});
      this.backstageViewButtonSave.Location = new System.Drawing.Point(5, 22);
      this.backstageViewButtonSave.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.backstageViewButtonSave.Name = "backstageViewButtonSave";
      this.backstageViewButtonSave.Padding = new System.Windows.Forms.Padding(15, 9, 25, 9);
      this.backstageViewButtonSave.Size = new System.Drawing.Size(150, 34);
      this.backstageViewButtonSave.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Default", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonSave.SmallImages.Images")))),
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonSave.SmallImages.Images1"))))});
      this.backstageViewButtonSave.TabIndex = 2;
      this.backstageViewButtonSave.Text = "Save";
      // 
      // backstageViewButtonRefresh
      // 
      this.backstageViewButtonRefresh.CommandName = "Refresh";
      this.backstageViewButtonRefresh.Id = "e76de925-453d-41f3-aa98-02e009a23f90";
      this.backstageViewButtonRefresh.ImageToTextSpace = 5;
      this.backstageViewButtonRefresh.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonRefresh.LargeImages.Images"))))});
      this.backstageViewButtonRefresh.Location = new System.Drawing.Point(5, 56);
      this.backstageViewButtonRefresh.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.backstageViewButtonRefresh.Name = "backstageViewButtonRefresh";
      this.backstageViewButtonRefresh.Padding = new System.Windows.Forms.Padding(15, 9, 25, 9);
      this.backstageViewButtonRefresh.Size = new System.Drawing.Size(150, 34);
      this.backstageViewButtonRefresh.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("backstageViewButtonRefresh.SmallImages.Images"))))});
      this.backstageViewButtonRefresh.TabIndex = 4;
      this.backstageViewButtonRefresh.Text = "Refresh";
      // 
      // backstageViewPageRecentFolders
      // 
      this.backstageViewPageRecentFolders.Controls.Add(this.panel1);
      this.backstageViewPageRecentFolders.Location = new System.Drawing.Point(0, 5);
      this.backstageViewPageRecentFolders.Name = "backstageViewPageRecentFolders";
      this.backstageViewPageRecentFolders.Padding = new System.Windows.Forms.Padding(12);
      this.backstageViewPageRecentFolders.Size = new System.Drawing.Size(840, 1020);
      this.backstageViewPageRecentFolders.TabIndex = 0;
      this.backstageViewPageRecentFolders.Text = "Recent Folders";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.separatorRecentFolders);
      this.panel1.Controls.Add(this.pinListRecentFolders);
      this.panel1.Location = new System.Drawing.Point(33, 36);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(779, 913);
      this.panel1.TabIndex = 0;
      this.panel1.Text = "panel1";
      // 
      // separatorRecentFolders
      // 
      this.separatorRecentFolders.Id = "dc2159b0-fc8b-48bb-9a49-96fc2c9c61e9";
      this.separatorRecentFolders.Location = new System.Drawing.Point(16, 19);
      this.separatorRecentFolders.Name = "separatorRecentFolders";
      this.separatorRecentFolders.Size = new System.Drawing.Size(112, 20);
      this.separatorRecentFolders.TabIndex = 2;
      this.separatorRecentFolders.Text = "Recent Folders";
      // 
      // pinListRecentFolders
      // 
      this.pinListRecentFolders.Id = "085c0e4d-df88-45cf-b68e-c8dea1b7af05";
      this.pinListRecentFolders.Location = new System.Drawing.Point(16, 56);
      this.pinListRecentFolders.Name = "pinListRecentFolders";
      this.pinListRecentFolders.PinnedItemsSeparatorMargin = new System.Windows.Forms.Padding(0, 5, 0, 5);
      this.pinListRecentFolders.Size = new System.Drawing.Size(747, 837);
      this.pinListRecentFolders.TabIndex = 1;
      this.pinListRecentFolders.ItemClick += new Elegant.Ui.PinItemEventHandler(this.pinListRecentFolders_ItemClick);
      // 
      // backstageViewSeparator1
      // 
      this.backstageViewSeparator1.Id = "369d25d6-d37c-4006-867c-9c1e69f63586";
      this.backstageViewSeparator1.Location = new System.Drawing.Point(0, 184);
      this.backstageViewSeparator1.Name = "backstageViewSeparator1";
      this.backstageViewSeparator1.Size = new System.Drawing.Size(155, 2);
      this.backstageViewSeparator1.TabIndex = 6;
      this.backstageViewSeparator1.Text = "backstageViewSeparator1";
      // 
      // backstageViewButtonChangeColumns
      // 
      this.backstageViewButtonChangeColumns.CommandName = "ChangeDisplayColumns";
      this.backstageViewButtonChangeColumns.Id = "86ec7f12-cb60-44d1-8593-5d4c8b9a22ce";
      this.backstageViewButtonChangeColumns.ImageToTextSpace = 5;
      this.backstageViewButtonChangeColumns.Location = new System.Drawing.Point(5, 186);
      this.backstageViewButtonChangeColumns.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.backstageViewButtonChangeColumns.Name = "backstageViewButtonChangeColumns";
      this.backstageViewButtonChangeColumns.Padding = new System.Windows.Forms.Padding(15, 9, 25, 9);
      this.backstageViewButtonChangeColumns.Size = new System.Drawing.Size(150, 31);
      this.backstageViewButtonChangeColumns.TabIndex = 5;
      this.backstageViewButtonChangeColumns.Text = "Change Display Columns";
      // 
      // backstageViewSeparator2
      // 
      this.backstageViewSeparator2.Id = "1f44213c-f649-4525-8a34-f85c80e2607f";
      this.backstageViewSeparator2.Location = new System.Drawing.Point(0, 217);
      this.backstageViewSeparator2.Name = "backstageViewSeparator2";
      this.backstageViewSeparator2.Size = new System.Drawing.Size(155, 2);
      this.backstageViewSeparator2.TabIndex = 8;
      this.backstageViewSeparator2.Text = "backstageViewSeparator2";
      // 
      // backstageViewButtonExit
      // 
      this.backstageViewButtonExit.CommandName = "Exit";
      this.backstageViewButtonExit.Id = "c79011c7-3dcd-44b7-8414-e1276b7e331f";
      this.backstageViewButtonExit.ImageToTextSpace = 5;
      this.backstageViewButtonExit.Location = new System.Drawing.Point(5, 219);
      this.backstageViewButtonExit.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
      this.backstageViewButtonExit.Name = "backstageViewButtonExit";
      this.backstageViewButtonExit.Padding = new System.Windows.Forms.Padding(15, 9, 25, 9);
      this.backstageViewButtonExit.Size = new System.Drawing.Size(150, 31);
      this.backstageViewButtonExit.TabIndex = 7;
      this.backstageViewButtonExit.Text = "Exit";
      // 
      // ribbonTabPageTag
      // 
      this.ribbonTabPageTag.Controls.Add(this.ribbonGroupTagsRetrieve);
      this.ribbonTabPageTag.Controls.Add(this.ribbonGroupTagsEdit);
      this.ribbonTabPageTag.Controls.Add(this.ribbonGroupPicture);
      this.ribbonTabPageTag.Controls.Add(this.ribbonGroupOrganise);
      this.ribbonTabPageTag.Controls.Add(this.ribbonGroupOther);
      this.ribbonTabPageTag.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ribbonTabPageTag.KeyTip = null;
      this.ribbonTabPageTag.Location = new System.Drawing.Point(0, 0);
      this.ribbonTabPageTag.Name = "ribbonTabPageTag";
      this.ribbonTabPageTag.Size = new System.Drawing.Size(1008, 101);
      this.ribbonTabPageTag.TabIndex = 0;
      this.ribbonTabPageTag.Tag = "Tags";
      this.ribbonTabPageTag.Text = "Tags";
      // 
      // ribbonGroupTagsRetrieve
      // 
      this.ribbonGroupTagsRetrieve.Controls.Add(this.buttonTagFromFile);
      this.ribbonGroupTagsRetrieve.Controls.Add(this.buttonTagIdentifyFiles);
      this.ribbonGroupTagsRetrieve.Controls.Add(this.buttonTagFromInternet);
      this.ribbonGroupTagsRetrieve.Location = new System.Drawing.Point(4, 3);
      this.ribbonGroupTagsRetrieve.Name = "ribbonGroupTagsRetrieve";
      this.ribbonGroupTagsRetrieve.Size = new System.Drawing.Size(162, 94);
      this.ribbonGroupTagsRetrieve.TabIndex = 1;
      this.ribbonGroupTagsRetrieve.Text = "Retrieve Tags";
      // 
      // buttonTagFromFile
      // 
      this.buttonTagFromFile.CommandName = "FileNameToTag";
      this.buttonTagFromFile.Id = "8ef0b3fa-4639-4da8-a32d-5b2811fb92e1";
      this.buttonTagFromFile.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagFromFile.LargeImages.Images"))))});
      this.buttonTagFromFile.Location = new System.Drawing.Point(4, 2);
      this.buttonTagFromFile.Name = "buttonTagFromFile";
      this.buttonTagFromFile.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonTagFromFile.ScreenTip.Image")));
      this.ribbonGroupTagsRetrieve.SetShortcutKeys(this.buttonTagFromFile, System.Windows.Forms.Keys.None);
      this.buttonTagFromFile.Size = new System.Drawing.Size(52, 72);
      this.buttonTagFromFile.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagFromFile.SmallImages.Images"))))});
      this.buttonTagFromFile.TabIndex = 0;
      this.buttonTagFromFile.Text = "Filename to Tag";
      this.buttonTagFromFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // buttonTagIdentifyFiles
      // 
      this.buttonTagIdentifyFiles.CommandName = "IdentifyFiles";
      this.buttonTagIdentifyFiles.Id = "ed6737da-d174-45ea-914a-07d738a04fa9";
      this.buttonTagIdentifyFiles.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagIdentifyFiles.LargeImages.Images"))))});
      this.buttonTagIdentifyFiles.Location = new System.Drawing.Point(58, 2);
      this.buttonTagIdentifyFiles.Name = "buttonTagIdentifyFiles";
      this.buttonTagIdentifyFiles.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonTagIdentifyFiles.ScreenTip.Image")));
      this.ribbonGroupTagsRetrieve.SetShortcutKeys(this.buttonTagIdentifyFiles, System.Windows.Forms.Keys.None);
      this.buttonTagIdentifyFiles.Size = new System.Drawing.Size(44, 72);
      this.buttonTagIdentifyFiles.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagIdentifyFiles.SmallImages.Images"))))});
      this.buttonTagIdentifyFiles.TabIndex = 1;
      this.buttonTagIdentifyFiles.Text = "Identify Files";
      // 
      // buttonTagFromInternet
      // 
      this.buttonTagFromInternet.CommandName = "TagFromInternet";
      this.buttonTagFromInternet.Id = "ba319a36-7b4b-4a50-b424-2a08ebe21a3b";
      this.buttonTagFromInternet.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagFromInternet.LargeImages.Images"))))});
      this.buttonTagFromInternet.Location = new System.Drawing.Point(104, 2);
      this.buttonTagFromInternet.Name = "buttonTagFromInternet";
      this.buttonTagFromInternet.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonTagFromInternet.ScreenTip.Image")));
      this.ribbonGroupTagsRetrieve.SetShortcutKeys(this.buttonTagFromInternet, System.Windows.Forms.Keys.None);
      this.buttonTagFromInternet.Size = new System.Drawing.Size(53, 72);
      this.buttonTagFromInternet.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonTagFromInternet.SmallImages.Images"))))});
      this.buttonTagFromInternet.TabIndex = 2;
      this.buttonTagFromInternet.Text = "Tag from Internet";
      // 
      // ribbonGroupTagsEdit
      // 
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonCaseConversion);
      this.ribbonGroupTagsEdit.Controls.Add(this.separator2);
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonDeleteTag);
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonGetLyrics);
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonRemoveComment);
      this.ribbonGroupTagsEdit.Controls.Add(this.separator3);
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonGroup1);
      this.ribbonGroupTagsEdit.Controls.Add(this.buttonGroup3);
      this.ribbonGroupTagsEdit.Location = new System.Drawing.Point(168, 3);
      this.ribbonGroupTagsEdit.Name = "ribbonGroupTagsEdit";
      this.ribbonGroupTagsEdit.Size = new System.Drawing.Size(271, 94);
      this.ribbonGroupTagsEdit.TabIndex = 2;
      this.ribbonGroupTagsEdit.Text = "Edit Tags";
      // 
      // buttonCaseConversion
      // 
      this.buttonCaseConversion.ButtonScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonCaseConversion.ButtonScreenTip.Image")));
      this.buttonCaseConversion.CommandName = "CaseConversion";
      this.buttonCaseConversion.DescriptionText = null;
      this.buttonCaseConversion.Id = "000a4131-395d-420d-9e14-40811c6e525c";
      this.buttonCaseConversion.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonCaseConversion.LargeImages.Images"))))});
      this.buttonCaseConversion.Location = new System.Drawing.Point(4, 2);
      this.buttonCaseConversion.Name = "buttonCaseConversion";
      this.buttonCaseConversion.Popup = this.popupMenu3;
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonCaseConversion, System.Windows.Forms.Keys.None);
      this.buttonCaseConversion.Size = new System.Drawing.Size(74, 72);
      this.buttonCaseConversion.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonCaseConversion.SmallImages.Images"))))});
      this.buttonCaseConversion.TabIndex = 5;
      this.buttonCaseConversion.Text = "Case Conversion";
      // 
      // popupMenu3
      // 
      this.popupMenu3.Items.AddRange(new System.Windows.Forms.Control[] {
            this.buttonCaseConversionOptions});
      this.popupMenu3.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
      this.popupMenu3.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
      this.popupMenu3.Size = new System.Drawing.Size(100, 100);
      // 
      // buttonCaseConversionOptions
      // 
      this.buttonCaseConversionOptions.CommandName = "CaseConversionOptions";
      this.buttonCaseConversionOptions.Id = "a82e8bf2-5344-4ae5-bb46-5161f294f60f";
      this.buttonCaseConversionOptions.Location = new System.Drawing.Point(2, 2);
      this.buttonCaseConversionOptions.Name = "buttonCaseConversionOptions";
      this.buttonCaseConversionOptions.Size = new System.Drawing.Size(192, 23);
      this.buttonCaseConversionOptions.TabIndex = 2;
      this.buttonCaseConversionOptions.Text = "Case Conversion Options";
      // 
      // separator2
      // 
      this.separator2.Id = "d7a68ab0-052d-457e-8ab3-95e30ecb244b";
      this.separator2.Location = new System.Drawing.Point(82, 7);
      this.separator2.Name = "separator2";
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.separator2, System.Windows.Forms.Keys.None);
      this.separator2.Size = new System.Drawing.Size(2, 60);
      this.separator2.TabIndex = 8;
      this.separator2.Text = "separator1";
      // 
      // buttonDeleteTag
      // 
      this.buttonDeleteTag.ButtonScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteTag.ButtonScreenTip.Image")));
      this.buttonDeleteTag.CommandName = "DeleteAllTags";
      this.buttonDeleteTag.DescriptionText = null;
      this.ribbonGroupTagsEdit.SetFlowBreak(this.buttonDeleteTag, true);
      this.buttonDeleteTag.Id = "3356cb8b-8ef8-4134-b8e4-8290dd07b0f0";
      this.buttonDeleteTag.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonDeleteTag.LargeImages.Images"))))});
      this.buttonDeleteTag.Location = new System.Drawing.Point(88, 2);
      this.buttonDeleteTag.Name = "buttonDeleteTag";
      this.buttonDeleteTag.Popup = this.popupMenu2;
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonDeleteTag, System.Windows.Forms.Keys.None);
      this.buttonDeleteTag.Size = new System.Drawing.Size(42, 72);
      this.buttonDeleteTag.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonDeleteTag.SmallImages.Images"))))});
      this.buttonDeleteTag.TabIndex = 1;
      this.buttonDeleteTag.Text = "Delete Tags";
      // 
      // popupMenu2
      // 
      this.popupMenu2.Items.AddRange(new System.Windows.Forms.Control[] {
            this.buttonDeleteAllTags,
            this.buttonDeleteID3v1,
            this.buttonDeleteID3v2});
      this.popupMenu2.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
      this.popupMenu2.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
      this.popupMenu2.Size = new System.Drawing.Size(100, 100);
      // 
      // buttonDeleteAllTags
      // 
      this.buttonDeleteAllTags.CommandName = "DeleteAllTags";
      this.buttonDeleteAllTags.Id = "52f93e54-be6f-4749-8fa8-8f201868c5c5";
      this.buttonDeleteAllTags.Location = new System.Drawing.Point(2, 2);
      this.buttonDeleteAllTags.Name = "buttonDeleteAllTags";
      this.buttonDeleteAllTags.Size = new System.Drawing.Size(156, 23);
      this.buttonDeleteAllTags.TabIndex = 2;
      this.buttonDeleteAllTags.Text = "Delete All Tags";
      // 
      // buttonDeleteID3v1
      // 
      this.buttonDeleteID3v1.CommandName = "DeleteID3v1";
      this.buttonDeleteID3v1.Id = "f5f872b6-0211-40c6-877d-474252a98a09";
      this.buttonDeleteID3v1.Location = new System.Drawing.Point(2, 25);
      this.buttonDeleteID3v1.Name = "buttonDeleteID3v1";
      this.buttonDeleteID3v1.Size = new System.Drawing.Size(156, 23);
      this.buttonDeleteID3v1.TabIndex = 3;
      this.buttonDeleteID3v1.Text = "Delete ID3 V1 Only";
      // 
      // buttonDeleteID3v2
      // 
      this.buttonDeleteID3v2.CommandName = "DeleteID3v2";
      this.buttonDeleteID3v2.Id = "269f63f1-5f47-4f71-9f4f-2964d45ee55f";
      this.buttonDeleteID3v2.Location = new System.Drawing.Point(2, 48);
      this.buttonDeleteID3v2.Name = "buttonDeleteID3v2";
      this.buttonDeleteID3v2.Size = new System.Drawing.Size(156, 23);
      this.buttonDeleteID3v2.TabIndex = 4;
      this.buttonDeleteID3v2.Text = "Delete ID3 V2 only";
      // 
      // buttonGetLyrics
      // 
      this.buttonGetLyrics.CommandName = "GetLyrics";
      this.buttonGetLyrics.Id = "dd174cc5-5be9-45b7-9cf9-26c6eb813b52";
      this.buttonGetLyrics.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonGetLyrics.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonGetLyrics.LargeImages.Images"))))});
      this.buttonGetLyrics.Location = new System.Drawing.Point(132, 2);
      this.buttonGetLyrics.Name = "buttonGetLyrics";
      this.buttonGetLyrics.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetLyrics.ScreenTip.Image")));
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonGetLyrics, System.Windows.Forms.Keys.None);
      this.buttonGetLyrics.Size = new System.Drawing.Size(26, 24);
      this.buttonGetLyrics.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonGetLyrics.SmallImages.Images"))))});
      this.buttonGetLyrics.TabIndex = 0;
      this.buttonGetLyrics.Text = "button3";
      // 
      // buttonRemoveComment
      // 
      this.buttonRemoveComment.CommandName = "RemoveComment";
      this.buttonRemoveComment.Id = "cbb994ed-acd4-4eeb-92d2-692a3e92d5bb";
      this.buttonRemoveComment.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonRemoveComment.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRemoveComment.LargeImages.Images"))))});
      this.buttonRemoveComment.Location = new System.Drawing.Point(132, 26);
      this.buttonRemoveComment.Name = "buttonRemoveComment";
      this.buttonRemoveComment.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveComment.ScreenTip.Image")));
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonRemoveComment, System.Windows.Forms.Keys.None);
      this.buttonRemoveComment.Size = new System.Drawing.Size(26, 24);
      this.buttonRemoveComment.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRemoveComment.SmallImages.Images"))))});
      this.buttonRemoveComment.TabIndex = 1;
      this.buttonRemoveComment.Text = "button1";
      // 
      // separator3
      // 
      this.separator3.Id = "6d913a4c-a584-4ec3-87a9-bae2f1d79f15";
      this.separator3.Location = new System.Drawing.Point(162, 7);
      this.separator3.Name = "separator3";
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.separator3, System.Windows.Forms.Keys.None);
      this.separator3.Size = new System.Drawing.Size(2, 60);
      this.separator3.TabIndex = 9;
      this.separator3.Text = "separator1";
      // 
      // buttonGroup1
      // 
      this.buttonGroup1.Controls.Add(this.comboBoxScripts);
      this.buttonGroup1.Controls.Add(this.buttonScriptExecute);
      this.buttonGroup1.Location = new System.Drawing.Point(167, 2);
      this.buttonGroup1.Name = "buttonGroup1";
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonGroup1, System.Windows.Forms.Keys.None);
      this.buttonGroup1.Size = new System.Drawing.Size(57, 24);
      this.buttonGroup1.TabIndex = 7;
      // 
      // comboBoxScripts
      // 
      this.comboBoxScripts.Editable = false;
      this.comboBoxScripts.FormattingEnabled = false;
      this.comboBoxScripts.Id = "517fc9cb-14b0-4fff-b350-cd5b098498c2";
      this.comboBoxScripts.LabelAreaWidthTemplate = "";
      this.comboBoxScripts.Location = new System.Drawing.Point(1, 0);
      this.comboBoxScripts.Name = "comboBoxScripts";
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.comboBoxScripts, System.Windows.Forms.Keys.None);
      this.comboBoxScripts.Size = new System.Drawing.Size(19, 23);
      this.comboBoxScripts.TabIndex = 0;
      this.comboBoxScripts.TextEditorWidth = 0;
      // 
      // buttonScriptExecute
      // 
      this.buttonScriptExecute.CommandName = "ScriptExecute";
      this.buttonScriptExecute.Id = "980e2572-f8a5-4c19-9f23-296539fb858b";
      this.buttonScriptExecute.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonScriptExecute.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonScriptExecute.LargeImages.Images"))))});
      this.buttonScriptExecute.Location = new System.Drawing.Point(21, 0);
      this.buttonScriptExecute.Name = "buttonScriptExecute";
      this.buttonScriptExecute.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonScriptExecute.ScreenTip.Image")));
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonScriptExecute, System.Windows.Forms.Keys.None);
      this.buttonScriptExecute.Size = new System.Drawing.Size(26, 24);
      this.buttonScriptExecute.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonScriptExecute.SmallImages.Images"))))});
      this.buttonScriptExecute.TabIndex = 1;
      this.buttonScriptExecute.Text = "Execute Script";
      // 
      // buttonGroup3
      // 
      this.buttonGroup3.Controls.Add(this.buttonNumberOnClick);
      this.buttonGroup3.Controls.Add(this.buttonAutoNumber);
      this.buttonGroup3.Controls.Add(this.textBoxNumber);
      this.buttonGroup3.Location = new System.Drawing.Point(167, 26);
      this.buttonGroup3.Name = "buttonGroup3";
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonGroup3, System.Windows.Forms.Keys.None);
      this.buttonGroup3.Size = new System.Drawing.Size(100, 24);
      this.buttonGroup3.TabIndex = 6;
      // 
      // buttonNumberOnClick
      // 
      this.buttonNumberOnClick.CommandName = "";
      this.buttonNumberOnClick.Id = "4dc861f9-7417-4727-ad76-bcafca928b70";
      this.buttonNumberOnClick.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonNumberOnClick.LargeImages.Images"))))});
      this.buttonNumberOnClick.Location = new System.Drawing.Point(0, 0);
      this.buttonNumberOnClick.Name = "buttonNumberOnClick";
      this.buttonNumberOnClick.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonNumberOnClick.ScreenTip.Image")));
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonNumberOnClick, System.Windows.Forms.Keys.None);
      this.buttonNumberOnClick.Size = new System.Drawing.Size(26, 24);
      this.buttonNumberOnClick.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonNumberOnClick.SmallImages.Images"))))});
      this.buttonNumberOnClick.TabIndex = 2;
      this.buttonNumberOnClick.Text = "NumberOnClick";
      this.buttonNumberOnClick.PressedChanged += new System.EventHandler(this.buttonNumberOnClick_PressedChanged);
      // 
      // buttonAutoNumber
      // 
      this.buttonAutoNumber.CommandName = "AutoNumber";
      this.buttonAutoNumber.Id = "2cc1eb5a-16cc-4259-8d08-8827191cbe96";
      this.buttonAutoNumber.Location = new System.Drawing.Point(26, 0);
      this.buttonAutoNumber.Name = "buttonAutoNumber";
      this.buttonAutoNumber.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonAutoNumber.ScreenTip.Image")));
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.buttonAutoNumber, System.Windows.Forms.Keys.None);
      this.buttonAutoNumber.Size = new System.Drawing.Size(26, 24);
      this.buttonAutoNumber.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonAutoNumber.SmallImages.Images"))))});
      this.buttonAutoNumber.TabIndex = 0;
      this.buttonAutoNumber.Text = "button1";
      // 
      // textBoxNumber
      // 
      this.textBoxNumber.Id = "103acbe1-2662-4c90-b050-8dc9c604b5a0";
      this.textBoxNumber.Location = new System.Drawing.Point(53, 0);
      this.textBoxNumber.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
      this.textBoxNumber.MaxLength = 4;
      this.textBoxNumber.MinimumSize = new System.Drawing.Size(60, 0);
      this.textBoxNumber.Name = "textBoxNumber";
      this.textBoxNumber.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
      this.ribbonGroupTagsEdit.SetShortcutKeys(this.textBoxNumber, System.Windows.Forms.Keys.None);
      this.textBoxNumber.Size = new System.Drawing.Size(60, 23);
      this.textBoxNumber.TabIndex = 2;
      this.textBoxNumber.Text = "1";
      this.textBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.textBoxNumber.TextEditorWidth = 54;
      // 
      // ribbonGroupPicture
      // 
      this.ribbonGroupPicture.Controls.Add(this.galleryPicture);
      this.ribbonGroupPicture.Controls.Add(this.buttonGetCoverArt);
      this.ribbonGroupPicture.Controls.Add(this.buttonRemoveCoverArt);
      this.ribbonGroupPicture.Controls.Add(this.buttonSaveAsThumb);
      this.ribbonGroupPicture.Location = new System.Drawing.Point(441, 3);
      this.ribbonGroupPicture.Name = "ribbonGroupPicture";
      this.ribbonGroupPicture.Size = new System.Drawing.Size(118, 94);
      this.ribbonGroupPicture.TabIndex = 6;
      this.ribbonGroupPicture.Text = "Picture";
      // 
      // galleryPicture
      // 
      this.galleryPicture.AutoScrollMinSize = new System.Drawing.Size(0, 0);
      this.galleryPicture.Id = "dfef072e-e209-42c2-8a2e-be1fc6f59025";
      this.galleryPicture.ItemWidth = 62;
      this.galleryPicture.Location = new System.Drawing.Point(4, 5);
      this.galleryPicture.MinimumItemsInRowCount = 1;
      this.galleryPicture.Name = "galleryPicture";
      // 
      // 
      // 
      this.galleryPicture.Popup.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.galleryPicture.Popup.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
      this.galleryPicture.Popup.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
      this.galleryPicture.Popup.Size = new System.Drawing.Size(100, 100);
      this.ribbonGroupPicture.SetShortcutKeys(this.galleryPicture, System.Windows.Forms.Keys.None);
      this.galleryPicture.Size = new System.Drawing.Size(81, 66);
      this.galleryPicture.TabIndex = 0;
      this.galleryPicture.Text = "gallery1";
      this.galleryPicture.HoveredItemChanged += new System.EventHandler<Elegant.Ui.GalleryHoveredItemChangedEventArgs>(this.galleryPicture_HoveredItemChanged);
      // 
      // buttonGetCoverArt
      // 
      this.buttonGetCoverArt.CommandName = "GetCoverArt";
      this.buttonGetCoverArt.Id = "f1dc7735-ff15-4363-b440-cc9e920f258b";
      this.buttonGetCoverArt.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.buttonGetCoverArt.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonGetCoverArt.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonGetCoverArt.LargeImages.Images"))))});
      this.buttonGetCoverArt.Location = new System.Drawing.Point(87, 2);
      this.buttonGetCoverArt.Name = "buttonGetCoverArt";
      this.buttonGetCoverArt.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonGetCoverArt.ScreenTip.Image")));
      this.ribbonGroupPicture.SetShortcutKeys(this.buttonGetCoverArt, System.Windows.Forms.Keys.None);
      this.buttonGetCoverArt.Size = new System.Drawing.Size(26, 24);
      this.buttonGetCoverArt.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonGetCoverArt.SmallImages.Images"))))});
      this.buttonGetCoverArt.TabIndex = 2;
      this.buttonGetCoverArt.Text = "Get Cover Art";
      // 
      // buttonRemoveCoverArt
      // 
      this.buttonRemoveCoverArt.CommandName = "RemoveCoverArt";
      this.buttonRemoveCoverArt.Id = "a9bf3abe-795d-4f3a-8e9f-d4efb9b3c887";
      this.buttonRemoveCoverArt.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonRemoveCoverArt.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRemoveCoverArt.LargeImages.Images"))))});
      this.buttonRemoveCoverArt.Location = new System.Drawing.Point(87, 26);
      this.buttonRemoveCoverArt.Name = "buttonRemoveCoverArt";
      this.buttonRemoveCoverArt.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveCoverArt.ScreenTip.Image")));
      this.ribbonGroupPicture.SetShortcutKeys(this.buttonRemoveCoverArt, System.Windows.Forms.Keys.None);
      this.buttonRemoveCoverArt.Size = new System.Drawing.Size(26, 24);
      this.buttonRemoveCoverArt.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRemoveCoverArt.SmallImages.Images"))))});
      this.buttonRemoveCoverArt.TabIndex = 3;
      this.buttonRemoveCoverArt.Text = "button3";
      // 
      // buttonSaveAsThumb
      // 
      this.buttonSaveAsThumb.CommandName = "SaveAsThumb";
      this.buttonSaveAsThumb.Id = "770274cc-208e-4e61-a8e1-f192edc88a1b";
      this.buttonSaveAsThumb.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonSaveAsThumb.Location = new System.Drawing.Point(87, 50);
      this.buttonSaveAsThumb.Name = "buttonSaveAsThumb";
      this.buttonSaveAsThumb.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveAsThumb.ScreenTip.Image")));
      this.ribbonGroupPicture.SetShortcutKeys(this.buttonSaveAsThumb, System.Windows.Forms.Keys.None);
      this.buttonSaveAsThumb.Size = new System.Drawing.Size(26, 24);
      this.buttonSaveAsThumb.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonSaveAsThumb.SmallImages.Images"))))});
      this.buttonSaveAsThumb.TabIndex = 4;
      this.buttonSaveAsThumb.Text = "button1";
      // 
      // ribbonGroupOrganise
      // 
      this.ribbonGroupOrganise.Controls.Add(this.buttonRenameFiles);
      this.ribbonGroupOrganise.Controls.Add(this.buttonOrganiseFiles);
      this.ribbonGroupOrganise.Location = new System.Drawing.Point(561, 3);
      this.ribbonGroupOrganise.Name = "ribbonGroupOrganise";
      this.ribbonGroupOrganise.Size = new System.Drawing.Size(111, 94);
      this.ribbonGroupOrganise.TabIndex = 3;
      this.ribbonGroupOrganise.Text = "Organise";
      // 
      // buttonRenameFiles
      // 
      this.buttonRenameFiles.ButtonScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonRenameFiles.ButtonScreenTip.Image")));
      this.buttonRenameFiles.CommandName = "RenameFiles";
      this.buttonRenameFiles.DescriptionText = null;
      this.buttonRenameFiles.Id = "6458a3fe-966e-4350-84a2-a2feea18c99d";
      this.buttonRenameFiles.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRenameFiles.LargeImages.Images"))))});
      this.buttonRenameFiles.Location = new System.Drawing.Point(4, 2);
      this.buttonRenameFiles.Name = "buttonRenameFiles";
      this.buttonRenameFiles.Popup = this.popupMenu1;
      this.ribbonGroupOrganise.SetShortcutKeys(this.buttonRenameFiles, System.Windows.Forms.Keys.None);
      this.buttonRenameFiles.Size = new System.Drawing.Size(49, 72);
      this.buttonRenameFiles.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRenameFiles.SmallImages.Images"))))});
      this.buttonRenameFiles.TabIndex = 0;
      this.buttonRenameFiles.Text = "Rename Files";
      // 
      // popupMenu1
      // 
      this.popupMenu1.Items.AddRange(new System.Windows.Forms.Control[] {
            this.buttonRenameFilesOptions});
      this.popupMenu1.KeepPopupsWithOffsetPlacementWithinPlacementArea = false;
      this.popupMenu1.PlacementMode = Elegant.Ui.PopupPlacementMode.Bottom;
      this.popupMenu1.Size = new System.Drawing.Size(100, 100);
      // 
      // buttonRenameFilesOptions
      // 
      this.buttonRenameFilesOptions.CommandName = "RenameFileOptions";
      this.buttonRenameFilesOptions.Id = "823a9d9f-69dd-45b7-b024-77fc09f23742";
      this.buttonRenameFilesOptions.Location = new System.Drawing.Point(2, 2);
      this.buttonRenameFilesOptions.Name = "buttonRenameFilesOptions";
      this.buttonRenameFilesOptions.Size = new System.Drawing.Size(173, 23);
      this.buttonRenameFilesOptions.TabIndex = 2;
      this.buttonRenameFilesOptions.Text = "Rename Files Options";
      // 
      // buttonOrganiseFiles
      // 
      this.buttonOrganiseFiles.CommandName = "OrganiseFiles";
      this.buttonOrganiseFiles.Id = "c936611c-9924-417d-b0dc-9219e83aa5a0";
      this.buttonOrganiseFiles.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonOrganiseFiles.LargeImages.Images"))))});
      this.buttonOrganiseFiles.Location = new System.Drawing.Point(55, 2);
      this.buttonOrganiseFiles.Name = "buttonOrganiseFiles";
      this.buttonOrganiseFiles.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonOrganiseFiles.ScreenTip.Image")));
      this.ribbonGroupOrganise.SetShortcutKeys(this.buttonOrganiseFiles, System.Windows.Forms.Keys.None);
      this.buttonOrganiseFiles.Size = new System.Drawing.Size(51, 72);
      this.buttonOrganiseFiles.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonOrganiseFiles.SmallImages.Images"))))});
      this.buttonOrganiseFiles.TabIndex = 1;
      this.buttonOrganiseFiles.Text = "Organise Files";
      // 
      // ribbonGroupOther
      // 
      this.ribbonGroupOther.Controls.Add(this.buttonAddToBurner);
      this.ribbonGroupOther.Controls.Add(this.buttonAddToConversion);
      this.ribbonGroupOther.Controls.Add(this.buttonAddToPlaylist);
      this.ribbonGroupOther.Location = new System.Drawing.Point(674, 3);
      this.ribbonGroupOther.Name = "ribbonGroupOther";
      this.ribbonGroupOther.Size = new System.Drawing.Size(133, 94);
      this.ribbonGroupOther.TabIndex = 5;
      this.ribbonGroupOther.Text = "Other";
      // 
      // buttonAddToBurner
      // 
      this.buttonAddToBurner.CommandName = "AddToBurner";
      this.buttonAddToBurner.Id = "33e48a90-67a6-4307-9fe6-5bcc8729a288";
      this.buttonAddToBurner.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImageWithText";
      this.buttonAddToBurner.Location = new System.Drawing.Point(4, 2);
      this.buttonAddToBurner.Name = "buttonAddToBurner";
      this.buttonAddToBurner.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddToBurner.ScreenTip.Image")));
      this.ribbonGroupOther.SetShortcutKeys(this.buttonAddToBurner, System.Windows.Forms.Keys.None);
      this.buttonAddToBurner.Size = new System.Drawing.Size(99, 24);
      this.buttonAddToBurner.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonAddToBurner.SmallImages.Images"))))});
      this.buttonAddToBurner.TabIndex = 0;
      this.buttonAddToBurner.Text = "Add to Burner";
      // 
      // buttonAddToConversion
      // 
      this.buttonAddToConversion.CommandName = "AddToConversion";
      this.buttonAddToConversion.Id = "9960458f-576c-4ef4-a763-4365a98433c8";
      this.buttonAddToConversion.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImageWithText";
      this.buttonAddToConversion.Location = new System.Drawing.Point(4, 26);
      this.buttonAddToConversion.Name = "buttonAddToConversion";
      this.buttonAddToConversion.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddToConversion.ScreenTip.Image")));
      this.ribbonGroupOther.SetShortcutKeys(this.buttonAddToConversion, System.Windows.Forms.Keys.None);
      this.buttonAddToConversion.Size = new System.Drawing.Size(124, 24);
      this.buttonAddToConversion.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonAddToConversion.SmallImages.Images"))))});
      this.buttonAddToConversion.TabIndex = 1;
      this.buttonAddToConversion.Text = "Add to Conversion";
      // 
      // buttonAddToPlaylist
      // 
      this.buttonAddToPlaylist.CommandName = "AddToPlaylist";
      this.buttonAddToPlaylist.Id = "869b0a70-3051-4248-a96a-88284fdeb54c";
      this.buttonAddToPlaylist.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImageWithText";
      this.buttonAddToPlaylist.Location = new System.Drawing.Point(4, 50);
      this.buttonAddToPlaylist.Name = "buttonAddToPlaylist";
      this.buttonAddToPlaylist.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddToPlaylist.ScreenTip.Image")));
      this.ribbonGroupOther.SetShortcutKeys(this.buttonAddToPlaylist, System.Windows.Forms.Keys.None);
      this.buttonAddToPlaylist.Size = new System.Drawing.Size(101, 24);
      this.buttonAddToPlaylist.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonAddToPlaylist.SmallImages.Images"))))});
      this.buttonAddToPlaylist.TabIndex = 2;
      this.buttonAddToPlaylist.Text = "Add to Playlist";
      // 
      // ribbonTabPageRip
      // 
      this.ribbonTabPageRip.Controls.Add(this.ribbonGroupRip);
      this.ribbonTabPageRip.Controls.Add(this.ribbonGroupRipOptions);
      this.ribbonTabPageRip.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ribbonTabPageRip.KeyTip = null;
      this.ribbonTabPageRip.Location = new System.Drawing.Point(0, 0);
      this.ribbonTabPageRip.Name = "ribbonTabPageRip";
      this.ribbonTabPageRip.Size = new System.Drawing.Size(1166, 101);
      this.ribbonTabPageRip.TabIndex = 0;
      this.ribbonTabPageRip.Tag = "Rip";
      this.ribbonTabPageRip.Text = "Rip";
      // 
      // ribbonGroupRip
      // 
      this.ribbonGroupRip.Controls.Add(this.buttonRipStart);
      this.ribbonGroupRip.Controls.Add(this.buttonRipCancel);
      this.ribbonGroupRip.Location = new System.Drawing.Point(4, 3);
      this.ribbonGroupRip.Name = "ribbonGroupRip";
      this.ribbonGroupRip.Size = new System.Drawing.Size(95, 0);
      this.ribbonGroupRip.TabIndex = 1;
      // 
      // buttonRipStart
      // 
      this.buttonRipStart.CommandName = "RipStart";
      this.buttonRipStart.Id = "d001a4be-1aa7-4920-93da-c0dc3ec51e31";
      this.buttonRipStart.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRipStart.LargeImages.Images"))))});
      this.buttonRipStart.Location = new System.Drawing.Point(16, 2);
      this.buttonRipStart.Name = "buttonRipStart";
      this.buttonRipStart.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonRipStart.ScreenTip.Image")));
      this.ribbonGroupRip.SetShortcutKeys(this.buttonRipStart, System.Windows.Forms.Keys.None);
      this.buttonRipStart.Size = new System.Drawing.Size(25, 0);
      this.buttonRipStart.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRipStart.SmallImages.Images"))))});
      this.buttonRipStart.TabIndex = 4;
      this.buttonRipStart.Text = "Rip";
      // 
      // buttonRipCancel
      // 
      this.buttonRipCancel.CommandName = "RipCancel";
      this.buttonRipCancel.Id = "dd9e5847-c68c-44a1-9a44-246f6ae71cd5";
      this.buttonRipCancel.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRipCancel.LargeImages.Images"))))});
      this.buttonRipCancel.Location = new System.Drawing.Point(16, 2);
      this.buttonRipCancel.Name = "buttonRipCancel";
      this.buttonRipCancel.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonRipCancel.ScreenTip.Image")));
      this.ribbonGroupRip.SetShortcutKeys(this.buttonRipCancel, System.Windows.Forms.Keys.None);
      this.buttonRipCancel.Size = new System.Drawing.Size(61, 0);
      this.buttonRipCancel.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRipCancel.SmallImages.Images"))))});
      this.buttonRipCancel.TabIndex = 5;
      this.buttonRipCancel.Text = "Rip Cancel";
      // 
      // ribbonGroupRipOptions
      // 
      this.ribbonGroupRipOptions.Controls.Add(this.textBoxRipOutputFolder);
      this.ribbonGroupRipOptions.Controls.Add(this.comboBoxRipEncoder);
      this.ribbonGroupRipOptions.Controls.Add(this.buttonRipFolderSelect);
      this.ribbonGroupRipOptions.Location = new System.Drawing.Point(101, 3);
      this.ribbonGroupRipOptions.Name = "ribbonGroupRipOptions";
      this.ribbonGroupRipOptions.Size = new System.Drawing.Size(514, 0);
      this.ribbonGroupRipOptions.TabIndex = 0;
      this.ribbonGroupRipOptions.Text = "Rip Options";
      // 
      // textBoxRipOutputFolder
      // 
      this.textBoxRipOutputFolder.Id = "232a5cbf-0ce0-4aff-b9bf-1c7640ed1c28";
      this.textBoxRipOutputFolder.LabelAreaWidthTemplate = "Select Encoder:                      ";
      this.textBoxRipOutputFolder.LabelText = "Output Folder:";
      this.textBoxRipOutputFolder.Location = new System.Drawing.Point(4, 2);
      this.textBoxRipOutputFolder.Name = "textBoxRipOutputFolder";
      this.ribbonGroupRipOptions.SetShortcutKeys(this.textBoxRipOutputFolder, System.Windows.Forms.Keys.None);
      this.textBoxRipOutputFolder.Size = new System.Drawing.Size(473, 19);
      this.textBoxRipOutputFolder.TabIndex = 3;
      this.textBoxRipOutputFolder.TextEditorWidth = 322;
      // 
      // comboBoxRipEncoder
      // 
      this.comboBoxRipEncoder.Editable = false;
      this.ribbonGroupRipOptions.SetFlowBreak(this.comboBoxRipEncoder, true);
      this.comboBoxRipEncoder.FormattingEnabled = false;
      this.comboBoxRipEncoder.Id = "c8d5a621-31b2-4a30-81c4-ff37571165dc";
      this.comboBoxRipEncoder.LabelAreaWidthTemplate = "Select Encoder:                      ";
      this.comboBoxRipEncoder.LabelText = "Select Encoder:";
      this.comboBoxRipEncoder.Location = new System.Drawing.Point(479, 2);
      this.comboBoxRipEncoder.Name = "comboBoxRipEncoder";
      this.ribbonGroupRipOptions.SetShortcutKeys(this.comboBoxRipEncoder, System.Windows.Forms.Keys.None);
      this.comboBoxRipEncoder.Size = new System.Drawing.Size(473, 19);
      this.comboBoxRipEncoder.TabIndex = 2;
      this.comboBoxRipEncoder.TextEditorWidth = 309;
      // 
      // buttonRipFolderSelect
      // 
      this.buttonRipFolderSelect.CommandName = "FolderSelect";
      this.buttonRipFolderSelect.Id = "ea53cc78-57ab-4d19-91e8-afe6a1d99e7a";
      this.buttonRipFolderSelect.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonRipFolderSelect.Location = new System.Drawing.Point(954, 2);
      this.buttonRipFolderSelect.Name = "buttonRipFolderSelect";
      this.ribbonGroupRipOptions.SetShortcutKeys(this.buttonRipFolderSelect, System.Windows.Forms.Keys.None);
      this.buttonRipFolderSelect.Size = new System.Drawing.Size(6, 0);
      this.buttonRipFolderSelect.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonRipFolderSelect.SmallImages.Images"))))});
      this.buttonRipFolderSelect.TabIndex = 4;
      // 
      // ribbonTabPageConvert
      // 
      this.ribbonTabPageConvert.Controls.Add(this.ribbonGroupConvert);
      this.ribbonTabPageConvert.Controls.Add(this.ribbonGroupConvertOptions);
      this.ribbonTabPageConvert.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ribbonTabPageConvert.KeyTip = null;
      this.ribbonTabPageConvert.Location = new System.Drawing.Point(0, 0);
      this.ribbonTabPageConvert.Name = "ribbonTabPageConvert";
      this.ribbonTabPageConvert.Size = new System.Drawing.Size(1166, 101);
      this.ribbonTabPageConvert.TabIndex = 0;
      this.ribbonTabPageConvert.Tag = "Convert";
      this.ribbonTabPageConvert.Text = "Convert";
      // 
      // ribbonGroupConvert
      // 
      this.ribbonGroupConvert.Controls.Add(this.buttonConvertStart);
      this.ribbonGroupConvert.Controls.Add(this.buttonConvertCancel);
      this.ribbonGroupConvert.Location = new System.Drawing.Point(4, 3);
      this.ribbonGroupConvert.Name = "ribbonGroupConvert";
      this.ribbonGroupConvert.Size = new System.Drawing.Size(155, 0);
      this.ribbonGroupConvert.TabIndex = 0;
      // 
      // buttonConvertStart
      // 
      this.buttonConvertStart.CommandName = "ConvertStart";
      this.buttonConvertStart.Id = "44c3e83e-aab8-4d1f-a1af-8986db19a11c";
      this.buttonConvertStart.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonConvertStart.LargeImages.Images"))))});
      this.buttonConvertStart.Location = new System.Drawing.Point(28, 2);
      this.buttonConvertStart.Name = "buttonConvertStart";
      this.buttonConvertStart.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvertStart.ScreenTip.Image")));
      this.ribbonGroupConvert.SetShortcutKeys(this.buttonConvertStart, System.Windows.Forms.Keys.None);
      this.buttonConvertStart.Size = new System.Drawing.Size(87, 0);
      this.buttonConvertStart.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonConvertStart.SmallImages.Images"))))});
      this.buttonConvertStart.TabIndex = 0;
      this.buttonConvertStart.Text = "Conversion Start";
      // 
      // buttonConvertCancel
      // 
      this.buttonConvertCancel.CommandName = "ConvertCancel";
      this.buttonConvertCancel.Id = "45c66776-33b0-4832-b771-490f19f60493";
      this.buttonConvertCancel.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonConvertCancel.LargeImages.Images"))))});
      this.buttonConvertCancel.Location = new System.Drawing.Point(28, 2);
      this.buttonConvertCancel.Name = "buttonConvertCancel";
      this.buttonConvertCancel.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonConvertCancel.ScreenTip.Image")));
      this.ribbonGroupConvert.SetShortcutKeys(this.buttonConvertCancel, System.Windows.Forms.Keys.None);
      this.buttonConvertCancel.Size = new System.Drawing.Size(98, 0);
      this.buttonConvertCancel.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonConvertCancel.SmallImages.Images"))))});
      this.buttonConvertCancel.TabIndex = 1;
      this.buttonConvertCancel.Text = "Conversion Cancel";
      // 
      // ribbonGroupConvertOptions
      // 
      this.ribbonGroupConvertOptions.Controls.Add(this.textBoxConvertOutputFolder);
      this.ribbonGroupConvertOptions.Controls.Add(this.comboBoxConvertEncoder);
      this.ribbonGroupConvertOptions.Controls.Add(this.buttonConvertFolderSelect);
      this.ribbonGroupConvertOptions.Location = new System.Drawing.Point(161, 3);
      this.ribbonGroupConvertOptions.Name = "ribbonGroupConvertOptions";
      this.ribbonGroupConvertOptions.Size = new System.Drawing.Size(535, 0);
      this.ribbonGroupConvertOptions.TabIndex = 1;
      this.ribbonGroupConvertOptions.Text = "Conversion Options";
      // 
      // textBoxConvertOutputFolder
      // 
      this.textBoxConvertOutputFolder.Id = "73b761e2-6141-479c-b192-9e0bb04c70d1";
      this.textBoxConvertOutputFolder.LabelAreaWidthTemplate = "Select Encoder:                      ";
      this.textBoxConvertOutputFolder.LabelText = "Output Folder:";
      this.textBoxConvertOutputFolder.Location = new System.Drawing.Point(4, 2);
      this.textBoxConvertOutputFolder.Name = "textBoxConvertOutputFolder";
      this.ribbonGroupConvertOptions.SetShortcutKeys(this.textBoxConvertOutputFolder, System.Windows.Forms.Keys.None);
      this.textBoxConvertOutputFolder.Size = new System.Drawing.Size(472, 19);
      this.textBoxConvertOutputFolder.TabIndex = 4;
      this.textBoxConvertOutputFolder.TextEditorWidth = 321;
      // 
      // comboBoxConvertEncoder
      // 
      this.comboBoxConvertEncoder.Editable = false;
      this.ribbonGroupConvertOptions.SetFlowBreak(this.comboBoxConvertEncoder, true);
      this.comboBoxConvertEncoder.FormattingEnabled = false;
      this.comboBoxConvertEncoder.Id = "c76d2510-fde1-4b0d-b3b6-23f77f4a44af";
      this.comboBoxConvertEncoder.LabelAreaWidthTemplate = "Select Encoder:                      ";
      this.comboBoxConvertEncoder.LabelText = "Select Encoder:";
      this.comboBoxConvertEncoder.Location = new System.Drawing.Point(478, 2);
      this.comboBoxConvertEncoder.Name = "comboBoxConvertEncoder";
      this.ribbonGroupConvertOptions.SetShortcutKeys(this.comboBoxConvertEncoder, System.Windows.Forms.Keys.None);
      this.comboBoxConvertEncoder.Size = new System.Drawing.Size(472, 19);
      this.comboBoxConvertEncoder.TabIndex = 5;
      this.comboBoxConvertEncoder.TextEditorWidth = 308;
      // 
      // buttonConvertFolderSelect
      // 
      this.buttonConvertFolderSelect.CommandName = "FolderSelect";
      this.buttonConvertFolderSelect.Id = "afb2c267-778d-4d4a-9b2e-37116c167693";
      this.buttonConvertFolderSelect.InformativenessMaximumLevel = "Elegant.Ui.RibbonGroupButtonInformativenessLevel:SmallImage";
      this.buttonConvertFolderSelect.Location = new System.Drawing.Point(952, 2);
      this.buttonConvertFolderSelect.Name = "buttonConvertFolderSelect";
      this.ribbonGroupConvertOptions.SetShortcutKeys(this.buttonConvertFolderSelect, System.Windows.Forms.Keys.None);
      this.buttonConvertFolderSelect.Size = new System.Drawing.Size(6, 0);
      this.buttonConvertFolderSelect.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonConvertFolderSelect.SmallImages.Images"))))});
      this.buttonConvertFolderSelect.TabIndex = 6;
      // 
      // ribbonTabPageBurn
      // 
      this.ribbonTabPageBurn.Controls.Add(this.ribbonGroupBurn);
      this.ribbonTabPageBurn.Controls.Add(this.ribbonGroupBurnOptions);
      this.ribbonTabPageBurn.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ribbonTabPageBurn.KeyTip = null;
      this.ribbonTabPageBurn.Location = new System.Drawing.Point(0, 0);
      this.ribbonTabPageBurn.Name = "ribbonTabPageBurn";
      this.ribbonTabPageBurn.Size = new System.Drawing.Size(1166, 101);
      this.ribbonTabPageBurn.TabIndex = 0;
      this.ribbonTabPageBurn.Tag = "Burn";
      this.ribbonTabPageBurn.Text = "Burn";
      // 
      // ribbonGroupBurn
      // 
      this.ribbonGroupBurn.Controls.Add(this.buttonBurnStart);
      this.ribbonGroupBurn.Controls.Add(this.buttonBurnCancel);
      this.ribbonGroupBurn.Location = new System.Drawing.Point(4, 3);
      this.ribbonGroupBurn.Name = "ribbonGroupBurn";
      this.ribbonGroupBurn.Size = new System.Drawing.Size(95, 0);
      this.ribbonGroupBurn.TabIndex = 0;
      // 
      // buttonBurnStart
      // 
      this.buttonBurnStart.CommandName = "BurnStart";
      this.buttonBurnStart.Id = "a741c025-7b86-4b1b-bf57-132c84317d09";
      this.buttonBurnStart.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonBurnStart.LargeImages.Images"))))});
      this.buttonBurnStart.Location = new System.Drawing.Point(13, 2);
      this.buttonBurnStart.Name = "buttonBurnStart";
      this.buttonBurnStart.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonBurnStart.ScreenTip.Image")));
      this.ribbonGroupBurn.SetShortcutKeys(this.buttonBurnStart, System.Windows.Forms.Keys.None);
      this.buttonBurnStart.Size = new System.Drawing.Size(56, 0);
      this.buttonBurnStart.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonBurnStart.SmallImages.Images"))))});
      this.buttonBurnStart.TabIndex = 0;
      this.buttonBurnStart.Text = "Burn Start";
      // 
      // buttonBurnCancel
      // 
      this.buttonBurnCancel.CommandName = "BurnCancel";
      this.buttonBurnCancel.Id = "227f00e7-f669-417b-8c6f-505d30d342a0";
      this.buttonBurnCancel.LargeImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonBurnCancel.LargeImages.Images"))))});
      this.buttonBurnCancel.Location = new System.Drawing.Point(13, 2);
      this.buttonBurnCancel.Name = "buttonBurnCancel";
      this.buttonBurnCancel.ScreenTip.Image = ((System.Drawing.Image)(resources.GetObject("buttonBurnCancel.ScreenTip.Image")));
      this.ribbonGroupBurn.SetShortcutKeys(this.buttonBurnCancel, System.Windows.Forms.Keys.None);
      this.buttonBurnCancel.Size = new System.Drawing.Size(67, 0);
      this.buttonBurnCancel.SmallImages.Images.AddRange(new Elegant.Ui.ControlImage[] {
            new Elegant.Ui.ControlImage("Normal", ((System.Drawing.Image)(resources.GetObject("buttonBurnCancel.SmallImages.Images"))))});
      this.buttonBurnCancel.TabIndex = 1;
      this.buttonBurnCancel.Text = "Burn Cancel";
      // 
      // ribbonGroupBurnOptions
      // 
      this.ribbonGroupBurnOptions.Controls.Add(this.comboBoxBurner);
      this.ribbonGroupBurnOptions.Controls.Add(this.comboBoxBurnerSpeed);
      this.ribbonGroupBurnOptions.Location = new System.Drawing.Point(101, 3);
      this.ribbonGroupBurnOptions.Name = "ribbonGroupBurnOptions";
      this.ribbonGroupBurnOptions.Size = new System.Drawing.Size(357, 0);
      this.ribbonGroupBurnOptions.TabIndex = 1;
      this.ribbonGroupBurnOptions.Text = "Burner Options";
      // 
      // comboBoxBurner
      // 
      this.comboBoxBurner.Editable = false;
      this.comboBoxBurner.FormattingEnabled = false;
      this.comboBoxBurner.Id = "91b0d24e-514a-4df6-acc7-83af9eecc776";
      this.comboBoxBurner.LabelAreaWidthTemplate = "Burner Speed:                          ";
      this.comboBoxBurner.LabelText = "Select Burner:";
      this.comboBoxBurner.Location = new System.Drawing.Point(4, 2);
      this.comboBoxBurner.Name = "comboBoxBurner";
      this.ribbonGroupBurnOptions.SetShortcutKeys(this.comboBoxBurner, System.Windows.Forms.Keys.None);
      this.comboBoxBurner.Size = new System.Drawing.Size(348, 19);
      this.comboBoxBurner.TabIndex = 0;
      this.comboBoxBurner.TextEditorWidth = 180;
      this.comboBoxBurner.SelectedIndexChanged += new System.EventHandler(this.comboBoxBurner_SelectedIndexChanged);
      // 
      // comboBoxBurnerSpeed
      // 
      this.comboBoxBurnerSpeed.Editable = false;
      this.comboBoxBurnerSpeed.FormattingEnabled = false;
      this.comboBoxBurnerSpeed.Id = "f13f2b7f-bee8-4078-8614-0efe27832435";
      this.comboBoxBurnerSpeed.LabelAreaWidthTemplate = "Burner Speed:                          ";
      this.comboBoxBurnerSpeed.LabelText = "Burner Speed:";
      this.comboBoxBurnerSpeed.Location = new System.Drawing.Point(354, 2);
      this.comboBoxBurnerSpeed.Name = "comboBoxBurnerSpeed";
      this.ribbonGroupBurnOptions.SetShortcutKeys(this.comboBoxBurnerSpeed, System.Windows.Forms.Keys.None);
      this.comboBoxBurnerSpeed.Size = new System.Drawing.Size(268, 19);
      this.comboBoxBurnerSpeed.TabIndex = 1;
      this.comboBoxBurnerSpeed.SelectedIndexChanged += new System.EventHandler(this.comboBoxBurnerSpeed_SelectedIndexChanged);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1008, 1111);
      this.Controls.Add(this.backstageView);
      this.Controls.Add(this.panelMiddle);
      this.Controls.Add(this.ribbon);
      this.Controls.Add(this.splitterPlayer);
      this.Controls.Add(this.panelBottom);
      this.Controls.Add(this.statusBar);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "Main";
      this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
      this.Text = "MPTagThat - The MediaPortal Tag Editor";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Close);
      this.Load += new System.EventHandler(this.Main_Load);
      this.Move += new System.EventHandler(this.Main_Move);
      this.Resize += new System.EventHandler(this.Main_Resize);
      this.panelBottom.ResumeLayout(false);
      this.panelMiddle.ResumeLayout(false);
      this.panelMiddleTop.ResumeLayout(false);
      this.panelLeft.ResumeLayout(false);
      this.statusBar.ResumeLayout(false);
      this.statusBar.PerformLayout();
      this.statusBarNotificationsArea1.ResumeLayout(false);
      this.statusBarNotificationsArea1.PerformLayout();
      this.statusBarPane2.ResumeLayout(false);
      this.statusBarPane2.PerformLayout();
      this.statusBarPane3.ResumeLayout(false);
      this.statusBarPane3.PerformLayout();
      this.statusBarControlsArea1.ResumeLayout(false);
      this.statusBarControlsArea1.PerformLayout();
      this.statusBarPane4.ResumeLayout(false);
      this.statusBarPane4.PerformLayout();
      this.statusBarPane1.ResumeLayout(false);
      this.statusBarPane1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.backstageView)).EndInit();
      this.backstageViewPageOptions.ResumeLayout(false);
      this.backstageViewPageOptions.PerformLayout();
      this.backstageViewPageRecentFolders.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pinListRecentFolders)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageTag)).EndInit();
      this.ribbonTabPageTag.ResumeLayout(false);
      this.ribbonTabPageTag.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupTagsRetrieve)).EndInit();
      this.ribbonGroupTagsRetrieve.ResumeLayout(false);
      this.ribbonGroupTagsRetrieve.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupTagsEdit)).EndInit();
      this.ribbonGroupTagsEdit.ResumeLayout(false);
      this.ribbonGroupTagsEdit.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu2)).EndInit();
      this.buttonGroup1.ResumeLayout(false);
      this.buttonGroup1.PerformLayout();
      this.buttonGroup3.ResumeLayout(false);
      this.buttonGroup3.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupPicture)).EndInit();
      this.ribbonGroupPicture.ResumeLayout(false);
      this.ribbonGroupPicture.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.galleryPicture)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupOrganise)).EndInit();
      this.ribbonGroupOrganise.ResumeLayout(false);
      this.ribbonGroupOrganise.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupOther)).EndInit();
      this.ribbonGroupOther.ResumeLayout(false);
      this.ribbonGroupOther.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageRip)).EndInit();
      this.ribbonTabPageRip.ResumeLayout(false);
      this.ribbonTabPageRip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupRip)).EndInit();
      this.ribbonGroupRip.ResumeLayout(false);
      this.ribbonGroupRip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupRipOptions)).EndInit();
      this.ribbonGroupRipOptions.ResumeLayout(false);
      this.ribbonGroupRipOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageConvert)).EndInit();
      this.ribbonTabPageConvert.ResumeLayout(false);
      this.ribbonTabPageConvert.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupConvert)).EndInit();
      this.ribbonGroupConvert.ResumeLayout(false);
      this.ribbonGroupConvert.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupConvertOptions)).EndInit();
      this.ribbonGroupConvertOptions.ResumeLayout(false);
      this.ribbonGroupConvertOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonTabPageBurn)).EndInit();
      this.ribbonTabPageBurn.ResumeLayout(false);
      this.ribbonTabPageBurn.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupBurn)).EndInit();
      this.ribbonGroupBurn.ResumeLayout(false);
      this.ribbonGroupBurn.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ribbonGroupBurnOptions)).EndInit();
      this.ribbonGroupBurnOptions.ResumeLayout(false);
      this.ribbonGroupBurnOptions.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MPTagThat.Core.WinControls.MPTPanel panelLeft;
    private MPTagThat.Core.WinControls.MPTCollapsibleSplitter splitterLeft;
    private MPTagThat.Core.WinControls.MPTPanel panelRight;
    private System.Windows.Forms.ToolTip toolTip;
    private MPTagThat.Core.WinControls.MPTCollapsibleSplitter splitterRight;
    private MPTagThat.Core.WinControls.MPTPanel panelLeftTop;
    private MPTagThat.Core.WinControls.MPTCollapsibleSplitter splitterBottom;
    private MPTagThat.Core.WinControls.MPTPanel panelFileList;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private MPTagThat.Core.WinControls.MPTPanel panelMiddle;
    private MPTagThat.Core.WinControls.MPTPanel playerPanel;
    private MPTagThat.Core.WinControls.MPTPanel panelMiddleTop;
    private MPTagThat.Core.WinControls.MPTPanel panelMiddleBottom;
    private NJFLib.Controls.CollapsibleSplitter splitterTop;
    private MPTagThat.Core.WinControls.MPTPanel panelMiddleDBSearch;
    private System.Windows.Forms.Panel panelBottom;
    private NJFLib.Controls.CollapsibleSplitter splitterPlayer;
    private Elegant.Ui.FormFrameSkinner formFrameSkinner;
    private Elegant.Ui.StatusBar statusBar;
    private Elegant.Ui.StatusBarNotificationsArea statusBarNotificationsArea1;
    private Elegant.Ui.StatusBarPane statusBarPane2;
    private Elegant.Ui.StatusBarControlsArea statusBarControlsArea1;
    private Elegant.Ui.StatusBarPane statusBarPane3;
    private Elegant.Ui.Label toolStripStatusLabelFolder;
    private Elegant.Ui.Label toolStripStatusLabelFiles;
    private Elegant.Ui.Label toolStripStatusLabelFilter;
    private Elegant.Ui.StatusBarPane statusBarPane1;
    internal Elegant.Ui.ProgressBar progressBar1;
    private Elegant.Ui.Button buttonProgressCancel;
    private Elegant.Ui.StatusBarPane statusBarPane4;
    private Elegant.Ui.Label toolStripStatusLabelScanProgress;
    private Elegant.Ui.Ribbon ribbon;
    private Elegant.Ui.Button startMenuSave;
    private Elegant.Ui.Button startMenuRefresh;
    private Elegant.Ui.RibbonTabPage ribbonTabPageTag;
    private Elegant.Ui.RibbonGroup ribbonGroupTagsRetrieve;
    private Elegant.Ui.Button buttonTagFromFile;
    private Elegant.Ui.Button buttonTagIdentifyFiles;
    private Elegant.Ui.Button buttonTagFromInternet;
    private Elegant.Ui.RibbonGroup ribbonGroupTagsEdit;
    private Elegant.Ui.Button buttonGetCoverArt;
    private Elegant.Ui.Button buttonRemoveCoverArt;
    private Elegant.Ui.Button buttonGetLyrics;
    private Elegant.Ui.Button buttonRemoveComment;
    private Elegant.Ui.RibbonGroup ribbonGroupOrganise;
    private Elegant.Ui.SplitButton buttonRenameFiles;
    private Elegant.Ui.PopupMenu popupMenu1;
    private Elegant.Ui.Button buttonRenameFilesOptions;
    private Elegant.Ui.SplitButton buttonDeleteTag;
    private Elegant.Ui.PopupMenu popupMenu2;
    private Elegant.Ui.Button buttonDeleteAllTags;
    private Elegant.Ui.SplitButton buttonCaseConversion;
    private Elegant.Ui.PopupMenu popupMenu3;
    private Elegant.Ui.Button buttonCaseConversionOptions;
    private Elegant.Ui.ButtonGroup buttonGroup3;
    private Elegant.Ui.TextBox textBoxNumber;
    private Elegant.Ui.Button buttonOrganiseFiles;
    private Elegant.Ui.ComboBox comboBoxScripts;
    private Elegant.Ui.Button buttonScriptExecute;
    private Elegant.Ui.RibbonGroup ribbonGroupOther;
    private Elegant.Ui.Button buttonAddToBurner;
    private Elegant.Ui.Button buttonAddToConversion;
    private Elegant.Ui.Button buttonAddToPlaylist;
    private Elegant.Ui.RibbonTabPage ribbonTabPageConvert;
    private Elegant.Ui.RibbonTabPage ribbonTabPageRip;
    private Elegant.Ui.RibbonTabPage ribbonTabPageBurn;
    private Elegant.Ui.RibbonGroup ribbonGroupRipOptions;
    private Elegant.Ui.ComboBox comboBoxRipEncoder;
    private Elegant.Ui.TextBox textBoxRipOutputFolder;
    private Elegant.Ui.RibbonGroup ribbonGroupRip;
    private Elegant.Ui.Button buttonRipStart;
    private Elegant.Ui.Button buttonRipCancel;
    private Elegant.Ui.RibbonGroup ribbonGroupConvert;
    private Elegant.Ui.RibbonGroup ribbonGroupConvertOptions;
    private Elegant.Ui.TextBox textBoxConvertOutputFolder;
    private Elegant.Ui.Button buttonDeleteID3v1;
    private Elegant.Ui.Button buttonDeleteID3v2;
    private Elegant.Ui.Button buttonRipFolderSelect;
    private Elegant.Ui.ComboBox comboBoxConvertEncoder;
    private Elegant.Ui.Button buttonConvertStart;
    private Elegant.Ui.Button buttonConvertCancel;
    private Elegant.Ui.Button buttonConvertFolderSelect;
    private Elegant.Ui.RibbonGroup ribbonGroupBurn;
    private Elegant.Ui.RibbonGroup ribbonGroupBurnOptions;
    private Elegant.Ui.ComboBox comboBoxBurner;
    private Elegant.Ui.ComboBox comboBoxBurnerSpeed;
    private Elegant.Ui.Button buttonBurnStart;
    private Elegant.Ui.Button buttonBurnCancel;
    private Elegant.Ui.Button buttonAutoNumber;
    private Elegant.Ui.ToggleButton buttonNumberOnClick;
    private Elegant.Ui.RibbonGroup ribbonGroupPicture;
    private Elegant.Ui.Gallery galleryPicture;
    private Elegant.Ui.ButtonGroup buttonGroup1;
    private Elegant.Ui.Button buttonSaveAsThumb;
    private Elegant.Ui.Separator separator2;
    private Elegant.Ui.Separator separator3;
    private Elegant.Ui.BackstageView backstageView1;
    private Elegant.Ui.BackstageViewPage backstageViewPage1;
    private Elegant.Ui.BackstageView backstageView;
    private Elegant.Ui.BackstageViewPage backstageViewPageRecentFolders;
    private Elegant.Ui.BackstageViewButton backstageViewButtonSave;
    private Elegant.Ui.BackstageViewButton backstageViewButtonRefresh;
    private Elegant.Ui.BackstageViewSeparator backstageViewSeparator1;
    private Elegant.Ui.BackstageViewButton backstageViewButtonChangeColumns;
    private Elegant.Ui.BackstageViewSeparator backstageViewSeparator2;
    private Elegant.Ui.BackstageViewButton backstageViewButtonExit;
    private Elegant.Ui.Panel panel1;
    private Elegant.Ui.PinList pinListRecentFolders;
    private Elegant.Ui.Separator separatorRecentFolders;
    private Elegant.Ui.BackstageViewPage backstageViewPageOptions;
    private Elegant.Ui.Panel panel2;
    private Elegant.Ui.BackstageViewPanel backstageViewPanel1;
  }
}

