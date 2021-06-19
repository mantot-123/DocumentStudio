
namespace DocumentStudio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.insertImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertDateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutDocumentStudioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteContextMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.fontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.fontSizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.boldTextToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.italicTextToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.underlineTextToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.strikeTextToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.textColorToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.insertImageToolStripBtn = new System.Windows.Forms.ToolStripButton();
            this.insertDateTimeTooStripBtn = new System.Windows.Forms.ToolStripButton();
            this.addImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.textBoxCharCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.textColorDialog = new System.Windows.Forms.ColorDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.insertMenu,
            this.viewMenu,
            this.helpMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileMenuItem,
            this.openFileMenuItem,
            this.saveFileMenuItem,
            this.exitMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // newFileMenuItem
            // 
            this.newFileMenuItem.Name = "newFileMenuItem";
            this.newFileMenuItem.Size = new System.Drawing.Size(166, 22);
            this.newFileMenuItem.Text = "New file";
            this.newFileMenuItem.Click += new System.EventHandler(this.newFileToolStripMenuItem_Click);
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.Size = new System.Drawing.Size(166, 22);
            this.openFileMenuItem.Text = "Open existing file";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveFileMenuItem.Text = "Save file";
            this.saveFileMenuItem.Click += new System.EventHandler(this.saveFileMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.redoMenuItem,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(39, 20);
            this.editMenu.Text = "Edit";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoMenuItem.Text = "Undo";
            this.undoMenuItem.Click += new System.EventHandler(this.undoMenuItem_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.Size = new System.Drawing.Size(103, 22);
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.redoMenuItem_Click);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutMenuItem.Text = "Cut";
            this.cutMenuItem.Click += new System.EventHandler(this.cutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyMenuItem.Text = "Copy";
            this.copyMenuItem.Click += new System.EventHandler(this.copyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteMenuItem.Text = "Paste";
            this.pasteMenuItem.Click += new System.EventHandler(this.pasteMenuItem_Click);
            // 
            // insertMenu
            // 
            this.insertMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertImageMenuItem,
            this.insertDateTimeMenuItem});
            this.insertMenu.Name = "insertMenu";
            this.insertMenu.Size = new System.Drawing.Size(48, 20);
            this.insertMenu.Text = "Insert";
            // 
            // insertImageMenuItem
            // 
            this.insertImageMenuItem.Name = "insertImageMenuItem";
            this.insertImageMenuItem.Size = new System.Drawing.Size(150, 22);
            this.insertImageMenuItem.Text = "Image/Picture";
            this.insertImageMenuItem.Click += new System.EventHandler(this.insertImageMenuItem_Click);
            // 
            // insertDateTimeMenuItem
            // 
            this.insertDateTimeMenuItem.Name = "insertDateTimeMenuItem";
            this.insertDateTimeMenuItem.Size = new System.Drawing.Size(150, 22);
            this.insertDateTimeMenuItem.Text = "Date and Time";
            this.insertDateTimeMenuItem.Click += new System.EventHandler(this.insertDateTimeMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "View";
            // 
            // statusBarMenuItem
            // 
            this.statusBarMenuItem.Name = "statusBarMenuItem";
            this.statusBarMenuItem.Size = new System.Drawing.Size(126, 22);
            this.statusBarMenuItem.Text = "Status bar";
            this.statusBarMenuItem.Click += new System.EventHandler(this.statusBarMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutDocumentStudioToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "Help";
            // 
            // aboutDocumentStudioToolStripMenuItem
            // 
            this.aboutDocumentStudioToolStripMenuItem.Name = "aboutDocumentStudioToolStripMenuItem";
            this.aboutDocumentStudioToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.aboutDocumentStudioToolStripMenuItem.Text = "About Document Studio";
            this.aboutDocumentStudioToolStripMenuItem.Click += new System.EventHandler(this.aboutDocumentStudioToolStripMenuItem_Click);
            // 
            // TextBox
            // 
            this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox.ContextMenuStrip = this.contextMenuStrip;
            this.TextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.Location = new System.Drawing.Point(0, 52);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1200, 576);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutContextMenuItem,
            this.copyContextMenuItem,
            this.pasteContextMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(103, 70);
            // 
            // cutContextMenuItem
            // 
            this.cutContextMenuItem.Name = "cutContextMenuItem";
            this.cutContextMenuItem.Size = new System.Drawing.Size(102, 22);
            this.cutContextMenuItem.Text = "Cut";
            this.cutContextMenuItem.Click += new System.EventHandler(this.cutContextMenuItem_Click);
            // 
            // copyContextMenuItem
            // 
            this.copyContextMenuItem.Name = "copyContextMenuItem";
            this.copyContextMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyContextMenuItem.Text = "Copy";
            this.copyContextMenuItem.Click += new System.EventHandler(this.copyContextMenuItem_Click);
            // 
            // pasteContextMenuItem
            // 
            this.pasteContextMenuItem.Name = "pasteContextMenuItem";
            this.pasteContextMenuItem.Size = new System.Drawing.Size(102, 22);
            this.pasteContextMenuItem.Text = "Paste";
            this.pasteContextMenuItem.Click += new System.EventHandler(this.pasteContextMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.fontComboBox,
            this.toolStripLabel2,
            this.fontSizeComboBox,
            this.boldTextToolStripBtn,
            this.italicTextToolStripBtn,
            this.underlineTextToolStripBtn,
            this.strikeTextToolStripBtn,
            this.textColorToolStripBtn,
            this.toolStripSeparator1,
            this.insertImageToolStripBtn,
            this.insertDateTimeTooStripBtn});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1200, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(34, 22);
            this.toolStripLabel1.Text = "Font:";
            // 
            // fontComboBox
            // 
            this.fontComboBox.Name = "fontComboBox";
            this.fontComboBox.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(30, 22);
            this.toolStripLabel2.Text = "Size:";
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(75, 25);
            // 
            // boldTextToolStripBtn
            // 
            this.boldTextToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.boldTextToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.boldTextToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("boldTextToolStripBtn.Image")));
            this.boldTextToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldTextToolStripBtn.Name = "boldTextToolStripBtn";
            this.boldTextToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.boldTextToolStripBtn.Text = "B";
            this.boldTextToolStripBtn.ToolTipText = "Bold";
            this.boldTextToolStripBtn.Click += new System.EventHandler(this.boldTextToolStripBtn_Click);
            // 
            // italicTextToolStripBtn
            // 
            this.italicTextToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.italicTextToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicTextToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("italicTextToolStripBtn.Image")));
            this.italicTextToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicTextToolStripBtn.Name = "italicTextToolStripBtn";
            this.italicTextToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.italicTextToolStripBtn.Text = "I";
            this.italicTextToolStripBtn.ToolTipText = "Italics";
            this.italicTextToolStripBtn.Click += new System.EventHandler(this.italicTextToolStripBtn_Click);
            // 
            // underlineTextToolStripBtn
            // 
            this.underlineTextToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.underlineTextToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineTextToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("underlineTextToolStripBtn.Image")));
            this.underlineTextToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineTextToolStripBtn.Name = "underlineTextToolStripBtn";
            this.underlineTextToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.underlineTextToolStripBtn.Text = "U";
            this.underlineTextToolStripBtn.ToolTipText = "Underline";
            this.underlineTextToolStripBtn.Click += new System.EventHandler(this.underlineTextToolStripBtn_Click);
            // 
            // strikeTextToolStripBtn
            // 
            this.strikeTextToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strikeTextToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strikeTextToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("strikeTextToolStripBtn.Image")));
            this.strikeTextToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeTextToolStripBtn.Name = "strikeTextToolStripBtn";
            this.strikeTextToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.strikeTextToolStripBtn.Text = "abc";
            this.strikeTextToolStripBtn.ToolTipText = "Strikethrough";
            this.strikeTextToolStripBtn.Click += new System.EventHandler(this.strikeTextToolStripBtn_Click);
            // 
            // textColorToolStripBtn
            // 
            this.textColorToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.textColorToolStripBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColorToolStripBtn.ForeColor = System.Drawing.Color.Black;
            this.textColorToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("textColorToolStripBtn.Image")));
            this.textColorToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.textColorToolStripBtn.Name = "textColorToolStripBtn";
            this.textColorToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.textColorToolStripBtn.Text = "A";
            this.textColorToolStripBtn.ToolTipText = "Set text color";
            this.textColorToolStripBtn.Click += new System.EventHandler(this.textColorToolStripBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // insertImageToolStripBtn
            // 
            this.insertImageToolStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertImageToolStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("insertImageToolStripBtn.Image")));
            this.insertImageToolStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertImageToolStripBtn.Name = "insertImageToolStripBtn";
            this.insertImageToolStripBtn.Size = new System.Drawing.Size(23, 22);
            this.insertImageToolStripBtn.Text = "Insert Image";
            this.insertImageToolStripBtn.Click += new System.EventHandler(this.insertImageToolStripBtn_Click);
            // 
            // insertDateTimeTooStripBtn
            // 
            this.insertDateTimeTooStripBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.insertDateTimeTooStripBtn.Image = ((System.Drawing.Image)(resources.GetObject("insertDateTimeTooStripBtn.Image")));
            this.insertDateTimeTooStripBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.insertDateTimeTooStripBtn.Name = "insertDateTimeTooStripBtn";
            this.insertDateTimeTooStripBtn.Size = new System.Drawing.Size(23, 22);
            this.insertDateTimeTooStripBtn.Text = "Insert date and time";
            this.insertDateTimeTooStripBtn.Click += new System.EventHandler(this.insertDateTimeTooStripBtn_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textBoxCharCount});
            this.statusBar.Location = new System.Drawing.Point(0, 631);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1200, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // textBoxCharCount
            // 
            this.textBoxCharCount.Name = "textBoxCharCount";
            this.textBoxCharCount.Size = new System.Drawing.Size(0, 17);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 653);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Document Studio";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem insertMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem newFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutDocumentStudioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertImageMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox fontComboBox;
        private System.Windows.Forms.ToolStripButton boldTextToolStripBtn;
        private System.Windows.Forms.ToolStripButton italicTextToolStripBtn;
        private System.Windows.Forms.ToolStripButton underlineTextToolStripBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton strikeTextToolStripBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem cutContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteContextMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertDateTimeMenuItem;
        public System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.OpenFileDialog addImageDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton insertImageToolStripBtn;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel textBoxCharCount;
        private System.Windows.Forms.ToolStripComboBox fontSizeComboBox;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem statusBarMenuItem;
        private System.Windows.Forms.ToolStripButton textColorToolStripBtn;
        private System.Windows.Forms.ColorDialog textColorDialog;
        private System.Windows.Forms.ToolStripButton insertDateTimeTooStripBtn;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

