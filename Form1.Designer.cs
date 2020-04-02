namespace QRPS
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
            this.btnMaster = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaster
            // 
            this.btnMaster.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.Location = new System.Drawing.Point(86, 64);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(128, 69);
            this.btnMaster.TabIndex = 0;
            this.btnMaster.Text = "Master List";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnMaster.UseVisualStyleBackColor = true;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(299, 64);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(128, 69);
            this.btnGen.TabIndex = 1;
            this.btnGen.Text = "Generate New";
            this.btnGen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(204, 201);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(128, 69);
            this.btnNew.TabIndex = 2;
            this.btnNew.Text = "Add New Entry";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(437, 351);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(92, 22);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 385);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnMaster);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnExit;
    }
}

