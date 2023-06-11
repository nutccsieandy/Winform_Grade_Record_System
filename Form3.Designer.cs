namespace Management_Information_System
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.scoretableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoreDataSet = new Management_Information_System.scoreDataSet();
            this.score_tableTableAdapter = new Management_Information_System.scoreDataSetTableAdapters.score_tableTableAdapter();
            this.scoreDataSet1 = new Management_Information_System.scoreDataSet();
            this.LV = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scoretableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(957, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoretableBindingSource
            // 
            this.scoretableBindingSource.DataMember = "score_table";
            this.scoretableBindingSource.DataSource = this.scoreDataSet;
            // 
            // scoreDataSet
            // 
            this.scoreDataSet.DataSetName = "scoreDataSet";
            this.scoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // score_tableTableAdapter
            // 
            this.score_tableTableAdapter.ClearBeforeFill = true;
            // 
            // scoreDataSet1
            // 
            this.scoreDataSet1.DataSetName = "scoreDataSet";
            this.scoreDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LV
            // 
            this.LV.HideSelection = false;
            this.LV.Location = new System.Drawing.Point(12, 151);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(1043, 352);
            this.LV.TabIndex = 1;
            this.LV.UseCompatibleStateImageBehavior = false;
            this.LV.SelectedIndexChanged += new System.EventHandler(this.LV_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(46, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "刪除選取列";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.LV);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scoretableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private scoreDataSet scoreDataSet;
        private System.Windows.Forms.BindingSource scoretableBindingSource;
        private scoreDataSetTableAdapters.score_tableTableAdapter score_tableTableAdapter;
        private scoreDataSet scoreDataSet1;
        private System.Windows.Forms.ListView LV;
        private System.Windows.Forms.Button button2;
    }
}