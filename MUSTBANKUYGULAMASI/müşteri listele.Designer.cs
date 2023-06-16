
namespace MUSTBANKUYGULAMASI
{
    partial class müşteri_listele
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
            this.musterilerdtg = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.musterilerdtg)).BeginInit();
            this.SuspendLayout();
            // 
            // musterilerdtg
            // 
            this.musterilerdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerdtg.Location = new System.Drawing.Point(12, 43);
            this.musterilerdtg.Name = "musterilerdtg";
            this.musterilerdtg.Size = new System.Drawing.Size(665, 366);
            this.musterilerdtg.TabIndex = 0;
            // 
            // müşteri_listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 450);
            this.Controls.Add(this.musterilerdtg);
            this.Name = "müşteri_listele";
            this.Text = "müşteri_listele";
            this.Load += new System.EventHandler(this.müşteri_listele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerdtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView musterilerdtg;
    }
}