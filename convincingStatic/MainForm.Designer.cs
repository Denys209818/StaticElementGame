
namespace convincingStatic
{
    partial class MainForm
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
            this.pcStaticElement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcStaticElement)).BeginInit();
            this.SuspendLayout();
            // 
            // pcStaticElement
            // 
            this.pcStaticElement.Enabled = false;
            this.pcStaticElement.Location = new System.Drawing.Point(145, 126);
            this.pcStaticElement.Name = "pcStaticElement";
            this.pcStaticElement.Size = new System.Drawing.Size(85, 85);
            this.pcStaticElement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcStaticElement.TabIndex = 0;
            this.pcStaticElement.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pcStaticElement);
            this.Name = "MainForm";
            this.Text = "Гра \"Убегающий статик\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcStaticElement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcStaticElement;
    }
}