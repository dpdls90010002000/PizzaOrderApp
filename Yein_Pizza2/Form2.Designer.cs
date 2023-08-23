namespace Yein_Pizza2
{//Yein An 301316062
    partial class Form2
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
            this.gridOders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOders)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOders
            // 
            this.gridOders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridOders.Location = new System.Drawing.Point(12, 27);
            this.gridOders.Name = "gridOders";
            this.gridOders.RowHeadersWidth = 62;
            this.gridOders.RowTemplate.Height = 28;
            this.gridOders.Size = new System.Drawing.Size(1215, 411);
            this.gridOders.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 450);
            this.Controls.Add(this.gridOders);
            this.Name = "Form2";
            this.Text = "View Orders";
            ((System.ComponentModel.ISupportInitialize)(this.gridOders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridOders;
    }
}