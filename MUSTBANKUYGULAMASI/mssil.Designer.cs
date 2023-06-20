
namespace MUSTBANKUYGULAMASI
{
    partial class mssil
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
            this.musterilerdtg.AllowUserToAddRows = false;
            this.musterilerdtg.AllowUserToDeleteRows = false;
            this.musterilerdtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilerdtg.Location = new System.Drawing.Point(68, 42);
            this.musterilerdtg.Name = "musterilerdtg";
            this.musterilerdtg.Size = new System.Drawing.Size(665, 366);
            this.musterilerdtg.TabIndex = 2;
            this.musterilerdtg.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.musterilerdtg_CellMouseClick);
            // 
            // mssil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.musterilerdtg);
            this.Name = "mssil";
            this.Text = "mssil";
            this.Load += new System.EventHandler(this.mssil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterilerdtg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView musterilerdtg;
    }
}