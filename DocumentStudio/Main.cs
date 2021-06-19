using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace DocumentStudio
{
    public partial class Main : Form
    {
        bool textChanged;
        public void SetFontStyle(FontStyle fs)
        {
            TextBox.SelectionFont = new Font(TextBox.SelectionFont, TextBox.SelectionFont.Style ^ fs);
        }
        public Main()
        {
            InitializeComponent();
            fontComboBox.SelectedIndexChanged += fontComboBox_SelectedIndexChanged;
            fontSizeComboBox.SelectedIndexChanged += fontSizeComboBox_SelectedIndexChanged;
        }
        private void Main_Load(object sender, EventArgs e)
        {
            undoMenuItem.Enabled = false;
            redoMenuItem.Enabled = false;

            textBoxCharCount.Text = "Character count: " + "0";

            // List all installed fonts
            InstalledFontCollection installedFonts = new InstalledFontCollection();

            foreach(FontFamily font in installedFonts.Families)
            {
                fontComboBox.Items.Add(font.Name);
            }
            fontComboBox.SelectedItem = TextBox.Font.Name;

            // Font size selection box
            for(int i = 1; i < 101; i++)
            {
                fontSizeComboBox.Items.Add(i);
            }
            fontSizeComboBox.SelectedIndex = (int)TextBox.Font.Size - 1;
        }
        
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            textChanged = true;
            undoMenuItem.Enabled = TextBox.CanUndo;
            redoMenuItem.Enabled = TextBox.CanRedo;

            textBoxCharCount.Text = "Character count: " + TextBox.Text.Length.ToString();
        }
        private void newFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main newFileWindow = new Main();
            newFileWindow.Show();
        }
        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Rich Text Documents (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt|All files (*)| *.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK) // Opens the Open File Dialog, lets the user choose a file to be opened.
            {
                if (System.IO.Path.GetExtension(openFileDialog.FileName) == ".rtf")
                {
                    TextBox.LoadFile(openFileDialog.FileName); // Execute this function if the user has selected a Rich Text Document (or RTF)
                    this.Text = openFileDialog.FileName + " - Document Studio";
                }
                else
                {
                    TextBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName); // Execute this function if the user has selected a Plain Text Document (or TXT)
                    this.Text = openFileDialog.FileName + " - Document Studio";
                }
            }
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Rich Text Documents (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt|All files (*)| *.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // Opens the Save File dialog, lets the user choose a file name and directory the file should be saved in. 
            {
                if (System.IO.Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                { 
                    TextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText); // Execute this function if the user has decided to save the document as Rich Text (or RTF)
                    this.Text = saveFileDialog.FileName + " - Document Studio";
                }
                else
                { 
                    System.IO.File.WriteAllText(saveFileDialog.FileName, TextBox.Text); // Execute this function if the user has decided to save the document as Plain Text (or TXT)
                    this.Text = saveFileDialog.FileName + " - Document Studio";
                }
            }
            
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (textChanged == true)
            {
                DialogResult saveConfirmation = new DialogResult();
                saveConfirmation = MessageBox.Show( "This document has been modified\n\nDo you want to save changes?", "greenhunt's Document Studio", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(saveConfirmation == DialogResult.Yes)
                {
                    saveFileDialog.Filter = "Rich Text Documents (*.rtf)|*.rtf|Plain Text (*.txt)|*.txt|All files (*)| *.*";
                    if(saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if(System.IO.Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                        {
                            TextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                            this.Close();
                        } 
                        else
                        {
                            System.IO.File.WriteAllText(saveFileDialog.FileName, TextBox.Text);
                            this.Close();
                        }  
                    }
                } 
                else if (saveConfirmation == DialogResult.No) 
                {
                    this.Close();
                }
            } else
            {
                this.Close();
            }
        }

        private void aboutDocumentStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("greenhunt's Document Studio\nCurrent version: " + Assembly.GetEntryAssembly().GetName().Version + "\n\nDocument Studio is a free rich and plain text editing software created by greenhunt.\nYou can use this application to create and edit your documents.\n\nDiscord: greenhunt#9392\nGitHub: http://github.com/greenhunt2003", "About Document Studio");
        }

        private void undoMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Undo();
        }

        private void redoMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Redo();
        }

        private void cutMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void cutContextMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Cut();
        }

        private void copyContextMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Copy();
        }

        private void pasteContextMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.Paste();
        }

        private void insertImageMenuItem_Click(object sender, EventArgs e)
        {
            addImageDialog.Filter = "Images (JPG/JPEG, PNG, GIF, BMP)| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (addImageDialog.ShowDialog() == DialogResult.OK) // Lets the user select an image
            {
                String image = addImageDialog.FileName;
                Clipboard.SetImage(Image.FromFile(image));
                TextBox.Paste(); // Inserts the selected image to the document
            }
        }

        private void insertDateTimeMenuItem_Click(object sender, EventArgs e)
        {
            TextBox.AppendText(DateTime.Now.ToString());
        }

        private void insertImageToolStripBtn_Click(object sender, EventArgs e)
        {
            addImageDialog.Filter = "Images (JPG/JPEG, PNG, GIF, BMP)| *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (addImageDialog.ShowDialog() == DialogResult.OK)
            {
                var image = addImageDialog.FileName;
                Clipboard.SetImage(Image.FromFile(image));
                TextBox.Paste();
            }
        }
        private void insertDateTimeTooStripBtn_Click(object sender, EventArgs e)
        {
            TextBox.AppendText(DateTime.Now.ToString());
        }

        private void boldTextToolStripBtn_Click(object sender, EventArgs e)
        {
            SetFontStyle(FontStyle.Bold);
        }

        private void italicTextToolStripBtn_Click(object sender, EventArgs e)
        {
            SetFontStyle(FontStyle.Italic);
        }

        private void underlineTextToolStripBtn_Click(object sender, EventArgs e)
        {
            SetFontStyle(FontStyle.Underline);
        }

        private void strikeTextToolStripBtn_Click(object sender, EventArgs e)
        {
            SetFontStyle(FontStyle.Strikeout);
        }

        private void fontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedfont = fontComboBox.SelectedItem.ToString();
            TextBox.SelectionFont = new Font(selectedfont, TextBox.SelectionFont.Size, TextBox.SelectionFont.Style);
        }
        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontsize = fontSizeComboBox.SelectedItem;
            TextBox.SelectionFont = new Font(TextBox.SelectionFont.FontFamily, (int)fontsize, TextBox.SelectionFont.Style);
        }
        private void textColorToolStripBtn_Click(object sender, EventArgs e)
        {
            if(textColorDialog.ShowDialog() == DialogResult.OK)
            {
                TextBox.SelectionColor = textColorDialog.Color;
            }
        }

        private void statusBarMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBar.Visible == true)
            {
                statusBar.Visible = false;
            }
            else
            {
                statusBar.Visible = true;
            }
        }
    }
}