namespace BuyNSell
{
    partial class Sold_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.soldView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soldView)).BeginInit();
            this.SuspendLayout();
            // 
            // soldView
            // 
            this.soldView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.soldView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldView.Location = new System.Drawing.Point(17, 102);
            this.soldView.Name = "soldView";
            this.soldView.Size = new System.Drawing.Size(543, 380);
            this.soldView.TabIndex = 75;
            this.soldView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.soldView_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 46);
            this.label1.TabIndex = 74;
            this.label1.Text = "Sold Properties";
            // 
            // Sold_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.soldView);
            this.Controls.Add(this.label1);
            this.Name = "Sold_UserControl";
            this.Size = new System.Drawing.Size(577, 520);
            this.Load += new System.EventHandler(this.Sold_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soldView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView soldView;
        private System.Windows.Forms.Label label1;
    }
}
