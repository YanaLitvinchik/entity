namespace ExprTest
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
            this.dgGoods = new System.Windows.Forms.DataGridView();
            this.more5 = new System.Windows.Forms.CheckBox();
            this.pricem5000 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGoods
            // 
            this.dgGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGoods.Location = new System.Drawing.Point(12, 104);
            this.dgGoods.Name = "dgGoods";
            this.dgGoods.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGoods.Size = new System.Drawing.Size(657, 308);
            this.dgGoods.TabIndex = 0;
            this.dgGoods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgGoods_CellContentClick);
            // 
            // more5
            // 
            this.more5.AutoSize = true;
            this.more5.Location = new System.Drawing.Point(12, 12);
            this.more5.Name = "more5";
            this.more5.Size = new System.Drawing.Size(69, 17);
            this.more5.TabIndex = 1;
            this.more5.Text = "Count >5";
            this.more5.UseVisualStyleBackColor = true;
            this.more5.CheckedChanged += new System.EventHandler(this.more5_CheckedChanged);
            // 
            // pricem5000
            // 
            this.pricem5000.AutoSize = true;
            this.pricem5000.Location = new System.Drawing.Point(143, 12);
            this.pricem5000.Name = "pricem5000";
            this.pricem5000.Size = new System.Drawing.Size(86, 17);
            this.pricem5000.TabIndex = 2;
            this.pricem5000.Text = "Price > 5000";
            this.pricem5000.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(340, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pricem5000);
            this.Controls.Add(this.more5);
            this.Controls.Add(this.dgGoods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGoods;
        private System.Windows.Forms.CheckBox more5;
        private System.Windows.Forms.CheckBox pricem5000;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

