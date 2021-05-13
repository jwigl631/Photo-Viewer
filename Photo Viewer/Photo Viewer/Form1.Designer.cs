
namespace Photo_Viewer
{
    partial class Form1
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.StrecthButton = new System.Windows.Forms.CheckBox();
            this.NewPictureButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ChangeBackgroundButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ZoomButton = new System.Windows.Forms.CheckBox();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.AutosizeButton = new System.Windows.Forms.CheckBox();
            this.CenterImageButton = new System.Windows.Forms.CheckBox();
            this.TableLayoutPanel.SuspendLayout();
            this.FlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.022472F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.97753F));
            this.TableLayoutPanel.Controls.Add(this.FlowLayoutPanel, 1, 1);
            this.TableLayoutPanel.Controls.Add(this.PictureBox, 0, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 2;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.47108F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.52892F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(477, 402);
            this.TableLayoutPanel.TabIndex = 0;
            this.TableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowLayoutPanel.Controls.Add(this.StrecthButton);
            this.FlowLayoutPanel.Controls.Add(this.NewPictureButton);
            this.FlowLayoutPanel.Controls.Add(this.ClearButton);
            this.FlowLayoutPanel.Controls.Add(this.ChangeBackgroundButton);
            this.FlowLayoutPanel.Controls.Add(this.ExitButton);
            this.FlowLayoutPanel.Controls.Add(this.ZoomButton);
            this.FlowLayoutPanel.Controls.Add(this.AutosizeButton);
            this.FlowLayoutPanel.Controls.Add(this.CenterImageButton);
            this.FlowLayoutPanel.Location = new System.Drawing.Point(12, 338);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.Size = new System.Drawing.Size(461, 61);
            this.FlowLayoutPanel.TabIndex = 2;
            // 
            // StrecthButton
            // 
            this.StrecthButton.AutoSize = true;
            this.StrecthButton.Location = new System.Drawing.Point(3, 3);
            this.StrecthButton.Name = "StrecthButton";
            this.StrecthButton.Size = new System.Drawing.Size(60, 17);
            this.StrecthButton.TabIndex = 1;
            this.StrecthButton.Text = "Stretch";
            this.StrecthButton.UseVisualStyleBackColor = true;
            this.StrecthButton.CheckedChanged += new System.EventHandler(this.StrecthButton_CheckedChanged);
            // 
            // NewPictureButton
            // 
            this.NewPictureButton.AutoSize = true;
            this.NewPictureButton.Location = new System.Drawing.Point(69, 3);
            this.NewPictureButton.Name = "NewPictureButton";
            this.NewPictureButton.Size = new System.Drawing.Size(75, 23);
            this.NewPictureButton.TabIndex = 2;
            this.NewPictureButton.Text = "New Picture";
            this.NewPictureButton.UseVisualStyleBackColor = true;
            this.NewPictureButton.Click += new System.EventHandler(this.NewPictureButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.AutoSize = true;
            this.ClearButton.Location = new System.Drawing.Point(150, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ChangeBackgroundButton
            // 
            this.ChangeBackgroundButton.AutoSize = true;
            this.ChangeBackgroundButton.Location = new System.Drawing.Point(231, 3);
            this.ChangeBackgroundButton.Name = "ChangeBackgroundButton";
            this.ChangeBackgroundButton.Size = new System.Drawing.Size(115, 23);
            this.ChangeBackgroundButton.TabIndex = 4;
            this.ChangeBackgroundButton.Text = "Change Background";
            this.ChangeBackgroundButton.UseVisualStyleBackColor = true;
            this.ChangeBackgroundButton.Click += new System.EventHandler(this.ChangeBackgroundButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(352, 3);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 5;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ZoomButton
            // 
            this.ZoomButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ZoomButton.AutoSize = true;
            this.ZoomButton.Location = new System.Drawing.Point(3, 32);
            this.ZoomButton.Name = "ZoomButton";
            this.ZoomButton.Size = new System.Drawing.Size(53, 17);
            this.ZoomButton.TabIndex = 6;
            this.ZoomButton.Text = "Zoom";
            this.ZoomButton.UseVisualStyleBackColor = true;
            this.ZoomButton.CheckedChanged += new System.EventHandler(this.ZoomButton_CheckedChanged);
            // 
            // PictureBox
            // 
            this.TableLayoutPanel.SetColumnSpan(this.PictureBox, 2);
            this.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(471, 329);
            this.PictureBox.TabIndex = 3;
            this.PictureBox.TabStop = false;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            this.OpenFileDialog.Title = "ChooseAPicture";
            // 
            // AutosizeButton
            // 
            this.AutosizeButton.AutoSize = true;
            this.AutosizeButton.Location = new System.Drawing.Point(62, 32);
            this.AutosizeButton.Name = "AutosizeButton";
            this.AutosizeButton.Size = new System.Drawing.Size(66, 17);
            this.AutosizeButton.TabIndex = 7;
            this.AutosizeButton.Text = "Autosize";
            this.AutosizeButton.UseVisualStyleBackColor = true;
            this.AutosizeButton.CheckedChanged += new System.EventHandler(this.AutosizeButton_CheckedChanged);
            // 
            // CenterImageButton
            // 
            this.CenterImageButton.AutoSize = true;
            this.CenterImageButton.Location = new System.Drawing.Point(134, 32);
            this.CenterImageButton.Name = "CenterImageButton";
            this.CenterImageButton.Size = new System.Drawing.Size(89, 17);
            this.CenterImageButton.TabIndex = 8;
            this.CenterImageButton.Text = "Center Image";
            this.CenterImageButton.UseVisualStyleBackColor = true;
            this.CenterImageButton.CheckedChanged += new System.EventHandler(this.CenterImageButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 402);
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "Form1";
            this.Text = "Photo Viewer";
            this.TableLayoutPanel.ResumeLayout(false);
            this.FlowLayoutPanel.ResumeLayout(false);
            this.FlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.CheckBox StrecthButton;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.Button NewPictureButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ChangeBackgroundButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.CheckBox ZoomButton;
        private System.Windows.Forms.CheckBox AutosizeButton;
        private System.Windows.Forms.CheckBox CenterImageButton;
    }
}

