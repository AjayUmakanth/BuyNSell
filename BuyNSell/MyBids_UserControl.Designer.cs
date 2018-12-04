namespace BuyNSell
{
    partial class MyBids_UserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.myBidsView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myBidsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Offers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // myBidsView
            // 
            this.myBidsView.AllowUserToAddRows = false;
            this.myBidsView.AllowUserToDeleteRows = false;
            this.myBidsView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.myBidsView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myBidsView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myBidsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myBidsView.EnableHeadersVisualStyles = false;
            this.myBidsView.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.myBidsView.Location = new System.Drawing.Point(17, 86);
            this.myBidsView.Name = "myBidsView";
            this.myBidsView.Size = new System.Drawing.Size(543, 380);
            this.myBidsView.TabIndex = 73;
            this.myBidsView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.myPropView_CellContentClick);
            // 
            // MyBids_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::BuyNSell.Properties.Resources.blue_background_8_blue_abstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.myBidsView);
            this.Controls.Add(this.label1);
            this.Name = "MyBids_UserControl";
            this.Size = new System.Drawing.Size(577, 520);
            this.Load += new System.EventHandler(this.MyBids_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myBidsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView myBidsView;
    }
}
