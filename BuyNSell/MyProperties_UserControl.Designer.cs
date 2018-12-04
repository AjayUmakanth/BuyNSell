namespace BuyNSell
{
    partial class MyProperties_UserControl
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.myPropView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.myPropView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Properties";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 32);
            this.button1.TabIndex = 69;
            this.button1.Text = "Add property";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // myPropView
            // 
            this.myPropView.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.myPropView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.myPropView.Location = new System.Drawing.Point(15, 79);
            this.myPropView.Name = "myPropView";
            this.myPropView.Size = new System.Drawing.Size(543, 380);
            this.myPropView.TabIndex = 70;
            this.myPropView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MyProperties_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::BuyNSell.Properties.Resources.blue_background_8_blue_abstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.myPropView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MyProperties_UserControl";
            this.Size = new System.Drawing.Size(577, 520);
            this.Load += new System.EventHandler(this.MyProperties_UserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myPropView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView myPropView;
    }
}